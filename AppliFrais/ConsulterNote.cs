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
    public partial class ConsulterNote : Form
    {
        applifraisEntities1 db = new applifraisEntities1();
        string moisEnCours = DateTime.Now.Date.Month.ToString() + "/" + DateTime.Now.Year.ToString();
        public visiteur VisiConnect = new visiteur();
        public ConsulterNote()
        {
            InitializeComponent();
        }

        private void ConsulterNote_Load(object sender, EventArgs e)
        {
            date_moisNote.Format = DateTimePickerFormat.Custom;
            date_moisNote.CustomFormat = "MM/yyyy";
        }

        private void groupBoxSaisie_Enter(object sender, EventArgs e)
        {

        }
        private void chargeFrForfait()
        {
            try
            {
                table_frForfait.Rows.Clear();
                var list_frais = (from c in db.lignefraisforfait
                                 where (c.mois == moisEnCours && c.idVisiteur == VisiConnect.id)
                                 select c).ToList();

                foreach (var frais in list_frais)
                {
                    var a = (from c in db.fraisforfait
                             where c.id == frais.idFraisForfait
                             select c).First();
                    string type = a.libelle;
                    var b = (from c in db.etat
                             where c.id == frais.idEtat
                             select c).First();
                    string etat = b.libelle;
                    string reporter;
                    if (frais.reporter == 1)
                        reporter = "Reporté au mois suivant";
                    else
                        reporter = "";

                    table_frForfait.Rows.Add(type, frais.quantite, etat, reporter);
                }
                DateTime date = date_moisNote.Value.Date;
                date=date.AddMonths(-1);
                moisEnCours=date.Month.ToString() + "/" + date_moisNote.Value.Year.ToString();
                var report = (from c in db.lignefraisforfait
                              where (c.mois == moisEnCours && c.idVisiteur == VisiConnect.id && c.reporter == 1)
                              select c).ToList();
                foreach (var frais in report)
                {
                    var a = (from c in db.fraisforfait
                             where c.id == frais.idFraisForfait
                             select c).First();
                    string type = a.libelle;
                    var b = (from c in db.etat
                             where c.id == frais.idEtat
                             select c).First();
                    string etat = b.libelle;
                    string reporter="Importé du mois précédent";
                    

                    table_frForfait.Rows.Add(type, frais.quantite, etat, reporter);
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

        private void btn_afficher_Click(object sender, EventArgs e)
        {
            moisEnCours = date_moisNote.Value.Month.ToString() + "/" + date_moisNote.Value.Year.ToString();
            chargeFrForfait();
            chargeFrHorsForfait();
        }
        private void chargeFrHorsForfait()
        {
            try
            {
                table_frHorsForfait.Rows.Clear();
                var list_frais = (from c in db.lignefraishorsforfait
                                  where (c.mois == moisEnCours && c.idVisiteur == VisiConnect.id)
                                  select c).ToList();

                foreach (var frais in list_frais)
                {
                    var b = (from c in db.etat
                             where c.id == frais.idEtat
                             select c).First();
                    string etat = b.libelle;
                    string reporter;
                    if (frais.reporter == 1)
                        reporter = "Reporté au mois suivant";
                    else
                        reporter = "";

                    table_frHorsForfait.Rows.Add(frais.date.Value.ToShortDateString(), frais.libelle, frais.montant, etat, reporter);
                }

                DateTime date = date_moisNote.Value.Date;
                date = date.AddMonths(-1);
                moisEnCours = date.Month.ToString() + "/" + date_moisNote.Value.Year.ToString();
                var report = (from c in db.lignefraishorsforfait
                              where (c.mois == moisEnCours && c.idVisiteur == VisiConnect.id && c.reporter == 1)
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
    }
}
