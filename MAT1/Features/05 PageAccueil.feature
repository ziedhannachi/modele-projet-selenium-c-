Feature: 05 PageAccueil
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

	Scenario: 19 Modification Pavés
		Given Cliquer sur l’icone Paramétrage de l’affichage de la page d’accueil
		When Sélectionner 5 pavés à partir de la liste
		And Cliquer sur valider le modèle
		And Glisser Documents récents dans le premier pavé
		And Glisser Requête Mes délais de procédure dans le deuxième pavé
		And Glisser Requête Dossiers dont je suis responsable dans le troisième pavé
		And Glisser Dossiers par année dans le quatrième pavé
		And Glisser Réceptacle dans le cinquième pavé
		And Cliquer sur le bouton sauvegarder du popup paramétrage
		Then Tous les pavés sont bien affiché

	Scenario: 20 Modification Pavés de Détai
		Given Cliquer sur l’icone Paramétrage de l’affichage de la page d’accueil
		When Sélectionner 5 pavés à partir de la liste
		And Cliquer sur valider le modèle
		And Glisser Créer nouveau pavé de requête dans le premier pavé
		And Cliquer sur le bouton +
		And Sélectionner Détails de la liste
		And Cliquer sur icone recherche
		And Cliquer sur Type d’échéance
		And Cliquer sur dans
		And Cliquer sur Client
		And Cliquer sur facturation
		And Cliquer sur Interne
		And Cliquer sur Officiel
		And Clicher sur Eléments
		And Cliquer sur Date de l'échéance
		And Cliquer sur ENTRE
		And Cliquer sur Date relative
		And Saisir '-5' dans le champ Année
		And Cliquer sur le bouton Valider du popup Moteur de recherche
		And Saisir '+2' dans Année
		And Cliquer sur le bouton Valider du popup Moteur de recherche
		And Clicher sur Eléments
		And Cliquer sur Responsable de l’étape
		And Cliquer sur égal à
		And Saisir 'OD' dans le champ Initiales de la Personne
		And Cliquer sur le bouton Valider du popup Moteur de recherche
		And Cliquer sur Sauvegarder la requête
		And Saisir 'Délais Olivier' dans le champ Libellé court du popup Sauvegarder la requête
		And Cliquer sur Sauvegarder
		And Valider la requête
		And Glisser Requête Mes délais de procédure dans le deuxième pavé
		And Glisser Requête Dossiers dont je suis responsable dans le troisième pavé
		And Glisser Dossiers par année dans le quatrième pavé
		And Glisser Réceptacle dans le cinquième pavé
		And Cliquer sur le bouton sauvegarder du popup paramétrage
		Then Le nouveau pavé apparait sur la page d’accueil
		
