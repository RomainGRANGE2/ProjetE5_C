namespace ProjetE5_C.Presentation
{
    partial class Fprescription
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
            this.lb_prescription = new System.Windows.Forms.Label();
            this.lb_MedocP = new System.Windows.Forms.Label();
            this.dg_prescription = new System.Windows.Forms.DataGridView();
            this.cb_Prescriptions = new System.Windows.Forms.ComboBox();
            this.bt_supprimerP = new System.Windows.Forms.Button();
            this.bt_ajouterP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_prescription)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_prescription
            // 
            this.lb_prescription.AutoSize = true;
            this.lb_prescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_prescription.Location = new System.Drawing.Point(12, 9);
            this.lb_prescription.Name = "lb_prescription";
            this.lb_prescription.Size = new System.Drawing.Size(476, 31);
            this.lb_prescription.TabIndex = 1;
            this.lb_prescription.Text = "Liste des préscriptions du médicament";
            // 
            // lb_MedocP
            // 
            this.lb_MedocP.AutoSize = true;
            this.lb_MedocP.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MedocP.Location = new System.Drawing.Point(494, 9);
            this.lb_MedocP.Name = "lb_MedocP";
            this.lb_MedocP.Size = new System.Drawing.Size(124, 42);
            this.lb_MedocP.TabIndex = 2;
            this.lb_MedocP.Text = "label1";
            // 
            // dg_prescription
            // 
            this.dg_prescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_prescription.Location = new System.Drawing.Point(18, 54);
            this.dg_prescription.Name = "dg_prescription";
            this.dg_prescription.Size = new System.Drawing.Size(770, 258);
            this.dg_prescription.TabIndex = 3;
            // 
            // cb_Prescriptions
            // 
            this.cb_Prescriptions.FormattingEnabled = true;
            this.cb_Prescriptions.Location = new System.Drawing.Point(18, 330);
            this.cb_Prescriptions.Name = "cb_Prescriptions";
            this.cb_Prescriptions.Size = new System.Drawing.Size(121, 21);
            this.cb_Prescriptions.TabIndex = 7;
            // 
            // bt_supprimerP
            // 
            this.bt_supprimerP.Location = new System.Drawing.Point(172, 328);
            this.bt_supprimerP.Name = "bt_supprimerP";
            this.bt_supprimerP.Size = new System.Drawing.Size(75, 23);
            this.bt_supprimerP.TabIndex = 8;
            this.bt_supprimerP.Text = "Supprimer";
            this.bt_supprimerP.UseVisualStyleBackColor = true;
            // 
            // bt_ajouterP
            // 
            this.bt_ajouterP.Location = new System.Drawing.Point(713, 328);
            this.bt_ajouterP.Name = "bt_ajouterP";
            this.bt_ajouterP.Size = new System.Drawing.Size(75, 23);
            this.bt_ajouterP.TabIndex = 9;
            this.bt_ajouterP.Text = "Ajouter";
            this.bt_ajouterP.UseVisualStyleBackColor = true;
            // 
            // Fprescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_ajouterP);
            this.Controls.Add(this.bt_supprimerP);
            this.Controls.Add(this.cb_Prescriptions);
            this.Controls.Add(this.dg_prescription);
            this.Controls.Add(this.lb_MedocP);
            this.Controls.Add(this.lb_prescription);
            this.Name = "Fprescription";
            this.Text = "Fprescription";
            this.Load += new System.EventHandler(this.Fprescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_prescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_prescription;
        private System.Windows.Forms.Label lb_MedocP;
        private System.Windows.Forms.DataGridView dg_prescription;
        private System.Windows.Forms.ComboBox cb_Prescriptions;
        private System.Windows.Forms.Button bt_supprimerP;
        private System.Windows.Forms.Button bt_ajouterP;
    }
}