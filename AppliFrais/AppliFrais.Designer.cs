namespace AppliFrais
{
    partial class AppliFrais
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
            this.btn_nouvFiche = new System.Windows.Forms.Button();
            this.btn_consult = new System.Windows.Forms.Button();
            this.btn_deco = new System.Windows.Forms.Button();
            this.link_admin = new System.Windows.Forms.LinkLabel();
            this.linkCompt = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_nouvFiche
            // 
            this.btn_nouvFiche.Location = new System.Drawing.Point(77, 35);
            this.btn_nouvFiche.Name = "btn_nouvFiche";
            this.btn_nouvFiche.Size = new System.Drawing.Size(155, 68);
            this.btn_nouvFiche.TabIndex = 0;
            this.btn_nouvFiche.Text = "Nouvelle note de frais";
            this.btn_nouvFiche.UseVisualStyleBackColor = true;
            this.btn_nouvFiche.Click += new System.EventHandler(this.btn_nouvFiche_Click);
            // 
            // btn_consult
            // 
            this.btn_consult.Location = new System.Drawing.Point(77, 109);
            this.btn_consult.Name = "btn_consult";
            this.btn_consult.Size = new System.Drawing.Size(155, 68);
            this.btn_consult.TabIndex = 1;
            this.btn_consult.Text = "Consulter les notes";
            this.btn_consult.UseVisualStyleBackColor = true;
            this.btn_consult.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_deco
            // 
            this.btn_deco.Location = new System.Drawing.Point(77, 183);
            this.btn_deco.Name = "btn_deco";
            this.btn_deco.Size = new System.Drawing.Size(155, 68);
            this.btn_deco.TabIndex = 2;
            this.btn_deco.Text = "Déconnexion";
            this.btn_deco.UseVisualStyleBackColor = true;
            this.btn_deco.Click += new System.EventHandler(this.btn_deco_Click);
            // 
            // link_admin
            // 
            this.link_admin.AutoSize = true;
            this.link_admin.Location = new System.Drawing.Point(223, 272);
            this.link_admin.Name = "link_admin";
            this.link_admin.Size = new System.Drawing.Size(72, 13);
            this.link_admin.TabIndex = 4;
            this.link_admin.TabStop = true;
            this.link_admin.Text = "Administration";
            this.link_admin.Visible = false;
            this.link_admin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_admin_LinkClicked);
            // 
            // linkCompt
            // 
            this.linkCompt.AutoSize = true;
            this.linkCompt.Location = new System.Drawing.Point(12, 272);
            this.linkCompt.Name = "linkCompt";
            this.linkCompt.Size = new System.Drawing.Size(57, 13);
            this.linkCompt.TabIndex = 5;
            this.linkCompt.TabStop = true;
            this.linkCompt.Text = "Comptable";
            this.linkCompt.Visible = false;
            this.linkCompt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCompt_LinkClicked);
            // 
            // AppliFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 294);
            this.Controls.Add(this.linkCompt);
            this.Controls.Add(this.btn_nouvFiche);
            this.Controls.Add(this.link_admin);
            this.Controls.Add(this.btn_deco);
            this.Controls.Add(this.btn_consult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AppliFrais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSB - Gestion des frais";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppliFrais_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nouvFiche;
        private System.Windows.Forms.Button btn_consult;
        private System.Windows.Forms.Button btn_deco;
        private System.Windows.Forms.LinkLabel link_admin;
        private System.Windows.Forms.LinkLabel linkCompt;
    }
}

