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
    public partial class AppliFrais : Form
    {
        public visiteur VisiConnect = new visiteur();
        public AppliFrais()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (VisiConnect.login == "admin")
            {
                link_admin.Visible = true;
            }
            if (VisiConnect.comptable == 1)
            {
                linkCompt.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsulterNote cons = new ConsulterNote();
            cons.VisiConnect = this.VisiConnect;
            cons.ShowDialog();
        }

        private void btn_deco_Click(object sender, EventArgs e)
        {
            VisiConnect = null;
            this.Close();
        }

        private void btn_nouvFiche_Click(object sender, EventArgs e)
        {
            NouvelleNote nouv = new NouvelleNote();
            nouv.VisiConnect = this.VisiConnect;
            nouv.ShowDialog();
        }

        private void link_admin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin adm = new admin();
            adm.ShowDialog();
        }

        private void linkCompt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            comptable compt = new comptable();
            compt.ShowDialog();
        }

        private void AppliFrais_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log formlog = new Log();
            formlog.Show();
        }
    }
}
