using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    /***************************************************************************
     * DAL associée à la fenêtre de gestion des versions de logiciels
     ***************************************************************************/

    public class DALLogiciels
    {
        // Récupération de la liste des logiciels avec leurs modules associés
        // Dans la requête, on filtre pour obtenir les données associées à l'équipe "Dev Bio Humaine"
        // - filière : BIOH
        // - équipe : BIOH_DEV
        public static List<Logiciel> GetLogiciels()
        {
            // Liste à retourner
            var listLogiciels = new List<Logiciel>();

            // Récupération de la chaîne de connexion
            var connectString = Properties.Settings.Default.JobOverviewConnectionString;

            //Ecriture de la requête
            string req = @"select L.CodeLogiciel, L.Nom, M.CodeModule, M.Libelle, M.CodeModuleParent
                            from jo.Logiciel L
                            inner join jo.Module M on L.CodeLogiciel = M.CodeLogiciel
                            inner join jo.Filiere F on L.CodeFiliere = F.CodeFiliere
                            inner join jo.Equipe E on F.CodeFiliere = E.CodeFiliere
                            where F.CodeFiliere = 'BIOH' and E.CodeEquipe = 'BIOH_DEV'";

            // Création d'une connexion à partir de la chaîne de connexion stockée juste avant
            using (var cnx = new SqlConnection(connectString))
            {
                // Création d'une commande à partir de la requête et de la connexion
                var command = new SqlCommand(req, cnx);

                // Ouverture de la connexion (elle sera fermée en sortant de l'instruction using)
                cnx.Open();

                // Exécution de la commande
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // On parcourt le reader et on remplit la liste.
                    while (reader.Read())
                    {
                        GetLogicielsFromDataReader(listLogiciels, reader);
                    }
                }
            }

            // On retourne la liste obtenue
            return listLogiciels;
        }

        // Ajout d'un logiciel dans la liste des logiciels
        public static void GetLogicielsFromDataReader(List<Logiciel> listLogiciels, SqlDataReader reader)
        {
            // Variable stockant le code du logiciel courant
            // Cette variable permet de détecter un changement de logiciel.
            string codeLog = (string)reader["CodeLogiciel"];

            Logiciel log = null;

            // On crée un nouvel objet logiciel uniquement si on remplit les conditions.
            if (listLogiciels.Count == 0 || listLogiciels.Last().Code != codeLog)
            {
                log = new Logiciel();
                log.Code = (string)reader["CodeLogiciel"];
                log.Nom = (string)reader["Nom"];
                log.listModules = new List<Module>();   // Initialisation de la liste de modules du logiciel courant
                listLogiciels.Add(log);
            }
            else log = listLogiciels.Last();

            // On remplit la liste des modules associée au logiciel courant.
            Module mod = new Module();
            mod.Code = (string)reader["CodeModule"];
            mod.Libellé = (string)reader["Libelle"];
            if (reader["CodeModuleParent"] != DBNull.Value)  // Gestion de la valeur null
                mod.ModParent = (string)reader["CodeModuleParent"];
            log.listModules.Add(mod);
        }
    }
}
