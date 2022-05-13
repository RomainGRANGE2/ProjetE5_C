namespace ProjetE5_C.Presentation
{
    partial class Fconnexion
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
            this.lb_connexionV = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.bt_connexion = new System.Windows.Forms.Button();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_connexionV
            // 
            this.lb_connexionV.AutoSize = true;
            this.lb_connexionV.Location = new System.Drawing.Point(316, 62);
            this.lb_connexionV.Name = "lb_connexionV";
            this.lb_connexionV.Size = new System.Drawing.Size(116, 13);
            this.lb_connexionV.TabIndex = 0;
            this.lb_connexionV.Text = "Connexion d\'un visiteur";
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Location = new System.Drawing.Point(123, 141);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(33, 13);
            this.lb_login.TabIndex = 1;
            this.lb_login.Text = "Login";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(123, 221);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(71, 13);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Mot de passe";
            // 
            // bt_connexion
            // 
            this.bt_connexion.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_connexion.Location = new System.Drawing.Point(239, 333);
            this.bt_connexion.Name = "bt_connexion";
            this.bt_connexion.Size = new System.Drawing.Size(75, 23);
            this.bt_connexion.TabIndex = 3;
            this.bt_connexion.Text = "Connecter";
            this.bt_connexion.UseVisualStyleBackColor = true;
            this.bt_connexion.Click += new System.EventHandler(this.bt_connexion_Click);
            // 
            // bt_annuler
            // 
            this.bt_annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_annuler.Location = new System.Drawing.Point(477, 332);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(75, 23);
            this.bt_annuler.TabIndex = 4;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(358, 141);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(100, 20);
            this.tb_login.TabIndex = 5;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(358, 221);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 6;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // Fconnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.bt_annuler);
            this.Controls.Add(this.bt_connexion);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.lb_connexionV);
            this.Name = "Fconnexion";
            this.Text = "Fconnexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_connexionV;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Button bt_connexion;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
    }
}