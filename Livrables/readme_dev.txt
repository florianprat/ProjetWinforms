------------------------------------------------------------------
--- Documentation technique � destination d'un d�veloppeur
------------------------------------------------------------------

L'objectif de ce readme est de pr�ciser dans les grandes lignes l'architecture technique 
de chaque fen�tre et m�thodes de DAL associ�es.

--- Fen�tre d�di�e � la gestion de versions de logiciels

Cette fen�tre permet de s�lectionner un logiciel via une ComboBox. Les items de cette ComboBox 
sont obtenus � l'aide d'une m�thode d'une classe DAL d�di�e � la fen�tre. La m�thode permet de 
r�cup�rer des informations avec une requ�te SQL. Cette requ�te permet �galement d'afficher les 
modules du logiciel dans une DataGridView. Une deuxi�me requ�te g�r�e par une autre m�thode de 
la DAL r�cup�re des informations sur les versions et les affiche dans une deuxi�me DataGridView. 
L'ajout et la suppression de versions sont g�r�s par des m�thodes de la DAL suite aux clics sur 
des boutons associ�s.

--- Fen�tre d�di�e � l'importation de donn�es externes

La fen�tre li�e � l'importation de t�ches de production permet de s�lectionner un fichier XML 
via un explorateur de fichiers ou de rentrer directement son chemin dans une zone de saisie. Le 
bouton permet de d�s�rialiser le fichier s�lectionn�. La m�thode est disponible dans une DAL 
d�di�e aux t�ches de production. Les informations charg�es sont affich�es dans des DataGridView 
permettant � l'utilsateur de v�rifier de la bonne marche du chargement. L'utilisateur peut ensuite 
lancer l'enregistrement des donn�es charg�es dans la base de donn�es via une requ�te disponible 
dans la DAL.