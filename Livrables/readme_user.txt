------------------------------------------------------------------
--- Description succincte des fonctionnalit�s de l'application
------------------------------------------------------------------

L'application permet � son utilisateur :
   - de g�rer des versions de logiciels (MENU [Logiciels]).
   - de g�rer les t�ches (MENU [T�ches]).
   - d'�changer des donn�es (MENU [Echanges]).

------------------------------------------------------------------
--- S�lection de la fen�tre active (MENU [Echanges])
------------------------------------------------------------------

Le menu [Fen�tres] permet de naviguer entre les diff�rentes fen�tres actives de l'application.


------------------------------------------------------------------
--- Gestion des versions de logiciels (MENU [Logiciels])
------------------------------------------------------------------

Apr�s un clic sur le menu [Logiciels], la fen�tre de gestion des versions de logiciels appara�t.
Suite � la s�lection d'un logiciel, les modules et les versions li�es au logiciel sont affich�es 
sous forme de tableau. Ces tableaux pr�sentent les principales informations associ�es aux modules 
et aux versions.

Informations disponibles sur les modules :
   - Num�ro, Mill�sime, Date d'ouverture, Date de sortie pr�vue, Date de sortie r�elle, Num�ro de derni�re release.
   - Code module, Libell�, Module parent.

--- Ajout/Suppression d'une version

Suite � la s�lection d'un logiciel, une zone d�di�e � l'ajout/suppression de version appara�t.

Pour supprimer une version, s�lectionnez cette derni�re dans la zone "Liste des versions" et 
cliquez sur le bouton "-". Suite � cette action, la version s�lectionn�e est supprim�e de la 
base de donn�es. Une version peut �tre supprim�e si elle n'est li�e � aucune t�che de production. 
Dans le cas contraire, un message d'alerte est affich�.

Pour ajouter une version, cliquez sur le bouton "+" dans la zone "Liste des versions". Une fen�tre 
modale de saisie appara�t (fen�tre "Saisie d'une nouvelle version"). Apr�s saisie, cliquez sur le 
bouton "OK" pour enregistrer la nouvelle version dans la base de donn�es. Si la saisie n'est pas 
valide, un message d'alerte est affich� et vous retournez dans la fen�tre de saisie. Un clic sur 
bouton "Annuler" permet de sortir de la fen�tre et de revenir dans la fen�tre de gestion des versions 
de logiciels.

------------------------------------------------------------------
--- Echange de donn�es (MENU [Echanges])
------------------------------------------------------------------

Un clic sur le menu [Echanges] permet d'acc�der aux deux sous-menus suivants :
   - Importation t�ches de production (chargement puis enregistrement de donn�es externes dans la base de donn�es)
   - Exportation t�ches de production (g�n�ration d'un fichier au format XML contenant les donn�es relatives aux t�ches de production)

--- Importation de donn�es externes

Pour importer des t�ches de production et travaux associ�s, saisissez dans la zone de saisie le chemin 
du fichier � importer au format XML, ou cliquez sur le bouton d'exploration de fichiers et s�lectionnez 
le fichier. Cliquez ensuite sur le bouton "Chargement des donn�es". Si le fichier sp�cifi� n'est pas 
au format XML, un message d'alerte est affich�. Apr�s chargement, les donn�es sont consultables sous 
forme de tableaux. Si les donn�es sont celles souhait�es, cliquez sur le bouton "Enregistrer" pour 
les enregistrer dans la base de donn�es.




















