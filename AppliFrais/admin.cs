using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace AppliFrais
{
    public partial class admin : Form
    {
        applifraisEntities1 db = new applifraisEntities1();
        bool nouveau = true;
        int idselect;
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            chargeUtilisateurs();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void chargeUtilisateurs()
        {
            var list_util = from c in db.visiteur
                            select c;
            table_utilisateur.DataSource = list_util;
            table_utilisateur.Columns[0].IsVisible = false;
            table_utilisateur.Columns[1].HeaderText = "Nom";
            table_utilisateur.Columns[1].Width = 80;
            table_utilisateur.Columns[2].HeaderText = "Prénom";
            table_utilisateur.Columns[2].Width = 80;
            table_utilisateur.Columns[3].HeaderText = "Login";
            table_utilisateur.Columns[3].Width = 80;
            table_utilisateur.Columns[4].HeaderText = "Mot de passe";
            table_utilisateur.Columns[4].Width = 80;
            table_utilisateur.Columns[5].HeaderText = "Adresse";
            table_utilisateur.Columns[5].Width = 80;
            table_utilisateur.Columns[6].HeaderText = "Code postal";
            table_utilisateur.Columns[6].Width = 80;
            table_utilisateur.Columns[7].HeaderText = "Ville";
            table_utilisateur.Columns[7].Width = 80;
            table_utilisateur.Columns[8].HeaderText = "Date d'embauche";
            table_utilisateur.Columns[8].Width = 80; 
            table_utilisateur.Columns[9].HeaderText = "Comptable";
            table_utilisateur.Columns[9].Width = 80;
            table_utilisateur.Columns[9].DataType =typeof(bool);

            foreach (var item in table_utilisateur.Columns)
            {
                item.TextAlignment = ContentAlignment.MiddleCenter;
            }
        }

        private void txt_cp_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            nouveau = true;
            txt_nom.Text = txt_prenom.Text = txt_login.Text = txt_mdp.Text = txt_adresse.Text = txt_cp.Text = txt_ville.Text = "";
            chk_comptable.Checked = false;
            date_embauche.Value = DateTime.Now;
        }

        private void table_utilisateur_Click(object sender, EventArgs e)
        {

            if (table_utilisateur.SelectedRows.Count() > 0)
            {
                idselect = Convert.ToInt32(table_utilisateur.SelectedRows.First().Cells[0].Value);
                visiteur visi = (from c in db.visiteur
                                 where c.id == idselect
                                 select c).First();
               
                txt_nom.Text = visi.nom;
                txt_prenom.Text = visi.prenom;
                txt_login.Text = visi.login;
                txt_mdp.Text = visi.mdp;
                txt_adresse.Text = visi.adresse;
                txt_cp.Text = visi.cp;
                txt_ville.Text = visi.ville;
                date_embauche.Value = Convert.ToDateTime(visi.dateEmbauche);
                if (visi.comptable == 1)
                    chk_comptable.Checked = true;
                else
                    chk_comptable.Checked = false;
                nouveau = false;
            }
        }

        private void date_embauche_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_enresgitrer_Click(object sender, EventArgs e)
        {
            if (nouveau)
            {
                visiteur visi = new visiteur();
                visi.nom = txt_nom.Text;
                visi.prenom = txt_prenom.Text;
                visi.login = txt_login.Text;
                visi.mdp = txt_mdp.Text;
                visi.adresse = txt_adresse.Text;
                visi.cp = txt_cp.Text;
                visi.ville = txt_ville.Text;
                visi.dateEmbauche = date_embauche.Value.Date;
                if (chk_comptable.Checked == true)
                    visi.comptable = 1;
                else
                    visi.comptable = 0;
                db.AddTovisiteur(visi);
                db.SaveChanges();
                MessageBox.Show("Nouveau visiteur ajouté", "Visiteur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                visiteur visi = (from c in db.visiteur
                                 where c.id == idselect
                                 select c).First();
                visi.nom = txt_nom.Text;
                visi.prenom = txt_prenom.Text;
                visi.login = txt_login.Text;
                visi.mdp = txt_mdp.Text;
                visi.adresse = txt_adresse.Text;
                visi.cp = txt_cp.Text;
                visi.ville = txt_ville.Text;
                visi.dateEmbauche = date_embauche.Value.Date;
                if (chk_comptable.Checked == true)
                    visi.comptable = 1;
                else
                    visi.comptable = 0;
                
                db.SaveChanges();
                MessageBox.Show("Modifications enregistrées", "Visiteur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            chargeUtilisateurs();
            nouveau = true;
            txt_nom.Text = txt_prenom.Text = txt_login.Text = txt_mdp.Text = txt_adresse.Text = txt_cp.Text = txt_ville.Text = "";
            chk_comptable.Checked = false;
            date_embauche.Value = DateTime.Now;
        }
    }
}
