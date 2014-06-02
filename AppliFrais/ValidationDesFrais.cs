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
    public partial class ValidationDesFrais : Form
    {
        applifraisEntities db = new applifraisEntities();
        string moisEnCours = DateTime.Now.Date.Month.ToString() + "/" + DateTime.Now.Year.ToString();
        public visiteur VisiConnect = new visiteur();
        public ValidationDesFrais()
        {
            InitializeComponent();
        }

        private void ConsulterNote_Load(object sender, EventArgs e)
        {
            
        }

        private void loadVisiteur()
        {
            var visiteurs = from c in db.visiteur
                            where (c.comptable == 0 && c.login != "admin")
                            select c;
            cmb_visiteur.DataSource = visiteurs;
            cmb_visiteur.DisplayMember = "nom";
            cmb_visiteur.ValueMember = "ID";
        }

        private void groupBoxSaisie_Enter(object sender, EventArgs e)
        {

        }
        

        private void btn_afficher_Click(object sender, EventArgs e)
        {
            try
            {
                int idvisiteur = Convert.ToInt32(cmb_visiteur.SelectedValue);
                moisEnCours = (string)cmb_listFiches.SelectedValue;
                chargeFrForfait(idvisiteur);
                chargeFrHorsForfait(idvisiteur);
                loadJustificatif(idvisiteur);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\n\n"+ex.InnerException+"\n\n"+ex.StackTrace);
                return;
            }
        }

        private void loadJustificatif(int idvisiteur)        
        {
            moisEnCours = (string)cmb_listFiches.SelectedValue;
            var fiche = (from c in db.fichefrais
                         where (c.idVisiteur == idvisiteur && c.mois == moisEnCours)
                         select c).First();
            txt_justificatifs.Text = fiche.nbJustificatifs.ToString();
            if (fiche.manqueJustificatif == 1)
                chk_justificatif.Checked = true;
            else
                chk_justificatif.Checked = false;
        }
        private void chargeFrHorsForfait( int idVisiteur)
        {
            try
            {
                table_frHorsForfait.Rows.Clear();
                var list_frais = (from c in db.lignefraishorsforfait
                                  where (c.mois == moisEnCours && c.idVisiteur == idVisiteur)
                                  select c).ToList();

                foreach (var frais in list_frais)
                {
                    var b = (from c in db.etat
                             where c.id == frais.idEtat
                             select c).First();
                    string etat = b.libelle;
                   
                    table_frHorsForfait.Rows.Add(frais.date.Value.ToShortDateString(), frais.libelle, frais.montant, etat, frais.id);
                }


                moisEnCours = cmb_listFiches.SelectedText;
                var report = (from c in db.lignefraishorsforfait
                              where (c.mois == moisEnCours && c.idVisiteur == idVisiteur)
                              select c).ToList();

                foreach (var frais in report)
                {
                    var b = (from c in db.etat
                             where c.id == frais.idEtat
                             select c).First();
                    string etat = b.libelle;
                    table_frHorsForfait.Rows.Add(frais.date.Value.ToShortDateString(), frais.libelle, frais.montant, etat);
                }
                foreach (var item in table_frForfait.Columns)
                {
                    item.TextAlignment = ContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException);
                return;
            }
        }
        private void chargeFrForfait(int idVisiteur)
        {
            try
            {
                int midi = 0;
                int nuit = 0;
                int etape = 0;
                int kilometre = 0;
                table_frForfait.Rows.Clear();
                var list_frais = (from c in db.lignefraisforfait
                                  where (c.mois == moisEnCours && c.idVisiteur == idVisiteur)
                                  select c).ToList();
                var fiche = (from c in db.fichefrais
                             where (c.mois == moisEnCours && c.idVisiteur == idVisiteur)
                             select c).First();
                string etat = (from c in db.etat
                               where c.id == fiche.idEtat
                               select c).First().libelle;

                foreach (var frais in list_frais)
                {
                    if (frais.idFraisForfait == 1)
                        midi += (int)frais.quantite;
                    if (frais.idFraisForfait == 2)
                        nuit += (int)frais.quantite;
                    if (frais.idFraisForfait == 3)
                        etape += (int)frais.quantite;
                    if (frais.idFraisForfait == 4)
                        kilometre += (int)frais.quantite;
                }

                table_frForfait.Rows.Add(midi, nuit, etape, kilometre,etat);
                foreach (var item in table_frForfait.Columns)
                {
                    item.TextAlignment = ContentAlignment.MiddleCenter;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException);
                return;
            }
        }
        private void btn_quit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.No)
                return;
            Close();
        }

        private void btn_enresgitrer_Click(object sender, EventArgs e)
        {
            try
            {
                //enregistrement frais forfait
                int idvisiteur = Convert.ToInt32(cmb_visiteur.SelectedValue);
                moisEnCours = (string)cmb_listFiches.SelectedValue;
                var fiche = (from c in db.fichefrais
                             where (c.mois == moisEnCours && c.idVisiteur == idvisiteur)
                             select c).First();
                
                //on change l'ID état en fonction du choix du comptable par clic droit
                switch ( table_frForfait.Rows.First().Cells[4].Value.ToString())
                {
                    case "Remboursée":
                        fiche.idEtat = 1;
                        break;
                    case "Saisie clôturée":
                        fiche.idEtat = 2;
                        break;
                    case "Fiche créée, saisie en cours":
                        fiche.idEtat = 3;
                        break;
                    case "Validée et mise en paiement":
                        fiche.idEtat = 4;
                        break;
                    default:
                        break;
                }
                
                //justificatifs
                fiche.nbJustificatifs = Convert.ToInt32(txt_justificatifs.Text);
                if (chk_justificatif.Checked)
                    fiche.manqueJustificatif = 1;
                else
                    fiche.manqueJustificatif = 0;
                
                //On repercute dans la base de données:
                db.SaveChanges();


                //ENREGISTREMENT HORS FORFAIT
                int i = 0;
                for (i = 0; i < table_frHorsForfait.Rows.Count; i++)
                {   
                    int id= Convert.ToInt32(table_frHorsForfait.Rows[i].Cells[4].Value);
                    var horsForfait = (from c in db.lignefraishorsforfait
                                      where c.id == id
                                      select c).First();
                    switch (table_frHorsForfait.Rows[i].Cells[3].Value.ToString())
                    {
                        case "Remboursée":
                            horsForfait.idEtat = 1;
                            break;
                        case "Saisie clôturée":
                            horsForfait.idEtat = 2;
                            break;
                        case "Fiche créée, saisie en cours":
                            horsForfait.idEtat = 3;
                            break;
                        case "Validée et mise en paiement":
                            horsForfait.idEtat = 4;
                            break;
                        default:
                            break;
                    }
                    db.SaveChanges();
                }

                MessageBox.Show("Fiche enregistrée", "Validation des frais", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException);
                return;
            }
        }

        private void date_moisNote_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date_moisNote_ValueChanged_1(object sender, EventArgs e)
        {
        }

        private void cmb_visiteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                visiteur visiteur = (visiteur)cmb_visiteur.SelectedValue;
                int id = visiteur.id;
                chargeListeFiche(id);
            }
            catch (Exception ex)
            {
                int id = Convert.ToInt32(cmb_visiteur.SelectedValue)
                    ;
                chargeListeFiche(id);
                //MessageBox.Show(ex.Message + "\n\n" + ex.InnerException + "\n\n" + ex.StackTrace);
                //return;
            }
        }

        public void chargeListeFiche(int idVisiteur)
        {
            List<string> fiches = (from c in db.fichefrais
                                   where (c.idVisiteur == idVisiteur)
                                   orderby c.dateModif
                                   select c.mois).ToList();
            cmb_listFiches.DataSource = fiches;
            if (fiches.Count > 0)
                btn_afficher.Enabled = cmb_listFiches.Enabled = true;
            else
                btn_afficher.Enabled = cmb_listFiches.Enabled = false;
        }

        private void ValidationDesFrais_Load(object sender, EventArgs e)
        {
            loadVisiteur();
        }

        private void table_frForfait_Click(object sender, EventArgs e)
        {

        }

        private void table_frForfait_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            e.ContextMenu.Items.Clear();
            RadMenuItem Item1Forfait = new RadMenuItem();
            Item1Forfait.Text = "Remboursée";
            Item1Forfait.Click += new EventHandler(Item1Forfait_Click);
            RadMenuItem Item2Forfait = new RadMenuItem();
            Item2Forfait.Text = "Saisie clôturée";
            Item2Forfait.Click += new EventHandler(Item2Forfait_Click);
            RadMenuItem Item3Forfait = new RadMenuItem();
            Item3Forfait.Text = "Fiche créée, saisie en cours";
            Item3Forfait.Click += new EventHandler(Item3Forfait_Click);
            RadMenuItem Item4Forfait = new RadMenuItem();
            Item4Forfait.Text = "Validée et mise en paiement";
            Item4Forfait.Click += new EventHandler(Item4Forfait_Click);
            e.ContextMenu.Items.Add(Item1Forfait);
            e.ContextMenu.Items.Add(Item2Forfait);
            e.ContextMenu.Items.Add(Item3Forfait);
            e.ContextMenu.Items.Add(Item4Forfait);
        }

        void Item4Forfait_Click(object sender, EventArgs e)
        {
            //Validée et mise en paiement
            table_frForfait.SelectedRows.First().Cells[4].Value = "Validée et mise en paiement";
        }

        void Item3Forfait_Click(object sender, EventArgs e)
        {
            //Fiche créée, saisie en cours
            table_frForfait.SelectedRows.First().Cells[4].Value = "Fiche créée, saisie en cours";
        }

        void Item2Forfait_Click(object sender, EventArgs e)
        {
            //Saisie clôturée
            table_frForfait.SelectedRows.First().Cells[4].Value = "Saisie clôturée";
        }

        void Item1Forfait_Click(object sender, EventArgs e)
        {
            //Remboursée
            table_frForfait.SelectedRows.First().Cells[4].Value = "Remboursée";
        }

        private void table_frHorsForfait_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            e.ContextMenu.Items.Clear();
            RadMenuItem Item1 = new RadMenuItem();
            Item1.Text = "Remboursée";
            Item1.Click += new EventHandler(Item1_Click);
            RadMenuItem Item2 = new RadMenuItem();
            Item2.Text = "Saisie clôturée";
            Item2.Click += new EventHandler(Item2_Click);
            RadMenuItem Item3 = new RadMenuItem();
            Item3.Text = "Fiche créée, saisie en cours";
            Item3.Click += new EventHandler(Item3_Click);
            RadMenuItem Item4 = new RadMenuItem();
            Item4.Text = "Validée et mise en paiement";
            Item4.Click += new EventHandler(Item4_Click);
            e.ContextMenu.Items.Add(Item1);
            e.ContextMenu.Items.Add(Item2);
            e.ContextMenu.Items.Add(Item3);
            e.ContextMenu.Items.Add(Item4);
        }

        void Item4_Click(object sender, EventArgs e)
        {
            //Validée et mise en paiement
            table_frHorsForfait.SelectedRows.First().Cells[3].Value = "Validée et mise en paiement";
        }

        void Item3_Click(object sender, EventArgs e)
        {
            //Fiche créée, saisie en cours
            table_frHorsForfait.SelectedRows.First().Cells[3].Value = "Fiche créée, saisie en cours";
        }

        void Item2_Click(object sender, EventArgs e)
        {
            //Saisie clôturée
            table_frHorsForfait.SelectedRows.First().Cells[3].Value = "Saisie clôturée";
        }

        void Item1_Click(object sender, EventArgs e)
        {
            //Remboursée
            table_frHorsForfait.SelectedRows.First().Cells[3].Value = "Remboursée";
        }
    }
}
