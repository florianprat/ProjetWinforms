namespace JobOverview
{
    partial class FormSaisieVersions
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
            this.mtbNumVersion = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbMillésime = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.dtpDateOuverture = new System.Windows.Forms.DateTimePicker();
            this.dtpDateSortiePrévue = new System.Windows.Forms.DateTimePicker();
            this.dtpDateSortieRéelle = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // mtbNumVersion
            // 
            this.mtbNumVersion.Location = new System.Drawing.Point(163, 22);
            this.mtbNumVersion.Mask = "99";
            this.mtbNumVersion.Name = "mtbNumVersion";
            this.mtbNumVersion.Size = new System.Drawing.Size(100, 20);
            this.mtbNumVersion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numéro de version";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(94, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Millésime";
            // 
            // mtbMillésime
            // 
            this.mtbMillésime.Location = new System.Drawing.Point(163, 64);
            this.mtbMillésime.Mask = "9999";
            this.mtbMillésime.Name = "mtbMillésime";
            this.mtbMillésime.Size = new System.Drawing.Size(100, 20);
            this.mtbMillésime.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(43, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date d\'ouverture";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de sortie prévue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(30, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date de sortie réelle\r\n(facultatif)";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(147, 249);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 28);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(239, 249);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(77, 28);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // dtpDateOuverture
            // 
            this.dtpDateOuverture.Location = new System.Drawing.Point(163, 103);
            this.dtpDateOuverture.Name = "dtpDateOuverture";
            this.dtpDateOuverture.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOuverture.TabIndex = 8;
            this.dtpDateOuverture.Value = new System.DateTime(2017, 5, 4, 16, 50, 2, 0);
            // 
            // dtpDateSortiePrévue
            // 
            this.dtpDateSortiePrévue.Location = new System.Drawing.Point(163, 142);
            this.dtpDateSortiePrévue.Name = "dtpDateSortiePrévue";
            this.dtpDateSortiePrévue.Size = new System.Drawing.Size(200, 20);
            this.dtpDateSortiePrévue.TabIndex = 8;
            // 
            // dtpDateSortieRéelle
            // 
            this.dtpDateSortieRéelle.Location = new System.Drawing.Point(163, 178);
            this.dtpDateSortieRéelle.Name = "dtpDateSortieRéelle";
            this.dtpDateSortieRéelle.Size = new System.Drawing.Size(200, 20);
            this.dtpDateSortieRéelle.TabIndex = 8;
            // 
            // FormSaisieVersions
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(406, 312);
            this.ControlBox = false;
            this.Controls.Add(this.dtpDateSortieRéelle);
            this.Controls.Add(this.dtpDateSortiePrévue);
            this.Controls.Add(this.dtpDateOuverture);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbMillésime);
            this.Controls.Add(this.mtbNumVersion);
            this.Name = "FormSaisieVersions";
            this.Text = "Saisie d\'une nouvelle version";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbNumVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbMillésime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.DateTimePicker dtpDateOuverture;
        private System.Windows.Forms.DateTimePicker dtpDateSortiePrévue;
        private System.Windows.Forms.DateTimePicker dtpDateSortieRéelle;
    }
}