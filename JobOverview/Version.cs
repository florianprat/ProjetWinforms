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
        public short Millesime { get; set; }
        public DateTime DateOuverture { get; set; }
        public DateTime DateSortiePrévue { get; set; }
        public DateTime DateSortieRéelle { get; set; }
        [DisplayName("Numéro dernière release")]
        public short DernièreRelease { get; set; }
    }
}
