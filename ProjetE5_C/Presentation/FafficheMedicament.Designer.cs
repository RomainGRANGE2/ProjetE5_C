namespace ProjetE5_C.Presentation
{
    partial class FafficheMedicament
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
            this.lb_affichageV = new System.Windows.Forms.Label();
            this.bt_fermer = new System.Windows.Forms.Button();
            this.dg_medicament = new System.Windows.Forms.DataGridView();
            this.bt_formulation = new System.Windows.Forms.Button();
            this.bt_interactions = new System.Windows.Forms.Button();
            this.bt_prescriptions = new System.Windows.Forms.Button();
            this.cb_medicament = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_medicament)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_affichageV
            // 
            this.lb_affichageV.AutoSize = true;
            this.lb_affichageV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_affichageV.Location = new System.Drawing.Point(187, 9);
            this.lb_affichageV.Name = "lb_affichageV";
            this.lb_affichageV.Size = new System.Drawing.Size(468, 31);
            this.lb_affichageV.TabIndex = 0;
            this.lb_affichageV.Text = "Affichage de la liste des Médicaments";
            // 
            // bt_fermer
            // 
            this.bt_fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_fermer.Location = new System.Drawing.Point(713, 415);
            this.bt_fermer.Name = "bt_fermer";
            this.bt_fermer.Size = new System.Drawing.Size(75, 23);
            this.bt_fermer.TabIndex = 1;
            this.bt_fermer.Text = "Fermer";
            this.bt_fermer.UseVisualStyleBackColor = true;
            // 
            // dg_medicament
            // 
            this.dg_medicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_medicament.Location = new System.Drawing.Point(12, 43);
            this.dg_medicament.Name = "dg_medicament";
            this.dg_medicament.Size = new System.Drawing.Size(776, 245);
            this.dg_medicament.TabIndex = 2;
            // 
            // bt_formulation
            // 
            this.bt_formulation.Location = new System.Drawing.Point(212, 318);
            this.bt_formulation.Name = "bt_formulation";
            this.bt_formulation.Size = new System.Drawing.Size(75, 23);
            this.bt_formulation.TabIndex = 3;
            this.bt_formulation.Text = "Formulations";
            this.bt_formulation.UseVisualStyleBackColor = true;
            this.bt_formulation.Click += new System.EventHandler(this.bt_formulation_Click);
            // 
            // bt_interactions
            // 
            this.bt_interactions.Location = new System.Drawing.Point(345, 318);
            this.bt_interactions.Name = "bt_interactions";
            this.bt_interactions.Size = new System.Drawing.Size(75, 23);
            this.bt_interactions.TabIndex = 4;
            this.bt_interactions.Text = "Interractions";
            this.bt_interactions.UseVisualStyleBackColor = true;
            this.bt_interactions.Click += new System.EventHandler(this.bt_interactions_Click);
            // 
            // bt_prescriptions
            // 
            this.bt_prescriptions.Location = new System.Drawing.Point(492, 318);
            this.bt_prescriptions.Name = "bt_prescriptions";
            this.bt_prescriptions.Size = new System.Drawing.Size(75, 23);
            this.bt_prescriptions.TabIndex = 5;
            this.bt_prescriptions.Text = "Prescriptions";
            this.bt_prescriptions.UseVisualStyleBackColor = true;
            this.bt_prescriptions.Click += new System.EventHandler(this.bt_prescriptions_Click);
            // 
            // cb_medicament
            // 
            this.cb_medicament.FormattingEnabled = true;
            this.cb_medicament.Location = new System.Drawing.Point(44, 320);
            this.cb_medicament.Name = "cb_medicament";
            this.cb_medicament.Size = new System.Drawing.Size(121, 21);
            this.cb_medicament.TabIndex = 6;
            // 
            // FafficheMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_medicament);
            this.Controls.Add(this.bt_prescriptions);
            this.Controls.Add(this.bt_interactions);
            this.Controls.Add(this.bt_formulation);
            this.Controls.Add(this.dg_medicament);
            this.Controls.Add(this.bt_fermer);
            this.Controls.Add(this.lb_affichageV);
            this.Name = "FafficheMedicament";
            this.Text = "FafficheMedicament";
            this.Load += new System.EventHandler(this.FafficheMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_medicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_affichageV;
        private System.Windows.Forms.Button bt_fermer;
        private System.Windows.Forms.DataGridView dg_medicament;
        private System.Windows.Forms.Button bt_formulation;
        private System.Windows.Forms.Button bt_interactions;
        private System.Windows.Forms.Button bt_prescriptions;
        private System.Windows.Forms.ComboBox cb_medicament;
    }
}