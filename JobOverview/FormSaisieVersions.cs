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
        private bool _vérifDateOuverture = false;
        private bool _vérifDateSortiePrévue = false;
        private bool _vérifDateSortieRéelle = false;
        private DateTime _dateOuverture;
        private DateTime _dateSortiePrévue;
        private DateTime _dateSortieRéelle;

        public FormSaisieVersions()
        {
            InitializeComponent();

            // La saisie ou non des champs de date est contrôlée à l'aide de booléens.
            dtpDateOuverture.ValueChanged += (object sender, EventArgs e) =>
            {
                _vérifDateOuverture = true;
                _dateOuverture = dtpDateOuverture.Value;
                
                // La date minimale de sortie prévue autorisée est indexée sur la date d'ouverture (la sortie ne peut pas précéder la sortie).
                // Attention : quand on assigne une date min à la DateTimePicker de date de sortie prévue, _vérifDateSortiePrévue passe true.
                if (_vérifDateSortiePrévue)
                    dtpDateSortiePrévue.MinDate = _dateOuverture;
                else
                {
                    dtpDateSortiePrévue.MinDate = _dateOuverture;
                    _vérifDateSortiePrévue = false;
                }
            };
            dtpDateSortiePrévue.ValueChanged += (object sender, EventArgs e) =>
            {
                _vérifDateSortiePrévue = true;
                _dateSortiePrévue = dtpDateSortiePrévue.Value;
            };
            dtpDateSortieRéelle.ValueChanged += (object sender, EventArgs e) =>
            {
                _vérifDateSortieRéelle = true;
                _dateSortieRéelle = dtpDateSortieRéelle.Value;
            };
        }

        // Fermeture de la fenêtre modale de saisie
        protected override void OnClosing(CancelEventArgs e)
        {
            // Booléen indiquant le statut valide ou non de la saisie
            bool validitéSaisie = false;

            // On crée une nouvelle version à partir des données saisies par l'utilisateur,
            // à condition que les champs soient bien renseignés (sauf la date de sortie réelle qui est facultative), et qu'il clique sur OK.
            if (this.DialogResult == DialogResult.OK && !string.IsNullOrEmpty(mtbNumVersion.Text) && !string.IsNullOrEmpty(mtbMillésime.Text)
                    && _vérifDateOuverture && _vérifDateSortiePrévue)
            {
                // On gère ici le fait que le numéro de version est unique.
                // S'il y a conflit, on avertit l'utilisateur et on revient dans la fenêtre de saisie.
                var list = DALLogiciels.GetLogicielsAvecVersions().Select(l => l.listVersions).FirstOrDefault();
                if (list.Exists(v => v.Num == short.Parse(mtbNumVersion.Text)))
                {
                    MessageBox.Show("Attention : le numéro de version doit être unique.");
                    e.Cancel = true;
                }

                versionSaisie = new Version();
                versionSaisie.Num = float.Parse(mtbNumVersion.Text);
                versionSaisie.Millesime = short.Parse(mtbMillésime.Text);
                versionSaisie.DateOuverture = _dateOuverture;
                versionSaisie.DateSortiePrévue = _dateSortiePrévue;
                if (_vérifDateSortieRéelle)
                    versionSaisie.DateSortieRéelle = _dateSortieRéelle;
                else versionSaisie.DateSortieRéelle = null;
                validitéSaisie = true;
            }

            // Si on appuie sur OK mais que la saisie n'est pas complète, on ne sort pas de la fenêtre et l'utilisateur est averti.
            if (this.DialogResult == DialogResult.OK && !validitéSaisie)
            {
                e.Cancel = true;
                MessageBox.Show("La saisie est incomplète. Les champs numéro, millésime, date d'ouverture et date de sortie prévue sont obligatoires.");
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
