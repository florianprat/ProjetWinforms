using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    public class Version
    {
        [DisplayName("Numéro")]
        public float Num { get; set; }
        public string CodeLog { get; set; }
        [DisplayName("Millésime")]
        public short Millesime { get; set; }
        [DisplayName("Date d'ouverture")]
        public DateTime DateOuverture { get; set; }
        [DisplayName("Date de sortie prévue")]
        public DateTime DateSortiePrévue { get; set; }
        [DisplayName("Date de sortie réelle")]
        public DateTime? DateSortieRéelle { get; set; }
        [DisplayName("Numéro dernière release")]
        public short DernièreRelease { get; set; }
    }
}
