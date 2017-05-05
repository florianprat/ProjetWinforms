namespace JobOverview
{
    partial class FormImportProd
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
            this.tbCheminFichier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExplorateurFichier = new System.Windows.Forms.Button();
            this.btnChargementDonnées = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCheminFichier
            // 
            this.tbCheminFichier.Location = new System.Drawing.Point(15, 41);
            this.tbCheminFichier.Name = "tbCheminFichier";
            this.tbCheminFichier.Size = new System.Drawing.Size(481, 20);
            this.tbCheminFichier.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sélection du fichier de données à importer";
            // 
            // btnExplorateurFichier
            // 
            this.btnExplorateurFichier.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExplorateurFichier.Location = new System.Drawing.Point(514, 39);
            this.btnExplorateurFichier.Name = "btnExplorateurFichier";
            this.btnExplorateurFichier.Size = new System.Drawing.Size(57, 23);
            this.btnExplorateurFichier.TabIndex = 3;
            this.btnExplorateurFichier.Text = "...";
            this.btnExplorateurFichier.UseVisualStyleBackColor = true;
            // 
            // btnChargementDonnées
            // 
            this.btnChargementDonnées.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChargementDonnées.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChargementDonnées.Location = new System.Drawing.Point(15, 85);
            this.btnChargementDonnées.Name = "btnChargementDonnées";
            this.btnChargementDonnées.Size = new System.Drawing.Size(223, 24);
            this.btnChargementDonnées.TabIndex = 4;
            this.btnChargementDonnées.Text = "Chargement des données";
            this.btnChargementDonnées.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 159);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Enregistrement des données";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Visualisation des données importées";
            // 
            // FormImportProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnChargementDonnées);
            this.Controls.Add(this.btnExplorateurFichier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCheminFichier);
            this.Name = "FormImportProd";
            this.Text = "Gestion - Importation de données";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCheminFichier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExplorateurFichier;
        private System.Windows.Forms.Button btnChargementDonnées;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}