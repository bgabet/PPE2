namespace AppliFrais
{
    partial class ConsulterNote
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.groupBoxSaisie = new System.Windows.Forms.GroupBox();
            this.btn_afficher = new System.Windows.Forms.Button();
            this.lab_date = new System.Windows.Forms.Label();
            this.date_moisNote = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.table_frForfait = new Telerik.WinControls.UI.RadGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.table_frHorsForfait = new Telerik.WinControls.UI.RadGridView();
            this.groupBoxSaisie.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_frForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_frForfait.MasterTemplate)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_frHorsForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_frHorsForfait.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSaisie
            // 
            this.groupBoxSaisie.Controls.Add(this.btn_afficher);
            this.groupBoxSaisie.Controls.Add(this.lab_date);
            this.groupBoxSaisie.Controls.Add(this.date_moisNote);
            this.groupBoxSaisie.Location = new System.Drawing.Point(6, 5);
            this.groupBoxSaisie.Name = "groupBoxSaisie";
            this.groupBoxSaisie.Size = new System.Drawing.Size(527, 56);
            this.groupBoxSaisie.TabIndex = 16;
            this.groupBoxSaisie.TabStop = false;
            this.groupBoxSaisie.Text = "Période";
            // 
            // btn_afficher
            // 
            this.btn_afficher.Location = new System.Drawing.Point(156, 21);
            this.btn_afficher.Name = "btn_afficher";
            this.btn_afficher.Size = new System.Drawing.Size(75, 23);
            this.btn_afficher.TabIndex = 4;
            this.btn_afficher.Text = "Afficher";
            this.btn_afficher.UseVisualStyleBackColor = true;
            this.btn_afficher.Click += new System.EventHandler(this.btn_afficher_Click);
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
            // date_moisNote
            // 
            this.date_moisNote.CustomFormat = "\"MM/yyyy\"";
            this.date_moisNote.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date_moisNote.Location = new System.Drawing.Point(58, 23);
            this.date_moisNote.Name = "date_moisNote";
            this.date_moisNote.ShowUpDown = true;
            this.date_moisNote.Size = new System.Drawing.Size(92, 20);
            this.date_moisNote.TabIndex = 0;
            this.date_moisNote.Value = new System.DateTime(2014, 4, 1, 0, 0, 0, 0);
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
            gridViewTextBoxColumn1.HeaderText = "Type frais";
            gridViewTextBoxColumn1.Name = "frais";
            gridViewTextBoxColumn1.Width = 120;
            gridViewTextBoxColumn2.HeaderText = "Quantité";
            gridViewTextBoxColumn2.Name = "column1";
            gridViewTextBoxColumn2.Width = 120;
            gridViewTextBoxColumn3.HeaderText = "Etat";
            gridViewTextBoxColumn3.Name = "column2";
            gridViewTextBoxColumn3.Width = 136;
            gridViewTextBoxColumn4.HeaderText = "Report";
            gridViewTextBoxColumn4.Name = "Report";
            gridViewTextBoxColumn4.Width = 120;
            this.table_frForfait.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.table_frForfait.Name = "table_frForfait";
            this.table_frForfait.Size = new System.Drawing.Size(513, 142);
            this.table_frForfait.TabIndex = 0;
            this.table_frForfait.Text = "radGridView1";
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
            this.table_frHorsForfait.MasterTemplate.AllowCellContextMenu = false;
            this.table_frHorsForfait.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.table_frHorsForfait.MasterTemplate.AllowDragToGroup = false;
            this.table_frHorsForfait.MasterTemplate.AllowEditRow = false;
            gridViewTextBoxColumn5.HeaderText = "Date";
            gridViewTextBoxColumn5.Name = "column1";
            gridViewTextBoxColumn5.Width = 100;
            gridViewTextBoxColumn6.HeaderText = "Libellé";
            gridViewTextBoxColumn6.Name = "column2";
            gridViewTextBoxColumn6.Width = 100;
            gridViewTextBoxColumn7.HeaderText = "Montant";
            gridViewTextBoxColumn7.Name = "column3";
            gridViewTextBoxColumn7.Width = 100;
            gridViewTextBoxColumn8.HeaderText = "Etat";
            gridViewTextBoxColumn8.Name = "column5";
            gridViewTextBoxColumn8.Width = 96;
            gridViewTextBoxColumn9.HeaderText = "Report";
            gridViewTextBoxColumn9.Name = "column4";
            gridViewTextBoxColumn9.Width = 100;
            this.table_frHorsForfait.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9});
            this.table_frHorsForfait.Name = "table_frHorsForfait";
            this.table_frHorsForfait.Size = new System.Drawing.Size(513, 112);
            this.table_frHorsForfait.TabIndex = 1;
            this.table_frHorsForfait.Text = "radGridView2";
            // 
            // ConsulterNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSaisie);
            this.Name = "ConsulterNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSB - Gestion des frais";
            this.Load += new System.EventHandler(this.ConsulterNote_Load);
            this.groupBoxSaisie.ResumeLayout(false);
            this.groupBoxSaisie.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_afficher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date_moisNote;
        private System.Windows.Forms.GroupBox groupBox2;
        private Telerik.WinControls.UI.RadGridView table_frForfait;
        private Telerik.WinControls.UI.RadGridView table_frHorsForfait;
    }
}