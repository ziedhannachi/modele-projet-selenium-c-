Feature: 03 DossiersBrevets
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

	Background: Connecter à Alissia
		Given naviguer à l'application Alissia Formation
		When entrer le company login 'Moncey'
		And entrer le username 'ZiedH'
		And  entrer le mot de passe 'U74Xvp2Fq'
		When cliquer sur Connexion
		Then utilisateur connecté à l'application et la page d'accueil est affichée

	Scenario: 10 Création Dossier Brevets
		Given Cliquer dans l’onglet Dossiers 
		And Cliquer sur dossier Breverts
		And Cliquer sur Nouveau
		When Sélectionner Brevet français d’origine française dans le champ Prestation
		And Désélectionné le checkBox Numéro automatique
		And Saisir 'TEST AUTO' dans le champ Référence
		And Cliquer sur Titre abrégé de la ligne créée
		And Saisir 'DOSSIER BADOIT'
		And Cliquer sur Titre de la ligne créée
		And Saisir 'DOSSIER BADOIT COMPLET' dand le champ Titre
		And Cliquer sur Suivant du popup
		And Cliquer sur le bouton Ajouter un tiers Donneurs d'ordre
		And Saisir 'BADOIT' dans Nom abrégé
		And cliquer Entrer
		And Cliquer sur le bouton Suivant
		And Cliquer sur le bouton Suivant
		And Cliquer sur le bouton Suivant
		And Cliquer sur le bouton Ajouter un tiers inventeur
		And Saisir 'PETIT' dans Nom abrégé
		And cliquer Entrer
		And Cliquer sur le bouton Suivant
		And Cliquer sur le bouton Suivant
		And Cliquer sur le bouton Terminer
		Then 'DOSSIER BADOIT' est affiché dans le champ Titre abrégé et 'DOSSIER BADOIT COMPLET' est affiché dans le champ titre
		When Cliquer sur Val/Fac
		Then une notification est affiché

	Scenario: 11 Lancement Etape de Procèdure Brevets
		Given Selectionner Brevets dans la liste de recherche
		When Saisir 'TEST AUTO' dans la zonne de recherche
		And cliquer Entrer
		And Sélectionner le dossier 'TEST AUTO' à partir de la liste
		And Cliquer sur le bouton Sélectionnez
		And Cliquer sur Procédure
		And Cliquer sur le radio button Procédure
		And Cliquer sur DATE / N° DEPOT
		And Saisir la date '15012016' dans le champ Date
		And Saisir '1604328' dans le champ numéro
		And Cliquer sur le bouton Suivant
		And Cliquer sur le bouton Générer un nouveau document
		And Cliquer sur suivant
		And Cliquer sur Générer le document
		And Cliquer sur icone document
		And Cliquer sur le bouton Ouvrir Word
		And Saisir le company login 'Moncey'
		And Saisir le username 'ZiedH'
		And Saisir le mot de passe 'U74Xvp2Fq'
		And cliquer sur le bouton Connexion
		And Cliquer sur Terminer
		And Cliquer sur le bouton Suivant
		And Ajouter un document
		And Cliquer sur la liste Titre
		And Sélectionner le titre prérempli  
		And Cliquer sur le bouton Suivant
		And Saisir '200' dans Nb mots de la description
		And Saisir '300' dans Nb mots des revendications
		And Saisir '500' dans Total de mots
		And Saisir '6' dans Nb de pages
		And Saisir '2' dans Nb de planches
		And Saisir '12' dans Nb de revendications
		And Cliquer sur le bouton Suivant
		And Cliquer sur le bouton Terminer
		And Cliquer sur Dossier
		Then La date '15/01/2016' est affiché pour la date dépot
		And  Le numéro '1604328' est affiché pour la date dépot
		And '200' est affiché pour Nb mots de la description
		And '300' est affiché pour Nb mots des revendications
		And '500' est affiché pour Nombre de mots
		And '6' est affiché pour Nombre de pages
		And '2' est affiché pour Nombre de planches
		And '12' est affiché pour Nombre de revendications
		When Cliquer sur Documents
		And Cliquer sur étape Procédure
		And Cliquer sur étape Avis de dépôt
		And Cliquer sur l'étape DATE / N° DEPOT
		And Cliquer sur le document
		Then Le document est bien affiché
		When Cliquer sur le bouton Générer le pdf
		And Cliquer sur le document	pdf
		Then Le document pdf est bien généré
		When Cliquer sur Procédure
		And Cliquer su le radio button Historique
		And Cliquer sur le Date/N° Depot
		Then Les informations de l'étape DATE/ DEPOT sont affichées

	Scenario: 12 Lancement Etape de valorisation
		Given Selectionner Brevets dans la liste de recherche
		When Saisir 'TEST AUTO' dans la zonne de recherche
		And cliquer Entrer
		And Sélectionner le dossier 'TEST AUTO' à partir de la liste
		And Cliquer sur le bouton Sélectionnez
		And Cliquer sur Procédure
		And Cliquer sur le radio button Procédure
		And Cliquer sur Valorisation DEPOT
		And récupéré le numéro de la valorisation dépôt 
		And Cliquer sur le bouton Terminer
		Then Le radio button En cours est coché
		And Un délai de type facturation est affiché
		When Cliquer sur Val/Fac
		Then Valorisation DEPOT En cours est affichée
		When Cliquer sur Valorisation DEPOT créé
		Then '4 000,00 EUR' est le total affiché pour Dépôt en ligne
		When Cliquer sur l'état du libellé Envoi recommandé 
		And Modifier l'état à non facturable
		And Cliquer sur le libellé Frais de photocopies
		And Modifier le frais du libellé Frais de photocopies à '10' EUR pour valorisation
		And Cliquer sur le checkBox Facturation
		And Modifier le frais du libellé Frais de photocopies à '100' EUR pour Facturation
		And Cliquer sur bouton Sauvegarder
		Then La ligne Frais de photocopies du dépôt est en gras
		When Cliquer sur Nouveau tarif
		And Saisir 'VALORG' dans le champ tarif
		And cliquer Entrer
		And Cliquer sur Valider
		Then Une nouvelle ligne avec le libellé "Constitution de mandataire" est affiché 
		When Cliquer sur le Export cognos
		And Cliquer sur le bouton Télécharger le fichier
		Then Le fichier doit être téléchargé
		When Cliquer sur bouton Sauvegarder
		Then La ligne tarif Envoi recommandé doit être supprimé du tableau
		And L onglet Historique est affiché
		When Cliquer sur onglet Historique
		Then La valorisation de dépôt est affiché
		When Cliquer sur la valorisation dépôt
		Then La ligne de tarif Envoi recommandé apparait dans le répertoire Historique à l’état Non facturable et grisée
		When Cliquer sur Valorisation DEPOT créé
		And Cliquer sur Facturation
		And Cocher la case Supprimer toutes les lignes de valorisation à l’état Incomplet
		And Cliquer sur le bouton Facturation
		And Cliquer sur onglet Historique
		And Cliquer sur la valorisation dépôt
		Then Les lignes de valorisation sont affichées
		And Le répertoire Facture est créé
		And Le répertoire Procédure est créé
		And Une facture est créée
		When Cliquer sur le projet de facture
		Then le montant des taxes est de '2 825,00'
		When Cliquer sur numérotationFacture
		And Modifier la date la numérotation de la facture par la date de la veille
		And Cliquer sur le bouton valider
		Then Le projet de facture est transformé en Facture et est numéroté
		And La date de la facture correspond à la date renseignée précédemment
		When Cliquer sur Crédit depuis la barre d’outils de la facture numérotée
		And Cliquer sur OK pour valider la création du projet
		Then Une ligne de projet d’avoir est apparue
		And Le projet d’avoir reprend les montants de la facture
		When Cliquer sur Valorisation DEPOT créé
		Then Les lignes de tarifs issues de la facture créditée sont affichées à l’état facturable
		And '4 000,00 EUR' est le total affiché pour Dépôt en ligne
	
	Scenario: 13 Saisir Débours dans un dossier
		Given Selectionner Brevets dans la liste de recherche
		When Saisir 'BRE10151' dans la zonne de recherche 
		And cliquer Entrer
		And Cliquer sur Val/Fac
		And Cliquer sur + associé au libellé Débours
		And Saisir '20-1234' dans le champ N° Facture
		And Saisir '06/01/2020 ' dans le champ date facture
		And Cliquer sur le champ document
		And Ajouter un document du PC
		And Cliquer sur le bouton Ajouter le document au débours
		Then le nom du document apparait dans le champ associé à Document
		When Saisir '100' dans le champ Débours
		And Saisir '200' dans le champ Honoraire
		Then Constater que le total TTC est '300' et que la devise 'EUR'
		When Cliquer sur le champ Etape
		And Cliquer sur le radio Button Afficher les étapes de la procédure
		And Cliquer sur le libellé Avis de dépôts
		And Lancer l’étape Valorisation de dépôt
		And récupéré le numéro de la valorisation dépôt 
		And Cliquer sur le bouton Terminer
		And Cliquer sur le bouton Valider du popup
		And Cliquer sur le champ Intervenant 
		And Saisir 'JC' dans le champ Initiales de la personne
		And Cliquer sur Valider pour l'ajout de l'intervenant
		And Saisir 'Débours envoyé tardivement' dans le champ Motif
		And Cliquer sur Valider du popup Debours
		Then 'BEETZ' est affiché dans la colonne Tiers
		And '06/01/2020' est affiché dans la colonne Date
		And '100,00' est affiché dans la colonne Debours
		And '200,00' est affiché dans la colonne Honoraires
		And '300,00' est affiché dans la colonne Total
		And 'EUR' est affiché dans la colonne Devise
		When Accéder à la valorisation
		And Cliquer sur la ligne 'Débours externes'
		Then 'JCAV' est affiché dans la colonne Intervenant
		And 'Facturable' est affiché dans la colonne Etat
		And '300' est affiché dans la colonne Débours
		And '30' est affiché dans la colonne Frais
		And '330,00 EUR' est affiché pour la colonne Total
		And 'Julien Cavaggion' est affiché dans le champ Intervenant
		And 'BEETZ' est affiché dans le champ Fournisseur
		And '20-1234' est affiché dans le champ N° Facture
		And '06/01/2020' est affiché dans le champ Date
		And '300,00 EUR' est affiché pour total débours
		And '30,00 EUR' est affiché pour le total Frais
		And '330,00 EUR' est affiché pour le total
		When Cliquer sur Documents
		And Cliquer sur Divers
		Then Le document ajouté est affiché

	Scenario: 14 Recherche Dossier Marque
		Given Cliquer dans l’onglet Dossiers 
		When Cliquer sur Dossiers
		And Cliquer sur le lien Ouvrir
		And Cliquer sur Objet du dossier
		And Cliquer sur L'opérateur égale à
		And Cliquer sur Marques 
		And Cliquer sur Valider du popup
		And Cliquer sur Référence du dossier
		And Cliquer sur commence par
		And Saisir 'MAR' dans le champ valeur
		And Cliquer sur Valider du popup
		And Cliquer sur Dossier en vigueur
		And Cliquer sur le bouton Recherche
		And Cliquer sur le buton Paramétrage des colonnes
		And Glisser Image dans la partie Colonne sélectionnées en dessous de pays
		And Glisser Liste des caractéristiques en dessous d’Inventeur dans la partie Colonnes sélectionnées
		And Glisser protection dans la partie colonnes disponibles
		And Cliquer sur le bouton Sauvegarder
		Then Les deux colonnes Image et Liste des caractéristiques sont visibles dans la liste
		And La colonne Inventeur a disparue

	Scenario: 15 Ajout Document dans Onglet Documents
		Given Selectionner Brevets dans la liste de recherche
		When Saisir 'TEST AUTO' dans la zonne de recherche
		And cliquer Entrer
		And Sélectionner le dossier 'TEST AUTO' à partir de la liste
		And Cliquer sur le bouton Sélectionnez
		And Cliquer sur Documents
		And Ajouter un document à partir du bureau
		And Modifier le titre via le menu déroulant
		And Sélectionner Administratif brevets de la liste Nature
		And Saisir 'Test sur document' dans le champ Commentaire
		And Cliquer sur le bouton valider du pop up Ajouter Document
		Then Le document est affiché sous l'onglet Divers
		Then Les informations du document sont affichées
		And Le document est affiché dans la partie Aperçu
		When Ajouter un document à partir du bouton Ajouter un document
		And Saisir 'Document 2' dans le champ Titre du popup affiché
		And Cliquer sur le bouton valider du pop up Ajouter Document
		Then Le document est affiché dans le dossier Divers avec le nom 'Document 2'
		And Le document est affiché dans la partie Aperçu

	Scenario: 16 Ajout Logo
		Given Selectionner Dossier dans la liste de recherche
		When Saisir 'MAR10005' dans la zonne de recherche
		And cliquer Entrer
		And Sélectionner Le dossier 'MAR10005'
		And Cliquer sur Documents
		And Ajouter le logo à partir du bouton Ajouter un document
		And Cocher la case Image Principale
		And Cocher la case Disponible sur le portail
		And Cliquer sur le bouton valider du pop up Ajouter Document
		Then Le logo ALISSIA doit apparaitre à côté du titre du dossier
		And Le fichier Alissia est affiché dans le répertoire Divers
		And Le logo est affiché dans la partie Aperçu