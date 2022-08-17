using MAT1.PageObjects.ValorisationDevisPages;
using MAT1.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MAT1.StepDefinitions.GestionValorisationDevis
{
    [Binding]
    public class ValorisationDevisSteps
    {

        private IWebDriver driver;


        static CommonMethod comM;
        static GestionValorisationDevisObjects valoDev;
        static string date_Depot;
        static string valorisationDepot;
        static AssertHelper asserthelper;
        static string documentName;
        static string facturation;

        public ValorisationDevisSteps(IWebDriver _driver)
        {
            driver = _driver;
            comM = new CommonMethod(driver);
            valoDev = new GestionValorisationDevisObjects(driver);
            asserthelper = new AssertHelper(driver);
        }

        [When(@"Cliquer sur Valorisation & Devis")]
        public void WhenCliquerSurValorisationDevis()
        {

            valoDev.ValorisationDevisClick();
        }
        
        [When(@"Cliquer sur Saisie des heures")]
        public void WhenCliquerSurSaisieDesHeures()
        {

            Thread.Sleep(3000);
            valoDev.SaisieDesHeuresClick();
        }
        
        [When(@"Cliquer sur le bouton Ajouter une ligne de temps passé")]
        public void WhenCliquerSurLeBoutonAjouterUneLigneDeTempsPasse()
        {
            valoDev.AjouterLigneClick();
        }
        
        [When(@"Saisir '(.*)' dans le champ Date")]
        public void WhenSaisirDansLeChampDate(string date)
        {
            Thread.Sleep(3000);
            valoDev.DateInputSendKeys(date);
        }
        
        [When(@"Saisir '(.*)' dans Référence")]
        public void WhenSaisirDansReference(string référence)
        {
            Thread.Sleep(3000);
            valoDev.RéférenceInputSendKeys(référence);
        }
        
        [When(@"Saisir '(.*)' dans Motif")]
        public void WhenSaisirDansMotif(string motif)
        {
            Thread.Sleep(3000);
            valoDev.MotifInputSendKeys(motif);
        }
        
        [When(@"Cliquer sur le champ Étape")]
        public void WhenCliquerSurLeChampEtape()
        {
            Thread.Sleep(3000);
            valoDev.EtapeClick();
        }
        
        [When(@"Sélectionner Afficher les étapes de la procédure")]
        public void WhenSelectionnerAfficherLesEtapesDeLaProcedure()
        {
            Thread.Sleep(8000);
            valoDev.EtapeProcedureClick();
        }
        
        [When(@"Lancer une étape Valorisation de dépôt")]
        public void WhenLancerUneEtapeValorisationDeDepot()
        {
            Thread.Sleep(5000);
            valoDev.LancerEtapeValorisation();
        }

        [When(@"Cliquer sur le bouton valider du popup éditer le dossier et l'étape")]
        public void WhenCliquerSurLeBoutonValiderDuPopupEditerLeDossierEtLEtape()
        {
            Thread.Sleep(5000);
            valoDev.ValiderButtonClick();
        }


        [When(@"Cliquer sur le champ Echelon")]
        public void WhenCliquerSurLeChampEchelon()
        {
            valoDev.EchelonInputClick();
        }
        
        [When(@"Sélectionner (.*)ème Echelon")]
        public void WhenSelectionnerEmeEchelon(int p0)
        {
            Thread.Sleep(5000);
            valoDev.Echelon3Click();
        }
        
        [When(@"Cliquer sur Valider du pop up Echelon du barème")]
        public void WhenCliquerSurValiderDuPopUpEchelonDuBareme()
        {
            Thread.Sleep(5000);
            valoDev.ValiderClick();
        }
        
        [When(@"Saisir '(.*)' h dans le champ Qté val")]
        public void WhenSaisirHDansLeChampQteVal(string heure)
        {
            Thread.Sleep(5000);
            valoDev.QtéValSendKeys(heure);
        }
        
        [When(@"Saisir '(.*)' h dans le champ Qté fac")]
        public void WhenSaisirHDansLeChampQteFac(string heure)
        {
            Thread.Sleep(5000);
            valoDev.QtéFacSendKeys(heure);
        }
        
        
        [When(@"Cliquer sur l'icone enregistrer")]
        public void WhenCliquerSurLIconeEnregistrer()
        {
            Thread.Sleep(5000);
            valoDev.SauvegarderClick();
        }
        
        [When(@"Selectionner Brevets dans la liste de recherche")]
        public void WhenSelectionnerBrevetsDansLaListeDeRecherche()
        {
            valoDev.DropDownClick();
            Thread.Sleep(4000);
            valoDev.TypeClick();
            Thread.Sleep(1000);
        }
        
        [Then(@"La ligne apparait en gras")]
        public void ThenLaLigneApparaitEnGras()
        {
            Thread.Sleep(5000);
            Assert.AreEqual(valoDev.BoldTextDisplayed(), "700");
        }
        
        [Then(@"la ligne d’heure apparait dans l’onglet Val/Fac")]
        public void ThenLaLigneDHeureApparaitDansLOngletValFac()
        {
            Thread.Sleep(5000);

        }

        [When(@"Cliquer Saisie des débours")]
        public void WhenCliquerSaisieDesDebours()
        {
            Thread.Sleep(10000);
            valoDev.SaisieDéboursClick();
        }

        [When(@"Saisir '(.*)' dans le champ Fournisseur")]
        public void WhenSaisirDansLeChampFournisseur(string fournisseur)
        {
            Thread.Sleep(5000);
            valoDev.FournisseurInputSendKeys(fournisseur);
        }

        [Then(@"Un message d'erreur est affiché")]
        public void ThenUnMessageDErreurEstAffiche()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(valoDev.NotificationText().Equals("Ce tiers ne peut être utilisé en tant que fournisseur"));
        }

        [Then(@"Un message informe que le tiers est reconnu est apparait")]
        public void ThenUnMessageInformeQueLeTiersEstReconnuEstApparait()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(valoDev.NotificationText().Equals("Tiers reconnu"));
        }

        [When(@"Cliquer sur Ajouter un débours")]
        public void WhenCliquerSurAjouterUnDebours()
        {
            Thread.Sleep(5000);
            valoDev.AjouterDéboursClick();
        }

        [When(@"Cliquer sur le bouton enregistrer")]
        public void WhenCliquerSurLeBoutonEnregistrer()
        {
            Thread.Sleep(5000);
            valoDev.EnregistrerDéboursClick();
        }

        [Then(@"Un pop up rouge d’avertissement d’erreur apparait")]
        public void ThenUnPopUpRougeDAvertissementDErreurApparait()
        {
            
        }

        [When(@"Saisir '(.*)' dans le champ Date de la facture")]
        public void WhenSaisirDansLeChampDateDeLaFacture(string date)
        {
            Thread.Sleep(5000);
            valoDev.DateFactureSendkeys(date);
        }

        [When(@"Saisir '(.*)' dans le champ N° facture")]
        public void WhenSaisirDansLeChampNFacture(string nFacture)
        {
            Thread.Sleep(5000);
            valoDev.NFactureSendKeys(nFacture);
        }

        [When(@"Saisir '(.*)' dans le champ Honoraires du tableau")]
        public void WhenSaisirDansLeChampHonorairesDuTableau(string honoraire)
        {
            Thread.Sleep(5000);
            valoDev.HonoraireInputSendKeys(honoraire);
        }

        [Then(@"Les champs Total HT, Total TTC et TVA sont remplis automatiquement")]
        public void ThenLesChampsTotalHTTotalTTCEtTVASontRemplisAutomatiquement()
        {
            Thread.Sleep(5000);
            Assert.IsFalse(valoDev.TotalTHText().Equals("0,00"));
            Assert.IsFalse(valoDev.TotalTTCText().Equals("0,00"));
            Assert.IsFalse(valoDev.TVAText().Equals("0,00"));
        }

        [Then(@"Les lignes ne sont plus en rouge")]
        public void ThenLesLignesNeSontPlusEnRouge()
        {
            
        }

        [When(@"Cliquer sur Document")]
        public void WhenCliquerSurDocument()
        {
            Thread.Sleep(5000);
            //valoDev.DocumentInputClick();
        }

        [When(@"Ajouter un document dans le champ Document")]
        public void WhenAjouterUnDocumentDansLeChampDocument()
        {
            Thread.Sleep(5000);

        }

        [When(@"Cliquer dans le champ Référence")]
        public void WhenCliquerDansLeChampReference()
        {
            Thread.Sleep(5000);
            valoDev.RéférenceClick();

            Thread.Sleep(5000);
            valoDev.RéférenceButtonClick();
        }

        [When(@"Saisir '(.*)' dans le champ Référence dossier")]
        public void WhenSaisirDansLeChampReferenceDossier(string référence)
        {
            Thread.Sleep(5000);
            valoDev.RéférenceDossierInputSendKeys(référence);
        }


        [Then(@"L'étape valorisation dépôt est affiché")]
        public void ThenLEtapeValorisationDepotEstAffiche()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(valoDev.Étapedisplayed().Equals(true));
            Assert.IsTrue(valoDev.Evénementdisplayed().Equals(true));
        }

        [Then(@"Le tableau Section est affiché avec toutes les informations")]
        public void ThenLeTableauSectionEstAfficheAvecToutesLesInformations()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(valoDev.FiltreEvénementsdisplayed().Equals(true));
            Assert.IsTrue(valoDev.Déboursdisplayed().Equals(true));
            Assert.IsTrue(valoDev.EtatValorisationdisplayed().Equals(true));
        }

        [Then(@"'(.*)' est affiché dans le champ")]
        public void ThenEstAfficheDansLeChamp(string belin)
        {
            Thread.Sleep(5000);
            Assert.IsTrue(valoDev.BelinInputText().Equals(belin));
        }

        [Then(@"'(.*)' est affiché dans le champ société")]
        public void ThenEstAfficheDansLeChampSociete(string société)
        {
            Thread.Sleep(5000);
            Assert.IsTrue(valoDev.SociétéInputText().Equals(société));
        }

        [When(@"Cliquer sur le bouton Valider et Sauvegarder")]
        public void WhenCliquerSurLeBoutonValiderEtSauvegarder()
        {
            Thread.Sleep(5000);
            valoDev.ValiderEtSauvegarderClick();
        }

        [When(@"Cliquer sur le bouton tout à gauche du tableau")]
        public void WhenCliquerSurLeBoutonToutAGaucheDuTableau()
        {
            Thread.Sleep(8000);
            valoDev.DétailsClick();
        }


        [Then(@"'(.*)' est affiché pour Date de valorisation")]
        public void ThenEstAffichePourDateDeValorisation(string date)
        {
            Thread.Sleep(5000);
            Assert.IsTrue(valoDev.DateValorisationText().Contains(date));
        }

        [Then(@"'(.*)' est affiché pour Référence")]
        public void ThenEstAffichePourReference(string référence)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(valoDev.RéférenceDisplayedText().Contains(référence));
        }

        [Then(@"'(.*)' est affiché pour Titre")]
        public void ThenEstAffichePourTitre(string titre)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(valoDev.TitreDisplayedText().Contains(titre));
        }

        [Then(@"'(.*)' est affiché pour Étape")]
        public void ThenEstAffichePourEtape(string étape)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(valoDev.EtapeDisplayedText().Contains(étape));
        }

        [Then(@"'(.*)' est affiché pour Honoraires")]
        public void ThenEstAffichePourHonoraires(string honoraire)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(valoDev.HonoraireDisplayedText().Contains(honoraire));
        }

        [Then(@"'(.*)' est affiché pour Tiers")]
        public void ThenEstAffichePourTiers(string tiers)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(valoDev.TiersDisplayedText().Contains(tiers));
        }

        [Then(@"la ligne du tableau est affiché avec la couleur rouge")]
        public void ThenLaLigneDuTableauEstAfficheAvecLaCouleurRouge()
        {
            Assert.IsTrue(valoDev.honoraireDisplayed().Equals("#=OnError ? "));
        }

        [Then(@"Deux messages d'erreur sont affichés")]
        public void ThenDeuxMessagesDErreurSontAffiches()
        {
            Thread.Sleep(3000);
            Assert.IsTrue(valoDev.NotificationText().Equals("Erreurs détectées dans la grille de ventilation du débours  / Responsable manquant"));
        }

        [When(@"Cliquer sur le bouton \+ pour ajouter un détail")]
        public void WhenCliquerSurLeBoutonPourAjouterUnDetail()
        {
            Thread.Sleep(5000);
            valoDev.AjouterDtailClick();
        }

        [Then(@"Une nouvelle sous ligne apparait et '(.*)' est affiché dans la colonne Honoraire")]
        public void ThenUneNouvelleSousLigneApparaitEtEstAfficheDansLaColonneHonoraire(int p0)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(valoDev.CoefInputDisplayed().Equals(true));
        }

        [When(@"Saisir '(.*)' dans le champ Référence de la ligne ajoutée")]
        public void WhenSaisirDansLeChampReferenceDeLaLigneAjoutee(string p0)
        {
            
        }

        [When(@"Cliquer sur Afficher les étapes disponibles")]
        public void WhenCliquerSurAfficherLesEtapesDisponibles()
        {
            
        }

        [When(@"Lancer une valorisation dépôt")]
        public void WhenLancerUneValorisationDepot()
        {
            
        }

        [When(@"Cliquer sur le bouton Valider du pop up")]
        public void WhenCliquerSurLeBoutonValiderDuPopUp()
        {
            
        }


    }
}
