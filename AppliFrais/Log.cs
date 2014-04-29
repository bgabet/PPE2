using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.Entity;

namespace AppliFrais
{
    public partial class Log : Form
    {
        applifraisEntities1 db = new applifraisEntities1();

        public Log()
        {
            InitializeComponent();
        }
        
        private void btn_connexion_Click(object sender, EventArgs e)
        {
            try
            {
                var vis = from c in db.visiteur
                          where (c.login == txt_login.Text && c.mdp == txt_mdp.Text)
                          select c;
                if (vis.Count() == 0)
                {
                    MessageBox.Show("Login ou mot de passe erroné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Form.ActiveForm.Hide();
                AppliFrais app = new AppliFrais();
                app.VisiConnect = vis.First();
                app.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
                return;
            }
        }

        private void txt_mdp_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txt_mdp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_connexion_Click(null, null);
            }
        }

        private void Log_Load(object sender, EventArgs e)
        {

        }

        private void Log_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
