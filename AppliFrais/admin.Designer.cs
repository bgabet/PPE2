namespace AppliFrais
{
    partial class admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.table_utilisateur = new Telerik.WinControls.UI.RadGridView();
            this.btn_nouveau = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.txt_adresse = new System.Windows.Forms.TextBox();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.txt_ville = new System.Windows.Forms.TextBox();
            this.chk_comptable = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.date_embauche = new System.Windows.Forms.DateTimePicker();
            this.btn_enresgitrer = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_utilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_utilisateur.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_supprimer);
            this.groupBox1.Controls.Add(this.btn_enresgitrer);
            this.groupBox1.Controls.Add(this.date_embauche);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chk_comptable);
            this.groupBox1.Controls.Add(this.txt_ville);
            this.groupBox1.Controls.Add(this.txt_cp);
            this.groupBox1.Controls.Add(this.txt_adresse);
            this.groupBox1.Controls.Add(this.txt_mdp);
            this.groupBox1.Controls.Add(this.txt_login);
            this.groupBox1.Controls.Add(this.txt_prenom);
            this.groupBox1.Controls.Add(this.txt_nom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_nouveau);
            this.groupBox1.Controls.Add(this.table_utilisateur);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utilisateurs";
            // 
            // table_utilisateur
            // 
            this.table_utilisateur.Location = new System.Drawing.Point(6, 19);
            // 
            // table_utilisateur
            // 
            this.table_utilisateur.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.table_utilisateur.MasterTemplate.AllowAddNewRow = false;
            this.table_utilisateur.MasterTemplate.AllowDeleteRow = false;
            this.table_utilisateur.MasterTemplate.AllowDragToGroup = false;
            this.table_utilisateur.MasterTemplate.AllowEditRow = false;
            this.table_utilisateur.MasterTemplate.AllowRowReorder = true;
            this.table_utilisateur.Name = "table_utilisateur";
            this.table_utilisateur.Size = new System.Drawing.Size(301, 273);
            this.table_utilisateur.TabIndex = 0;
            this.table_utilisateur.Text = "radGridView1";
            this.table_utilisateur.Click += new System.EventHandler(this.table_utilisateur_Click);
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.Image = ((System.Drawing.Image)(resources.GetObject("btn_nouveau.Image")));
            this.btn_nouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nouveau.Location = new System.Drawing.Point(316, 261);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(80, 31);
            this.btn_nouveau.TabIndex = 1;
            this.btn_nouveau.Text = "Nouveau";
            this.btn_nouveau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nouveau.UseVisualStyleBackColor = true;
            this.btn_nouveau.Click += new System.EventHandler(this.btn_nouveau_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prénom";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(410, 22);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(161, 20);
            this.txt_nom.TabIndex = 4;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(410, 48);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(161, 20);
            this.txt_prenom.TabIndex = 5;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(410, 74);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(161, 20);
            this.txt_login.TabIndex = 6;
            // 
            // txt_mdp
            // 
            this.txt_mdp.Location = new System.Drawing.Point(410, 100);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.Size = new System.Drawing.Size(161, 20);
            this.txt_mdp.TabIndex = 7;
            // 
            // txt_adresse
            // 
            this.txt_adresse.Location = new System.Drawing.Point(410, 126);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.Size = new System.Drawing.Size(161, 20);
            this.txt_adresse.TabIndex = 8;
            // 
            // txt_cp
            // 
            this.txt_cp.Location = new System.Drawing.Point(410, 152);
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(161, 20);
            this.txt_cp.TabIndex = 9;
            this.txt_cp.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.txt_cp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cp_KeyPress);
            // 
            // txt_ville
            // 
            this.txt_ville.Location = new System.Drawing.Point(410, 178);
            this.txt_ville.Name = "txt_ville";
            this.txt_ville.Size = new System.Drawing.Size(161, 20);
            this.txt_ville.TabIndex = 10;
            // 
            // chk_comptable
            // 
            this.chk_comptable.AutoSize = true;
            this.chk_comptable.Location = new System.Drawing.Point(410, 232);
            this.chk_comptable.Name = "chk_comptable";
            this.chk_comptable.Size = new System.Drawing.Size(15, 14);
            this.chk_comptable.TabIndex = 12;
            this.chk_comptable.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mot de passe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Code Postal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ville";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Date d\'embauche";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Comptable";
            // 
            // date_embauche
            // 
            this.date_embauche.Location = new System.Drawing.Point(410, 204);
            this.date_embauche.Name = "date_embauche";
            this.date_embauche.Size = new System.Drawing.Size(161, 20);
            this.date_embauche.TabIndex = 20;
            this.date_embauche.ValueChanged += new System.EventHandler(this.date_embauche_ValueChanged);
            // 
            // btn_enresgitrer
            // 
            this.btn_enresgitrer.Image = ((System.Drawing.Image)(resources.GetObject("btn_enresgitrer.Image")));
            this.btn_enresgitrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_enresgitrer.Location = new System.Drawing.Point(491, 260);
            this.btn_enresgitrer.Name = "btn_enresgitrer";
            this.btn_enresgitrer.Size = new System.Drawing.Size(80, 32);
            this.btn_enresgitrer.TabIndex = 21;
            this.btn_enresgitrer.Text = "Enregistrer";
            this.btn_enresgitrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_enresgitrer.UseVisualStyleBackColor = true;
            this.btn_enresgitrer.Click += new System.EventHandler(this.btn_enresgitrer_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Image = ((System.Drawing.Image)(resources.GetObject("btn_supprimer.Image")));
            this.btn_supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_supprimer.Location = new System.Drawing.Point(403, 260);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(80, 32);
            this.btn_supprimer.TabIndex = 22;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 316);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSB - Gestion des frais";
            this.Load += new System.EventHandler(this.admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_utilisateur.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_utilisateur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadGridView table_utilisateur;
        private System.Windows.Forms.Button btn_nouveau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ville;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.TextBox txt_adresse;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.CheckBox chk_comptable;
        private System.Windows.Forms.DateTimePicker date_embauche;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_enresgitrer;

    }
}