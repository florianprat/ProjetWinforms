------------------------------------------------------------------
--- Description succincte des fonctionnalités de l'application
------------------------------------------------------------------

L'application permet à son utilisateur :
   - de gérer des versions de logiciels (MENU [Logiciels]).
   - de gérer les tâches (MENU [Tâches]).
   - d'échanger des données (MENU [Echanges]).

------------------------------------------------------------------
--- Sélection de la fenêtre active (MENU [Echanges])
------------------------------------------------------------------

Le menu [Fenêtres] permet de naviguer entre les différentes fenêtres actives de l'application.


------------------------------------------------------------------
--- Gestion des versions de logiciels (MENU [Logiciels])
------------------------------------------------------------------

Après un clic sur le menu [Logiciels], la fenêtre de gestion des versions de logiciels apparaît.
Suite à la sélection d'un logiciel, les modules et les versions liées au logiciel sont affichées 
sous forme de tableau. Ces tableaux présentent les principales informations associées aux modules 
et aux versions.

Informations disponibles sur les modules :
   - Numéro, Millésime, Date d'ouverture, Date de sortie prévue, Date de sortie réelle, Numéro de dernière release.
   - Code module, Libellé, Module parent.

--- Ajout/Suppression d'une version

Suite à la sélection d'un logiciel, une zone dédiée à l'ajout/suppression de version apparaît.

Pour supprimer une version, sélectionnez cette dernière dans la zone "Liste des versions" et 
cliquez sur le bouton "-". Suite à cette action, la version sélectionnée est supprimée de la 
base de données. Une version peut être supprimée si elle n'est liée à aucune tâche de production. 
Dans le cas contraire, un message d'alerte est affiché.

Pour ajouter une version, cliquez sur le bouton "+" dans la zone "Liste des versions". Une fenêtre 
modale de saisie apparaît (fenêtre "Saisie d'une nouvelle version"). Après saisie, cliquez sur le 
bouton "OK" pour enregistrer la nouvelle version dans la base de données. Si la saisie n'est pas 
valide, un message d'alerte est affiché et vous retournez dans la fenêtre de saisie. Un clic sur 
bouton "Annuler" permet de sortir de la fenêtre et de revenir dans la fenêtre de gestion des versions 
de logiciels.

------------------------------------------------------------------
--- Echange de données (MENU [Echanges])
------------------------------------------------------------------

Un clic sur le menu [Echanges] permet d'accéder aux deux sous-menus suivants :
   - Importation tâches de production (chargement puis enregistrement de données externes dans la base de données)
   - Exportation tâches de production (génération d'un fichier au format XML contenant les données relatives aux tâches de production)

--- Importation de données externes

Pour importer des tâches de production et travaux associés, saisissez dans la zone de saisie le chemin 
du fichier à importer au format XML, ou cliquez sur le bouton d'exploration de fichiers et sélectionnez 
le fichier. Cliquez ensuite sur le bouton "Chargement des données". Si le fichier spécifié n'est pas 
au format XML, un message d'alerte est affiché. Après chargement, les données sont consultables sous 
forme de tableaux. Si les données sont celles souhaitées, cliquez sur le bouton "Enregistrer" pour 
les enregistrer dans la base de données.




















