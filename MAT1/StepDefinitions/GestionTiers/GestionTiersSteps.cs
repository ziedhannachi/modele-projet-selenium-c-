using MAT1.PageObjects.Tiers;
using MAT1.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MAT1.StepDefinitions.GestionTiers
{
    [Binding]
    public class GestionTiersSteps
    {
        private IWebDriver driver;
        static GestionTiersObjects tiers;

        static CommonMethod comM;

        public GestionTiersSteps(IWebDriver _driver)
        {
            driver = _driver;
            tiers = new GestionTiersObjects(driver);

        }

        [Given(@"Cliquer dans l’onglet Tiers")]
        public void GivenCliquerDansLOngletTiers()
        {
            Thread.Sleep(5000);
            tiers.TiersLinkClick();

        }

        [Given(@"Cliquer sur Nouveau")]
        public void GivenCliquerSurNouveau()
        {
            Thread.Sleep(8000);
            tiers.NouveauLinkClick();
        }

        [When(@"Saisir '(.*)' dans le champ Nom abrégé")]
        public void WhenSaisirDansLeChampNomAbrege(string nomAbrégé)
        {
            Thread.Sleep(5000);
            tiers.NomAbrégéSendKeys(nomAbrégé);
        }

        [When(@"Saisir '(.*)' dans Nom complet")]
        public void WhenSaisirDansNomComplet(string nomComplet)
        {
            Thread.Sleep(5000);
            tiers.NomCompletSendKeys(nomComplet);
        }

        [When(@"Cliquer sur sauvegarder")]
        public void WhenCliquerSurSauvegarder()
        {
            Thread.Sleep(2000);
            tiers.SauvegarderButtonClick();
        }


        [Then(@"Les données du tiers Nom abrégé: '(.*)', Nom complet: '(.*)' et Pays: '(.*)' sont bien affichées dans sa fiche")]
        public void ThenLesDonneesDuTiersNomAbregeNomCompletEtPaysSontBienAfficheesDansSaFiche(string nomAbrégé, string nomComplet, string pays)
        {
            Thread.Sleep(8000);

            Assert.IsTrue(tiers.NomAbrégéFicheText().Equals(nomAbrégé));
            Assert.IsTrue(tiers.NomCompletFicheText().Equals(nomComplet));
            Assert.IsTrue(tiers.PaysText().Equals(pays));
        }

        [Given(@"Cliquer sur le tiers '(.*)'")]
        public void GivenCliquerSurLeBoutonLeTiers(string p0)
        {
            Thread.Sleep(8000);
            tiers.BadoitTiersLinkClick();
        }


        [When(@"Cliquer sur le bouton Insérer de la rubrique Types")]
        public void WhenCliquerSurLeBoutonInsererDeLaRubriqueTypes()
        {
            Thread.Sleep(2000);
            tiers.InsérerLinkClick();
        }

        [When(@"Sélectionner le type CLIDIR - Client Direct")]
        public void WhenSelectionnerLeTypeCLIDIR_ClientDirect()
        {
            Thread.Sleep(2000);

            tiers.TypesClick();

            Thread.Sleep(2000);

            tiers.ADVERSAdversaireTypesClick();
        }

        [When(@"Cliquer sur valider")]
        public void WhenCliquerSurValider()
        {
            Thread.Sleep(2000);
            tiers.ValidationButtonClick();
        }

        [When(@"Cliquer sur le bouton Numéro de compte automatique")]
        public void WhenCliquerSurLeBoutonNumeroDeCompteAutomatique()
        {
            Thread.Sleep(5000);
            tiers.NuméroCompteAutomatiqueClick();
        }

        [When(@"Cliquer sur le bouton Sauvegarder pour le sauvegard du compte")]
        public void WhenCliquerSurLeBoutonSauvegarderPourLeSauvegardDuCompte()
        {
            Thread.Sleep(2000);
            tiers.SauvegarderCompetButtonClick();
        }

        [When(@"Cliquer sur le bouton Sauvegarder les modifications")]
        public void WhenCliquerSurLeBoutonSauvegarderLesModifications()
        {
            Thread.Sleep(2000);
            tiers.EnregistrerButtonClick();
        }

        [When(@"Actualiser la page")]
        public void WhenActualiserLaPage()
        {
            Thread.Sleep(2000);
            driver.Navigate().Refresh();
        }

        [Then(@"'(.*)' est affiché dans le champ Compte client et '(.*)' est affiché dans le tableau de la rubrique Types")]
        public void ThenEstAfficheDansLeChampCompteClientEtEstAfficheDansLeTableauDeLaRubriqueTypes(string compteClient, string type)
        {
            Thread.Sleep(5000);
            Assert.IsTrue(tiers.CompteClientInputText().Contains(compteClient));
            Assert.IsTrue(tiers.TextType().Contains(type));
        }

        [When(@"Saisir '(.*)' dans le champ Adresse")]
        public void WhenSaisirDansLeChampAdresse(string adresse)
        {
            Thread.Sleep(8000);
            tiers.adresseInputSendKeys(adresse);
        }

        [When(@"Saisir '(.*)' da,s le champ Code postal")]
        public void WhenSaisirDaSLeChampCodePostale(string codePostal)
        {
            Thread.Sleep(2000);
            tiers.CodePostalInputSendKeys(codePostal);
        }

        [When(@"Cliquer sur le bouton Sauvegarder adresse")]
        public void WhenCliquerSurLeBoutonSauvegarderAdresse()
        {
            Thread.Sleep(2000);
            tiers.SauvegarderAdresseButtonClick();
        }

        [Then(@"Les informations adresse: '(.*)', Code postal: '(.*)' et Ville: '(.*)' sont bien affiché")]
        public void ThenLesInformationsAdresseCodePostaleEtVilleSontBienAffiche(string adresse, string codePostal, string ville)
        {
            Thread.Sleep(5000);
            Assert.IsTrue(tiers.adresseInputText().Contains(adresse));
            Assert.IsTrue(tiers.CodePostalInputText().Contains(codePostal));
            Assert.IsTrue(tiers.VilleInputText().Contains(ville));
        }

        [Given(@"Cliquer sur onglet Note")]
        public void GivenCliquerSurOngletNote()
        {
            Thread.Sleep(10000);
            tiers.NoteClick();
        }

        [When(@"Cliquer sur le bouton Ajouter une note")]
        public void WhenCliquerSurLeBoutonAjouterUneNote()
        {
            Thread.Sleep(5000);
            tiers.AjouterNoteClick();
        }

        [When(@"Saisir '(.*)' dans le champ Titre")]
        public void WhenSaisirDansLeChampTitre(string titre)
        {
            Thread.Sleep(3000);
            tiers.TitreInputSendKeys(titre);
        }

        [When(@"Saisir '(.*)' dans le champ Note")]
        public void WhenSaisirDansLeChampNote(string note)
        {
            Thread.Sleep(3000);
            tiers.NoteInputSendKeys(note);
        }

        [When(@"Cocher la case Fiche dossier")]
        public void WhenCocherLaCaseFicheDossier()
        {
            Thread.Sleep(3000);
            tiers.FicheDossierClick();
        }

        [When(@"Sélectionner Val/Fact dans le champ Uniquement sur les onglets")]
        public void WhenSelectionnerValFactDansLeChampUniquementSurLesOnglets()
        {
            Thread.Sleep(10000);
            tiers.OngletSelect();
        }

        [When(@"Cliquer sur de validation d'ajout")]
        public void WhenCliquerSurDeValidationDAjout()
        {
            Thread.Sleep(3000);
            tiers.ValidationAddNoteButtonClick();
        }

        [Then(@"Le titre: '(.*)', La note: '(.*)' et Uniquement sur les onglets: '(.*)' doivent être affichées")]
        public void ThenLeTitreLaNoteEtUniquementSurLesOngletsDoiventEtreAffichees(string titre, string note, string onglet)
        {
            Thread.Sleep(3000);
            Assert.IsTrue(tiers.TitreInputText().Contains(titre));
            Assert.IsTrue(tiers.NoteInputText().Contains(note));
            Assert.IsTrue(tiers.OngletText().Contains(onglet));
        }

        [Given(@"Cliquer sur onglet Contacts")]
        public void GivenCliquerSurOngletContacts()
        {
            Thread.Sleep(8000);
            tiers.ContactLinkClick("Contacts");
        }

        [When(@"Cliquer sur Ajouter un contact")]
        public void WhenCliquerSurAjouterUnContact()
        {
            Thread.Sleep(5000);
            tiers.AjouterContactClick();
        }

        [When(@"Saisir '(.*)' dans le champ Libellé court")]
        public void WhenSaisirDansLeChampLibelleCourt(string libellé)
        {
            Thread.Sleep(5000);
            tiers.LibelléCourtSendKeys(libellé);
        }


        [When(@"Cliquer sur le bouton Valider pour l'ajout du type de contact")]
        public void WhenCliquerSurLeBoutonValiderPourLAjoutDuTypeDeContact()
        {
            Thread.Sleep(5000);
            tiers.AjouterTypeContactButtonClick();
        }

        [When(@"Saisir '(.*)' dans le champ Nom")]
        public void WhenSaisirDansLeChampNom(string nom)
        {
            Thread.Sleep(5000);
            tiers.NomInputSendKeys(nom);
        }

        [When(@"Saisir '(.*)' dans le champ Prénom")]
        public void WhenSaisirDansLeChampPrenom(string prénom)
        {
            Thread.Sleep(2000);
            tiers.PrénomInputSendKeys(prénom);
        }

        [When(@"Cliquer sur le bouton Ajouter")]
        public void WhenCliquerSurLeBoutonAjouter()
        {
            Thread.Sleep(2000);
            tiers.AjouterButtonClick();
        }

        [Then(@"Les informations du contact: Nom: '(.*)', Prénom: '(.*)' et Type de contact: '(.*)' sont affichées dans le tableau")]
        public void ThenLesInformationsDuContactNomPrenomEtTypeDeContactSontAfficheesDansLeTableau(string nom, string prénom, string contactType)
        {
            Thread.Sleep(5000);
            Assert.IsTrue(tiers.ContactNomDisplayed().Equals(true));
            Assert.IsTrue(tiers.ContactPrénomDisplayed().Equals(true));
            Assert.IsTrue(tiers.ContactTypeDisplayed().Equals(true));
        }

        [Given(@"Cliquer sur onglet Portefeuilles")]
        public void GivenCliquerSurOngletPortefeuilles()
        {
            Thread.Sleep(10000);
            tiers.PortefeuillesClick("Portefeuilles");
        }

        [Given(@"Cliquer sur Correspondance")]
        public void GivenCliquerSurCorrespondance()
        {
            Thread.Sleep(8000);
            tiers.CorrespondanceClick();

        }

        [Given(@"Cliquer sur le bouton Insérer")]
        public void GivenCliquerSurLeBoutonInserer()
        {
            Thread.Sleep(8000);
            tiers.InsérerButtonClick();
        }

        [Given(@"Cliquer sur la colone objet")]
        public void GivenCliquerSurLaColoneObjet()
        {
            Thread.Sleep(5000);
            tiers.ObjetClick();
        }

        [Given(@"Saisir '(.*)' dans le champ Libellé")]
        public void GivenSaisirDansLeChampLibelle(string libellé)
        {
            Thread.Sleep(8000);
            tiers.LibelléSendKeys(libellé);
        }

        [Given(@"Cliquer sur le bouton Valider pour ajouter Objet")]
        public void GivenCliquerSurLeBoutonValiderPourAjouterObjet()
        {
            Thread.Sleep(3000);
            tiers.ValiderClick();
        }

        [Given(@"Cliquer sur le bouton de validation")]
        public void GivenCliquerSurLeBoutonDeValidation()
        {
            Thread.Sleep(5000);
            tiers.ValiderCorrespClick();
        }

        [Given(@"Double click sur Correspondance")]
        public void GivenDoubleClickSurCorrespondance()
        {
            Thread.Sleep(5000);
            tiers.CorrespDoubleClick();
        }


        [Given(@"Cliquer sur Breverts")]
        public void GivenCliquerSurBreverts()
        {
            Thread.Sleep(5000);
            tiers.BrevetsClick();
        }

        [Given(@"Cliquer sur le bouton Insérer dans la rubrique Règles de correspondance")]
        public void GivenCliquerSurLeBouonInsererDansLaRubriqueReglesDeCorrespondance()
        {
            Thread.Sleep(10000);
            tiers.IsérerRèglesCorrespondancesClick();
        }

        [Given(@"Cliquer sur Destinataire de la ligne créée")]
        public void GivenCliquerSurDestinataireDeLaLigneCreee()
        {
            Thread.Sleep(5000);
            tiers.DestinataireClick();
        }

        [Given(@"Cliquer sur le champ contact")]
        public void GivenCliquerSurLeChampContact()
        {
            Thread.Sleep(5000);
            tiers.ContactClick();
        }

        [Given(@"Saisir '(.*)' dans le champ nom")]
        public void GivenSaisirDansLeChampNom(string nom)
        {
            Thread.Sleep(3000);
            tiers.NomSendKeys(nom);
        }


        [Given(@"Cliquer sur le bouton Valider pour valider l'ajout du contact")]
        public void GivenCliquerSurLeBoutonValiderPourValiderLAjoutDuContact()
        {
            Thread.Sleep(3000);
            tiers.ValidationChoixContactClick();
        }

        [Given(@"Cliquer sur le bouton Valider du popup choix du destinataire")]
        public void GivenCliquerSurLeBoutonValiderDuPopupChoixDuDestinataire()
        {
            Thread.Sleep(5000);
            tiers.ValidationChoixDestinataireClick();
        }

        [Given(@"Cliquer sur le bouton de validation d'ajout du Règles de correspondances")]
        public void GivenCliquerSurLeBoutonDeValidationDAjoutDuReglesDeCorrespondances()
        {
            Thread.Sleep(5000);
            tiers.RèglesCorrespondancesValidationButtonClick();
        }


        [Then(@"Une règle de correspondance '(.*)' est affichée")]
        public void ThenUneRegleDeCorrespondanceEstAffichee(string règleCorrespondance)
        {
            Thread.Sleep(5000);
            Assert.IsTrue(tiers.RègleCorrespondanceText().Equals(règleCorrespondance));
        }

        [Given(@"Selectionner '(.*)' dans la liste de recherche")]
        public void GivenSelectionnerDansLaListeDeRecherche(string brevets)
        {
            tiers.DropDownClick();
            Thread.Sleep(4000);
            tiers.TypeClick();
            Thread.Sleep(1000);
        }

        [When(@"Saisir '(.*)' dans la zonne de recherche")]
        public void WhenSaisirDansLaZonneDeRecherche(string nomDossier)
        {

            tiers.SaisirNomDossier(nomDossier);
            Thread.Sleep(10000);
        }

        [When(@"cliquer Entrer")]
        public void WhenCliquerEntrer()
        {
            tiers.ClickEntrer();

            Thread.Sleep(5000);

        }

        [When(@"Sélectionner le tiers '(.*)' à partir de la liste")]
        public void WhenSelectionnerLeTiersAPartirDeLaListe(string tiersNom)
        {
            Thread.Sleep(10000);
            tiers.TiersClick(tiersNom);
        }

        [When(@"Cliquer sur le bouton Sélectionnez")]
        public void WhenCliquerSurLeBoutonSelectionnez()
        {
            Thread.Sleep(5000);
            tiers.SélectionnerButtonClick();
        }

        [Given(@"Cliquer sur Ouvrir")]
        public void GivenCliquerSurOuvrir()
        {
            Thread.Sleep(8000);
            tiers.OuvrirLinkClick();
        }

        [When(@"Cliquer sur Nom Complet")]
        public void WhenCliquerSurNomComplet()
        {
            Thread.Sleep(5000);
            tiers.NomCompletLinkClick();
        }

        [When(@"Cliquer sur égale à")]
        public void WhenCliquerSurEgaleA()
        {
            Thread.Sleep(3000);
            tiers.EgalButtonClick();
        }

        [When(@"Saisir '(.*)' dans le champ Valeur")]
        public void WhenSaisirDansLeChampValeur(string nom)
        {
            Thread.Sleep(3000);
            tiers.ValeurInputSendKey(nom);
        }

        [When(@"Cliquer sur le bouton Valider")]
        public void WhenCliquerSurLeBoutonValider()
        {
            Thread.Sleep(3000);

            tiers.ValiderButtonClick();
            Thread.Sleep(1000);
        }

        [When(@"Cliquer sur le bouton Recherche")]
        public void WhenCliquerSurLeBoutonRecherche()
        {
            Thread.Sleep(4000);
            tiers.RechercheButtonClick();
        }

        [Then(@"Une liste avec les noms '(.*)' est affichée")]
        public void ThenUneListeAvecLesNomsEstAffichee(string p0)
        {
            Thread.Sleep(3000);
            Assert.IsTrue(tiers.ListTiersResult().Equals(0));
        }

    }
}
