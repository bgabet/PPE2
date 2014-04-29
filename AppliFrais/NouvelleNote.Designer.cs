namespace AppliFrais
{
    partial class NouvelleNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NouvelleNote));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.date_moisNote = new System.Windows.Forms.DateTimePicker();
            this.btn_EnrNouvNote = new System.Windows.Forms.Button();
            this.lab_date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.Button();
            this.table_detailsNote = new Telerik.WinControls.UI.RadGridView();
            this.groupBoxSaisie = new System.Windows.Forms.GroupBox();
            this.txt_montantNote = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxForfait = new System.Windows.Forms.GroupBox();
            this.txt_km = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_etape = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nuitee = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_repas = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateHorsForfait = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btn_ajoutHorsForfait = new System.Windows.Forms.Button();
            this.txt_montantHorsForfait = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_libelleHorsForfait = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.cmb_etat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_detailsNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_detailsNote.MasterTemplate)).BeginInit();
            this.groupBoxSaisie.SuspendLayout();
            this.groupBoxForfait.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateHorsForfait)).BeginInit();
            this.SuspendLayout();
            // 
            // date_moisNote
            // 
            this.date_moisNote.CustomFormat = "\"MM/yyyy\"";
            this.date_moisNote.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date_moisNote.Location = new System.Drawing.Point(58, 23);
            this.date_moisNote.Name = "date_moisNote";
            this.date_moisNote.ShowUpDown = true;
            this.date_moisNote.Size = new System.Drawing.Size(92, 20);
            this.date_moisNote.TabIndex = 0;
            this.date_moisNote.ValueChanged += new System.EventHandler(this.date_moisNote_ValueChanged);
            // 
            // btn_EnrNouvNote
            // 
            this.btn_EnrNouvNote.Image = ((System.Drawing.Image)(resources.GetObject("btn_EnrNouvNote.Image")));
            this.btn_EnrNouvNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EnrNouvNote.Location = new System.Drawing.Point(12, 341);
            this.btn_EnrNouvNote.Name = "btn_EnrNouvNote";
            this.btn_EnrNouvNote.Size = new System.Drawing.Size(95, 32);
            this.btn_EnrNouvNote.TabIndex = 2;
            this.btn_EnrNouvNote.Text = "Enregistrer";
            this.btn_EnrNouvNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EnrNouvNote.UseVisualStyleBackColor = true;
            this.btn_EnrNouvNote.Click += new System.EventHandler(this.btn_EnrNouvNote_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Montant total";
            // 
            // btn_quit
            // 
            this.btn_quit.Image = ((System.Drawing.Image)(resources.GetObject("btn_quit.Image")));
            this.btn_quit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quit.Location = new System.Drawing.Point(433, 341);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(83, 32);
            this.btn_quit.TabIndex = 10;
            this.btn_quit.Text = "Quitter";
            this.btn_quit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.button1_Click);
            // 
            // table_detailsNote
            // 
            this.table_detailsNote.AllowDrop = true;
            this.table_detailsNote.Location = new System.Drawing.Point(16, 19);
            // 
            // table_detailsNote
            // 
            this.table_detailsNote.MasterTemplate.AllowAddNewRow = false;
            this.table_detailsNote.MasterTemplate.AllowDragToGroup = false;
            this.table_detailsNote.MasterTemplate.AllowRowReorder = true;
            gridViewTextBoxColumn5.HeaderText = "ID";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "ID";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.HeaderText = "Date";
            gridViewTextBoxColumn6.Name = "Date";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 100;
            gridViewTextBoxColumn7.HeaderText = "Libellé";
            gridViewTextBoxColumn7.Name = "Libellé";
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 270;
            gridViewTextBoxColumn8.HeaderText = "Montant";
            gridViewTextBoxColumn8.Name = "Montant";
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn8.Width = 100;
            this.table_detailsNote.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.table_detailsNote.Name = "table_detailsNote";
            this.table_detailsNote.Size = new System.Drawing.Size(488, 119);
            this.table_detailsNote.TabIndex = 11;
            this.table_detailsNote.Text = "radGridView1";
            // 
            // groupBoxSaisie
            // 
            this.groupBoxSaisie.Controls.Add(this.label4);
            this.groupBoxSaisie.Controls.Add(this.cmb_etat);
            this.groupBoxSaisie.Controls.Add(this.lab_date);
            this.groupBoxSaisie.Controls.Add(this.date_moisNote);
            this.groupBoxSaisie.Location = new System.Drawing.Point(12, 4);
            this.groupBoxSaisie.Name = "groupBoxSaisie";
            this.groupBoxSaisie.Size = new System.Drawing.Size(512, 56);
            this.groupBoxSaisie.TabIndex = 15;
            this.groupBoxSaisie.TabStop = false;
            this.groupBoxSaisie.Text = "Saisie";
            // 
            // txt_montantNote
            // 
            this.txt_montantNote.Enabled = false;
            this.txt_montantNote.Location = new System.Drawing.Point(354, 314);
            this.txt_montantNote.Name = "txt_montantNote";
            this.txt_montantNote.Size = new System.Drawing.Size(72, 20);
            this.txt_montantNote.TabIndex = 17;
            this.txt_montantNote.Text = "0";
            this.txt_montantNote.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_montantNote_MaskInputRejected);
            // 
            // groupBoxForfait
            // 
            this.groupBoxForfait.Controls.Add(this.txt_km);
            this.groupBoxForfait.Controls.Add(this.label6);
            this.groupBoxForfait.Controls.Add(this.txt_etape);
            this.groupBoxForfait.Controls.Add(this.label5);
            this.groupBoxForfait.Controls.Add(this.txt_nuitee);
            this.groupBoxForfait.Controls.Add(this.label2);
            this.groupBoxForfait.Controls.Add(this.txt_repas);
            this.groupBoxForfait.Controls.Add(this.label1);
            this.groupBoxForfait.Location = new System.Drawing.Point(12, 66);
            this.groupBoxForfait.Name = "groupBoxForfait";
            this.groupBoxForfait.Size = new System.Drawing.Size(512, 60);
            this.groupBoxForfait.TabIndex = 16;
            this.groupBoxForfait.TabStop = false;
            this.groupBoxForfait.Text = "Frais forfait";
            // 
            // txt_km
            // 
            this.txt_km.Location = new System.Drawing.Point(368, 26);
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(51, 20);
            this.txt_km.TabIndex = 26;
            this.txt_km.Text = "0";
            this.txt_km.ValidatingType = typeof(int);
            this.txt_km.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_km_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Km";
            // 
            // txt_etape
            // 
            this.txt_etape.Location = new System.Drawing.Point(283, 26);
            this.txt_etape.Name = "txt_etape";
            this.txt_etape.Size = new System.Drawing.Size(51, 20);
            this.txt_etape.TabIndex = 24;
            this.txt_etape.Text = "0";
            this.txt_etape.ValidatingType = typeof(int);
            this.txt_etape.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_etape_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Étape";
            // 
            // txt_nuitee
            // 
            this.txt_nuitee.Location = new System.Drawing.Point(186, 26);
            this.txt_nuitee.Name = "txt_nuitee";
            this.txt_nuitee.Size = new System.Drawing.Size(51, 20);
            this.txt_nuitee.TabIndex = 22;
            this.txt_nuitee.Text = "0";
            this.txt_nuitee.ValidatingType = typeof(int);
            this.txt_nuitee.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            this.txt_nuitee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nuitee_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nuitée";
            // 
            // txt_repas
            // 
            this.txt_repas.Location = new System.Drawing.Point(85, 26);
            this.txt_repas.Name = "txt_repas";
            this.txt_repas.Size = new System.Drawing.Size(51, 20);
            this.txt_repas.TabIndex = 20;
            this.txt_repas.Text = "0";
            this.txt_repas.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_repas_MaskInputRejected);
            this.txt_repas.ModifiedChanged += new System.EventHandler(this.txt_repas_ModifiedChanged);
            this.txt_repas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_repas_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Repas midi";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(432, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 24);
            this.button1.TabIndex = 28;
            this.button1.Text = "Calcul";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateHorsForfait);
            this.groupBox1.Controls.Add(this.btn_ajoutHorsForfait);
            this.groupBox1.Controls.Add(this.txt_montantHorsForfait);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_libelleHorsForfait);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelDate);
            this.groupBox1.Controls.Add(this.table_detailsNote);
            this.groupBox1.Location = new System.Drawing.Point(12, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 173);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frais hors-forfait";
            // 
            // dateHorsForfait
            // 
            this.dateHorsForfait.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateHorsForfait.Location = new System.Drawing.Point(50, 144);
            this.dateHorsForfait.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateHorsForfait.MinDate = new System.DateTime(((long)(0)));
            this.dateHorsForfait.Name = "dateHorsForfait";
            this.dateHorsForfait.NullableValue = new System.DateTime(2014, 4, 12, 21, 7, 4, 609);
            this.dateHorsForfait.NullDate = new System.DateTime(((long)(0)));
            this.dateHorsForfait.Size = new System.Drawing.Size(78, 20);
            this.dateHorsForfait.TabIndex = 30;
            this.dateHorsForfait.TabStop = false;
            this.dateHorsForfait.Text = "samedi 12 avril 2014";
            this.dateHorsForfait.Value = new System.DateTime(2014, 4, 12, 21, 7, 4, 609);
            this.dateHorsForfait.ValueChanged += new System.EventHandler(this.radDateTimePicker1_ValueChanged);
            // 
            // btn_ajoutHorsForfait
            // 
            this.btn_ajoutHorsForfait.Image = ((System.Drawing.Image)(resources.GetObject("btn_ajoutHorsForfait.Image")));
            this.btn_ajoutHorsForfait.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ajoutHorsForfait.Location = new System.Drawing.Point(421, 142);
            this.btn_ajoutHorsForfait.Name = "btn_ajoutHorsForfait";
            this.btn_ajoutHorsForfait.Size = new System.Drawing.Size(83, 24);
            this.btn_ajoutHorsForfait.TabIndex = 29;
            this.btn_ajoutHorsForfait.Text = "Ajouter";
            this.btn_ajoutHorsForfait.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ajoutHorsForfait.UseVisualStyleBackColor = true;
            this.btn_ajoutHorsForfait.Click += new System.EventHandler(this.btn_ajoutHorsForfait_Click);
            // 
            // txt_montantHorsForfait
            // 
            this.txt_montantHorsForfait.Location = new System.Drawing.Point(342, 144);
            this.txt_montantHorsForfait.Name = "txt_montantHorsForfait";
            this.txt_montantHorsForfait.Size = new System.Drawing.Size(72, 20);
            this.txt_montantHorsForfait.TabIndex = 28;
            this.txt_montantHorsForfait.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.txt_montantHorsForfait.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_montantHorsForfait_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Montant";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_libelleHorsForfait
            // 
            this.txt_libelleHorsForfait.Location = new System.Drawing.Point(177, 144);
            this.txt_libelleHorsForfait.Name = "txt_libelleHorsForfait";
            this.txt_libelleHorsForfait.Size = new System.Drawing.Size(109, 20);
            this.txt_libelleHorsForfait.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Libellé";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(14, 147);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "Date";
            // 
            // cmb_etat
            // 
            this.cmb_etat.FormattingEnabled = true;
            this.cmb_etat.Items.AddRange(new object[] {
            "Créée, en saisie",
            "Cloturée",
            "Validée",
            "Mise en paiement",
            "Remboursée"});
            this.cmb_etat.Location = new System.Drawing.Point(383, 23);
            this.cmb_etat.Name = "cmb_etat";
            this.cmb_etat.Size = new System.Drawing.Size(121, 21);
            this.cmb_etat.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "État";
            // 
            // NouvelleNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 376);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_montantNote);
            this.Controls.Add(this.groupBoxForfait);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxSaisie);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_EnrNouvNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NouvelleNote";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSB - Gestion des frais";
            this.Load += new System.EventHandler(this.NouvelleNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_detailsNote.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_detailsNote)).EndInit();
            this.groupBoxSaisie.ResumeLayout(false);
            this.groupBoxSaisie.PerformLayout();
            this.groupBoxForfait.ResumeLayout(false);
            this.groupBoxForfait.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateHorsForfait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_moisNote;
        private System.Windows.Forms.Button btn_EnrNouvNote;
        private System.Windows.Forms.Label lab_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_quit;
        private Telerik.WinControls.UI.RadGridView table_detailsNote;
        private System.Windows.Forms.GroupBox groupBoxSaisie;
        private System.Windows.Forms.MaskedTextBox txt_montantNote;
        private System.Windows.Forms.GroupBox groupBoxForfait;
        private System.Windows.Forms.MaskedTextBox txt_repas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_km;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txt_etape;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txt_nuitee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button btn_ajoutHorsForfait;
        private System.Windows.Forms.MaskedTextBox txt_montantHorsForfait;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txt_libelleHorsForfait;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadDateTimePicker dateHorsForfait;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_etat;
    }
}