namespace AppliFrais
{
    partial class SuiviRemboursement
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuiviRemboursement));
            this.groupBoxSaisie = new System.Windows.Forms.GroupBox();
            this.btn_afficherFiche = new System.Windows.Forms.Button();
            this.cmb_listFiches = new System.Windows.Forms.ComboBox();
            this.manqueJustif = new System.Windows.Forms.Label();
            this.lab_date = new System.Windows.Forms.Label();
            this.groupBoxForfait = new System.Windows.Forms.GroupBox();
            this.table_frForfait = new Telerik.WinControls.UI.RadGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.table_frHorsForfait = new Telerik.WinControls.UI.RadGridView();
            this.btn_quit = new System.Windows.Forms.Button();
            this.groupBoxSaisie.SuspendLayout();
            this.groupBoxForfait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_frForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_frForfait.MasterTemplate)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_frHorsForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_frHorsForfait.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSaisie
            // 
            this.groupBoxSaisie.Controls.Add(this.btn_afficherFiche);
            this.groupBoxSaisie.Controls.Add(this.cmb_listFiches);
            this.groupBoxSaisie.Controls.Add(this.manqueJustif);
            this.groupBoxSaisie.Controls.Add(this.lab_date);
            this.groupBoxSaisie.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSaisie.Name = "groupBoxSaisie";
            this.groupBoxSaisie.Size = new System.Drawing.Size(529, 56);
            this.groupBoxSaisie.TabIndex = 16;
            this.groupBoxSaisie.TabStop = false;
            this.groupBoxSaisie.Text = "Période";
            // 
            // btn_afficherFiche
            // 
            this.btn_afficherFiche.Location = new System.Drawing.Point(182, 22);
            this.btn_afficherFiche.Name = "btn_afficherFiche";
            this.btn_afficherFiche.Size = new System.Drawing.Size(75, 23);
            this.btn_afficherFiche.TabIndex = 6;
            this.btn_afficherFiche.Text = "Afficher";
            this.btn_afficherFiche.UseVisualStyleBackColor = true;
            this.btn_afficherFiche.Click += new System.EventHandler(this.btn_afficherFiche_Click);
            // 
            // cmb_listFiches
            // 
            this.cmb_listFiches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_listFiches.FormattingEnabled = true;
            this.cmb_listFiches.Location = new System.Drawing.Point(55, 23);
            this.cmb_listFiches.Name = "cmb_listFiches";
            this.cmb_listFiches.Size = new System.Drawing.Size(121, 21);
            this.cmb_listFiches.TabIndex = 5;
            // 
            // manqueJustif
            // 
            this.manqueJustif.AutoSize = true;
            this.manqueJustif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manqueJustif.ForeColor = System.Drawing.Color.Red;
            this.manqueJustif.Location = new System.Drawing.Point(388, 26);
            this.manqueJustif.Name = "manqueJustif";
            this.manqueJustif.Size = new System.Drawing.Size(131, 13);
            this.manqueJustif.TabIndex = 4;
            this.manqueJustif.Text = "/!\\ Manque justificatif";
            this.manqueJustif.Visible = false;
            // 
            // lab_date
            // 
            this.lab_date.AutoSize = true;
            this.lab_date.Location = new System.Drawing.Point(20, 26);
            this.lab_date.Name = "lab_date";
            this.lab_date.Size = new System.Drawing.Size(29, 13);
            this.lab_date.TabIndex = 3;
            this.lab_date.Text = "Mois";
            // 
            // groupBoxForfait
            // 
            this.groupBoxForfait.Controls.Add(this.table_frForfait);
            this.groupBoxForfait.Location = new System.Drawing.Point(12, 74);
            this.groupBoxForfait.Name = "groupBoxForfait";
            this.groupBoxForfait.Size = new System.Drawing.Size(529, 169);
            this.groupBoxForfait.TabIndex = 17;
            this.groupBoxForfait.TabStop = false;
            this.groupBoxForfait.Text = "Frais forfait";
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
            gridViewTextBoxColumn1.Width = 90;
            gridViewTextBoxColumn2.HeaderText = "Nuitée";
            gridViewTextBoxColumn2.Name = "nuitee";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.HeaderText = "Étape";
            gridViewTextBoxColumn3.Name = "etape";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.HeaderText = "Kilomètres";
            gridViewTextBoxColumn4.Name = "km";
            gridViewTextBoxColumn4.Width = 90;
            gridViewComboBoxColumn1.DisplayMember = null;
            gridViewComboBoxColumn1.HeaderText = "Situation";
            gridViewComboBoxColumn1.Name = "situation";
            gridViewComboBoxColumn1.ValueMember = null;
            gridViewComboBoxColumn1.Width = 117;
            this.table_frForfait.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewComboBoxColumn1});
            this.table_frForfait.Name = "table_frForfait";
            this.table_frForfait.Size = new System.Drawing.Size(513, 142);
            this.table_frForfait.TabIndex = 1;
            this.table_frForfait.Text = "radGridView1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.table_frHorsForfait);
            this.groupBox2.Location = new System.Drawing.Point(12, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 137);
            this.groupBox2.TabIndex = 19;
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
            this.table_frHorsForfait.MasterTemplate.AllowCellContextMenu = false;
            this.table_frHorsForfait.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.table_frHorsForfait.MasterTemplate.AllowDragToGroup = false;
            this.table_frHorsForfait.MasterTemplate.AllowEditRow = false;
            gridViewTextBoxColumn5.HeaderText = "Date";
            gridViewTextBoxColumn5.Name = "date";
            gridViewTextBoxColumn5.Width = 120;
            gridViewTextBoxColumn6.HeaderText = "Libellé";
            gridViewTextBoxColumn6.Name = "libelle";
            gridViewTextBoxColumn6.Width = 125;
            gridViewTextBoxColumn7.HeaderText = "Montant";
            gridViewTextBoxColumn7.Name = "montant";
            gridViewTextBoxColumn7.Width = 125;
            gridViewComboBoxColumn2.DisplayMember = null;
            gridViewComboBoxColumn2.HeaderText = "Situation";
            gridViewComboBoxColumn2.Name = "situation";
            gridViewComboBoxColumn2.ValueMember = null;
            gridViewComboBoxColumn2.Width = 126;
            this.table_frHorsForfait.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewComboBoxColumn2});
            this.table_frHorsForfait.Name = "table_frHorsForfait";
            this.table_frHorsForfait.Size = new System.Drawing.Size(513, 112);
            this.table_frHorsForfait.TabIndex = 1;
            this.table_frHorsForfait.Text = "radGridView2";
            // 
            // btn_quit
            // 
            this.btn_quit.Image = ((System.Drawing.Image)(resources.GetObject("btn_quit.Image")));
            this.btn_quit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quit.Location = new System.Drawing.Point(445, 392);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(96, 32);
            this.btn_quit.TabIndex = 24;
            this.btn_quit.Text = "Quitter";
            this.btn_quit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // SuiviRemboursement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 428);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxForfait);
            this.Controls.Add(this.groupBoxSaisie);
            this.Name = "SuiviRemboursement";
            this.Text = "GSB - Suivi de remboursement des frais";
            this.Load += new System.EventHandler(this.SuiviRemboursement_Load);
            this.groupBoxSaisie.ResumeLayout(false);
            this.groupBoxSaisie.PerformLayout();
            this.groupBoxForfait.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_frForfait.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_frForfait)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_frHorsForfait.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_frHorsForfait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSaisie;
        private System.Windows.Forms.Label lab_date;
        private System.Windows.Forms.GroupBox groupBoxForfait;
        private Telerik.WinControls.UI.RadGridView table_frForfait;
        private System.Windows.Forms.Label manqueJustif;
        private System.Windows.Forms.GroupBox groupBox2;
        private Telerik.WinControls.UI.RadGridView table_frHorsForfait;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.ComboBox cmb_listFiches;
        private System.Windows.Forms.Button btn_afficherFiche;
    }
}