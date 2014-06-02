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
    public partial class SuiviRemboursement : Form
    {
        public applifraisEntities db = new applifraisEntities();
        public visiteur VisiConnect = new visiteur();
        public string moisEnCours = "";
        public SuiviRemboursement()
        {
            InitializeComponent();
        }

        private void SuiviRemboursement_Load(object sender, EventArgs e)
        {
            chargeListeFiche();
        }
        public void chargeListeFiche()
        {
            cmb_listFiches.Items.Clear();
            List<string> fiches = (from c in db.fichefrais
                                     where (c.idVisiteur == VisiConnect.id)
                                     orderby c.dateModif
                                     select c.mois).ToList();
            cmb_listFiches.DataSource = fiches;
          
        }
        private void chargeFrHorsForfait(int idVisiteur)
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

                    table_frHorsForfait.Rows.Add(frais.date.Value.ToShortDateString(), frais.libelle, frais.montant, etat);
                }


                moisEnCours = cmb_listFiches.SelectedText;
                var report = (from c in db.lignefraishorsforfait
                              where (c.mois == moisEnCours && c.idVisiteur == VisiConnect.id)
                              select c).ToList();

                foreach (var frais in report)
                {
                    var b = (from c in db.etat
                             where c.id == frais.idEtat
                             select c).First();
                    string etat = b.libelle;
                    string reporter = "Importé du mois précédent";
                    table_frHorsForfait.Rows.Add(frais.date.Value.ToShortDateString(), frais.libelle, frais.montant, etat, reporter);
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
        private void btn_afficherFiche_Click(object sender, EventArgs e)
        {
            moisEnCours = (string)cmb_listFiches.SelectedValue;
            chargeFrForfait(VisiConnect.id);
            chargeFrHorsForfait(VisiConnect.id);
            justificatif();
        }

        private void justificatif()
        {
            moisEnCours = (string)cmb_listFiches.SelectedValue;
            var fiche = (from c in db.fichefrais
                         where (c.idVisiteur == VisiConnect.id && c.mois == moisEnCours)
                         select c).First();
            if (fiche.manqueJustificatif == 1)
                manqueJustif.Visible = true;
            else
                manqueJustif.Visible = false;
        }
        public void chargeFicheFrais()
        {
 
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
