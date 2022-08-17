using MAT1.PageObjects.Accueil;
using MAT1.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MAT1.StepDefinitions.GestionPageAccueil
{
    [Binding]
    public class GestionPageAccueilSteps
    {
        private IWebDriver driver;


        static CommonMethod comM;
        static GestionPageAccueilObjects accueil;


        public GestionPageAccueilSteps(IWebDriver _driver)
        {
            driver = _driver;
            comM = new CommonMethod(driver);
            accueil = new GestionPageAccueilObjects(driver);
        }

        [Given(@"Cliquer sur l’icone Paramétrage de l’affichage de la page d’accueil")]
        public void GivenCliquerSurLIconeParametrageDeLAffichageDeLaPageDAccueil()
        {
            Thread.Sleep(10000);
            accueil.ParamètrageClick();
        }
        
        [When(@"Sélectionner (.*) pavés à partir de la liste")]
        public void WhenSelectionnerPavesAPartirDeLaListe(int p0)
        {
            Thread.Sleep(8000);
            accueil.NbPavéClick();

            Thread.Sleep(3000);
            accueil.Pavé_5_Click();
        }
        
        [When(@"Cliquer sur valider le modèle")]
        public void WhenCliquerSurValiderLeModele()
        {
            Thread.Sleep(3000);
            accueil.ValiderModèleClick();
        }
        
        [When(@"Glisser Documents récents dans le premier pavé")]
        public void WhenGlisserDocumentsRecentsDansLePremierPave()
        {
            Thread.Sleep(8000);
            accueil.dragDropDocumentsRècents();
        }
        
        [When(@"Glisser Requête Mes délais de procédure dans le deuxième pavé")]
        public void WhenGlisserRequeteMesDelaisDeProcedureDansLeDeuxiemePave()
        {
            Thread.Sleep(5000);
            accueil.DragDropRequêteMesDélaisProcédure();
        }

        [When(@"Glisser Requête Dossiers dont je suis responsable dans le troisième pavé")]
        public void WhenGlisserRequeteDossiersDontJeSuisResponsableDansLeTroisiemePave()
        {
            Thread.Sleep(5000);
            accueil.DragDropRequêteDossiersResponsable();
        }

        [When(@"Glisser Dossiers par année dans le quatrième pavé")]
        public void WhenGlisserDossiersParAnneeDansLeQuatriemePave()
        {
            Thread.Sleep(5000);
            accueil.DragDropDossiersAnnée();
        }
        
        [When(@"Glisser Réceptacle dans le cinquième pavé")]
        public void WhenGlisserReceptacleDansLeCinquiemePave()
        {
            Thread.Sleep(5000);
            accueil.DragDropRéceptacle();
        }
        
        [When(@"Cliquer sur le bouton sauvegarder du popup paramétrage")]
        public void WhenCliquerSurLeBoutonSauvegarderDuPopupParametrage()
        {
            Thread.Sleep(5000);
            accueil.SauvegaderButtonClick();
        }
        
        [Then(@"Tous les pavés sont bien affiché")]
        public void ThenTousLesPavesSontBienAffiche()
        {
            Thread.Sleep(10000);
            Assert.IsTrue(accueil.DocumentsRècentsdisplayed().Equals(true));
            Assert.IsTrue(accueil.RequêteMesDélaisprocéduredisplayed().Equals(true));
            Assert.IsTrue(accueil.RequêteDossiersResponsabledisplayed().Equals(true));
            Assert.IsTrue(accueil.Réceptacledisplayed().Equals(true));
            Assert.IsTrue(accueil.DossiersAnnéedisplayed().Equals(true));
        }

        [When(@"Glisser Créer nouveau pavé de requête dans le premier pavé")]
        public void WhenGlisserCreerNouveauPaveDeRequeteDansLePremierPave()
        {
            Thread.Sleep(8000);
            accueil.dragDropCréerNouveauPavé();
        }

        [When(@"Cliquer sur le bouton \+")]
        public void WhenCliquerSurLeBouton()
        {
            Thread.Sleep(5000);
            accueil.NouveauPavéButtonClick();
        }

        [When(@"Sélectionner Détails de la liste")]
        public void WhenSelectionnerDetailsDeLaListe()
        {
            Thread.Sleep(5000);
            accueil.NouveauPavéListClick();

            Thread.Sleep(5000);
            accueil.DélaisClick();
        }

        [When(@"Cliquer sur icone recherche")]
        public void WhenCliquerSurIconeRecherche()
        {
            Thread.Sleep(5000);
            accueil.RechercheButtonClick();
        }

        [When(@"Cliquer sur Type d’échéance")]
        public void WhenCliquerSurTypeDEcheance()
        {
            Thread.Sleep(5000);
            accueil.TypeEchéanceClick();
        }

        [When(@"Cliquer sur dans")]
        public void WhenCliquerSurDans()
        {
            Thread.Sleep(5000);
            accueil.DansClick();
        }

        [When(@"Cliquer sur Client")]
        public void WhenCliquerSurClient()
        {
            Thread.Sleep(5000);
            accueil.ClientActionClick();
        }

        [When(@"Cliquer sur facturation")]
        public void WhenCliquerSurFacturation()
        {
            Thread.Sleep(5000);
            accueil.FacturationActionClick();
        }

        [When(@"Cliquer sur Interne")]
        public void WhenCliquerSurInterne()
        {
            Thread.Sleep(5000);
            accueil.InterneActionClick();
        }

        [When(@"Cliquer sur Officiel")]
        public void WhenCliquerSurOfficiel()
        {
            Thread.Sleep(5000);
            accueil.OfficielActionClick();
        }

        [When(@"Clicher sur Eléments")]
        public void WhenClicherSurElements()
        {
            Thread.Sleep(5000);
            accueil.ElémentsClick();
        }

        [When(@"Cliquer sur Date de l'échéance")]
        public void WhenCliquerSurDateDeLEcheanc()
        {
            Thread.Sleep(5000);
            accueil.DateEchéanceClick();
        }

        [When(@"Cliquer sur ENTRE")]
        public void WhenCliquerSurENTRE()
        {
            Thread.Sleep(5000);
            accueil.EntreClick();
        }

        [When(@"Cliquer sur Date relative")]
        public void WhenCliquerSurDateRelative()
        {
            Thread.Sleep(5000);
            accueil.DateRelativeClick();
        }

        [When(@"Saisir '(.*)' dans le champ Année")]
        public void WhenSaisirDansLeChampAnnee(string année)
        {
            Thread.Sleep(5000);
            accueil.AnnéeSendKeys(année);
        }

        [When(@"Cliquer sur le bouton Valider du popup Moteur de recherche")]
        public void WhenCliquerSurLeBoutonValiderDuPopupMoteurDeRecherche()
        {
            Thread.Sleep(5000);
            accueil.ValiderButtonClick();       
        }


        [When(@"Saisir '(.*)' dans Année")]
        public void WhenSaisirDansAnnee(string année)
        {
            Thread.Sleep(5000);
            accueil.Année2SendKeys(année);
        }


        [When(@"Cliquer sur Responsable de l’étape")]
        public void WhenCliquerSurResponsableDeLEtape()
        {
            Thread.Sleep(5000);
            accueil.ResponsableEtapeClick();
        }

        [When(@"Cliquer sur égal à")]
        public void WhenCliquerSurEgalA()
        {
            Thread.Sleep(5000);
            accueil.EgaleClick();
        }

        [When(@"Saisir '(.*)' dans le champ Initiales de la Personne")]
        public void WhenSaisirDansLeChampInitialesDeLaPersonne(string initialesPersonne)
        {
            Thread.Sleep(5000);
            accueil.InitialesPersonneSendKeys(initialesPersonne);
        }

        [When(@"Cliquer sur Sauvegarder la requête")]
        public void WhenCliquerSurSauvegarderLaRequete()
        {
            Thread.Sleep(5000);
            accueil.SauvegarderRequêteClick();
        }

        [When(@"Saisir '(.*)' dans le champ Libellé court du popup Sauvegarder la requête")]
        public void WhenSaisirDansLeChampLibelleCourtDuPopupSauvegarderLaRequete(string libellé)
        {
            Thread.Sleep(8000);
            accueil.LibelléRequêteSendKeys(libellé);

        }

        [When(@"Cliquer sur Sauvegarder")]
        public void WhenCliquerSurSauvegarder()
        {
            Thread.Sleep(5000);
            accueil.SauvegarderClick();
        }

        [When(@"Valider la requête")]
        public void WhenValiderLaRequete()
        {
            Thread.Sleep(8000);
            accueil.ValiderRequêteClick();
        }

        [Then(@"Le nouveau pavé apparait sur la page d’accueil")]
        public void ThenLeNouveauPaveApparaitSurLaPageDAccueil()
        {
            Thread.Sleep(8000);
            Assert.IsTrue(accueil.Délaisdisplayed().Equals(true));
        }

    }
}
