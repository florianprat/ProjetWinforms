﻿namespace JobOverview
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
            this.btnChargementDonnées.Location = new System.Drawing.Point(15, 79);
            this.btnChargementDonnées.Name = "btnChargementDonnées";
            this.btnChargementDonnées.Size = new System.Drawing.Size(223, 24);
            this.btnChargementDonnées.TabIndex = 4;
            this.btnChargementDonnées.Text = "Chargement des données";
            this.btnChargementDonnées.UseVisualStyleBackColor = true;
            // 
            // FormImportProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 339);
            this.Controls.Add(this.btnChargementDonnées);
            this.Controls.Add(this.btnExplorateurFichier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCheminFichier);
            this.Name = "FormImportProd";
            this.Text = "Gestion - Importation de données";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCheminFichier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExplorateurFichier;
        private System.Windows.Forms.Button btnChargementDonnées;
    }
}