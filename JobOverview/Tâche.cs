using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    public class Tâche
    {
        public Guid Id { get; set; }
        public string Libelle { get; set; }
        public bool Annexe { get; set; }
        public string CodeActivité { get; set; }
        public string Login { get; set; }
        public string Description { get; set; }
        public List<Travail> listTravaux { get; set; }
    }

    public class TâcheProd : Tâche
    {
        public int Num { get; set; }
        public DateTime DuréePrévue { get; set; }
        public DateTime DuréeRestEstimée { get; set; }
        public string CodeMod { get; set; }
        public string CodeLogMod { get; set; }
        public float NumVer { get; set; }
        public string CodeLogVer { get; set; }
    }

    public class Travail
    {
        public DateTime DateTravail { get; set; }
        public float Heures { get; set; }
        public float TxProd { get; set; }
    }
}
