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
    // Cette propriété permet de récupérer la version saisie après la fermeture de la fenêtre.
    public partial class FormSaisieVersions : Form
    {
        public Version versionSaisie { get; private set; }

        public FormSaisieVersions()
        {
            InitializeComponent();
        }
    }
}
