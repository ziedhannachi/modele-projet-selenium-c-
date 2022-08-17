Feature: 06 ValorisationDevis
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

	Scenario: 21 Saisie des heures
		Given Cliquer sur l’onglet Finances 
		When Cliquer sur Valorisation & Devis
		And Cliquer sur Saisie des heures
		And Cliquer sur le bouton Ajouter une ligne de temps passé
		And Saisir '27/02/2020' dans le champ Date
		And Saisir 'TEST AUTO' dans Référence
		And Saisir 'Test sur la saisie des heures' dans Motif
		And Cliquer sur le champ Étape
		And Sélectionner Afficher les étapes de la procédure
		And Lancer une étape Valorisation de dépôt
		And récupéré le numéro de la valorisation dépôt 
		And Cliquer sur le bouton Terminer
		And Cliquer sur le bouton valider du popup éditer le dossier et l'étape
		And Cliquer sur le champ Echelon
		And Sélectionner 3ème Echelon
		And Cliquer sur Valider du pop up Echelon du barème
		And Saisir '03' h dans le champ Qté val
		And Saisir '02' h dans le champ Qté fac
		And Cliquer sur l'icone enregistrer
		Then La ligne apparait en gras
		When Selectionner Brevets dans la liste de recherche
		And Saisir 'TEST AUTO' dans la zonne de recherche
		And cliquer Entrer
		And Cliquer sur Val/Fac
		And Cliquer sur Valorisation DEPOT créé
		Then la ligne d’heure apparait dans l’onglet Val/Fac

	Scenario: 22 Débours groupés
		Given Cliquer sur l’onglet Finances 
		When Cliquer sur Valorisation & Devis
		And Cliquer Saisie des débours
		And Saisir 'TINTIN' dans le champ Fournisseur
		And cliquer Entrer
	    Then Un message d'erreur est affiché
		When Saisir 'ACUMASS' dans le champ Fournisseur
		And cliquer Entrer
		Then Un message informe que le tiers est reconnu est apparait
		When Cliquer sur Ajouter un débours
		And Cliquer sur le bouton enregistrer
		Then Un pop up rouge d’avertissement d’erreur apparait
		When Saisir '02/03/2020' dans le champ Date de la facture
		And Saisir '20-1234' dans le champ N° facture
		And Saisir '500' dans le champ Honoraires du tableau
		And Cliquer sur le bouton enregistrer
		Then Les champs Total HT, Total TTC et TVA sont remplis automatiquement
		And Les lignes ne sont plus en rouge
		When Cliquer sur Document
		And Ajouter un document dans le champ Document
		And Cliquer dans le champ Référence
		And Saisir 'BRE10151' dans le champ Référence dossier
		And cliquer Entrer
		Then L'étape valorisation dépôt est affiché
		And Le tableau Section est affiché avec toutes les informations
		And 'BELIN' est affiché dans le champ
		And 'Société Belin France' est affiché dans le champ société
		When Cliquer sur le bouton Valider et Sauvegarder
		And Cliquer sur le bouton tout à gauche du tableau
		Then '02/03/2020' est affiché pour Date de valorisation
		And 'BRE10151' est affiché pour Référence
		And 'MON INVENTION DE DEMO 151' est affiché pour Titre
		And 'Valorisation Dépôt' est affiché pour Étape
		And '500,00' est affiché pour Honoraires
		And 'BELIN' est affiché pour Tiers
		When Saisir '300' dans le champ Honoraires du tableau
		And Cliquer sur le bouton enregistrer
		Then la ligne du tableau est affiché avec la couleur rouge
		When Cliquer sur le bouton enregistrer
		Then Deux messages d'erreur sont affichés
		When Cliquer sur le bouton + pour ajouter un détail
		Then Une nouvelle sous ligne apparait et '200' est affiché dans la colonne Honoraire
		When Saisir 'BRE10153' dans le champ Référence de la ligne ajoutée
		And Cliquer sur Afficher les étapes disponibles 
		And Lancer une valorisation dépôt
		And Cliquer sur le bouton Terminer
		And Cliquer sur le bouton Valider du pop up





		

