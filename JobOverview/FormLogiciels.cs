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
    public partial class FormLogiciels : Form
    {
        private List<Logiciel> _listLogAvecModules;
        private List<Logiciel> _listLogAvecVersions;
        public FormLogiciels()
        {
            InitializeComponent();
            // Branchements des contrôles
            cmbLogiciels.SelectedIndexChanged += CmbLogiciels_SelectedIndexChanged;  // Sélection dans la liste déroulante
            btnPlus.Click += BtnPlus_Click;                                          // Clic sur le bouton "Plus"
            btnMoins.Click += BtnMoins_Click;                                        // Clic sur le bouton "Moins"
        }

        // Instructions exécutées à l'ouverture de la fenêtre
        protected override void OnLoad(EventArgs e)
        {
            _listLogAvecModules = DALLogiciels.GetLogicielsAvecModules();
            _listLogAvecVersions = DALLogiciels.GetLogicielsAvecVersions();

            // Liste déroulante de sélection d'un logiciel (noms des logiciels par ordre alphabétique)
            // cmbLogiciels.DataSource = _listLogAvecModules.OrderBy(l => l.Nom).Select(l => l.Nom).ToList();
            cmbLogiciels.DataSource = _listLogAvecModules.OrderBy(l => l.Nom).ToList();
            cmbLogiciels.ValueMember = "Code";
            cmbLogiciels.DisplayMember = "Nom";
            cmbLogiciels.SelectedValue = string.Empty;   // Permet de ne rien afficher dans la liste déroulante.

            // Permet de vider les DataGridView sinon les infos concernant le premier item de la liste déoulante logiciel s'affiche
            dgvModules.DataSource = null;
            dgvVersions.DataSource = null;

            // La zone liée à l'ajout et suppression d'une version est invisible tant qu'un logiciel n'est pas sélectionné.
            lblAjoutSupprVersion.Visible = false;
            btnPlus.Visible = false;
            btnMoins.Visible = false;

            base.OnLoad(e);
        }

        // Sélection dans la liste déroulante
        // Les modules sont affichés par ordre alphabétique selon leurs codes.
        // Les versions sont affichées par ordre numérique, avec le numéro de la dernière release.
        private void CmbLogiciels_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Affichage de la zone d'ajout et suppression de version
            lblAjoutSupprVersion.Visible = true;
            btnPlus.Visible = true;
            btnMoins.Visible = true;

            // Affichage des modules
            dgvModules.DataSource = _listLogAvecModules.Select(l => l.listModules).FirstOrDefault().OrderBy(m => m.Code).ToList();

            // Affichage des versions (les colonnes inutiles sont masquées).
            dgvVersions.DataSource = _listLogAvecVersions.Select(l => l.listVersions).FirstOrDefault().OrderBy(v => v.Num).ToList();
            dgvVersions.Columns["CodeLog"].Visible = false;
        }

        // Clic sur le bouton "Plus"
        // Permet l'ouverture de la fenêtre modale FormSaisieVersions et d'ajouter une version à la base de données.
        private void BtnPlus_Click(object sender, EventArgs e)
        {
            // Création et ouverture d'une fenêtre modale de saisie de versions
            // La fenêtre est détruite à la sortie de l'instruction using.
            using (var form = new FormSaisieVersions())
            {
                // On ouvre la fenêtre de saisie et on récupère le résultat OK ou annuler de la fenêtre.
                DialogResult dr = form.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    if (form.versionSaisie != null)
                    {
                        form.versionSaisie.CodeLog = (string)cmbLogiciels.SelectedValue;
                        DALLogiciels.AjouterVersion(form.versionSaisie);
                    }

                    // Rafraîchissement de la liste affichée des versions
                    // Effectuer ce rafraîchissement via une BindingList serait peut-être plus adapté.
                    _listLogAvecVersions = DALLogiciels.GetLogicielsAvecVersions();
                    dgvVersions.DataSource = _listLogAvecVersions.Select(l => l.listVersions).FirstOrDefault().OrderBy(v => v.Num).ToList();
                }
            }
        }

        // Clic sur le bouton "Moins"
        // Permet de supprimer une version de la base de données.
        private void BtnMoins_Click(object sender, EventArgs e)
        {
            // On récupère le numéro de la version à supprimer et le code du logiciel associé
            float numVersionASupprimer = ((Version)dgvVersions.CurrentRow.DataBoundItem).Num;
            string codeLog = (string)cmbLogiciels.SelectedValue;

            // La version du logiciel est supprimée si elle n'est associée à aucune tâche de production.
            int nbTâches = DALLogiciels.CompterTâchesProd(numVersionASupprimer, codeLog);
            if (nbTâches == 0)
                DALLogiciels.SupprimerVersion(numVersionASupprimer, codeLog);
            else
                MessageBox.Show("Suppression impossible : la version sélectionnée est associée à des tâches de production.");

            // Rafraîchissement de la liste affichée des versions
            // Effectuer ce rafraîchissement via une BindingList serait peut-être plus adapté.
            _listLogAvecVersions = DALLogiciels.GetLogicielsAvecVersions();
            dgvVersions.DataSource = _listLogAvecVersions.Select(l => l.listVersions).FirstOrDefault().OrderBy(v => v.Num).ToList();
        }
    }
}
