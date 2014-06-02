namespace AppliFrais
{
    partial class ValidationDesFrais
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidationDesFrais));
            this.etatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxSaisie = new System.Windows.Forms.GroupBox();
            this.cmb_listFiches = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_visiteur = new System.Windows.Forms.ComboBox();
            this.btn_afficher = new System.Windows.Forms.Button();
            this.lab_date = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.table_frForfait = new Telerik.WinControls.UI.RadGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.table_frHorsForfait = new Telerik.WinControls.UI.RadGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_justificatif = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_justificatifs = new System.Windows.Forms.TextBox();
            this.visiteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_enresgitrer = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.etatBindingSource)).BeginInit();
            this.groupBoxSaisie.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_frForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_frForfait.MasterTemplate)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_frHorsForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_frHorsForfait.MasterTemplate)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSaisie
            // 
            this.groupBoxSaisie.Controls.Add(this.cmb_listFiches);
            this.groupBoxSaisie.Controls.Add(this.label1);
            this.groupBoxSaisie.Controls.Add(this.cmb_visiteur);
            this.groupBoxSaisie.Controls.Add(this.btn_afficher);
            this.groupBoxSaisie.Controls.Add(this.lab_date);
            this.groupBoxSaisie.Location = new System.Drawing.Point(6, 5);
            this.groupBoxSaisie.Name = "groupBoxSaisie";
            this.groupBoxSaisie.Size = new System.Drawing.Size(527, 56);
            this.groupBoxSaisie.TabIndex = 16;
            this.groupBoxSaisie.TabStop = false;
            this.groupBoxSaisie.Text = "Validation des frais par visiteur";
            // 
            // cmb_listFiches
            // 
            this.cmb_listFiches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_listFiches.Enabled = false;
            this.cmb_listFiches.FormattingEnabled = true;
            this.cmb_listFiches.Location = new System.Drawing.Point(229, 20);
            this.cmb_listFiches.Name = "cmb_listFiches";
            this.cmb_listFiches.Size = new System.Drawing.Size(120, 21);
            this.cmb_listFiches.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Visiteur";
            // 
            // cmb_visiteur
            // 
            this.cmb_visiteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_visiteur.FormattingEnabled = true;
            this.cmb_visiteur.Location = new System.Drawing.Point(53, 20);
            this.cmb_visiteur.Name = "cmb_visiteur";
            this.cmb_visiteur.Size = new System.Drawing.Size(120, 21);
            this.cmb_visiteur.TabIndex = 5;
            this.cmb_visiteur.SelectedIndexChanged += new System.EventHandler(this.cmb_visiteur_SelectedIndexChanged);
            // 
            // btn_afficher
            // 
            this.btn_afficher.Enabled = false;
            this.btn_afficher.Location = new System.Drawing.Point(366, 20);
            this.btn_afficher.Name = "btn_afficher";
            this.btn_afficher.Size = new System.Drawing.Size(75, 21);
            this.btn_afficher.TabIndex = 4;
            this.btn_afficher.Text = "Afficher";
            this.btn_afficher.UseVisualStyleBackColor = true;
            this.btn_afficher.Click += new System.EventHandler(this.btn_afficher_Click);
            // 
            // lab_date
            // 
            this.lab_date.AutoSize = true;
            this.lab_date.Location = new System.Drawing.Point(194, 24);
            this.lab_date.Name = "lab_date";
            this.lab_date.Size = new System.Drawing.Size(29, 13);
            this.lab_date.TabIndex = 3;
            this.lab_date.Text = "Mois";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.table_frForfait);
            this.groupBox1.Location = new System.Drawing.Point(6, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 167);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frais forfait";
            // 
            // table_frForfait
            // 
            this.table_frForfait.Location = new System.Drawing.Point(6, 19);
            // 
            // table_frForfait
            // 
            this.table_frForfait.MasterTemplate.AllowAddNewRow = false;
            this.table_frForfait.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.table_frForfait.MasterTemplate.AllowDeleteRow = false;
            this.table_frForfait.MasterTemplate.AllowDragToGroup = false;
            this.table_frForfait.MasterTemplate.AllowEditRow = false;
            gridViewTextBoxColumn1.HeaderText = "Repas midi";
            gridViewTextBoxColumn1.Name = "midi";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.HeaderText = "Nuitée";
            gridViewTextBoxColumn2.Name = "nuitee";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.HeaderText = "Étape";
            gridViewTextBoxColumn3.Name = "etape";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.HeaderText = "Kilomètres";
            gridViewTextBoxColumn4.Name = "km";
            gridViewTextBoxColumn4.Width = 90;
            gridViewTextBoxColumn5.HeaderText = "Situation";
            gridViewTextBoxColumn5.Name = "Situation";
            gridViewTextBoxColumn5.Width = 106;
            this.table_frForfait.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.table_frForfait.Name = "table_frForfait";
            this.table_frForfait.Size = new System.Drawing.Size(513, 142);
            this.table_frForfait.TabIndex = 0;
            this.table_frForfait.Text = "radGridView1";
            this.table_frForfait.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.table_frForfait_ContextMenuOpening);
            this.table_frForfait.Click += new System.EventHandler(this.table_frForfait_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.table_frHorsForfait);
            this.groupBox2.Location = new System.Drawing.Point(6, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 137);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frais hors-forfait";
            // 
            // table_frHorsForfait
            // 
            this.table_frHorsForfait.Location = new System.Drawing.Point(6, 17);
            // 
            // table_frHorsForfait
            // 
            this.table_frHorsForfait.MasterTemplate.AllowAddNewRow = false;
            this.table_frHorsForfait.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.table_frHorsForfait.MasterTemplate.AllowDragToGroup = false;
            this.table_frHorsForfait.MasterTemplate.AllowEditRow = false;
            gridViewTextBoxColumn6.HeaderText = "Date";
            gridViewTextBoxColumn6.Name = "date";
            gridViewTextBoxColumn6.Width = 120;
            gridViewTextBoxColumn7.HeaderText = "Libellé";
            gridViewTextBoxColumn7.Name = "libelle";
            gridViewTextBoxColumn7.Width = 125;
            gridViewTextBoxColumn8.HeaderText = "Montant";
            gridViewTextBoxColumn8.Name = "montant";
            gridViewTextBoxColumn8.Width = 125;
            gridViewComboBoxColumn1.DisplayMember = null;
            gridViewComboBoxColumn1.HeaderText = "Situation";
            gridViewComboBoxColumn1.Name = "situation";
            gridViewComboBoxColumn1.ValueMember = null;
            gridViewComboBoxColumn1.Width = 126;
            gridViewTextBoxColumn9.HeaderText = "id";
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "id";
            this.table_frHorsForfait.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewComboBoxColumn1,
            gridViewTextBoxColumn9});
            this.table_frHorsForfait.Name = "table_frHorsForfait";
            this.table_frHorsForfait.Size = new System.Drawing.Size(513, 112);
            this.table_frHorsForfait.TabIndex = 1;
            this.table_frHorsForfait.Text = "radGridView2";
            this.table_frHorsForfait.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.table_frHorsForfait_ContextMenuOpening);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_justificatif);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_justificatifs);
            this.groupBox3.Location = new System.Drawing.Point(6, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(525, 47);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Justificatifs";
            // 
            // chk_justificatif
            // 
            this.chk_justificatif.AutoSize = true;
            this.chk_justificatif.Location = new System.Drawing.Point(206, 22);
            this.chk_justificatif.Name = "chk_justificatif";
            this.chk_justificatif.Size = new System.Drawing.Size(302, 17);
            this.chk_justificatif.TabIndex = 2;
            this.chk_justificatif.Text = "Indiquer au visiteur qu\'il manque un ou plusieurs justificatifs";
            this.chk_justificatif.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de justificatifs";
            // 
            // txt_justificatifs
            // 
            this.txt_justificatifs.Location = new System.Drawing.Point(123, 20);
            this.txt_justificatifs.Name = "txt_justificatifs";
            this.txt_justificatifs.Size = new System.Drawing.Size(65, 20);
            this.txt_justificatifs.TabIndex = 0;
            // 
            // visiteurBindingSource
            // 
            this.visiteurBindingSource.DataMember = "visiteur";
            // 
            // btn_enresgitrer
            // 
            this.btn_enresgitrer.Image = ((System.Drawing.Image)(resources.GetObject("btn_enresgitrer.Image")));
            this.btn_enresgitrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_enresgitrer.Location = new System.Drawing.Point(6, 436);
            this.btn_enresgitrer.Name = "btn_enresgitrer";
            this.btn_enresgitrer.Size = new System.Drawing.Size(95, 32);
            this.btn_enresgitrer.TabIndex = 22;
            this.btn_enresgitrer.Text = "Enregistrer";
            this.btn_enresgitrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_enresgitrer.UseVisualStyleBackColor = true;
            this.btn_enresgitrer.Click += new System.EventHandler(this.btn_enresgitrer_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Image = ((System.Drawing.Image)(resources.GetObject("btn_quit.Image")));
            this.btn_quit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quit.Location = new System.Drawing.Point(435, 436);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(96, 32);
            this.btn_quit.TabIndex = 23;
            this.btn_quit.Text = "Quitter";
            this.btn_quit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // ValidationDesFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 472);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_enresgitrer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSaisie);
            this.Name = "ValidationDesFrais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSB - Validation des frais";
            this.Load += new System.EventHandler(this.ValidationDesFrais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.etatBindingSource)).EndInit();
            this.groupBoxSaisie.ResumeLayout(false);
            this.groupBoxSaisie.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_frForfait.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_frForfait)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_frHorsForfait.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_frHorsForfait)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSaisie;
        private System.Windows.Forms.Label lab_date;
        private System.Windows.Forms.Button btn_afficher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Telerik.WinControls.UI.RadGridView table_frForfait;
        private Telerik.WinControls.UI.RadGridView table_frHorsForfait;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_visiteur;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk_justificatif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_justificatifs;
        private System.Windows.Forms.BindingSource visiteurBindingSource;
        private System.Windows.Forms.Button btn_enresgitrer;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.BindingSource etatBindingSource;
        private System.Windows.Forms.ComboBox cmb_listFiches;
    }
}