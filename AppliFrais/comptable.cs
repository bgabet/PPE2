using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppliFrais
{
    public partial class comptable : Form
    {
        applifraisEntities1 db = new applifraisEntities1();
        public comptable()
        {
            InitializeComponent();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_EnrNouvNote_Click(object sender, EventArgs e)
        {
            //vérification valeurs 
            bool result =true;
            double rep,nuit,etap,km;
            result = Double.TryParse(txtRepas.Text, out rep);
            if (!result)
            {
                MessageBox.Show("Veuillez entrer des valeurs correctes","Erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            result = Double.TryParse(txtNuitee.Text, out nuit);
            if (!result)
            {
                MessageBox.Show("Veuillez entrer des valeurs correctes","Erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            result = Double.TryParse(txtEtape.Text, out etap);
            if (!result)
            {
                MessageBox.Show("Veuillez entrer des valeurs correctes","Erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            result = Double.TryParse(txtKm.Text, out km);
            if (!result)
            {
                MessageBox.Show("Veuillez entrer des valeurs correctes","Erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            // ID 1 Repas
            // ID 2 Nuitee
            // ID 3 Etape
            // ID 4 Km
            var repas = from c in db.fraisforfait
                        where c.id == 1
                        select c;
            if (repas.Count() == 0)
            {
                fraisforfait fr = new fraisforfait();
                fr.id = 1;
                fr.libelle = "repas";
                fr.montant = rep;
                db.AddTofraisforfait(fr);
                db.SaveChanges();
            }
            else 
            {
                repas.First().montant = rep;
                db.SaveChanges();
            }


            var nuitee = from c in db.fraisforfait
                        where c.id == 2
                        select c;
            if (nuitee.Count() == 0)
            {
                fraisforfait fr = new fraisforfait();
                fr.id = 1;
                fr.libelle = "nuitee";
                fr.montant = nuit;
                db.AddTofraisforfait(fr);
                db.SaveChanges();
            }
            else
            {
                nuitee.First().montant = nuit;
                db.SaveChanges();
            }

            var etape = from c in db.fraisforfait
                        where c.id == 3
                        select c;
            if (etape.Count() == 0)
            {
                fraisforfait fr = new fraisforfait();
                fr.id = 1;
                fr.libelle = "etape";
                fr.montant = etap;
                db.AddTofraisforfait(fr);
                db.SaveChanges();
            }
            else
            {
                etape.First().montant = etap;
                db.SaveChanges();
            }

            var kms = from c in db.fraisforfait
                        where c.id == 4
                        select c;
            if (kms.Count() == 0)
            {
                fraisforfait fr = new fraisforfait();
                fr.id = 1;
                fr.libelle = "km";
                fr.montant = km;
                db.AddTofraisforfait(fr);
                db.SaveChanges();
            }
            else
            {
                kms.First().montant = km;
                db.SaveChanges();
            }

            MessageBox.Show("Modifications enregistrées", "Comptable", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comptable_Load(object sender, EventArgs e)
        {
            // ID 1 Repas
            // ID 2 Nuitee
            // ID 3 Etape
            // ID 4 Km
            var info = from c in db.fraisforfait
                       where c.id==1
                       select c;
            if (info.Count() != 0)
            {
                txtRepas.Text = info.First().montant.ToString();
            }
            info = from c in db.fraisforfait
                   where c.id == 2
                   select c;
            if (info.Count() != 0)
            {
               txtNuitee.Text = info.First().montant.ToString();
            }
            info = from c in db.fraisforfait
                   where c.id == 3
                   select c;
            if (info.Count() != 0)
            {
                txtEtape.Text = info.First().montant.ToString();
            }
            info = from c in db.fraisforfait
                   where c.id == 4
                   select c;
            if (info.Count() != 0)
            {
                txtKm.Text = info.First().montant.ToString();
            }
                     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
