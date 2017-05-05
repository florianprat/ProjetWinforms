------------------------------------------------------------------
--- Documentation technique à destination d'un développeur
------------------------------------------------------------------

L'objectif de ce readme est de préciser dans les grandes lignes l'architecture technique 
de chaque fenêtre et méthodes de DAL associées.

--- Fenêtre dédiée à la gestion de versions de logiciels

Cette fenêtre permet de sélectionner un logiciel via une ComboBox. Les items de cette ComboBox 
sont obtenus à l'aide d'une méthode d'une classe DAL dédiée à la fenêtre. La méthode permet de 
récupérer des informations avec une requête SQL. Cette requête permet également d'afficher les 
modules du logiciel dans une DataGridView. Une deuxième requête gérée par une autre méthode de 
la DAL récupère des informations sur les versions et les affiche dans une deuxième DataGridView. 
L'ajout et la suppression de versions sont gérés par des méthodes de la DAL suite aux clics sur 
des boutons associés.

--- Fenêtre dédiée à l'importation de données externes

La fenêtre liée à l'importation de tâches de production permet de sélectionner un fichier XML 
via un explorateur de fichiers ou de rentrer directement son chemin dans une zone de saisie. Le 
bouton permet de désérialiser le fichier sélectionné. La méthode est disponible dans une DAL 
dédiée aux tâches de production. Les informations chargées sont affichées dans des DataGridView 
permettant à l'utilsateur de vérifier de la bonne marche du chargement. L'utilisateur peut ensuite 
lancer l'enregistrement des données chargées dans la base de données via une requête disponible 
dans la DAL.