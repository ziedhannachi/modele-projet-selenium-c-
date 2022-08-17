using MAT1.PageObjects.Tarifs;
using MAT1.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MAT1.StepDefinitions.GestionTarifs
{
    [Binding]
    public class GestionTarifsSteps
    {
        private IWebDriver driver;


        static CommonMethod comM;
        static GestionTarifsObjects tarif;
        static string date_Depot;
        static string valorisationDepot;
        static AssertHelper asserthelper;

        public GestionTarifsSteps(IWebDriver _driver)
        {
            driver = _driver;
            comM = new CommonMethod(driver);
            tarif = new GestionTarifsObjects(driver);
            asserthelper = new AssertHelper(driver);
        }

        [Given(@"Cliquer sur l’onglet Finances")]
        public void GivenCliquerSurLOngletFinances()
        {
            Thread.Sleep(5000);
            tarif.FinancesLinkClick();
        }
        
        [When(@"Cliquer sur l'onglet Tarifs")]
        public void WhenCliquerSurLOngletTarifs()
        {
            Thread.Sleep(5000);
            tarif.TarifsClick();
        }
        
        [When(@"Cliquer sur Nouveau")]
        public void WhenCliquerSurNouveau()
        {
            Thread.Sleep(5000);
            tarif.NouveauLinkClick();
        }
        
        [When(@"Cliquer dans le champ Code")]
        public void WhenCliquerDansLeChampCode()
        {
            Thread.Sleep(8000);
            tarif.CodeInputClick();
        }
        
        [When(@"Saisir '(.*)' dans le champ code")]
        public void WhenSaisirDansLeChampCode(string code)
        {
            Thread.Sleep(5000);
            tarif.CodeLibelléParamétrageSendKeys(code);

        }
        
        [When(@"Saisir '(.*)' dans le champ libellé court")]
        public void WhenSaisirDansLeChampLibelleCourt(string libelléCourt)
        {
            Thread.Sleep(2000);
            tarif.LibelléCourtLibelléParamétrageClick();

            Thread.Sleep(2000);
            tarif.ClickOKAlert();

            Thread.Sleep(2000);
            tarif.LibelléCourtLibelléParamétrageClear();

            Thread.Sleep(5000);
            tarif.LibelléCourtLibelléParamétrageSendKeys(libelléCourt);

        }
        
        [When(@"Saisir '(.*)' dans le champ libellé long")]
        public void WhenSaisirDansLeChampLibelleLong(string libelléLong)
        {
            Thread.Sleep(2000);
            tarif.LibelléLongLibelléParamétrageClick();

            Thread.Sleep(2000);
            tarif.LibelléLongLibelléParamétrageSendKeys(libelléLong);

        }
        
        [When(@"Cliquer sur le bouton Valider du popup Edition")]
        public void WhenCliquerSurLeBoutonValiderDuPopupEditionDuLibelleParametrage()
        {
            Thread.Sleep(2000);
            tarif.ValiderlibelléParamétrageClick();
        }
        
        [When(@"Cliquer sur le chmp libellé \(utilisateur\)")]
        public void WhenCliquerSurLeChmpLibelleUtilisateur()
        {
            Thread.Sleep(5000);
            tarif.LibelléUtilisateursClick();
        }
        
        [When(@"Sélectionner '(.*)' dans la liste pays")]
        public void WhenSelectionnerDansLaListePays(string p0)
        {
            Thread.Sleep(5000);
            tarif.PaysClick();

            Thread.Sleep(5000);
            tarif.PaysFranceClick();
        }
        
        [When(@"Sélectionner '(.*)'  dans la liste objet du Tarif")]
        public void WhenSelectionnerDansLaListeObjetDuTarif(string p0)
        {
            Thread.Sleep(5000);
            tarif.ObjetTarifListClick();

            Thread.Sleep(2000);
            tarif.BrevetsClick();
        }
        
        [When(@"Sélectionner '(.*)' dans la liste Mode de répartition")]
        public void WhenSelectionnerDansLaListeModeDeRepartition(string p0)
        {
            Thread.Sleep(5000);
            tarif.ModeRépartitionListClick();

            Thread.Sleep(3000);
            tarif.SelectModeRépartitionClick();
        }
        
        [When(@"Cliquer sur le champ Barème")]
        public void WhenCliquerSurLeChampBareme()
        {
            Thread.Sleep(5000);
            tarif.BarèmeInputClick();
        }
        
        [When(@"Saisir '(.*)' dans le champ code du popup barème")]
        public void WhenSaisirDansLeChampCodeDuPopupBareme(string code)
        {
            Thread.Sleep(5000);
            tarif.BarèmeCodeSendKeys(code);
        }
        
        [When(@"Cliquer sur le bouton valider du popup barème")]
        public void WhenCliquerSurLeBoutonValiderDuPopupBareme()
        {
            Thread.Sleep(5000);
            tarif.BarèmeValiderButtonClick();
        }
        
        [When(@"Sélectionner le checkbox Taxes")]
        public void WhenSelectionnerLeCheckboxTaxes()
        {
            Thread.Sleep(5000);
            tarif.TaxesCheckboxClick();
        }
        
        [When(@"Saisir '(.*)' dans le champ Initialiser à du taxes")]
        public void WhenSaisirDansLeChampInitialiserADuTaxes(string taxe)
        {
            Thread.Sleep(5000);
            tarif.TaxeInputSendKeys(taxe);
        }
        
        [When(@"Saisir '(.*)' dans le champ Initialiser à du Honoraires")]
        public void WhenSaisirDansLeChampInitialiserADuHonoraires(string honoraire)
        {
            Thread.Sleep(5000);
            tarif.HonoraireInputSendKeys(honoraire);
        }
        
        [When(@"Cliquer sur le bouton valider du popup nouveau tarif")]
        public void WhenCliquerSurLeBoutonValiderDuPopupNouveauTarif()
        {
            Thread.Sleep(5000);
            tarif.NouveauTarifValidationButtonClick();
        }

        [Then(@"'(.*)' est affiché dans le champ code")]
        public void ThenEstAfficheDansLeChampCode(string code)
        {
            Thread.Sleep(8000);
            Assert.IsTrue(tarif.CodeDisplayedText().Equals(code));
        }

        [Then(@"'(.*)' est affiché dans le champ libellé")]
        public void ThenEstAfficheDansLeChampLibelle(string libellé)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(tarif.LibelléDisplayedText().Equals(libellé));
        }

        [Then(@"'(.*)' est affiché dans le champ libellé \(Utilisateurs\)")]
        public void ThenEstAfficheDansLeChampLibelleUtilisateurs(string LibelléUtil)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(tarif.LibelléUtilisateursDisplayedText().Equals(LibelléUtil));
        }

        [Then(@"'(.*)' est affiché dans le champ pays")]
        public void ThenEstAfficheDansLeChampPays(string pays)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(tarif.PaysDisplayedText().Equals(pays));
        }

        [Then(@"'(.*)' est affiché dans le champ barème")]
        public void ThenEstAfficheDansLeChampBareme(string barème)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(tarif.BarèmeDisplayedText().Equals(barème));
        }

        [When(@"Cliquer sur le champ Honoraires de la ligne Petite Entité")]
        public void WhenCliquerSurLeChampHonorairesDeLaLignePetiteEntite()
        {
            Thread.Sleep(2000);
            tarif.HonoraireClick("Petite Entité");
        }

        [When(@"Saisir '(.*)' dans le champ Honoraires")]
        public void WhenSaisirDansLeChampHonoraires(string honoraire)
        {
            Thread.Sleep(2000);
            tarif.HonoraireSendKeys(honoraire);
        }

        [When(@"Cliquer sur le bouton sauvegarder")]
        public void WhenCliquerSurLeBoutonSauvegarder()
        {
            Thread.Sleep(2000);
            tarif.SauvegarderIconClick();
        }

        [When(@"Cliquer sur le champ Honoraires de la ligne Grande Entité")]
        public void WhenCliquerSurLeChampHonorairesDeLaLigneGrandeEntite()
        {
            Thread.Sleep(2000);
            tarif.HonoraireClick("Grande Entité");
        }

        [When(@"Cliquer sur le champ Honoraires de la ligne Individu")]
        public void WhenCliquerSurLeChampHonorairesDeLaLigneIndividu()
        {
            Thread.Sleep(2000);
            tarif.HonoraireClick("Individu");
        }

        [When(@"Cliquer sur le bouton Option de la barre d’outils")]
        public void WhenCliquerSurLeBoutonOptionDeLaBarreDOutils()
        {
            Thread.Sleep(2000);
            tarif.OptionClick();
        }

        [When(@"Cliquer sur le bouton Ajouter une colonne")]
        public void WhenCliquerSurLeBoutonAjouterUneColonne()
        {
            Thread.Sleep(10000);
            tarif.AjouterColonneClick();
        }

        [When(@"Sélectionner la colonne Frais")]
        public void WhenSelectionnerLaColonneFrais()
        {
            Thread.Sleep(5000);
            tarif.ColonneSelectClick();

            Thread.Sleep(2000);
            tarif.ColonneFraisClick();
        }

        [When(@"Cliquer sur le bouton Valider du popup options")]
        public void WhenCliquerSurLeBoutonValiderDuPopupOptions()
        {
            Thread.Sleep(2000);
            tarif.ValiderOptionButtonClick();
        }

        [When(@"Cliquer sur l'onglet Mise à jour du tarif")]
        public void WhenCliquerSurLOngletMiseAJourDuTarif()
        {
            Thread.Sleep(5000);
            tarif.MiseAJourTarifClick();
        }

        [When(@"Cocher la colonne Honoraires")]
        public void WhenCocherLaColonneHonoraires()
        {
            Thread.Sleep(5000);
            tarif.HonoraireRadioButtonClick();
        }

        [When(@"Cocher la case Ajouter %")]
        public void WhenCocherLaCaseAjouter()
        {
            Thread.Sleep(5000);
            tarif.AjouterRadioButtonClick();
        }

        [When(@"Saisir '(.*)' dans le champ")]
        public void WhenSaisirDansLeChamp(string honoraire)
        {
            Thread.Sleep(5000);
            tarif.HonoraireMontantInputSendKeys(honoraire);
        }

        [When(@"Saisir '(.*)' dans le champ Entrée en vigueur")]
        public void WhenSaisirDansLeChampEntreeEnVigueur(string date)
        {
            Thread.Sleep(2000);
            tarif.EntréeEnVigueurDateSendKeys(date);
        }

        [When(@"Cliquer sur le bouton Valider de la parite mise à jour du tarif")]
        public void WhenCliquerSurLeBoutonValiderDeLaPariteMiseAJourDuTarif()
        {
            Thread.Sleep(2000);
            tarif.ValiderButtonClick();
        }

        [When(@"Cliquer sur le bouton Fermer")]
        public void WhenCliquerSurLeBoutonFermer()
        {
            Thread.Sleep(2000);
            tarif.FermerButtonClick();
        }

        [Then(@"La colonne Frais est affichée")]
        public void ThenLaColonneFraisEstAffichee()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(tarif.FraisColonneDisplayed().Equals(true));
        }

        [When(@"Sélectionner A partir du (.*)/(.*) à partir de la liste de la colonne barème")]
        public void WhenSelectionnerAPartirDuAPartirDeLaListeDeLaColonneBareme(string p0, int p1)
        {
            Thread.Sleep(2000);
            tarif.BarèmeListClick();

            Thread.Sleep(2000);
            tarif.ElementListClick();
        }

        [Then(@"les montants de la colonne Honoraire ont changés")]
        public void ThenLesMontantsDeLaColonneHonoraireOntChanges()
        {
            Thread.Sleep(2000);
            
        }

        [When(@"Cliquer sur l’icône Nouveau tarif")]
        public void WhenCliquerSurLIconeNouveauTarif()
        {
            Thread.Sleep(10000);
            tarif.NouveauTarifClick();
        }

        [When(@"Saisir '(.*)' dans le premier champ tarif")]
        public void WhenSaisirDansLePremierChampTarif(string code)
        {
            Thread.Sleep(8000);
            tarif.TarifCodeInputSendKeys(code);
        }

        [When(@"Cliquer sur le bouton valider du popup")]
        public void WhenCliquerSurLeBoutonValiderDuPopup()
        {
            Thread.Sleep(5000);
            tarif.ValiderButtonNouveauTarifClick();
        }

        [Then(@"Le tarif apparait dans la valorisation en cours avec le libellé '(.*)'")]
        public void ThenLeTarifApparaitDansLaValorisationEnCoursAvecLeLibelle(string p0)
        {
            Thread.Sleep(5000);
            Assert.IsTrue(tarif.TarifLigneDisplayed().Equals(true));

        }


    }
}
