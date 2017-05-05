using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobOverview
{
    public partial class FormImportProd : Form
    {
        private string _nomFichierSelect;
        public FormImportProd()
        {
            InitializeComponent();

            // Branchements des contrôles
            btnExplorateurFichier.Click += BtnExplorateurFichier_Click;     // Sélection du fichier de données à importer
            btnChargementDonnées.Click += BtnChargementDonnées_Click;       // Chargement des données (lancement de la désérialisation)
        }

        // Sélection du fichier de données à importer
        // On récupère le chemin du fichier XML et on lance sa désérialisation.
        private void BtnExplorateurFichier_Click(object sender, EventArgs e)
        {
            // Lancement d'un fenêtre d'exploration
            // Après sélection du fichier, on récupère et on affiche le chemin du fichier dans la TextBox associée.
            // L'instruction using est utilisée pour fermer le fichier lors de la sortie du using.
            string cheminFichier;

            using (var fd = new OpenFileDialog())
            {
                fd.ShowDialog();
                _nomFichierSelect = fd.SafeFileName;    // On récupère le nom du fichier (sous la forme nomfichier.extension)
                cheminFichier = fd.FileName;
            }
            tbCheminFichier.Text = cheminFichier;
            
        }

        // Lancement du chargement des données, c'est-à-dire de la désérialisation du fichier sélectionné.
        private void BtnChargementDonnées_Click(object sender, EventArgs e)
        {
            // On vérifie que le fichier est au format .xml. Si oui, la désérialisation est lancée.
            // Dans le cas contraire, l'utilisateur est averti.
            if (!_nomFichierSelect.ToLower().Contains(".xml"))
                MessageBox.Show("Chargement impossible : le fichier sélectionné n'est pas au format XML.", "Message d'erreur");
            //else ---> TODO : décoration des classes impliquées
            
        }
    }
}
