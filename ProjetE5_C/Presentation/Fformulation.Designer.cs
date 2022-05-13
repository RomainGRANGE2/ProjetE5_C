namespace ProjetE5_C.Presentation
{
    partial class Fformulation
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
            this.lb_formulation = new System.Windows.Forms.Label();
            this.lb_MedocS = new System.Windows.Forms.Label();
            this.dg_formulation = new System.Windows.Forms.DataGridView();
            this.bt_ajouterF = new System.Windows.Forms.Button();
            this.bt_supprimerF = new System.Windows.Forms.Button();
            this.cb_Presentation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_formulation)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_formulation
            // 
            this.lb_formulation.AutoSize = true;
            this.lb_formulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_formulation.Location = new System.Drawing.Point(12, 9);
            this.lb_formulation.Name = "lb_formulation";
            this.lb_formulation.Size = new System.Drawing.Size(469, 31);
            this.lb_formulation.TabIndex = 0;
            this.lb_formulation.Text = "Liste des formulations du médicament";
            // 
            // lb_MedocS
            // 
            this.lb_MedocS.AutoSize = true;
            this.lb_MedocS.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MedocS.Location = new System.Drawing.Point(487, 9);
            this.lb_MedocS.Name = "lb_MedocS";
            this.lb_MedocS.Size = new System.Drawing.Size(124, 42);
            this.lb_MedocS.TabIndex = 1;
            this.lb_MedocS.Text = "label1";
            // 
            // dg_formulation
            // 
            this.dg_formulation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_formulation.Location = new System.Drawing.Point(18, 59);
            this.dg_formulation.Name = "dg_formulation";
            this.dg_formulation.Size = new System.Drawing.Size(770, 258);
            this.dg_formulation.TabIndex = 2;
            // 
            // bt_ajouterF
            // 
            this.bt_ajouterF.Location = new System.Drawing.Point(713, 346);
            this.bt_ajouterF.Name = "bt_ajouterF";
            this.bt_ajouterF.Size = new System.Drawing.Size(75, 23);
            this.bt_ajouterF.TabIndex = 3;
            this.bt_ajouterF.Text = "Ajouter";
            this.bt_ajouterF.UseVisualStyleBackColor = true;
            // 
            // bt_supprimerF
            // 
            this.bt_supprimerF.Location = new System.Drawing.Point(156, 346);
            this.bt_supprimerF.Name = "bt_supprimerF";
            this.bt_supprimerF.Size = new System.Drawing.Size(75, 23);
            this.bt_supprimerF.TabIndex = 4;
            this.bt_supprimerF.Text = "Supprimer";
            this.bt_supprimerF.UseVisualStyleBackColor = true;
            this.bt_supprimerF.Click += new System.EventHandler(this.bt_supprimerF_Click);
            // 
            // cb_Presentation
            // 
            this.cb_Presentation.FormattingEnabled = true;
            this.cb_Presentation.Location = new System.Drawing.Point(18, 346);
            this.cb_Presentation.Name = "cb_Presentation";
            this.cb_Presentation.Size = new System.Drawing.Size(121, 21);
            this.cb_Presentation.TabIndex = 5;
            this.cb_Presentation.SelectedIndexChanged += new System.EventHandler(this.cb_Formulations_SelectedIndexChanged);
            // 
            // Fformulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_Presentation);
            this.Controls.Add(this.bt_supprimerF);
            this.Controls.Add(this.bt_ajouterF);
            this.Controls.Add(this.dg_formulation);
            this.Controls.Add(this.lb_MedocS);
            this.Controls.Add(this.lb_formulation);
            this.Name = "Fformulation";
            this.Text = "Fformulation";
            this.Load += new System.EventHandler(this.Fformulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_formulation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_formulation;
        private System.Windows.Forms.Label lb_MedocS;
        private System.Windows.Forms.DataGridView dg_formulation;
        private System.Windows.Forms.Button bt_ajouterF;
        private System.Windows.Forms.Button bt_supprimerF;
        private System.Windows.Forms.ComboBox cb_Presentation;
    }
}