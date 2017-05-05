using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JobOverview
{
    public class DALTâcheProd
    {
        // Désérialisation du fichier XML sélectionné par l'utilisateur
        public static List<Tâche> ImporterFichierXml (string cheminFichier)
        {
            List<Tâche> listTravaux = null;
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Tâche>), new XmlRootAttribute("TachesProduction"));

            using (var sr = new StreamReader(cheminFichier))
            {
                listTravaux = (List<Tâche>)deserializer.Deserialize(sr);
            }
            return listTravaux;
        }
    }

    }
}
