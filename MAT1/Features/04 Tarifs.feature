Feature: 04 Tarifs
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

	Scenario: 17 Création et modification Tarif
		Given Cliquer sur l’onglet Finances 
		When Cliquer sur Nouveau
		And Cliquer dans le champ Code
		And Saisir 'AUTO' dans le champ code
		And Saisir 'Test auto' dans le champ libellé court
		And Saisir 'Test automatique' dans le champ libellé long
		And Cliquer sur le bouton Valider du popup Edition
		And Cliquer sur le chmp libellé (utilisateur)
		And Saisir 'Test auto (utilisateur)' dans le champ libellé court
		And Saisir 'Test auto (utilisateur)' dans le champ libellé long
		And Cliquer sur le bouton Valider du popup Edition
		And Sélectionner 'France' dans la liste pays
		And Sélectionner 'Brevet'  dans la liste objet du Tarif
		And Sélectionner 'Selon le taux de copropriété' dans la liste Mode de répartition
		And Cliquer sur le champ Barème
		And Saisir 'BIGSMA' dans le champ code du popup barème
		And Cliquer sur le bouton valider du popup barème
		And Sélectionner le checkbox Taxes
		And Saisir '250' dans le champ Initialiser à du taxes
		And Saisir '300' dans le champ Initialiser à du Honoraires 
		And Cliquer sur le bouton valider du popup nouveau tarif
		Then 'AUTO' est affiché dans le champ code
		And 'Test automatique' est affiché dans le champ libellé
		And 'Test auto (utilisateur)' est affiché dans le champ libellé (Utilisateurs)
		And 'FRANCE' est affiché dans le champ pays
		And 'Petite.grande entité' est affiché dans le champ barème
		When Cliquer sur le champ Honoraires de la ligne Petite Entité
		And Saisir '200' dans le champ Honoraires
		And Cliquer sur le champ Honoraires de la ligne Grande Entité
		And Saisir '300' dans le champ Honoraires
		And Cliquer sur le champ Honoraires de la ligne Individu
		And Saisir '100' dans le champ Honoraires
		And Cliquer sur le bouton sauvegarder
		And Cliquer sur le bouton Option de la barre d’outils
		And Cliquer sur le bouton Ajouter une colonne
		And Sélectionner la colonne Frais
		And Cliquer sur le bouton Valider du popup options
		And Cliquer sur l'onglet Mise à jour du tarif
		And Cocher la colonne Honoraires
		And Cocher la case Ajouter %
		And Saisir '50' dans le champ
		And Saisir '20/04/2024' dans le champ Entrée en vigueur
		And Cliquer sur le bouton Valider de la parite mise à jour du tarif 
		And Cliquer sur le bouton Fermer
		Then La colonne Frais est affichée
		When Sélectionner A partir du 20/04/2024 à partir de la liste de la colonne barème
		Then les montants de la colonne Honoraire ont changés

	Scenario: 18 Association tarif A un Dossier
		Given Selectionner Brevets dans la liste de recherche
		When Saisir 'TEST AUTO' dans la zonne de recherche
		And cliquer Entrer
		And Cliquer sur Procédure
		And Cliquer sur le radio button Procédure
		And Cliquer sur Valorisation DEPOT
		And récupéré le numéro de la valorisation dépôt 
		And Cliquer sur le bouton Terminer
		When Cliquer sur Val/Fac
		And Cliquer sur Valorisation DEPOT créé
		And Cliquer sur l’icône Nouveau tarif
		And Saisir 'AUTO' dans le premier champ tarif
		And cliquer Entrer
		And Cliquer sur le bouton valider du popup
		Then Le tarif apparait dans la valorisation en cours avec le libellé 'Test auto (utilisateur)'

