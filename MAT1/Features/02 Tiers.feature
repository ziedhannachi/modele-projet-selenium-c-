Feature: 02 Tiers
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

	Scenario: 02 Création Tiers
		Given Cliquer dans l’onglet Tiers 
		And Cliquer sur Nouveau
		When Saisir 'BADOIT' dans le champ Nom abrégé
		And Saisir 'Société Badoit France' dans Nom complet
		And Cliquer sur sauvegarder
		Then Les données du tiers Nom abrégé: 'BADOIT', Nom complet: 'Société Badoit France' et Pays: 'FRANCE' sont bien affichées dans sa fiche

	Scenario: 03 Paramétrage Type de Tiers
		Given Cliquer dans l’onglet Tiers
		And Cliquer sur le tiers 'BADOIT'
		When Cliquer sur le bouton Insérer de la rubrique Types
		And Sélectionner le type CLIDIR - Client Direct
		And Cliquer sur valider
		And Cliquer sur le bouton Numéro de compte automatique
		And Cliquer sur le bouton Sauvegarder pour le sauvegard du compte
		And Cliquer sur le bouton Sauvegarder les modifications
		And Actualiser la page
		Then '0000' est affiché dans le champ Compte client et 'CLIDIR - Client Direct' est affiché dans le tableau de la rubrique Types

	Scenario: 04 Paramétrage Adresse Principale de tiers
		Given Cliquer dans l’onglet Tiers
		And Cliquer sur le tiers 'BADOIT'
		When Saisir '18 rue de l’eau claire' dans le champ Adresse
		And Saisir '75009' da,s le champ Code postal
		And Cliquer sur le bouton Sauvegarder adresse
		Then Les informations adresse: '18 rue de l’eau claire', Code postal: '75009' et Ville: 'PARIS' sont bien affiché

	Scenario: 05 Création Note
		Given Cliquer dans l’onglet Tiers
		And Cliquer sur le tiers 'BADOIT'
		And Cliquer sur onglet Note
		When Cliquer sur le bouton Ajouter une note
		And Saisir 'Procédure de facturation' dans le champ Titre
		And Saisir 'Procédure de facturation brevets français' dans le champ Note
		And Cocher la case Fiche dossier
		And Sélectionner Val/Fact dans le champ Uniquement sur les onglets
		And Cliquer sur de validation d'ajout
		Then Le titre: 'Procédure de facturation', La note: 'Procédure de facturation brevets français' et Uniquement sur les onglets: 'Val/Fac' doivent être affichées

	Scenario: 06 Création Contact
		Given Cliquer dans l’onglet Tiers
		And Cliquer sur le tiers 'BADOIT'
		And Cliquer sur onglet Contacts
		When Cliquer sur Ajouter un contact
		And Saisir 'DIRECTION' dans le champ Libellé court
		And Cliquer sur le bouton Valider pour l'ajout du type de contact
		And Saisir 'MAISONEUVE' dans le champ Nom
		And Saisir 'Paul' dans le champ Prénom
		And Cliquer sur le bouton Ajouter
		Then Les informations du contact: Nom: 'MAISONEUVE', Prénom: 'Paul' et Type de contact: 'DIRECTION' sont affichées dans le tableau

	Scenario: 07 Paramétrage règle De Correspondance Brevets
		Given Cliquer dans l’onglet Tiers
		And Cliquer sur le tiers 'BADOIT'
		And Cliquer sur onglet Portefeuilles
		And Cliquer sur Correspondance
		And Cliquer sur le bouton Insérer
		And Cliquer sur la colone objet
		And Saisir 'Brevets' dans le champ Libellé
		And Cliquer sur le bouton Valider pour ajouter Objet
		And Cliquer sur le bouton de validation
		And Double click sur Correspondance
		And Cliquer sur Breverts
		And Cliquer sur le bouton Insérer dans la rubrique Règles de correspondance
		And Cliquer sur Destinataire de la ligne créée
		And Cliquer sur le champ contact
		And Saisir 'MAISONEUVE' dans le champ nom
		And Cliquer sur le bouton Valider pour valider l'ajout du contact
		And Cliquer sur le bouton Valider du popup choix du destinataire
		And Cliquer sur le bouton de validation d'ajout du Règles de correspondances
		Then Une règle de correspondance 'Libellé à BADOIT (MAISONEUVE)' est affichée

	Scenario: 08 Recherche Tiers via Recherche Rapide
		Given Selectionner 'Tiers' dans la liste de recherche
		When Saisir 'BADOIT' dans la zonne de recherche 
		And cliquer Entrer
		And Sélectionner le tiers 'BADOIT' à partir de la liste
		And Cliquer sur le bouton Sélectionnez
		Then Les données du tiers Nom abrégé: 'BADOIT', Nom complet: 'Société Badoit France' et Pays: 'FRANCE' sont bien affichées dans sa fiche

	Scenario: 09 Recherche tiers via Recherhe Approfondie
		Given Cliquer dans l’onglet Tiers
		And Cliquer sur Ouvrir
		When Cliquer sur Nom Complet
		And Cliquer sur égale à
		And Saisir 'TINTIN' dans le champ Valeur
		And Cliquer sur le bouton Valider
		And Cliquer sur le bouton Recherche
		Then Une liste avec les noms 'TINTIN' est affichée
	
