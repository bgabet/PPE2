namespace AppliFrais
{
    partial class Log
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
            this.btn_connexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mdp = new System.Windows.Forms.MaskedTextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_connexion
            // 
            this.btn_connexion.Location = new System.Drawing.Point(90, 61);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(134, 23);
            this.btn_connexion.TabIndex = 3;
            this.btn_connexion.Text = "Connexion";
            this.btn_connexion.UseVisualStyleBackColor = true;
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe";
            // 
            // txt_mdp
            // 
            this.txt_mdp.Location = new System.Drawing.Point(90, 36);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.PasswordChar = '*';
            this.txt_mdp.Size = new System.Drawing.Size(134, 20);
            this.txt_mdp.TabIndex = 2;
            this.txt_mdp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mdp_KeyDown);
            this.txt_mdp.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_mdp_MaskInputRejected);
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(90, 12);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(134, 20);
            this.txt_login.TabIndex = 1;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 92);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.txt_mdp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_connexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSB - Gestion des frais";
            this.Load += new System.EventHandler(this.Log_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Log_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_mdp;
        private System.Windows.Forms.TextBox txt_login;
    }
}