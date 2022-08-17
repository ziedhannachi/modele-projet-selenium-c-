using MAT1.Utils;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using MAT1.PageObjects.Dossiers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MAT1.StepDefinitions.GestionDossiers
{
    [Binding]
    public class GestionDossiersBrevetsSteps
    {
        private IWebDriver driver;


        static CommonMethod comM;
        static GestionDossiersObjects dossier;
        static string date_Depot;
        static string valorisationDepot;
        static AssertHelper asserthelper;
        static string documentName;
        static string facturation;

        public GestionDossiersBrevetsSteps(IWebDriver _driver)
        {
            driver = _driver;
            comM = new CommonMethod(driver);
            dossier = new GestionDossiersObjects(driver);
            asserthelper = new AssertHelper(driver);
        }

        [Given(@"Cliquer dans l’onglet Dossiers")]
        public void GivenCliquerDansLOngletDossiers()
        {
            Thread.Sleep(4000);

            dossier.DossiersLinkClick();
        }

        [Given(@"Cliquer sur dossier Breverts")]
        public void GivenCliquerSurDossierBreverts()
        {
            Thread.Sleep(3000);
            dossier.BrevetsClick();
        }

        [When(@"Sélectionner Brevet français d’origine française dans le champ Prestation")]
        public void WhenSelectionnerBrevetFrancaisDOrigineFrancaiseDnaLeChampPrestation()
        {
            Thread.Sleep(8000);
            dossier.PréstationListClick();

            Thread.Sleep(3000);
            dossier.BrevetFrançaisOrigineFrançaiseClick();
        }

        [When(@"Désélectionné le checkBox Numéro automatique")]
        public void WhenDeselectionneLeCheckBoxNumeroAutomatique()
        {
            Thread.Sleep(5000);
            dossier.NuméroAutomatiqueCheckBoxClick();
        }

        [When(@"Saisir '(.*)' dans le champ Référence")]
        public void WhenSaisirDansLeChampReference(string référence)
        {
            dossier.RéférenceSendKeys(référence);
        }
          
        [When(@"Cliquer sur Suivant du popup")]
        public void WhenCliquerSurSuivantDuPopup()
        {
            Thread.Sleep(5000);
            dossier.SuivantButtonClick();
        }

        [When(@"Cliquer sur Titre abrégé de la ligne créée")]
        public void WhenCliquerSurTitreAbregeDeLaLigneCreee()
        {
            Thread.Sleep(8000);
            dossier.TitreAbrégéClick();
        }

        [When(@"Saisir '(.*)'")]
        public void WhenSaisir(string titreAbrégé)
        {
            Thread.Sleep(2000);
            dossier.TitreAbrégéSendKeys(titreAbrégé);
        }

        [When(@"Cliquer sur Titre de la ligne créée")]
        public void WhenCliquerSurTitreDeLaLigneCreee()
        {
            Thread.Sleep(2000);
            dossier.TitleTextClick();
        }

        [When(@"Saisir '(.*)' dand le champ Titre")]
        public void WhenSaisirDandLeChampTitre(string titre)
        {
            Thread.Sleep(2000);
            dossier.TitleTextSendKeys(titre);
        }

        [When(@"Cliquer sur le bouton Ajouter un tiers Donneurs d'ordre")]
        public void WhenCliquerSurLeBoutonAjouterUnTiersDonneursDOrdre()
        {
            Thread.Sleep(8000);
            dossier.AjouterTiersDonneurOrdreClick();
        }

        [When(@"Saisir '(.*)' dans Nom abrégé")]
        public void WhenSaisirDansNomAbrege(string nomAbrégé)
        {
            Thread.Sleep(5000);
            dossier.NomAbrégéDonneurOrdreSendKeys(nomAbrégé);
        }

        [When(@"Cliquer sur le bouton Suivant")]
        public void WhenCliquerSurLeBoutonSuivant()
        {
            dossier.ClickSuivantButton();
            Thread.Sleep(5000);
            dossier.ClickOKAlert();
        }

        [When(@"Cliquer sur le bouton Ajouter un tiers inventeur")]
        public void WhenCliquerSurLeBoutonAjouterUnTiersInventeur()
        {
            dossier.AjouterTiersInventeurButton();
        }

        [When(@"Cliquer sur le bouton Terminer")]
        public void WhenCliquerSurLeBoutonTerminer()
        {
            Thread.Sleep(5000);
            dossier.TerminerButtonClick();
        }

        [Then(@"'(.*)' est affiché dans le champ Titre abrégé et '(.*)' est affiché dans le champ titre")]
        public void ThenEstAfficheDansLeChampTitreAbregeEtEstAfficheDansLeChampTitre(string TitreAbrégé, string Titre)
        {
            Thread.Sleep(10000);
            Assert.IsTrue(dossier.TitreAbrégéTextDisplayed().Equals(TitreAbrégé));
            Assert.IsTrue(dossier.TitreTextDisplayed().Equals(Titre));
            Thread.Sleep(5000);
        }

        [When(@"Cliquer sur Val/Fac")]
        public void WhenCliquerSurValFac()
        {
            Thread.Sleep(2000);
            dossier.Val_FacClick();
        }

        [Then(@"une notification est affiché")]
        public void ThenUneNotificationEstAffiche()
        {
            Thread.Sleep(6000);
            Console.WriteLine(dossier.NotificationDisplayedText());
            Assert.IsTrue(dossier.NotificationDisplayedText().Contains("BADOIT - Procédure de facturation"));
        }

        [Given(@"Cliquer La référence du dossier déjà créé")]
        public void GivenCliquerLaReferenceDuDossierDejaCree()
        {
            Thread.Sleep(5000);
            dossier.DossierRéférenceClick();
        }

        [When(@"Sélectionner le dossier '(.*)' à partir de la liste")]
        public void WhenSelectionnerLeDossierAPartirDeLaListe(string dossie)
        {
            Thread.Sleep(10000);
            dossier.DossierListClick(dossie);
        }

        [When(@"Cliquer sur Procédure")]
        public void WhenCliquerSurProcedure()
        {
            Thread.Sleep(8000);
            dossier.ProcédureClick();
        }

        [When(@"Cliquer sur le radio button Procédure")]
        public void WhenCliquerSurLeRadioButtonProcedure()
        {
            Thread.Sleep(5000);
            dossier.ProcedureCheckBoxClick();
        }

        [When(@"Cliquer sur DATE / N° DEPOT")]
        public void WhenCliquerSurDATENDEPOT()
        {
            Thread.Sleep(5000);
            dossier.DateNumDépotClick();
        }

        [When(@"Saisir la date '(.*)' dans le champ Date")]
        public void WhenSaisirLaDateDansLeChampDate(string Date)
        {
            Thread.Sleep(10000);
            dossier.DateInputSendKey(Date);
            date_Depot = dossier.Date_NDepotNumText();
        }

        [When(@"Saisir '(.*)' dans le champ numéro")]
        public void WhenSaisirDansLeChampNumero(string numéro)
        {
            Thread.Sleep(2000);
            dossier.NumeroInputSendKey(numéro);
        }

        [When(@"Cliquer sur le bouton Générer un nouveau document")]
        public void WhenCliquerSurLeBoutonGenererUnNouveauDocument()
        {
            Thread.Sleep(5000);
            dossier.GénéreeNouveauDocumentClick();
        }

        [When(@"Cliquer sur suivant")]
        public void WhenCliquerSurSuivant()
        {
            Thread.Sleep(7000);
            dossier.SuivantButClick();
        }

        [When(@"Cliquer sur Générer le document")]
        public void WhenCliquerSurGenererLeDocument()
        {
            Thread.Sleep(30000);
            dossier.GénérerDocumentClick();
        }

        [When(@"Cliquer sur icone document")]
        public void WhenCliquerSurIconeDocument()
        {
            Thread.Sleep(30000);
            dossier.DocumentIconClick();
        }

        [When(@"Cliquer sur le bouton Ouvrir Word")]
        public void WhenCliquerSurLeBoutonOuvrirWord()
        {
            Thread.Sleep(8000);
            dossier.OuvrirDocumentClick();
        }

        [When(@"Saisir le company login '(.*)'")]
        public void WhenSaisirLeCompanyLogin(string companyLogin)
        {
            Thread.Sleep(20000);
            dossier.CompanySendKeys(companyLogin);
        }

        [When(@"Saisir le username '(.*)'")]
        public void WhenSaisirLeUsername(string username)
        {
            Thread.Sleep(5000);
            dossier.UsernameSendKeys(username);
        }

        [When(@"Saisir le mot de passe '(.*)'")]
        public void WhenSaisirLeMotDePasse(string password)
        {
            Thread.Sleep(5000);
            dossier.PasswordSendKeys(password);
        }

        [When(@"cliquer sur le bouton Connexion")]
        public void WhenCliquerSurLeBoutonConnexion()
        {
            Thread.Sleep(5000);
            dossier.ConnexionClick();
            Thread.Sleep(8000);
        }


        [When(@"Cliquer sur Terminer")]
        public void WhenCliquerSurTerminer()
        {
            Thread.Sleep(20000);
            dossier.TerminerClick();
        }

        [When(@"Ajouter un document")]
        public void WhenAjouterUnDocument()
        {
            Thread.Sleep(5000);
            dossier.uploadfile();
            
        }

        [When(@"Saisir '(.*)' dans Nb mots de la description")]
        public void WhenSaisirDansNbMotsDeLaDescription(string NbMotsDescription)
        {
            Thread.Sleep(5000);
            dossier.InformationsGeneralesSendKeys(NbMotsDescription, "Nb mots de la description");
            
        }

        [When(@"Saisir '(.*)' dans Nb mots des revendications")]
        public void WhenSaisirDansNbMotsDesRevendications(string NbMotsRevendications)
        {
            Thread.Sleep(5000);
            dossier.InformationsGeneralesSendKeys(NbMotsRevendications, "Nb mots des revendications");
        }

        [When(@"Saisir '(.*)' dans Total de mots")]
        public void WhenSaisirDansTotalDeMots(string totalMots)
        {
            Thread.Sleep(5000);
            dossier.InformationsGeneralesSendKeys(totalMots, "Nombre de mots");
        }

        [When(@"Saisir '(.*)' dans Nb de pages")]
        public void WhenSaisirDansNbDePages(string NbPages)
        {
            Thread.Sleep(5000);
            dossier.InformationsGeneralesSendKeys(NbPages, "Nombre de pages");
        }

        [When(@"Saisir '(.*)' dans Nb de planches")]
        public void WhenSaisirDansNbDePlanches(string NbDePlanches)
        {
            Thread.Sleep(5000);
            dossier.InformationsGeneralesSendKeys(NbDePlanches, "Nombre de planches");
        }

        [When(@"Saisir '(.*)' dans Nb de revendications")]
        public void WhenSaisirDansNbDeRevendications(string NbDeRevendications)
        {
            Thread.Sleep(5000);
            dossier.InformationsGeneralesSendKeys(NbDeRevendications, "Nombre de revendications");
        }

        [When(@"Cliquer sur la liste Titre")]
        public void WhenCliquerSurLaListeTitre()
        {
            Thread.Sleep(5000);
            dossier.TitreListClick();
        }

        [When(@"Sélectionner le titre prérempli")]
        public void WhenSelectionnerLeTitrePrerempli()
        {
            Thread.Sleep(2000);
            dossier.TitrePrérempliClick();
        }

        [When(@"Cliquer sur Dossier")]
        public void WhenCliquerSurDossier()
        {
            Thread.Sleep(2000);
            dossier.DossierClick();

        }

        [Then(@"La date '(.*)' est affiché pour la date dépot")]
        public void ThenLaDateEstAffichePourLaDateDepot(string date)
        {
            Thread.Sleep(5000);
            Assert.IsTrue(dossier.DateDépôtText().Equals(date));
            Console.WriteLine(dossier.DateDépôtText());
        }

        [Then(@"Le numéro '(.*)' est affiché pour la date dépot")]
        public void ThenLeNumeroEstAffichePourLaDateDepot(string numéro)
        {
            Thread.Sleep(5000);
            Assert.IsTrue(dossier.NuméroDépôtText().Equals(numéro));
            Console.WriteLine(dossier.NuméroDépôtText());
        }

        [Then(@"'(.*)' est affiché pour Nb mots de la description")]
        public void ThenEstAffichePourNbMotsDeLaDescription(string NbMotsDeLaDescription)
        {
            Thread.Sleep(5000);
            Assert.IsTrue(dossier.ListeInfoInformationsGénérales("Nb mots de la description")[0].Contains(NbMotsDeLaDescription));
        }

        [Then(@"'(.*)' est affiché pour Nb mots des revendications")]
        public void ThenEstAffichePourNbMotsDesRevendications(string NbMotsDesRevendications)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.ListeInfoInformationsGénérales("Nb mots des revendications")[0].Contains(NbMotsDesRevendications));
        }

        [Then(@"'(.*)' est affiché pour Nombre de mots")]
        public void ThenEstAffichePourNombreDeMots(string NombreDeMots)
        {
            Assert.IsTrue(dossier.ListeInfoInformationsGénérales("Nombre de mots")[0].Contains(NombreDeMots));
        }

        [Then(@"'(.*)' est affiché pour Nombre de pages")]
        public void ThenEstAffichePourNombreDePages(string NombreDePages)
        {
            Assert.IsTrue(dossier.ListeInfoInformationsGénérales("Nombre de pages")[0].Contains(NombreDePages));
        }

        [Then(@"'(.*)' est affiché pour Nombre de planches")]
        public void ThenEstAffichePourNombreDePlanches(string NombreDePlanches)
        {
            Assert.IsTrue(dossier.ListeInfoInformationsGénérales("Nombre de planches")[0].Contains(NombreDePlanches));
        }

        [Then(@"'(.*)' est affiché pour Nombre de revendications")]
        public void ThenEstAffichePourNombreDeRevendications(string NombreDeRevendications)
        {
            Assert.IsTrue(dossier.ListeInfoInformationsGénérales("Nombre de revendications")[0].Contains(NombreDeRevendications));
        }

        [When(@"Cliquer sur Documents")]
        public void WhenCliquerSurDocuments()
        {
            Thread.Sleep(8000);
            dossier.DocumentsClick();
        }

        [When(@"Cliquer sur étape Procédure")]
        public void WhenCliquerSurEtapeProcedure()
        {
            Thread.Sleep(7000);
            dossier.DocumentsProcédureClick("Procédure");
        }

        [When(@"Cliquer sur étape Avis de dépôt")]
        public void WhenCliquerSurEtapeAvisDeDepot()
        {
            Thread.Sleep(7000);
            dossier.AvisDépôtEtapeClick();
        }

        [When(@"Cliquer sur l'étape DATE / N° DEPOT")]
        public void WhenCliquerSurLEtapeDATENDEPOT()
        {
            Thread.Sleep(2000);
            Console.WriteLine(date_Depot);
            dossier.Date_NDepotNumClick(date_Depot);
        }

        [When(@"Cliquer sur le document")]
        public void WhenCliquerSurLeDocument()
        {
            Thread.Sleep(2000);
            dossier.DocumentClick(date_Depot);
        }

        [Then(@"Le document est bien affiché")]
        public void ThenLeDocumentEstBienAffiche()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(dossier.DocumentDisplayedText().Contains(".doc"));
            Assert.IsTrue(dossier.documentDetailTypeText().Contains("Document Word"));
        }

        [When(@"Cliquer sur le bouton Générer le pdf")]
        public void WhenCliquerSurLeBoutonGenererLePdf()
        {
            Thread.Sleep(5000);
            dossier.GeneratePdfClick();
        }

        [When(@"Cliquer sur le document\tpdf")]
        public void WhenCliquerSurLeDocumentPdf()
        {
            Thread.Sleep(2000);
            dossier.DocumentPDFClick(date_Depot);
        }

        [Then(@"Le document pdf est bien généré")]
        public void ThenLeDocumentPdfEstBienGenere()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(dossier.documentDetailTypeText().Equals("Document Acrobat"));
        }

        [When(@"Cliquer su le radio button Historique")]
        public void WhenCliquerSuLeRadioButtonHistorique()
        {
            Thread.Sleep(5000);
            dossier.HistoriqueRadioButtonClick();
        }

        [When(@"Cliquer sur le Date/N° Depot")]
        public void WhenCliquerSurLeDateNDepot()
        {
            Thread.Sleep(15000);
            dossier.DateNDepotHistoriqueClick(date_Depot);
        }

        [Then(@"Les informations de l'étape DATE/ DEPOT sont affichées")]
        public void ThenLesInformationsDeLEtapeDATEDEPOTSontAffichees()
        {
            Thread.Sleep(8000);
            Assert.IsTrue(dossier.HistoriqueTypeDis().Equals(true));
            Assert.IsTrue(dossier.HistoriqueNuméroDis().Equals(true));
            Assert.IsTrue(dossier.HistoriqueDateDis().Equals(true));
            Assert.IsTrue(dossier.HistoriquePaysDis().Equals(true));
        }

        [When(@"Cliquer sur Valorisation DEPOT")]
        public void WhenCliquerSurValorisationDEPOT()
        {
            Thread.Sleep(10000);
            dossier.ValorisationDEPOTEtapeClick();
        }

        [When(@"récupéré le numéro de la valorisation dépôt")]
        public void WhenRecupereLeNumeroDeLaValorisationDepot()
        {
            Thread.Sleep(8000);
            valorisationDepot = dossier.ValorisationDepotIdValue();
            Console.WriteLine(valorisationDepot);
        }


        [Then(@"L onglé procédure reste affiché")]
        public void ThenLOngleProcedureResteAffiche()
        {
            Thread.Sleep(8000);
             Assert.IsTrue(dossier.Procédureactive().Contains("state-active"));
        }

        [Then(@"Le radio button En cours est coché")]
        public void ThenLeRadioButtonEnCoursEstCoche()
        {
            Thread.Sleep(8000);
            Assert.IsTrue(dossier.EnCoursRadioButtonSelected().Equals("true"));
        }

        [Then(@"Un délai de type facturation est affiché")]
        public void ThenUnDelaiDeTypeFacturationEstAffiche()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.ValorisationDEPOTEchéanceDisplayed().Equals(true));
        }

        [Then(@"Valorisation DEPOT En cours est affichée")]
        public void ThenValorisationDEPOTEnCoursEstAffichee()
        {
            Thread.Sleep(10000);
            Assert.IsTrue(dossier.valorisationDepotEncoursDisplayed(valorisationDepot).Equals(true));
        }

        [When(@"Cliquer sur Valorisation DEPOT créé")]
        public void WhenCliquerSurValorisationDEPOTCree()
        {
            dossier.valorisationDepotEncoursClick(valorisationDepot);
        }

        [Then(@"'(.*)' est le total affiché pour Dépôt en ligne")]
        public void ThenEstLeTotalAffichePourDepotEnLigne(string total)
        {
            Thread.Sleep(8000);
            Assert.IsTrue(dossier.TotalDépôtEnLigne().Equals(total));
        }

        [When(@"Cliquer sur l'état du libellé Envoi recommandé")]
        public void WhenCliquerSurLEtatDuLibelleEnvoiRecommande()
        {
            Thread.Sleep(2000);
            dossier.EnvoiRecommandéClick();
        }

        [When(@"Modifier l'état à non facturable")]
        public void WhenModifierLEtatANonFacturable()
        {
            Thread.Sleep(2000);
            dossier.NonFacturableClick();
        }

        [When(@"Cliquer sur le libellé Frais de photocopies")]
        public void WhenCliquerSurLeLibelleFraisDePhotocopies()
        {
            Thread.Sleep(2000);
            dossier.FraisPhotocopiesClick();
        }

        [When(@"Modifier le frais du libellé Frais de photocopies à '(.*)' EUR pour valorisation")]
        public void WhenModifierLeFraisDuLibelleFraisDePhotocopiesAEURPourValorisation(string qté)
        {
            Thread.Sleep(4000);
            dossier.QuantitéValClick();

            Thread.Sleep(2000);
            dossier.QuantitéValInputSendKeys(qté);
        }


        [When(@"Cliquer sur le checkBox Facturation")]
        public void WhenCliquerSurLeCheckBoxFacturation()
        {
            Thread.Sleep(5000);
            dossier.FacturationRadioButtonClick();
        }

        [When(@"Modifier le frais du libellé Frais de photocopies à '(.*)' EUR pour Facturation")]
        public void WhenModifierLeFraisDuLibelleFraisDePhotocopiesAEURPourFacturation(string qté)
        {
            Thread.Sleep(4000);
            dossier.QuantitéFactClick();

            Thread.Sleep(2000);
            dossier.QuantitéFactInputSendKeys(qté);        
        }

        [When(@"Cliquer sur bouton Sauvegarder")]
        public void WhenCliquerSurBoutonSauvegarder()
        {
            Thread.Sleep(5000);
            dossier.SauvegarderButtonClick();
        }


        [Then(@"La ligne Frais de photocopies du dépôt est en gras")]
        public void ThenLaLigneFraisDePhotocopiesDuDepotEstEnGras()
        {
            Thread.Sleep(5000);
            Assert.AreEqual(dossier.BoldText(), "700");

        }

        [When(@"Cliquer sur Nouveau tarif")]
        public void WhenCliquerSurNouveauTarif()
        {
            Thread.Sleep(5000);
            dossier.NouveauTarifClick();
        }

        [When(@"Saisir '(.*)' dans le champ tarif")]
        public void WhenSaisirDansLeChampTarif(string tarif)
        {
            Thread.Sleep(8000);
            dossier.TarifSendKeys(tarif);
        }

        [Then(@"Une nouvelle ligne avec le libellé ""(.*)"" est affiché")]
        public void ThenUneNouvelleLigneAvecLeLibelleEstAffiche(string p0)
        {
            Thread.Sleep(5000);
            Assert.IsTrue(dossier.FraisPhotocopiesDisplayed().Equals(true));
        }


        [When(@"Cliquer sur Valider")]
        public void WhenCliquerSurValider()
        {
            Thread.Sleep(2000);
            dossier.ValiderButtonClick();
        }


        [When(@"Cliquer sur le Export cognos")]
        public void WhenCliquerSurLeExportCognos()
        {
            Thread.Sleep(5000);
            dossier.ExportCongnosClick();
        }

        [When(@"Cliquer sur le bouton Télécharger le fichier")]
        public void WhenCliquerSurLeBoutonTelechargerLeFichier()
        {
            Thread.Sleep(8000);
            dossier.TélécharferFichierClick();
        }

        [Then(@"Le fichier doit être téléchargé")]
        public void ThenLeFichierDoitEtreTelecharge()
        {
            Thread.Sleep(30000);
            Assert.IsFalse(dossier.ExistFile().Equals(0));
            dossier.DeleteFile();
        }

        [Then(@"La ligne tarif Envoi recommandé doit être supprimé du tableau")]
        public void ThenLaLigneTarifEnvoiRecommandeDoitEtreSupprimeDuTableau()
        {
            Thread.Sleep(8000);
            asserthelper.AssertFail(dossier.TarifEnvoiRecommandéDisplayed(), 0);
            //Assert.IsTrue(dossier.TarifEnvoiRecommandéDisplayed().Equals(0));
        }

        [Then(@"L onglet Historique est affiché")]
        public void ThenLOngletHistoriqueEstAffiche()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(dossier.HistoriqueDisplayed().Equals(true));
        }

        [When(@"Cliquer sur onglet Historique")]
        public void WhenCliquerSurOngletHistorique()
        {
            Thread.Sleep(5000);
            dossier.HistoriqueClick();
        }

        [Then(@"La valorisation de dépôt est affiché")]
        public void ThenLaValorisationDeDepotEstAffiche()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(dossier.valorisationDepotHistoriqueDisplayed(valorisationDepot).Equals(true));
        }

        [When(@"Cliquer sur la valorisation dépôt")]
        public void WhenCliquerSurLaValorisationDepot()
        {
            Thread.Sleep(8000);
            dossier.valorisationDepotHistoriqueClick(valorisationDepot);
        }

        [Then(@"La ligne de tarif Envoi recommandé apparait dans le répertoire Historique à l’état Non facturable et grisée")]
        public void ThenLaLigneDeTarifEnvoiRecommandeApparaitDansLeRepertoireHistoriqueALEtatNonFacturableEtGrisee()
        {
            Thread.Sleep(8000);
            Assert.IsTrue(dossier.EnvoiRecommandéDisplayed().Equals(true));
        }

        [When(@"Cliquer sur Facturation")]
        public void WhenCliquerSurFacturation()
        {
            Thread.Sleep(8000);
            dossier.FacturationClick();
        }

        [When(@"Cocher la case Supprimer toutes les lignes de valorisation à l’état Incomplet")]
        public void WhenCocherLaCaseSupprimerToutesLesLignesDeValorisationALEtatIncomplet()
        {
            Thread.Sleep(8000);
            dossier.CheckBoxSupprimerLignesClick();
        }

        [When(@"Cliquer sur le bouton Facturation")]
        public void WhenCliquerSurLeBoutonFacturation()
        {
            Thread.Sleep(2000);
            dossier.FacturationButtonClick();

            Thread.Sleep(8000);

            Console.WriteLine(dossier.idFactorisation());

            facturation = dossier.idFactorisation();
        }

        [Then(@"Les lignes de valorisation sont affichées")]
        public void ThenLesLignesDeValorisationSontAffichees()
        {
            Thread.Sleep(8000);
            Assert.IsTrue(dossier.ValorisationLigneDisplayed("Frais de photocopies").Equals(1));
            Assert.IsTrue(dossier.ValorisationLigneDisplayed("Dépôt de la demande de brevet").Equals(1));
            Assert.IsTrue(dossier.ValorisationLigneDisplayed("Temps ingénieur").Equals(1));
            Assert.IsTrue(dossier.ValorisationLigneDisplayed("Dépôt en ligne").Equals(1));
            Assert.IsTrue(dossier.ValorisationLigneDisplayed("Constitution de mandataire").Equals(1));
            Assert.IsTrue(dossier.ValorisationLigneDisplayed("Forfait administratif du dépôt d'une demande de brevet").Equals(1));
        }

        [Then(@"Le répertoire Facture est créé")]
        public void ThenLeRepertoireFactureEstCree()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.repertoireFactureDisplayed().Equals(true));
        }

        [Then(@"Le répertoire Procédure est créé")]
        public void ThenLeRepertoireProcedureEstCree()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.repertoireFactureDisplayed().Equals(true));
        }

        [Then(@"Une facture est créée")]
        public void ThenUneFactureEstCreee()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.FactureDisplayed(facturation).Equals(true));
        }

        [When(@"Cliquer sur le projet de facture")]
        public void WhenCliquerSurLeProjetDeFacture()
        {
            Thread.Sleep(2000);
            dossier.FactureClick(facturation);
        }

        [Then(@"le montant des taxes est de '(.*)'")]
        public void ThenLeMontantDesTaxesEstDe(string taxe)
        {
            Thread.Sleep(5000);
            Assert.IsTrue(dossier.Taxes().Contains(taxe));
        }

        [When(@"Cliquer sur numérotationFacture")]
        public void WhenCliquerSurNumerotationFacture()
        {
            Thread.Sleep(5000);
            dossier.NumérotationFactureClick();
        }

        [When(@"Modifier la date la numérotation de la facture par la date de la veille")]
        public void WhenModifierLaDateLaNumerotationDeLaFactureParLaDateDeLaVeille()
        {
            Thread.Sleep(3000);
            dossier.NumérotationFactureDateSendKey();
        }

        [When(@"Cliquer sur le bouton valider")]
        public void WhenCliquerSurLeBoutonValider()
        {
            Thread.Sleep(3000);
            dossier.NumérotationValiderClick();
        }

        [Then(@"Le projet de facture est transformé en Facture et est numéroté")]
        public void ThenLeProjetDeFactureEstTransformeEnFactureEtEstNumerote()
        {
            Thread.Sleep(8000);
            Assert.IsFalse(dossier.FactureTitleText().Contains("(Projet)"));
        }

        [Then(@"La date de la facture correspond à la date renseignée précédemment")]
        public void ThenLaDateDeLaFactureCorrespondALaDateRenseigneePrecedemment()
        {
            Thread.Sleep(3000);            
            Assert.IsTrue(dossier.DateTextDisplayed().Equals(0));
        }

        [When(@"Cliquer sur Crédit depuis la barre d’outils de la facture numérotée")]
        public void WhenCliquerSurCreditDepuisLaBarreDOutilsDeLaFactureNumerotee()
        {
            Thread.Sleep(3000);
            dossier.CréditClick();
        }

        [When(@"Cliquer sur OK pour valider la création du projet")]
        public void WhenCliquerSurOKPourValiderLaCreationDuProjet()
        {
            Thread.Sleep(3000);
            dossier.ClickOKAlert();
        }

        [Then(@"Une ligne de projet d’avoir est apparue")]
        public void ThenUneLigneDeProjetDAvoirEstApparue()
        {
            Thread.Sleep(8000);
            Assert.IsTrue(dossier.AvoirsurFactureDisplayed().Equals(true));
        }

        [Then(@"Le projet d’avoir reprend les montants de la facture")]
        public void ThenLeProjetDAvoirReprendLesMontantsDeLaFacture()
        {
            Thread.Sleep(8000);
            Assert.IsTrue(dossier.TaxeDisplayed().Contains("2 825,00"));
            Assert.IsTrue(dossier.FraisHonDisplayed().Contains("3 883,00"));
        }

        [Then(@"Les lignes de tarifs issues de la facture créditée sont affichées à l’état facturable")]
        public void ThenLesLignesDeTarifsIssuesDeLaFactureCrediteeSontAfficheesALEtatFacturable()
        {
            Thread.Sleep(3000);
            Assert.IsTrue(dossier.ListEtatValorisationResult().Equals(0));
        }

        [Given(@"Selectionner Brevets dans la liste de recherche")]
        public void GivenSelectionnerBrevetsDansLaListeDeRecherche()
        {
            dossier.DropDownClick();
            Thread.Sleep(4000);
            dossier.TypeClick();
            Thread.Sleep(1000);
        }

        [When(@"Cliquer sur \+ associé au libellé Débours")]
        public void WhenCliquerSurAssocieAuLibelleDebours()
        {
            Thread.Sleep(8000);
            dossier.AddClick();
        }

        [When(@"Saisir '(.*)' dans le champ N° Facture")]
        public void WhenSaisirDansLeChampNFacture(string nFacture)
        {
            Thread.Sleep(10000);
            dossier.NFactureSendKeys(nFacture);
        }

        [When(@"Saisir '(.*)' dans le champ date facture")]
        public void WhenSaisirDansLeChampDateFacture(string date)
        {
            Thread.Sleep(3000);
            dossier.DateFactureSendKeys(date);
        }

        [When(@"Cliquer sur le champ document")]
        public void WhenCliquerSurLeChampDocument()
        {
            Thread.Sleep(3000);
            dossier.DocumentUploadClick();
        }

        [When(@"Ajouter un document du PC")]
        public void WhenAjouterUnDocumentDuPC()
        {
            Thread.Sleep(8000);
            dossier.Fileupload();
        }

        [When(@"Cliquer sur le bouton Ajouter le document au débours")]
        public void WhenCliquerSurLeBoutonAjouterLeDocumentAuDebours()
        {
            Thread.Sleep(8000);
            dossier.AjouterDocumentDéboursClick();
        }

        [Then(@"le nom du document apparait dans le champ associé à Document")]
        public void ThenLeNomDuDocumentApparaitDansLeChampAssocieADocument()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(dossier.DocumentText().Contains("Communication du dépôt au client"));
        }

        [When(@"Saisir '(.*)' dans le champ Débours")]
        public void WhenSaisirDansLeChampDebours(string débours)
        {
            Thread.Sleep(2000);
            dossier.DéboursSendKeys(débours);
        }

        [When(@"Saisir '(.*)' dans le champ Honoraire")]
        public void WhenSaisirDansLeChampHonoraire(string honoraire)
        {
            Thread.Sleep(2000);
            dossier.HonoraireSendKeys(honoraire);
        }

        [Then(@"Constater que le total TTC est '(.*)' et que la devise '(.*)'")]
        public void ThenConstaterQueLeTotalTTCEstEtQueLaDevise(string totalTTC, string devise)
        {
            Assert.IsTrue(dossier.TotalTTCText().Equals(totalTTC));
            Assert.IsTrue(dossier.DeviseText().Equals(devise));
        }

        [When(@"Cliquer sur le champ Etape")]
        public void WhenCliquerSurLeChampEtape()
        {
            Thread.Sleep(2000);
            dossier.EtapeClick();
        }

        [When(@"Cliquer sur le radio Button Afficher les étapes de la procédure")]
        public void WhenCliquerSurLeRadioButtonAfficherLesEtapesDeLaProcedure()
        {
            Thread.Sleep(2000);
            dossier.EtapesProcédureClick();
        }

        [When(@"Cliquer sur le libellé Avis de dépôts")]
        public void WhenCliquerSurLeLibelleAvisDeDepots()
        {
            Thread.Sleep(2000);
            dossier.EtapesProcédureAvisDepotClick();
        }

        [When(@"Lancer l’étape Valorisation de dépôt")]
        public void WhenLancerLEtapeValorisationDeDepot()
        {
            Thread.Sleep(2000);
            dossier.EtapesProcédureValorisationDepotClick();
        }

        [When(@"Cliquer sur le bouton Valider du popup")]
        public void WhenCliquerSurLeBoutonValiderDuPopup()
        {
            Thread.Sleep(5000);
            dossier.EditerEtapeValidationButtonClick();
        }

        [When(@"Cliquer sur le champ Intervenant")]
        public void WhenCliquerSurLeChampIntervenant()
        {
            Thread.Sleep(5000);
            dossier.IntervenantInputClick();
        }

        [When(@"Saisir '(.*)' dans le champ Initiales de la personne")]
        public void WhenSaisirDansLeChampInitialesDeLaPersonne(string InitialePersonne)
        {
            Thread.Sleep(5000);
            dossier.initialePersonneSendKeys(InitialePersonne);
        }

        [When(@"Cliquer sur Valider pour l'(.*)'intervenant")]
        public void WhenCliquerSurValiderPourLIntervenant(string p0)
        {
            Thread.Sleep(5000);
            dossier.ListeUtilisateurValidationButtonClick();
        }

        [When(@"Saisir '(.*)' dans le champ Motif")]
        public void WhenSaisirDansLeChampMotif(string motif)
        {
            Thread.Sleep(5000);
            dossier.MotifSendKeys(motif);
        }

        [When(@"Cliquer sur Valider du popup Debours")]
        public void WhenCliquerSurValiderDuPopupDebours()
        {
            Thread.Sleep(5000);
            dossier.DeboursValidationButtonClick();
        }

        [Then(@"'(.*)' est affiché dans la colonne Tiers")]
        public void ThenEstAfficheDansLaColonneTiers(string tiers)
        {
            Thread.Sleep(20000);
            Assert.IsTrue(dossier.ElémentDeboursTest("Tiers").Equals(tiers));
        }

        [Then(@"'(.*)' est affiché dans la colonne Date")]
        public void ThenEstAfficheDansLaColonneDate(string date)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.ElémentDeboursTest("Date").Equals(date));
        }

        [Then(@"'(.*)' est affiché dans la colonne Debours")]
        public void ThenEstAfficheDansLaColonneDebours(string debours)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.ElémentDeboursTest("Débours").Equals(debours));
        }

        [Then(@"'(.*)' est affiché dans la colonne Honoraires")]
        public void ThenEstAfficheDansLaColonneHonoraires(string honoraire)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.ElémentDeboursTest("Honoraires").Equals(honoraire));
        }

        [Then(@"'(.*)' est affiché dans la colonne Total")]
        public void ThenEstAfficheDansLaColonneTotal(string total)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.ElémentDeboursTest("Total").Equals(total));
        }

        [Then(@"'(.*)' est affiché dans la colonne Devise")]
        public void ThenEstAfficheDansLaColonneDevise(string devise)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.ElémentDeboursTest("Devise").Equals(devise));
        }

        [When(@"Accéder à la valorisation")]
        public void WhenAccederALaValorisation()
        {
            Thread.Sleep(5000);
            dossier.valorisationClick(valorisationDepot);
        }

        [When(@"Cliquer sur la ligne '(.*)'")]
        public void WhenCliquerSurLaLigne(string p0)
        {
            Thread.Sleep(10000);
            dossier.DéboursExternesClick();
        }

        [Then(@"'(.*)' est affiché dans la colonne Intervenant")]
        public void ThenEstAfficheDansLaColonneIntervenant(string intervenant)
        {
            Thread.Sleep(5000);
            Assert.IsTrue(dossier.IntervenantText().Equals(intervenant));
        }

        [Then(@"'(.*)' est affiché dans la colonne Etat")]
        public void ThenEstAfficheDansLaColonneEtat(string état)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.Etattext().Equals(état));
        }

        [Then(@"'(.*)' est affiché dans la colonne Débours")]
        public void ThenEstAfficheDansLaColonneDebour(string debours)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.DéboursText().Equals(debours));
        }

        [Then(@"'(.*)' est affiché dans la colonne Frais")]
        public void ThenEstAfficheDansLaColonneFrais(string frais)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.FraisTextDisplayed().Equals(frais));
        }

        [Then(@"'(.*)' est affiché pour la colonne Total")]
        public void ThenEstAffichePourLaColonneTotal(string total)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.TotalTextTextDisplayed().Equals(total));
        }

        [Then(@"'(.*)' est affiché dans le champ Intervenant")]
        public void ThenEstAfficheDansLeChampIntervenant(string intervenant)
        {
            Thread.Sleep(5000);
            Assert.IsTrue(dossier.IntervenantInputTextDisplayed().Contains(intervenant));
        }

        [Then(@"'(.*)' est affiché dans le champ Fournisseur")]
        public void ThenEstAfficheDansLeChampFournisseur(string fournisseur)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.FournisseurTextDisplayed().Equals(fournisseur));
        }

        [Then(@"'(.*)' est affiché dans le champ N° Facture")]
        public void ThenEstAfficheDansLeChampNFacture(string nFacture)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.NFactureTextDisplayed().Equals(nFacture));
        }

        [Then(@"'(.*)' est affiché dans le champ Date")]
        public void ThenEstAfficheDansLeChampDate(string date)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.DatetxtDisplayed().Equals(date));
        }

        [Then(@"'(.*)' est affiché pour total débours")]
        public void ThenEstAffichePourTotalDebours(string totalDebours)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.TotalDeboursDisplayed().Equals(totalDebours));
        }

        [Then(@"'(.*)' est affiché pour le total Frais")]
        public void ThenEstAffichePourLeTotalFrais(string frais)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.TotalFraisDisplayed().Equals(frais));
        }

        [Then(@"'(.*)' est affiché pour le total")]
        public void ThenEstAffichePourLeTotal(string total)
        {
            Thread.Sleep(2000);
            Assert.IsTrue(dossier.TotalDisplayed().Equals(total));
        }

        [When(@"Cliquer sur Divers")]
        public void WhenCliquerSurDivers()
        {
            Thread.Sleep(10000);
            dossier.DiversClick();
        }

        [Then(@"Le document ajouté est affiché")]
        public void ThenLeDocumentAjouteEstAffiche()
        {
            Thread.Sleep(8000);
            Assert.IsTrue(dossier.DiversDocDisplayed().Equals(true));
        }

        [When(@"Cliquer sur Dossiers")]
        public void WhenCliquerSurDossiers()
        {
            Thread.Sleep(8000);
            dossier.OngletDossiersClick();
        }

        [When(@"Cliquer sur le lien Ouvrir")]
        public void WhenCliquerSurLeLienOuvrir()
        {
            Thread.Sleep(5000);
            dossier.OuvrirLienClick();
        }

        [When(@"Cliquer sur Objet du dossier")]
        public void WhenCliquerSurObjetDuDossier()
        {
            Thread.Sleep(5000);
            dossier.ObjetDuDossierClick();
        }

        [When(@"Cliquer sur L'opérateur égale à")]
        public void WhenCliquerSurLOperateurEgaleA()
        {
            Thread.Sleep(8000);
            dossier.EgaleàClick();
        }

        [When(@"Cliquer sur Marques")]
        public void WhenCliquerSurMarques()
        {
            Thread.Sleep(5000);
            dossier.MarquesClick();
        }

        [When(@"Cliquer sur Valider du popup")]
        public void WhenCliquerSurValiderDuPopup()
        {
            Thread.Sleep(5000);
            dossier.ValiderClick();
        }

        [When(@"Cliquer sur Référence du dossier")]
        public void WhenCliquerSurReferenceDuDossier()
        {
            Thread.Sleep(5000);
            dossier.RéférenceDuDossierClick();
        }

        [When(@"Cliquer sur commence par")]
        public void WhenCliquerSurCommencePar()
        {
            Thread.Sleep(5000);
            dossier.CommencerParClick();
        }

        [When(@"Saisir '(.*)' dans le champ valeur")]
        public void WhenSaisirDansLeChampValeur(string valeur)
        {
            Thread.Sleep(5000);
            dossier.ValeurSendKeys(valeur);
        }

        [When(@"Cliquer sur Dossier en vigueur")]
        public void WhenCliquerSurDossierEnVigueur()
        {
            Thread.Sleep(5000);
            dossier.DossierEnVigueurClick();
        }

        [When(@"Cliquer sur le buton Paramétrage des colonnes")]
        public void WhenCliquerSurLeButonParametrageDesColonnes()
        {
            Thread.Sleep(5000);
            dossier.ParamétrageColonnesClick();
        }

        [When(@"Glisser Image dans la partie Colonne sélectionnées en dessous de pays")]
        public void WhenGlisserImageDansLaPartieColonneSelectionneesEnDessousDePays()
        {
            Thread.Sleep(5000);
            dossier.ImageDragAndDrop();
        }

        [When(@"Glisser Liste des caractéristiques en dessous d’Inventeur dans la partie Colonnes sélectionnées")]
        public void WhenGlisserListeDesClassesEnDessousDInventeurDansLaPartieColonnesSelectionnees()
        {
            Thread.Sleep(5000);
            dossier.ListeCaractéristiqueDragAndDrop();
        }

        [When(@"Glisser protection dans la partie colonnes disponibles")]
        public void WhenGlisserInventeursDansLaPartieColonnesDisponibles()
        {
            Thread.Sleep(5000);
            dossier.ProtectionDragAndDrop();
        }

        [When(@"Cliquer sur le bouton Sauvegarder")]
        public void WhenCliquerSurLeBoutonSauvegarder()
        {
            Thread.Sleep(5000);
            dossier.SauvegarderClick();
        }

        [Then(@"Les deux colonnes Image et Liste des caractéristiques sont visibles dans la liste")]
        public void ThenLesDeuxColonnesImageEtListeDesClassesSontVisiblesDansLaListe()
        {
            Thread.Sleep(8000);
            Assert.IsTrue(dossier.ColonneImageDisplayed().Equals(true));
            Assert.IsTrue(dossier.ColonneListeDesClassesDisplayed().Equals(true));
        }

        [Then(@"La colonne Inventeur a disparue")]
        public void ThenLaColonneInventeurADisparue()
        {
            Assert.IsTrue(dossier.ColonneProtectionDisplayed().Equals(false));

            Thread.Sleep(5000);

            dossier.DragAndDropInverse();
        }

        [When(@"Ajouter un document à partir du bureau")]
        public void WhenAjouterUnDocumentAPartirDuBureau()
        {
            Thread.Sleep(8000);
            dossier.AjouterDocumentSendKeys();

            Thread.Sleep(5000);
            dossier.AjoutFile();
        }

        [When(@"Modifier le titre via le menu déroulant")]
        public void WhenModifierLeTitreViaLeMenuDeroulant()
        {
            Thread.Sleep(8000);
            dossier.TitreBropBownClick();

            Thread.Sleep(5000);

            documentName = dossier.TitreText();

            dossier.TitreClick();
        }

        [When(@"Sélectionner Administratif brevets de la liste Nature")]
        public void WhenSelectionnerAdministratifBrevetsDeLaListeNature()
        {
            Thread.Sleep(5000);
            dossier.NatureListClick();

            Thread.Sleep(5000);
            dossier.AdministratifBrevetsClick();
        }

        [When(@"Saisir '(.*)' dans le champ Commentaire")]
        public void WhenSaisirDansLeChampCommentaire(string commentaire)
        {
            Thread.Sleep(5000);
            dossier.CommentaireSendKeys(commentaire);
        }

        [When(@"Cliquer sur le bouton valider du pop up Ajouter Document")]
        public void WhenCliquerSurLeBoutonValiderDuPopUpAjouterDocument()
        {
            Thread.Sleep(5000);
            dossier.AjouterDocumentValidationButtonClick();
        }

        [Then(@"Le document est affiché sous l'onglet Divers")]
        public void ThenLeDocumentEstAfficheSousLOngletDivers()
        {
            Thread.Sleep(8000);
            Assert.IsTrue(dossier.DocumentDiversDisplayed(documentName).Equals(true));
            
        }


        [Then(@"Les informations du document sont affichées")]
        public void ThenLesInformationsDuDocumentSontAffichees()
        {
            Assert.IsTrue(dossier.DocumentTitreText().Equals(documentName));
            Assert.IsTrue(dossier.DocumentTypeText().Equals("Document Word"));
            Assert.IsTrue(dossier.DocumentTypeText().Equals("Document Word"));
            Assert.IsTrue(dossier.DocumentNatureText().Equals(true));
            Assert.IsTrue(dossier.DocumentCommentaireText().Equals("Test sur document"));
        }

        [Then(@"Le document est affiché dans la partie Aperçu")]
        public void ThenLeDocumentEstAfficheDansLaPartieApercu()
        {
            Assert.IsTrue(dossier.DocumentDisplayedErreur().Equals(false));
        }

        [When(@"Ajouter un document à partir du bouton Ajouter un document")]
        public void WhenAjouterUnDocumentAPartirDuBoutonAjouterUnDocument()
        {
            Thread.Sleep(8000);
            dossier.AjouterUnDocumentSendKeys();
        }

        [When(@"Saisir '(.*)' dans le champ Titre du popup affiché")]
        public void WhenSaisirDansLeChampTitreDuPopupAffiche(string titre)
        {
            Thread.Sleep(8000);
            dossier.TitreInputClear();

            Thread.Sleep(3000);
            dossier.TitreInputSendKeys(titre);
        }

        [Then(@"Le document est affiché dans le dossier Divers avec le nom '(.*)'")]
        public void ThenLeDocumentEstAfficheDansLeDossierDiversAvecLeNom(string documentName)
        {
            Thread.Sleep(8000);
            Assert.IsTrue(dossier.DocumentDiversDisplayed(documentName).Equals(true));
        }

        [Given(@"Selectionner Dossier dans la liste de recherche")]
        public void GivenSelectionnerDossierDansLaListeDeRecherche()
        {
            dossier.DropDownClick();
            Thread.Sleep(4000);
            dossier.DossiersRechercheClick();
            Thread.Sleep(1000);
        }

        [When(@"Sélectionner Le dossier '(.*)'")]
        public void WhenSelectionnerLeDossier(string p0)
        {
            Thread.Sleep(8000);
            dossier.dossierSelect();
        }


        [When(@"Ajouter le logo à partir du bouton Ajouter un document")]
        public void WhenAjouterLeLogoAPartirDuBoutonAjouterUnDocument()
        {
            Thread.Sleep(10000);
            dossier.UploadLogo();
        }

        [When(@"Cocher la case Image Principale")]
        public void WhenCocherLaCaseImagePrincipale()
        {
            Thread.Sleep(8000);
            dossier.ImageprincipaleClick();
        }

        [When(@"Cocher la case Disponible sur le portail")]
        public void WhenCocherLaCaseDisponibleSurLePortail()
        {
            Thread.Sleep(5000);
            dossier.DisponibleSurPortailClick();
        }

        [Then(@"Le logo ALISSIA doit apparaitre à côté du titre du dossier")]
        public void ThenLeLogoALISSIADoitApparaitreACoteDuTitreDuDossier()
        {
            Thread.Sleep(8000);
            Assert.IsTrue(dossier.LogoDisplayed().Equals(true));
        }

        [Then(@"Le fichier Alissia est affiché dans le répertoire Divers")]
        public void ThenLeFichierAlissiaEstAfficheDansLeRepertoireDivers()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(dossier.LogoDiversDisplayed("Alissia").Equals(true));
        }

        [Then(@"Le logo est affiché dans la partie Aperçu")]
        public void ThenLeLogoEstAfficheDansLaPartieApercu()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(dossier.DocumentDisplayedErreur().Equals(false));
        }

    }
}
