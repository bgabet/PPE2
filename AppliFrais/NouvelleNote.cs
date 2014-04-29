using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace AppliFrais
{
    public partial class NouvelleNote : Form
    {
        fichefrais ficheEnCours = new fichefrais();
        applifraisEntities1 db = new applifraisEntities1();
        public visiteur VisiConnect = new visiteur();
        public NouvelleNote()
        {
            InitializeComponent();
        }

        private void btn_EnrNouvNote_Click(object sender, EventArgs e)
        {
            try
            {

                Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");

                //Tests sur les champs 
                if (DateTime.Now.Day > 10 && (date_moisNote.Value.Month < DateTime.Now.Month-1 || date_moisNote.Value.Year < DateTime.Now.Year))
                {
                    MessageBox.Show("Vous ne pouvez plus ajouter de frais pour le mois indiquer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //on vérifie si la fiche idvisiteur+mois n'existe pas puis on créé une nouvelle fiche 
                string moisEnCours = date_moisNote.Value.Month.ToString() + "/" + date_moisNote.Value.Year.ToString();
                var ficheExiste = from c in db.fichefrais
                                  where (c.idVisiteur == VisiConnect.id && c.mois == moisEnCours)
                                  select c;
                if (ficheExiste.Count() == 0)
                {
                    string moi = date_moisNote.Value.Month.ToString() + "/" + date_moisNote.Value.Year.ToString();
                    fichefrais fiche = new fichefrais();
                    fiche.dateModif = DateTime.Now.Date;
                    fiche.mois = moi;
                    fiche.idVisiteur = VisiConnect.id;
                    fiche.idEtat = 3;
                    db.AddTofichefrais(fiche);
                    db.SaveChanges();
                }
                lignefraisforfait frForfaitRepas = new lignefraisforfait();
                lignefraisforfait frForfaitNuitee = new lignefraisforfait();
                lignefraisforfait frForfaitEtape = new lignefraisforfait();
                lignefraisforfait frForfaitKm = new lignefraisforfait();

                if (txt_repas.Text != "0")
                {
                    frForfaitRepas.idFraisForfait = 1;
                    frForfaitRepas.mois = moisEnCours;
                    frForfaitRepas.idEtat = 3;
                    frForfaitRepas.idVisiteur = VisiConnect.id;
                    frForfaitRepas.quantite = Convert.ToInt32(txt_repas.Text);
                    if (date_moisNote.Value.Day > 10)
                        frForfaitRepas.reporter = 1;
                    db.AddTolignefraisforfait(frForfaitRepas);
                    db.SaveChanges();
                }
                if (txt_nuitee.Text != "0")
                {
                    frForfaitNuitee.idFraisForfait = 2;
                    frForfaitNuitee.mois = moisEnCours;
                    frForfaitNuitee.idVisiteur = VisiConnect.id;
                    frForfaitNuitee.idEtat = 3;
                    frForfaitNuitee.quantite = Convert.ToInt32(txt_nuitee.Text);
                    if (date_moisNote.Value.Day > 10)
                        frForfaitNuitee.reporter = 1;
                    db.AddTolignefraisforfait(frForfaitNuitee);
                    db.SaveChanges();
                }
                if (txt_etape.Text != "0")
                {
                    frForfaitEtape.idFraisForfait = 3;
                    frForfaitEtape.mois = moisEnCours;
                    frForfaitEtape.idEtat = 3;
                    frForfaitEtape.idVisiteur = VisiConnect.id;
                    frForfaitEtape.quantite = Convert.ToInt32(txt_etape.Text);
                    if (date_moisNote.Value.Day > 10)
                        frForfaitEtape.reporter = 1;
                    db.AddTolignefraisforfait(frForfaitEtape);
                    db.SaveChanges();
                }
                if (txt_km.Text != "0")
                {
                    frForfaitKm.idFraisForfait = 4;
                    frForfaitKm.mois = moisEnCours;
                    frForfaitKm.idEtat = 3;
                    frForfaitKm.idVisiteur = VisiConnect.id;
                    frForfaitKm.quantite = Convert.ToInt32(txt_km.Text);
                    if (date_moisNote.Value.Day > 10)
                        frForfaitKm.reporter = 1;
                    db.AddTolignefraisforfait(frForfaitKm);
                    db.SaveChanges();
                }

                int i = 0;
                for (i = 0; i < table_detailsNote.Rows.Count; i++)
                {
                    lignefraishorsforfait frHorsForfait = new lignefraishorsforfait();
                    frHorsForfait.idVisiteur = VisiConnect.id;
                    frHorsForfait.mois = moisEnCours;
                    frHorsForfait.idEtat = 3;
                    frHorsForfait.date = Convert.ToDateTime(table_detailsNote.Rows[i].Cells[1].Value);
                    frHorsForfait.libelle = table_detailsNote.Rows[i].Cells[2].Value.ToString();
                    frHorsForfait.montant = Convert.ToInt32(table_detailsNote.Rows[i].Cells[3].Value);
                    if (date_moisNote.Value.Day > 10)
                        frHorsForfait.reporter = 1;
                    db.AddTolignefraishorsforfait(frHorsForfait);
                    db.SaveChanges();
                }

                table_detailsNote.Rows.Clear();
                txt_repas.Text = txt_nuitee.Text = txt_etape.Text = txt_km.Text = "0";
                MessageBox.Show("Votre fiche du mois " + moisEnCours + " à été mise à jour.", "GSB - Gestion des frais", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException);
                return;
            }
        }

        private void NouvelleNote_Load(object sender, EventArgs e)
        {
            date_moisNote.Format = DateTimePickerFormat.Custom;
            date_moisNote.CustomFormat = "MM/yyyy";

            DateTime moisAnnee = DateTime.Now;
            date_moisNote.Value=moisAnnee;

            if (DateTime.Now.Day < 10)
            {
                moisAnnee = DateTime.Now;
                moisAnnee = moisAnnee.AddMonths(-1);
                date_moisNote.Value = moisAnnee;
            }
            
        }
        private void rempliTableHorsForfait()
        {
            //var listehorsForfait = from c in db.lignefraishorsforfait
            //                       where c.fichefrais == ficheEnCours
            //                       select c;

            //table_detailsNote.DataSource = listehorsForfait;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_valid_Click(object sender, EventArgs e)
        {
           
           
        }

        private void chargeFiche(fichefrais fiche)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_montantNote_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_fraisHorsForfait_Click(object sender, EventArgs e)
        {

        }

        private void txt_repas_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_repas_ModifiedChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    bool result = true;
            //    int rep;
            //    result = Int32.TryParse(txt_repas.Text, out rep);
            //    if (!result)
            //    {
            //        MessageBox.Show("Veuillez entrer des valeurs correctes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }

            //    var tarif = from c in db.fraisforfait
            //                where c.id == 1
            //                select c;
            //    double montantFrais = Convert.ToDouble(txt_montantNote.Text);
               
            //    double tar = (double)Convert.ToDouble(tarif.First().montant);
                
            //    double total = montantFrais + rep*tar ;
            //    txt_montantNote.Text = total.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
            //}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int rep = Convert.ToInt32(txt_repas.Text);
                int nuit = Convert.ToInt32(txt_nuitee.Text);
                int etap = Convert.ToInt32(txt_etape.Text);
                int km = Convert.ToInt32(txt_km.Text);

                var fraisRep = from c in db.fraisforfait
                               where c.id == 1
                               select c.montant;
                double frRep = (double)fraisRep.Sum();
                var fraisNuit = from c in db.fraisforfait
                                where c.id == 2
                                select c.montant;
                double frNuit = (double)fraisNuit.Sum();
                var fraisEtape = from c in db.fraisforfait
                                 where c.id == 3
                                 select c.montant;
                double frEtape = (double)fraisEtape.Sum();
                var fraisKm = from c in db.fraisforfait
                              where c.id == 4
                              select c.montant;
                double frKm = (double)fraisKm.Sum();
                double frHors = 0;
                int i = 0;
                for (i = 0; i < table_detailsNote.Rows.Count; i++)
                {
                    frHors += (double)Convert.ToDouble(table_detailsNote.Rows[i].Cells[3].Value);
                }

                double total = frHors+rep * frRep + nuit * frNuit + etap * frEtape + km * frKm;

                txt_montantNote.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
                return;
            }
        }

        private void date_moisNote_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_repas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        private void txt_nuitee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        private void txt_etape_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        private void txt_km_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_ajoutHorsForfait_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            table_detailsNote.Rows.Add(0, dateHorsForfait.Value.Date.ToShortDateString(), txt_libelleHorsForfait.Text, txt_montantHorsForfait.Text);
            txt_libelleHorsForfait.Text = txt_montantHorsForfait.Text="";
        }

        private void dateHorsForfait_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_montantHorsForfait_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void radDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
