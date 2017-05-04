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
    public partial class FormSaisieVersions : Form
    {
        // Cette propriété permet de récupérer la version saisie après la fermeture de la fenêtre.
        public Version versionSaisie { get; private set; }

        public FormSaisieVersions()
        {
            InitializeComponent();

            // Ce qui suit permet d'assigner les champs de date de versionSaisie seulement si l'utilisateur choisit une date.
            // Sinon les DateTimePickers assignent la date qu'ils affichent.
            dtpDateOuverture.ValueChanged += (object sender, EventArgs e) => versionSaisie.DateOuverture = dtpDateOuverture.Value;
            dtpDateSortiePrévue.ValueChanged += (object sender, EventArgs e) => versionSaisie.DateSortiePrévue = dtpDateSortiePrévue.Value;
            dtpDateSortieRéelle.ValueChanged += (object sender, EventArgs e) => versionSaisie.DateSortieRéelle = dtpDateSortieRéelle.Value;
        }

        // Fermeture de la fenêtre modale de saisie
        protected override void OnClosing(CancelEventArgs e)
        {
            // On crée une nouvelle version à partir des données saisies par l'utilisateur,
            // à condition que les champs soient bien renseignés (sauf la date de sortie réelle qui est facultative), et qu'il clique sur OK.
            if (this.DialogResult == DialogResult.OK && !string.IsNullOrEmpty(mtbNumVersion.Text) && !string.IsNullOrEmpty(mtbMillésime.Text))
            {
                versionSaisie = new Version();
                versionSaisie.Num = float.Parse(mtbNumVersion.Text);
                    versionSaisie.Millesime = short.Parse(mtbMillésime.Text);
            }
            base.OnClosing(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            // versionSaisie = new Version();

            base.OnLoad(e);
        }
    }
}
