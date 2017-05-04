using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    public class Module
    {
        [DisplayName("Code Module")]
        public string Code { get; set; }
        public string Libellé { get; set; }
        [DisplayName("Module parent")]
        public string ModParent { get; set; }
    }
}
