using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JobOverview
{
    public class Tâche
    {
        public Guid Id { get; set; }
        [XmlAttribute("Libelle")]
        public string Libelle { get; set; }
        public bool Annexe { get; set; }
        [XmlAttribute("Activite")]
        public string CodeActivité { get; set; }
        [XmlAttribute("Personne")]
        public string Login { get; set; }
        [XmlIgnore]
        public string Description { get; set; }
        public List<Travail> listTravaux { get; set; }
    }

    public class TâcheProd : Tâche
    {
        public int Num { get; set; }
        [XmlAttribute("DureePrev")]
        public DateTime DuréePrévue { get; set; }
        [XmlAttribute("DureeRest")]
        public DateTime DuréeRestEstimée { get; set; }
        [XmlAttribute("Module")]
        public string CodeMod { get; set; }
        [XmlAttribute("Logiciel")]
        public string CodeLogMod { get; set; }
        public float NumVer { get; set; }
        [XmlAttribute("Version")]
        public string CodeLogVer { get; set; }
    }

    public class Travail
    {
        [XmlAttribute("Date")]
        public DateTime DateTravail { get; set; }
        [XmlAttribute("Heures")]
        public float Heures { get; set; }
        [XmlAttribute("TauxProduct")]
        public float TxProd { get; set; }
    }
}
