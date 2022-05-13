namespace ProjetE5_C.Presentation
{
    partial class Finterraction
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
            this.lb_interraction = new System.Windows.Forms.Label();
            this.lb_MedocI = new System.Windows.Forms.Label();
            this.dg_interraction = new System.Windows.Forms.DataGridView();
            this.cb_Interraction = new System.Windows.Forms.ComboBox();
            this.bt_supprimerI = new System.Windows.Forms.Button();
            this.bt_ajouterI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_interraction)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_interraction
            // 
            this.lb_interraction.AutoSize = true;
            this.lb_interraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_interraction.Location = new System.Drawing.Point(12, 9);
            this.lb_interraction.Name = "lb_interraction";
            this.lb_interraction.Size = new System.Drawing.Size(470, 31);
            this.lb_interraction.TabIndex = 1;
            this.lb_interraction.Text = "Liste des interractions du médicament";
            // 
            // lb_MedocI
            // 
            this.lb_MedocI.AutoSize = true;
            this.lb_MedocI.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MedocI.Location = new System.Drawing.Point(488, 9);
            this.lb_MedocI.Name = "lb_MedocI";
            this.lb_MedocI.Size = new System.Drawing.Size(124, 42);
            this.lb_MedocI.TabIndex = 2;
            this.lb_MedocI.Text = "label1";
            // 
            // dg_interraction
            // 
            this.dg_interraction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_interraction.Location = new System.Drawing.Point(18, 64);
            this.dg_interraction.Name = "dg_interraction";
            this.dg_interraction.Size = new System.Drawing.Size(770, 258);
            this.dg_interraction.TabIndex = 3;
            // 
            // cb_Interraction
            // 
            this.cb_Interraction.FormattingEnabled = true;
            this.cb_Interraction.Location = new System.Drawing.Point(18, 343);
            this.cb_Interraction.Name = "cb_Interraction";
            this.cb_Interraction.Size = new System.Drawing.Size(121, 21);
            this.cb_Interraction.TabIndex = 6;
            // 
            // bt_supprimerI
            // 
            this.bt_supprimerI.Location = new System.Drawing.Point(174, 343);
            this.bt_supprimerI.Name = "bt_supprimerI";
            this.bt_supprimerI.Size = new System.Drawing.Size(75, 23);
            this.bt_supprimerI.TabIndex = 7;
            this.bt_supprimerI.Text = "Supprimer";
            this.bt_supprimerI.UseVisualStyleBackColor = true;
            // 
            // bt_ajouterI
            // 
            this.bt_ajouterI.Location = new System.Drawing.Point(713, 343);
            this.bt_ajouterI.Name = "bt_ajouterI";
            this.bt_ajouterI.Size = new System.Drawing.Size(75, 23);
            this.bt_ajouterI.TabIndex = 8;
            this.bt_ajouterI.Text = "Ajouter";
            this.bt_ajouterI.UseVisualStyleBackColor = true;
            // 
            // Finterraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_ajouterI);
            this.Controls.Add(this.bt_supprimerI);
            this.Controls.Add(this.cb_Interraction);
            this.Controls.Add(this.dg_interraction);
            this.Controls.Add(this.lb_MedocI);
            this.Controls.Add(this.lb_interraction);
            this.Name = "Finterraction";
            this.Text = "Finterraction";
            this.Load += new System.EventHandler(this.Finterraction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_interraction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_interraction;
        private System.Windows.Forms.Label lb_MedocI;
        private System.Windows.Forms.DataGridView dg_interraction;
        private System.Windows.Forms.ComboBox cb_Interraction;
        private System.Windows.Forms.Button bt_supprimerI;
        private System.Windows.Forms.Button bt_ajouterI;
    }
}