namespace JobOverview
{
	partial class MDIForm
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.menuGeneral = new System.Windows.Forms.MenuStrip();
            this.mnuLogiciels = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.tâchesDeProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tâchesAnnexesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisiesDeTempsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.echangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGeneral
            // 
            this.menuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogiciels,
            this.menu2,
            this.echangesToolStripMenuItem,
            this.menuWindows});
            this.menuGeneral.Location = new System.Drawing.Point(0, 0);
            this.menuGeneral.Name = "menuGeneral";
            this.menuGeneral.Size = new System.Drawing.Size(787, 24);
            this.menuGeneral.TabIndex = 0;
            this.menuGeneral.Text = "menuStrip1";
            // 
            // mnuLogiciels
            // 
            this.mnuLogiciels.Name = "mnuLogiciels";
            this.mnuLogiciels.Size = new System.Drawing.Size(65, 20);
            this.mnuLogiciels.Text = "Logiciels";
            // 
            // menu2
            // 
            this.menu2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tâchesDeProductionToolStripMenuItem,
            this.tâchesAnnexesToolStripMenuItem,
            this.saisiesDeTempsToolStripMenuItem});
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(55, 20);
            this.menu2.Text = "Tâches";
            // 
            // menuWindows
            // 
            this.menuWindows.Name = "menuWindows";
            this.menuWindows.Size = new System.Drawing.Size(63, 20);
            this.menuWindows.Text = "Fenêtres";
            // 
            // tâchesDeProductionToolStripMenuItem
            // 
            this.tâchesDeProductionToolStripMenuItem.Name = "tâchesDeProductionToolStripMenuItem";
            this.tâchesDeProductionToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.tâchesDeProductionToolStripMenuItem.Text = "Tâches de production";
            // 
            // tâchesAnnexesToolStripMenuItem
            // 
            this.tâchesAnnexesToolStripMenuItem.Name = "tâchesAnnexesToolStripMenuItem";
            this.tâchesAnnexesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.tâchesAnnexesToolStripMenuItem.Text = "Tâches annexes";
            // 
            // saisiesDeTempsToolStripMenuItem
            // 
            this.saisiesDeTempsToolStripMenuItem.Name = "saisiesDeTempsToolStripMenuItem";
            this.saisiesDeTempsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saisiesDeTempsToolStripMenuItem.Text = "Saisies de temps";
            // 
            // echangesToolStripMenuItem
            // 
            this.echangesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importationToolStripMenuItem,
            this.exportationToolStripMenuItem});
            this.echangesToolStripMenuItem.Name = "echangesToolStripMenuItem";
            this.echangesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.echangesToolStripMenuItem.Text = "Echanges";
            // 
            // importationToolStripMenuItem
            // 
            this.importationToolStripMenuItem.Name = "importationToolStripMenuItem";
            this.importationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importationToolStripMenuItem.Text = "Importation";
            // 
            // exportationToolStripMenuItem
            // 
            this.exportationToolStripMenuItem.Name = "exportationToolStripMenuItem";
            this.exportationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportationToolStripMenuItem.Text = "Exportation";
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 514);
            this.Controls.Add(this.menuGeneral);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuGeneral;
            this.Name = "MDIForm";
            this.Text = "Gestion Equipe - Dev Bio Humaine";
            this.menuGeneral.ResumeLayout(false);
            this.menuGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuGeneral;
		private System.Windows.Forms.ToolStripMenuItem mnuLogiciels;
		private System.Windows.Forms.ToolStripMenuItem menuWindows;
		private System.Windows.Forms.ToolStripMenuItem menu2;
        private System.Windows.Forms.ToolStripMenuItem tâchesDeProductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tâchesAnnexesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisiesDeTempsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem echangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportationToolStripMenuItem;
    }
}

