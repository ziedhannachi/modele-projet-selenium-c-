Feature: 01 Authentification
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

	Scenario: 01 Authentification
		Given naviguer à l'application Alissia Formation
		When entrer le company login 'Moncey'
		And entrer le username 'ZiedH'
		And  entrer le mot de passe 'U74Xvp2Fq'
		When cliquer sur Connexion
		Then utilisateur connecté à l'application et la page d'accueil est affichée