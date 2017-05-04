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
        public FormLogiciels()
        {
            InitializeComponent();
            // Branchements des contrôles

            // Après sélection dans la liste déroulante : les modules sont affichés par ordre alphabétique selon leurs codes.
            cmbLogiciels.SelectedIndexChanged += (object sender, EventArgs e)
                    => dgvModules.DataSource = _listLogAvecModules.Select(l => l.listModules).FirstOrDefault().OrderBy(m => m.Code).ToList();
        }

        // Instructions exécutées à l'ouverture de la fenêtre
        protected override void OnLoad(EventArgs e)
        {
            _listLogAvecModules = DALLogiciels.GetLogiciels();
            // Liste déroulante de sélection d'un logiciel (noms des logiciels par ordre alphabétique)
            cmbLogiciels.DataSource = _listLogAvecModules.OrderBy(l => l.Nom).Select(l => l.Nom).ToList();

            base.OnLoad(e);
        }
    }
}
