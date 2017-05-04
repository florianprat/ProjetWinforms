﻿using System;
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

            // Les instructions suivantes permettent d'assigner les champs de date de versionSaisie seulement
            // si l'utilisateur choisit une date.
            // Sinon la date d'aujourd'hui est assignée.
            dtpDateOuverture.ValueChanged += (object sender, EventArgs e) => versionSaisie.DateOuverture = dtpDateOuverture.Value;
            dtpDateSortiePrévue.ValueChanged += (object sender, EventArgs e) => versionSaisie.DateSortiePrévue = dtpDateSortiePrévue.Value;
            dtpDateSortieRéelle.ValueChanged += (object sender, EventArgs e) => versionSaisie.DateSortieRéelle = dtpDateSortieRéelle.Value;
        }

        // Fermeture de la fenêtre modale de saisie
        protected override void OnClosing(CancelEventArgs e)
        {
            // On crée une nouvelle version à partir des données saisies par l'utilisateur,
            // à condition que les champs Numéro et Millésime soient renseignés, et qu'il clique sur OK.
            if (this.DialogResult == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(mtbNumVersion.Text))
                    versionSaisie.Num = float.Parse(mtbNumVersion.Text);
                if (!string.IsNullOrEmpty(mtbMillésime.Text))
                    versionSaisie.Millesime = short.Parse(mtbMillésime.Text);
            }
            base.OnClosing(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            versionSaisie = new Version();

            base.OnLoad(e);
        }
    }
}
