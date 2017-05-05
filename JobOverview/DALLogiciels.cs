using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public static List<Logiciel> GetLogicielsAvecModules()
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
                        GetLogicielsAvecModulesFromDataReader(listLogiciels, reader);
                    }
                }
            }
            // On retourne la liste obtenue
            return listLogiciels;
        }

        // Ajout d'un logiciel dans la liste des logiciels
        // Méthode associée avec la récupération de la liste des logiciels avec leurs modules
        private static void GetLogicielsAvecModulesFromDataReader(List<Logiciel> listLogiciels, SqlDataReader reader)
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

        // Récupération de la liste des logiciels avec les versions
        // Pour chaque version, on ne récupère que la dernière release.
        // On filtre pour tenir compte de la filière et de l'équipe.
        public static List<Logiciel> GetLogicielsAvecVersions()
        {
            // Liste à retourner
            var listLogiciels = new List<Logiciel>();

            // Récupération de la chaîne de connexion
            var connectString = Properties.Settings.Default.JobOverviewConnectionString;

            //Ecriture de la requête
            string req = @"select L.CodeLogiciel, L.Nom, V.NumeroVersion, V.Millesime, max(R.NumeroRelease) [Dernière release],
		                            V.DateOuverture, V.DateSortiePrevue, V.DateSortieReelle
                            from jo.Logiciel L
                            inner join jo.Version V on L.CodeLogiciel = V.CodeLogiciel
                            left outer join jo.Release R on R.NumeroVersion = V.NumeroVersion
                            inner join jo.Filiere F on L.CodeFiliere = F.CodeFiliere
                            inner join jo.Equipe E on F.CodeFiliere = E.CodeFiliere
                            where F.CodeFiliere = 'BIOH' and E.CodeEquipe = 'BIOH_DEV'
                            group by L.CodeLogiciel, L.Nom, V.NumeroVersion, V.Millesime, V.DateOuverture,
                                    V.DateSortiePrevue, V.DateSortieReelle";

            // Création d'une connexion à partir de la chaîne de connexion stockée juste avant
            using (var cnx = new SqlConnection(connectString))
            {
                // Création d'une commande à partir de la requête et de la connexion
                var command = new SqlCommand(req, cnx);

                // Ouverture de la connexion (elle sera fermée en sortant de l'instruction using)
                cnx.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // On parcourt le reader et on remplit la liste.
                    while (reader.Read())
                    {
                        GetLogicielsAvecVersionsFromDataReader(listLogiciels, reader);
                    }
                }
            }
            return listLogiciels;
        }

        // Ajout d'un logiciel dans la liste des logiciels
        // Méthode associée avec la récupération de la liste des logiciels avec leurs versions
        private static void GetLogicielsAvecVersionsFromDataReader(List<Logiciel> listLogiciels, SqlDataReader reader)
        {
            string codeLog = (string)reader["CodeLogiciel"];

            Logiciel log = null;

            // On crée un nouvel objet logiciel uniquement si on remplit les conditions.
            if (listLogiciels.Count == 0 || listLogiciels.Last().Code != codeLog)
            {
                log = new Logiciel();
                log.Code = (string)reader["CodeLogiciel"];
                log.Nom = (string)reader["Nom"];
                log.listVersions = new List<Version>();   // Initialisation de la liste de versions du logiciel courant
                listLogiciels.Add(log);
            }
            else log = listLogiciels.Last();

            // On remplit la liste des versions associée au logiciel courant.
            Version ver = new Version();
            ver.Num = (float)reader["NumeroVersion"];
            ver.Millesime = (short)reader["Millesime"];
            if (reader["Dernière release"] != DBNull.Value)         // Permet de gérer le cas où il n'y a pas de release (cela arrive quand on crée une version).
                ver.DernièreRelease = (short)reader["Dernière release"];
            ver.DateOuverture = (DateTime)reader["DateOuverture"];
            ver.DateSortiePrévue = (DateTime)reader["DateSortiePrevue"];
            if (reader["DateSortieReelle"] != DBNull.Value)
                ver.DateSortieRéelle = (DateTime)reader["DateSortieReelle"];

            log.listVersions.Add(ver);
        }

        // Ajout d'une version dans la base de données
        public static void AjouterVersion(Version ver)
        {
            // Récupération de la chaîne de connexion
            var connectString = Properties.Settings.Default.JobOverviewConnectionString;

            //Ecriture de la requête
            string req = @"insert jo.Version (NumeroVersion, CodeLogiciel, Millesime, DateOuverture, DateSortiePrevue, DateSortieReelle)
                            values (@num, @codeLog, @mille, @dateOuverture, @dateSortiePrévue, @dateSortieRéelle)";

            // Paramètres de la requête
            var paramNum = new SqlParameter("@num", DbType.Double);
            paramNum.Value = ver.Num;
            var paramCodeLog = new SqlParameter("@codeLog", DbType.String);
            paramCodeLog.Value = ver.CodeLog;
            var paramMille = new SqlParameter("@mille", DbType.Int16);
            paramMille.Value = ver.Millesime;
            var paramDateOuverture = new SqlParameter("@dateOuverture", DbType.DateTime);
            paramDateOuverture.Value = ver.DateOuverture;
            var paramDateSortiePrévue = new SqlParameter("@dateSortiePrévue", DbType.DateTime);
            paramDateSortiePrévue.Value = ver.DateSortiePrévue;
            var paramDateSortieRéelle = new SqlParameter("@dateSortieRéelle", DbType.DateTime);
            // Il faut gérer ici le fait que la date de sortie réelle est facultative.
            if (ver.DateSortieRéelle != null)
                paramDateSortieRéelle.Value = ver.DateSortieRéelle;
            else paramDateSortieRéelle.Value = DBNull.Value;

            // Création d'une connexion à partir de la chaîne de connexion stockée juste avant
            using (var cnx = new SqlConnection(connectString))
            {
                // Création d'une commande à partir de la requête et de la connexion
                // et entrée des paramètres.
                var command = new SqlCommand(req, cnx);
                command.Parameters.Add(paramNum);
                command.Parameters.Add(paramCodeLog);
                command.Parameters.Add(paramMille);
                command.Parameters.Add(paramDateOuverture);
                command.Parameters.Add(paramDateSortiePrévue);
                command.Parameters.Add(paramDateSortieRéelle);

                // Ouverture de la connection et exécution de la commande
                cnx.Open();
                command.ExecuteNonQuery();
            }
        }

        // Suppression d'une version dans la base de données
        public static void SupprimerVersion(float numVersion, string codeLog)
        {
            // Récupération de la chaîne de connexion
            var connectString = Properties.Settings.Default.JobOverviewConnectionString;

            //Ecriture de la requête
            string req = @"delete jo.Version where NumeroVersion = @Num and CodeLogiciel = @CodeLog";

            // Paramètres de la requête
            var paramNum = new SqlParameter("@Num", DbType.Double);
            paramNum.Value = numVersion;
            var paramCodeLog = new SqlParameter("@CodeLog", DbType.String);
            paramCodeLog.Value = codeLog;

            using (var connect = new SqlConnection(connectString))
            {
                // Ouverture de la connexion et exécution de la commande
                connect.Open();

                // Utilisation d'une transaction
                SqlTransaction tran = connect.BeginTransaction();

                // Création de la commande avec paramètres
                var command = new SqlCommand(req, connect, tran);
                command.Parameters.Add(paramNum);
                command.Parameters.Add(paramCodeLog);

                try
                {
                    command.ExecuteNonQuery();
                    // Validation de la transaction si tout se passe bien.
                    tran.Commit();
                }
                catch (SqlException ex)
                {
                    // Annulation de la transaction
                    tran.Rollback();
                    // On lève une erreur avec un message explicite
                    throw new Exception("Suppression impossible : la version sélectionnée est associée à une ou des releases.", ex);
                }
            }
        }

        // Récupération du nombre de tâches de production associées à une version de logiciel données.
        // La requête exécutée dans la méthode permet de vérifier si la version est associée ou non à des tâches de production.
        // Si à la version ne correspond aucune tâche de production, la version pourra être supprimée.
        public static int CompterTâchesProd(float numVersion, string codeLog)
        {
            // Nombre de tâches de production à retourner
            int compteurTaches;

            // Récupération de la chaîne de connexion
            var connectString = Properties.Settings.Default.JobOverviewConnectionString;

            //Ecriture de la requête (pas outer join dans la requête mais inner, pour ne pas prendre en compte les versions sans tâches de production)
            string req = @"select COUNT(*)
                            from jo.Version V
                            inner join jo.TacheProd T on T.CodeLogicielVersion = V.NumeroVersion
                            where V.NumeroVersion = @num and V.CodeLogiciel = @codeLog";

            // Paramètres de la requête
            var paramNum = new SqlParameter("@num", DbType.Double);
            paramNum.Value = numVersion;
            var paramCodeLog = new SqlParameter("@codeLog", DbType.String);
            paramCodeLog.Value = codeLog;

            // Création d'une connexion à partir de la chaîne de connexion stockée juste avant
            using (var cnx = new SqlConnection(connectString))
            {
                // Création d'une commande à partir de la requête et de la connexion
                // et entrée des paramètres.
                var command = new SqlCommand(req, cnx);
                command.Parameters.Add(paramNum);
                command.Parameters.Add(paramCodeLog);

                // Ouverture de la connection et exécution de la commande
                cnx.Open();
                compteurTaches = (int)command.ExecuteScalar();
            }

            // Retour du nombre de tâches de production
            return compteurTaches;
        }
    }
}
