namespace AppliFrais
{
    partial class comptable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(comptable));
            this.label1 = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.MaskedTextBox();
            this.txtEtape = new System.Windows.Forms.MaskedTextBox();
            this.txtNuitee = new System.Windows.Forms.MaskedTextBox();
            this.txtRepas = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_EnrNouvNote = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Km";
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(161, 53);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(51, 20);
            this.txtKm.TabIndex = 24;
            // 
            // txtEtape
            // 
            this.txtEtape.Location = new System.Drawing.Point(161, 25);
            this.txtEtape.Name = "txtEtape";
            this.txtEtape.Size = new System.Drawing.Size(51, 20);
            this.txtEtape.TabIndex = 23;
            // 
            // txtNuitee
            // 
            this.txtNuitee.Location = new System.Drawing.Point(47, 51);
            this.txtNuitee.Name = "txtNuitee";
            this.txtNuitee.Size = new System.Drawing.Size(51, 20);
            this.txtNuitee.TabIndex = 22;
            this.txtNuitee.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // txtRepas
            // 
            this.txtRepas.Location = new System.Drawing.Point(47, 25);
            this.txtRepas.Name = "txtRepas";
            this.txtRepas.Size = new System.Drawing.Size(51, 20);
            this.txtRepas.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Étape";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nuitée";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Repas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKm);
            this.groupBox1.Controls.Add(this.txtEtape);
            this.groupBox1.Controls.Add(this.txtNuitee);
            this.groupBox1.Controls.Add(this.txtRepas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prix unitaire";
            // 
            // btn_EnrNouvNote
            // 
            this.btn_EnrNouvNote.Image = ((System.Drawing.Image)(resources.GetObject("btn_EnrNouvNote.Image")));
            this.btn_EnrNouvNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EnrNouvNote.Location = new System.Drawing.Point(12, 101);
            this.btn_EnrNouvNote.Name = "btn_EnrNouvNote";
            this.btn_EnrNouvNote.Size = new System.Drawing.Size(117, 32);
            this.btn_EnrNouvNote.TabIndex = 3;
            this.btn_EnrNouvNote.Text = "Enregistrer";
            this.btn_EnrNouvNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EnrNouvNote.UseVisualStyleBackColor = true;
            this.btn_EnrNouvNote.Click += new System.EventHandler(this.btn_EnrNouvNote_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(135, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 28;
            this.button1.Text = "Quitter";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comptable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 138);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_EnrNouvNote);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "comptable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSB - Gestion des frais";
            this.Load += new System.EventHandler(this.comptable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtKm;
        private System.Windows.Forms.MaskedTextBox txtEtape;
        private System.Windows.Forms.MaskedTextBox txtNuitee;
        private System.Windows.Forms.MaskedTextBox txtRepas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_EnrNouvNote;
        private System.Windows.Forms.Button button1;
    }
}