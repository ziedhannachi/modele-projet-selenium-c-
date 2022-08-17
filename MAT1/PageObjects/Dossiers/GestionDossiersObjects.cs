using MAT1.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoItX3Lib;
using Microsoft.Office.Interop.Word;

namespace MAT1.PageObjects.Dossiers
{
    class GestionDossiersObjects
    {
        public IWebDriver driver;
        static CommonMethod ComM;
        static string dateFact;
    

        public GestionDossiersObjects(IWebDriver driver)
        {
            this.driver = driver;
            #pragma warning disable CS0618 // Le type ou le membre est obsolète
            PageFactory.InitElements(driver, this);
            #pragma warning restore CS0618 // Le type ou le membre est obsolète

            ComM = new CommonMethod(driver);
            
        }

        [FindsBy(How = How.LinkText, Using = "Dossiers")]
        public IWebElement DossiersLink;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'Brevets')]")]
        public IWebElement Brevets;

        [FindsBy(How = How.XPath, Using = "//*[@id='mainContent']//div[contains(text(), 'Dossiers')]")]
        public IWebElement Dossier;

        [FindsBy(How = How.XPath, Using = "//*[@id='NO_CASE']//a[contains(text(), 'Ouvrir')]")]
        public IWebElement Ouvrir;

        [FindsBy(How = How.XPath, Using = "//*[@id='CaseCreateNewCaseCategoryContainer']//span[text()='Sélectionnez une prestation']")]
        public IWebElement PréstationList;

        [FindsBy(How = How.XPath, Using = "//*[@id='CaseCreateNewCaseCategory_listbox']//li[contains(text(),\"Brevet français d'origine française\")]")]
        public IWebElement BrevetFrançaisOrigineFrançaise;

        [FindsBy(How = How.Id, Using = "CaseCreateNewCaseValidateButton")]
        public IWebElement SuivantButton;

        [FindsBy(How = How.LinkText, Using = "Ajouter un tiers Deposant")]
        public IWebElement AjouterTiersDeposant;

        [FindsBy(How = How.Id, Using = "ShortTitleText")]
        public IWebElement TitreAbrégé;

        [FindsBy(How = How.Id, Using = "TitleText")]
        public IWebElement TitleText;

        [FindsBy(How = How.Id, Using = "PartyShortName")]
        public IWebElement NomAbrégéInput;

        [FindsBy(How = How.XPath, Using = "//*[@id='CaseCreateNewCaseTitlesGrid']//div[contains(text(),'(SANS NOM)')]")]
        public IWebElement TitreAbrégéCase;

        [FindsBy(How = How.LinkText, Using = "Ajouter un tiers Donneur d'ordre")]
        public IWebElement AjouterTiersDonneurOrdre;

        [FindsBy(How = How.Id, Using = "PartyShortName")]
        public IWebElement NomAbrégéDonneurOrdre;

        [FindsBy(How = How.Id, Using = "CatStepActionPopupNextButton")]
        public IWebElement Suivant;

        [FindsBy(How = How.LinkText, Using = "Ajouter un tiers Inventeur")]
        public IWebElement AjouterTiersInventeur;

        [FindsBy(How = How.Id, Using = "CatStepActionPopupNextButton")]
        public IWebElement TerminerButton;

        [FindsBy(How = How.Id, Using = "UncompletedStepPopupDeleteStepButton")]
        public IWebElement SupprimerEtapeInitButton;

        [FindsBy(How = How.Id, Using = "CaseVM_DisplayedTitle_ShortTitleText")]
        public IWebElement TitreAbrégéDisplayed;

        [FindsBy(How = How.Id, Using = "CaseVM_DisplayedTitle_TitleText")]
        public IWebElement TitreDisplayed;

        [FindsBy(How = How.Id, Using = "AlissiaDebugLastNotification")]
        public IWebElement NotificationDisplayed;

        [FindsBy(How = How.Id, Using = "EditCaseFloStepLaunchableTreeViewSpan100028758¤100002724")]                                       
        public IWebElement DateNDepot;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/section/div[5]/div/div[1]/div[2]/a[1]")]
        public IWebElement DossierRéférence;

        [FindsBy(How = How.XPath, Using = "//input[@value= '100128650']")]
        public IWebElement ProcedureCheckBox;

        [FindsBy(How = How.Id, Using = "EditCaseFloStepLaunchableTreeViewSpan100028758")] 
        public IWebElement AvisDépôt;

        [FindsBy(How = How.Id, Using = "CaseDateEditDPDate")]
        public IWebElement DateprioriteInput;

        [FindsBy(How = How.Id, Using = "CaseDateEditACNumber")]
        public IWebElement NumeroInput;

        [FindsBy(How = How.Id, Using = "FloDocManagementGenerateNewDocButton")]
        public IWebElement GénéreeNouveauDocument;

        [FindsBy(How = How.Id, Using = "DocGenerationBtnNext")]
        public IWebElement SuivantBut;

        [FindsBy(How = How.Id, Using = "DocGenerationBtnGenerate")]
        public IWebElement GénérerDocument;

        [FindsBy(How = How.Id, Using = "DocGenerationBtnEnd")]
        public IWebElement Terminer;

        [FindsBy(How = How.Id, Using = "DocumentAddUploader-upload")]
        public IWebElement UploadFile;

        [FindsBy(How = How.Id, Using = "CasGeneralitiesNumericEditor")]
        public IWebElement InputText;

        [FindsBy(How = How.XPath, Using = "//*[@id='DocDocumentAddDocumentInfos']//span[@style='cursor: pointer; display: inline-block; margin: 2px;']")]
        public IWebElement TitreList;

        [FindsBy(How = How.Id, Using = "DocDocumentAddDocumentTitle-list")]
        public IWebElement TitrePrérempli;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Avis de dépôt')]")]
        public IWebElement AvisDépôtEtape;

        [FindsBy(How = How.Id, Using = "CatStepActionPopup_wnd_title")]
        public IWebElement Date_NDepotNum;

        [FindsBy(How = How.Id, Using = "documentDetailIFDocxPreview")]
        public IWebElement DocumentDisplayed;

        [FindsBy(How = How.Id, Using = "GeneratePdf")]
        public IWebElement GeneratePdf;

        [FindsBy(How = How.Id, Using = "documentDetailType")]
        public IWebElement documentDetailType;

        [FindsBy(How = How.Id, Using = "EditCaseFloStepLaunchableTreeViewSpan100028758¤100026754")]
        public IWebElement ValorisationDEPOTEtape;

        [FindsBy(How = How.XPath, Using = "//input[@value= '100128649']")]
        public IWebElement EnCoursRadioButton;

        [FindsBy(How = How.Id, Using = "CatStepActionPopup_wnd_title")]
        public IWebElement ValorisationDEPOTNum;

        [FindsBy(How = How.XPath, Using = "//*[@id='WorkFlowInProgressDetailDeadlines']//div[contains(text(),'Facturation')]")]
        public IWebElement ValorisationDEPOTEchéance;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[2]/div[3]/div/div[1]/div[1]/div[2]/div/div/div[3]/div[2]/span/span/input[1]")]
        public IWebElement QuantitéVal;      

        [FindsBy(How = How.XPath, Using = "//input[@value='INVOICE']")]
        public IWebElement FacturationRadioButton; 

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[2]/div[3]/div/div[1]/div[1]/div[2]/div/div/div[3]/div[2]/span/span/input[2]")]
        public IWebElement QuantitéValInput;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[2]/div[3]/div/div[1]/div[1]/div[2]/div/div/div[4]/div[2]/span/span/input[1]")]
        public IWebElement QuantitéFact;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[2]/div[3]/div/div[1]/div[1]/div[2]/div/div/div[4]/div[2]/span/span/input[2]")]
        public IWebElement QuantitéFactInput;

        [FindsBy(How = How.Id, Using = "CaseWorkMadeDetailToolBarSaveButton")]
        public IWebElement SauvegrderButton;

        [FindsBy(How = How.Id, Using = "CaseWorkMadeDetailToolBarNewTariffButton")]
        public IWebElement NouveauTarif;

        [FindsBy(How = How.Id, Using = "CaseWorkMadeAddTariffPopupTariffCode")]
        public IWebElement TarifInput;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[2]/div[3]/div/div[1]/div[1]/div[1]/div/div[1]/div[2]/span/input")]
        public IWebElement Input;

        [FindsBy(How = How.Id, Using = "CaseWorkMadeAddTariffPopupValidateButton")]
        public IWebElement ValiderButton;

        [FindsBy(How = How.Id, Using = "CaseWorkMadeDetailToolBarReportButton")]
        public IWebElement ExportCognos;

        [FindsBy(How = How.Id, Using = "CognosReportDownloadButton")]
        public IWebElement TéléchargerFicherButton;

        [FindsBy(How = How.Id, Using = "CaseInvoicesGeneralTreeViewSpan100172699¤100005241")]
        public IWebElement Historique;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[2]/div[1]/div/div/div[2]/table/tbody/tr/td[2]/div")]
        public IWebElement EnvoiRecommandéHistorique;

        [FindsBy(How = How.Id, Using = "CaseWorkMadeDetailToolBarEditWorkMadeButton")]
        public IWebElement Facturation;

        [FindsBy(How = How.Id, Using = "CaseWorkMadeInvoicePartyDeleteIncompleteLinesCheckBox")]
        public IWebElement CheckBoxSupprimerLignes;

        [FindsBy(How = How.Id, Using = "CaseWorkMadeInvoicePartySelectValidateButton")]
        public IWebElement FacturationButton;

        [FindsBy(How = How.Id, Using = "CaseInvoicesGeneralTreeViewSpan100128245")]
        public IWebElement repertoireFacture;

        [FindsBy(How = How.Id, Using = "CaseInvoicesGeneralTreeViewSpan100128245¤100046176")]
        public IWebElement repertoireProcedure;

        [FindsBy(How = How.XPath, Using = "//html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[1]/div/div/div/ul/li[6]/ul/li/ul/li[1]/div/span")]
        public IWebElement Facture;

        [FindsBy(How = How.Id, Using = "AlissiaDebugLastInvoiceIds")]
        public IWebElement FactureId;

        [FindsBy(How = How. XPath, Using = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[2]/div/div[4]/div[2]/div[3]/div[2]")]
        public IWebElement TaxesDisplayed;

        [FindsBy(How = How.Id, Using = "CaseInvoiceDetailSetInvoiceTextButton")]
        public IWebElement NumérotationFacture;

        [FindsBy(How = How.Id, Using = "CaseInvoiceDetailNumberingPopupDate")]
        public IWebElement NumérotationFactureDate;

        [FindsBy(How = How.Id, Using = "CaseInvoiceDetailNumberingPopupValidateButton")]
        public IWebElement NumérotationValiderButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='CaseInvoiceContainer']//div[contains(text(),'Facture')]")]
        public IWebElement FactureTitle;

        [FindsBy(How = How.Id, Using = "CaseInvoiceDetailInvoiceDate")]
        public IWebElement DateDisplayed;

        [FindsBy(How = How.Id, Using = "CaseInvoiceDetailCreateCreditNoteButton")]
        public IWebElement Crédit;

        [FindsBy(How = How.XPath, Using = "//*[@id='CaseInvoiceDetailNumberingPopup']//div[contains(text(),'Date')]")]
        public IWebElement Date;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Val/Fac')]")]
        public IWebElement ValFacLink;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Procédure')]")]
        public IWebElement ProcédureLink;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Dossier')]")]
        public IWebElement DossierLink;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Documents')]")]
        public IWebElement DocumentsLink;

        [FindsBy(How = How.XPath, Using = "//li[@aria-controls='CasesMainTabStrip-6']")]
        public IWebElement ProcédureActive;

        [FindsBy(How = How.Id, Using = "CaseInvoicesGeneralTreeViewSpan100172699")]
        public IWebElement Valorisation;
  
        [FindsBy(How = How.Id, Using = "AlissiaDebugLastStepId")]
        public IWebElement ValorisationDepotId;

        [FindsBy(How = How.XPath, Using = "//*[@id='CaseInvoiceDetailBodyLine100004433']/div[2]")]
        public IWebElement TaxesOfficielles;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[2]/div/div[3]/div[1]/div[1]/div[1]/div/div/div[2]")]
        public IWebElement TaxesOfficiellestext;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[2]/div/div[3]/div[1]/div[1]/div[2]/div/div/div[2]")]
        public IWebElement FraisHonorairestext;

        [FindsBy(How = How.XPath, Using = "//span[@aria-activedescendant= 'QuickSearchObject_option_selected']")]
        public IWebElement DropDown;

        [FindsBy(How = How.XPath, Using = "//*[@id='QuickSearchObject_listbox']//div[contains(text(),'Brevets')]")]
        public IWebElement BrevetsRecherche;

        [FindsBy(How = How.XPath, Using = "//*[@id='CaseInvoicesGeneralTreeViewNode100011587']//span[@role= 'presentation']")]
        public IWebElement Add;

        [FindsBy(How = How.Id, Using = "CaseNewDisbursementDisbursementText")] 
        public IWebElement NFacture;

        [FindsBy(How = How.Id, Using = "CaseNewDisbursementDisbursementDate")]
        public IWebElement DateFacture;

        [FindsBy(How = How.Id, Using = "CaseNewDisbursementFileDisplayText")]
        public IWebElement Document;

        [FindsBy(How = How.Id, Using = "CaseNewDisbursementDocumentDocumentHelper-upload")]
        public IWebElement FileUpload;

        [FindsBy(How = How.Id, Using = "CaseNewDisbursementDocumentPopupValidateButton")]
        public IWebElement AjouterDocumentDébours;

        [FindsBy(How = How.XPath, Using = "//*[@id='CaseNewDisbursementPopup']/div[1]/div[1]/div[6]/div[1]/div[2]/span/span/input[1]")]
        public IWebElement Débours;

        [FindsBy(How = How.XPath, Using = "//*[@id='CaseNewDisbursementPopup']/div[1]/div[1]/div[6]/div[4]/div[2]/span/span/input[1]")]
        public IWebElement Honoraires;

        [FindsBy(How = How.Id, Using = "CaseNewDisbursementColumnValue100015896")]
        public IWebElement DéboursInput;

        [FindsBy(How = How.Id, Using = "CaseNewDisbursementColumnValue100015898")]
        public IWebElement HonorairesInput;

        [FindsBy(How = How.Id, Using = "CaseNewDisbursementColumnValueWIVATTotal")]
        public IWebElement TotalTTC;

        [FindsBy(How = How.Id, Using = "CaseNewDisbursementColumnValueCurrencyDisplayText")]
        public IWebElement Devise;

        [FindsBy(How = How.Id, Using = "CaseNewDisbursementStepDisplayText")]
        public IWebElement Etape;

        [FindsBy(How = How.XPath, Using = "//input[@value='NEW']")]
        public IWebElement EtapesProcédure;

        [FindsBy(How = How.XPath, Using = "//*[@id='TimeSheetCaseAndStepEditorLaunchableStepsTree']//div[contains(text(),'Avis de dépôt')]")]
        public IWebElement EtapesProcédureAvisDepot;

        [FindsBy(How = How.XPath, Using = "//*[@id='TimeSheetCaseAndStepEditorLaunchableStepsTree']//div[contains(text(),'Valorisation Dépôt')]")]
        public IWebElement EtapesProcédureValorisationDepot;

        [FindsBy(How = How.Id, Using = "TimeSheetCaseAndStepEditorValidateButton")]
        public IWebElement EditerEtapeValidationButton;

        [FindsBy(How = How.Id, Using = "CaseNewDisbursementUserDisplayText")]
        public IWebElement IntervenantInput;

        [FindsBy(How = How.Id, Using = "ListOfValueGridColumnHeaderCaseNewDisbursementUserLOVInitialsCode")]
        public IWebElement PersonneInitiale;

        [FindsBy(How = How.Id, Using = "ListOfValueValidateButtonCaseNewDisbursementUserLOV")]
        public IWebElement ListeUtilisateurValidationButton;

        [FindsBy(How = How.Id, Using = "CaseNewDisbursementMotive")]
        public IWebElement Motif;

        [FindsBy(How = How.Id, Using = "CaseNewDisbursementValidateButton")]
        public IWebElement DeboursValidationButton;

        [FindsBy(How = How.Id, Using = "UserShortDisplayText")]
        public IWebElement InterText;

        [FindsBy(How = How.XPath, Using = "//*[@id='CaseWorkMadeDetailGrid']//span[contains(text(),'Facturable')]")]
        public IWebElement EtatText;

        [FindsBy(How = How.Id, Using = "WorkedAgentFees")]
        public IWebElement DeboursText;

        [FindsBy(How = How.Id, Using = "WorkedExtraCharges")]
        public IWebElement FraisText;

        [FindsBy(How = How.XPath, Using = "//*[@id='CaseWorkMadeDetailGrid']//div[contains(text(),'330,00 EUR')]")]
        public IWebElement TotalText;

        [FindsBy(How = How.XPath, Using = "//input[contains(@value,'Julien Cavaggion')]")]
        public IWebElement IntervenantInputText;

        [FindsBy(How = How. XPath, Using = "//input[contains(@value,'BEETZ')]")]
        public IWebElement FournisseurText;

        [FindsBy(How = How.XPath, Using = "//input[contains(@value,'20-1234')]")]
        public IWebElement NFactureText;

        [FindsBy(How = How.XPath, Using = "//input[contains(@value,'06/01/2020')]")]
        public IWebElement DateText;

        [FindsBy(How = How.XPath, Using = "//*[@id='WorkflowDocumentsTreeView']//span[contains(text(),'Divers')]")]
        public IWebElement Divers;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'CaseWorkMadeTarGridTotalInvoice' and contains(text(),'300,00 EUR')]")]
        public IWebElement TotalDebours;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'CaseWorkMadeTarGridTotalInvoice' and contains(text(),'30,00 EUR')]")]
        public IWebElement TotalFrais;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'CaseWorkMadeTarGridTotalInvoice' and contains(text(),'330,00 EUR')]")]
        public IWebElement Total;

        [FindsBy(How = How.XPath, Using = "//*[@id='WorkflowDocumentsTreeView_tv_active']//span[contains(text(),'Communication du dépôt au client')]")]
        public IWebElement DiversDoc;

        [FindsBy(How = How.Id, Using = "CreateNewCaseGenerateReference")]
        public IWebElement NuméroAutomatiqueCheckBox;

        [FindsBy(How = How.Id, Using = "CaseCreateNewCaseReferenceText")]
        public IWebElement Référence;

        [FindsBy(How = How.XPath, Using = "//*[@id='DocGenerationGrdTemplateDetails']//span[@title='Ouvrir dans un nouvel onglet']")]
        public IWebElement documentIcon;

        [FindsBy(How = How.XPath, Using = "//input[@value= '100128648']")]
        public IWebElement HistoriqueRadioButton;

        [FindsBy(How = How.Id, Using = "EditCaseWorkflowHistoryTreeViewSpan100506036")]
        public IWebElement AvisDepotHistorique;

        [FindsBy(How = How.XPath, Using = "//*[@id='WorkflowHistoryDetailSplitter']//li[contains(text(),'Dépôt')]")]
        public IWebElement HistoriqueTypeDisplayed;

        [FindsBy(How = How.XPath, Using = "//*[@id='WorkflowHistoryDetailSplitter']//li[contains(text(),'15/01/2016')]")]
        public IWebElement HistoriqueDateDisplayed;

        [FindsBy(How = How.XPath, Using = "//*[@id='WorkflowHistoryDetailSplitter']//li[contains(text(),'FRANCE')]")]
        public IWebElement HistoriquePaysDisplayed;

        [FindsBy(How = How.XPath, Using = "//*[@id='WorkflowHistoryDetailSplitter']//li[contains(text(),'1604328')]")]
        public IWebElement HistoriqueNuméroDisplayed;

        [FindsBy(How = How.XPath, Using = "//a[@title= 'Dossiers']")]
        public IWebElement OngletDossier;

        [FindsBy(How = How.Id, Using = "SearchEngineTreeViewSpan420000127")]
        public IWebElement ObjetDuDossier;

        [FindsBy(How = How.Id, Using = "SearchEngineOperatorTreeViewSpan450000017")]
        public IWebElement Egaleà;

        [FindsBy(How = How.Id, Using = "GridOfValueGridOfValueLine100001879")]
        public IWebElement Marques;

        [FindsBy(How = How.Id, Using = "SearchEngineTreeViewSpan100010947")]
        public IWebElement RéférenceDuDossier;

        [FindsBy(How = How.Id, Using = "SearchEngineOperatorTreeViewSpan450000051")]
        public IWebElement CommencePar;

        [FindsBy(How = How.Id, Using = "Value")]
        public IWebElement Valeur;

        [FindsBy(How = How.Id, Using = "SearchEngineValueFormValidateButton")]
        public IWebElement Valider;

        [FindsBy(How = How.Id, Using = "SearchEngineTreeViewSpan100013457")]
        public IWebElement DossierEnVigueur;

        [FindsBy(How = How.Id, Using = "ColumnSettingsButton")]
        public IWebElement ParamétrageColonnes;

        [FindsBy(How = How.XPath, Using = "//*[@id='AvailableColumnsTree']//div[contains(text(),'Image')]")]
        public IWebElement Image;

        [FindsBy(How = How.XPath, Using = "//*[@id='TakenColumnsTree']/ul/li[2]")]
        public IWebElement DonneurOrdre;

        [FindsBy(How = How.Id, Using = "ValidateUserPrefButton")]
        public IWebElement Sauvegarder;

        [FindsBy(How = How.XPath, Using = "//*[@id='AvailableColumnsTree']//div[contains(text(),'Liste des caractéristiques')]")]
        public IWebElement ListeDesCaractéristique;

        [FindsBy(How = How.XPath, Using = "//*[@id='TakenColumnsTree']/ul/li[3]")]
        public IWebElement Voie;

        [FindsBy(How = How.XPath, Using = "//*[@id='TakenColumnsTree']//div[contains(text(),'Protection')]")]
        public IWebElement Protection;

        [FindsBy(How = How.XPath, Using = "//*[@id='AvailableColumnsTree']/ul/li[1]")]
        public IWebElement Statut;

        [FindsBy(How = How.XPath, Using = "//*[@id='TakenColumnsTree']//div[contains(text(),'Image')]")]
        public IWebElement ImageColonneSélectionné;

        [FindsBy(How = How.XPath, Using = "//*[@id='TakenColumnsTree']//div[contains(text(),'Liste des caractéristiques')]")]
        public IWebElement ListeDesCaractéristiqueColonneSélectionné;

        [FindsBy(How = How.XPath, Using = "//*[@id='AvailableColumnsTree']/ul/li[3]")]
        public IWebElement SousStatut;

        [FindsBy(How = How.XPath, Using = "//*[@id='AvailableColumnsTree']//div[contains(text(),'Protection')]")]
        public IWebElement ProtectionColonnesDisponible;

        [FindsBy(How = How.XPath, Using = "//*[@id='TakenColumnsTree']/ul/li[2]")]
        public IWebElement PaysColonneSélectionné;

        [FindsBy(How = How.Id, Using = "DocumentTreeBtnAdd")]
        public IWebElement AjouterDocument;

        [FindsBy(How = How.XPath, Using = "//*[@id='documentDetailAdd']/div[1]/div[2]/span/span[2]")]
        public IWebElement TitreBropBown;

        [FindsBy(How = How.Id, Using = "AddCaseDocumentsACFileName_listbox")]
        public IWebElement Titre;

        [FindsBy(How = How.XPath, Using = "//*[@id='documentDetailAdd']/div[5]/div[2]/span/span/span[1]")]
        public IWebElement NatureList;

        [FindsBy(How = How.XPath, Using = "//li[contains(text(),'Administratif Brevets')]")]
        public IWebElement AdministratifBrevets;

        [FindsBy(How = How.Id, Using = "AddCaseDocumentsTAComment")]
        public IWebElement Commentaire;

        [FindsBy(How = How.Id, Using = "SubmitDocument")]
        public IWebElement AjouterDocumentValidationButton;

        [FindsBy(How = How.Id, Using = "documentDetailTitle")]
        public IWebElement DocumentTitre;

        [FindsBy(How = How.Id, Using = "documentDetailType")]
        public IWebElement DocumentType;

        [FindsBy(How = How.XPath, Using = "//*[@id='documentDetail']//span[contains(text(),'Administratif Brevets')]")]
        public IWebElement DocumentNature;

        [FindsBy(How = How.Id, Using = "documentDetailComment")]
        public IWebElement DocumentCommentaire;

        [FindsBy(How = How.Id, Using = "WACErrorHeader")]
        public IWebElement ErreurServeur;

        [FindsBy(How = How.Id, Using = "CaseDocumentUpload")]
        public IWebElement AjouterUnDocument;

        [FindsBy(How = How.Id, Using = "AddCaseDocumentsACFileName")]
        public IWebElement TitreInput;

        [FindsBy(How = How.XPath, Using = "//*[@id='QuickSearchObject_listbox']//div[contains(text(),'Dossiers')]")]
        public IWebElement DossiersRecherche;

        [FindsBy(How = How.XPath, Using = "//*[@id='ResultGrid']//td[text()= 'MAR10005']")]
        public IWebElement DossierRéférenceList;

        [FindsBy(How = How.Id, Using = "SearchEngineResultGridValidateValueButton")]
        public IWebElement SélectionnezButton;

        [FindsBy(How = How.Id, Using = "AddCaseDocumentsCBIsMainImage")]
        public IWebElement Imageprincipale;

        [FindsBy(How = How.Id, Using = "AddCaseDocumentsCBInternet")]
        public IWebElement DisponibleSurPortail;


        public void DossiersLinkClick()
        {
            DossiersLink.Click();
        }

        public string ValorisationDepotIdValue()
        {
            return ValorisationDepotId.GetAttribute("value");
        }

        public void BrevetsClick()
        {
            Brevets.Click();
        }

        public void PréstationListClick()
        {
            PréstationList.Click();
        }

        public void BrevetFrançaisOrigineFrançaiseClick()
        {
            BrevetFrançaisOrigineFrançaise.Click();
        }

        public void SuivantButtonClick()
        {
            SuivantButton.Click();
        }

        public void NomAbrégéInputSendKeys(string NomAbrégé)
        {
            NomAbrégéInput.SendKeys(NomAbrégé);
        }

        public void TitreAbrégéClick()
        {
            TitreAbrégéCase.Click();
        }

        public void TitreAbrégéSendKeys(string titreAbrégé)
        {
            TitreAbrégé.SendKeys(titreAbrégé);
        }

        public void TitleTextClick()
        {
            TitleText.Click();
            Thread.Sleep(3000);

            string a = TitleText.GetAttribute("value");
            while (TitleText.GetAttribute("value").Length != 0)
            {
                TitleText.SendKeys(Keys.Backspace);
                a = TitleText.GetAttribute("value");
            }
        }

        public void TitleTextSendKeys(string titre)
        {
            TitleText.SendKeys(titre);
        }

        public void AjouterTiersDonneurOrdreClick()
        {
            AjouterTiersDonneurOrdre.Click();
        }

        public void NomAbrégéDonneurOrdreSendKeys(string NomAbrégé)
        {
            NomAbrégéDonneurOrdre.SendKeys(NomAbrégé);
        }

        public void ClickSuivantButton()
        {
            Suivant.Click();
            Thread.Sleep(5000);
        }

        public void AjouterTiersInventeurButton()
        {
            AjouterTiersInventeur.Click();
        }

        public void TerminerButtonClick()
        {
            TerminerButton.Click();
        }
        
        public string TitreAbrégéTextDisplayed()
        {
            return TitreAbrégéDisplayed.GetAttribute("value");
        }

        public string TitreTextDisplayed()
        {
            return TitreDisplayed.Text;
        }

        public string NotificationDisplayedText()
        {
            return NotificationDisplayed.GetAttribute("messagetodisplay");
        }

        public void Val_FacClick()
        {
            ValFacLink.Click();
            Thread.Sleep(2000);
        }

        public void DateNDepotClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(DateNDepot).Perform();
        }
        public void  ProcédureClick()
        {
            ProcédureLink.Click();
            Thread.Sleep(2000);
        }

        public void DossierClick()
        {
            DossierLink.Click();
            Thread.Sleep(2000);
        }

        public void DocumentsClick()
        {
            DocumentsLink.Click();
            Thread.Sleep(2000);
        }

        public void DossierRéférenceClick()
        {
            DossierRéférence.Click();
        }

        public void ProcedureCheckBoxClick()
        {
            ProcedureCheckBox.Click();
        }

        public void DateNumDépotClick()
        {
            if (ComM.IsElementPresent(By.Id("EditCaseFloStepLaunchableTreeViewSpan100028758¤100002724")) == true)
            {
                Console.WriteLine("element displayed");

                Actions action = new Actions(driver);
                action.DoubleClick(DateNDepot).Perform();

            }
            else
            {

                Console.WriteLine("element not displayed");

                Actions action = new Actions(driver);
                action.DoubleClick(AvisDépôt).Perform();

                Thread.Sleep(5000);

                Actions action2 = new Actions(driver);
                action2.DoubleClick(DateNDepot).Perform();


            }
        }

        public void DateInputSendKey(String date)
        {
            ComM.ExplicitWait(By.Id("CaseDateEditDPDate"));

            DateprioriteInput.Clear();
            DateprioriteInput.Click();
            Thread.Sleep(3000);
            DateprioriteInput.SendKeys(date);
        }

        public void NumeroInputSendKey(String numero)
        {
            NumeroInput.Clear();
            Thread.Sleep(2000);
            NumeroInput.SendKeys(numero);
        }

        public void GénéreeNouveauDocumentClick()
        {
            GénéreeNouveauDocument.Click();
        }

        public void SuivantButClick()
        {
            SuivantBut.Click();
        }

        public void GénérerDocumentClick()
        {
            GénérerDocument.Click();
        }

        public void TerminerClick()
        {
            Terminer.Click();
        }

        public void uploadfile()
        {
            string document = Environment.GetEnvironmentVariable("USERPROFILE") + @"\source\Workspaces\AlissiaIpr2\QA\MAT1\MAT1\Document" + @"\";
            UploadFile.SendKeys(@document + "Communication du dépôt au client.docx");
        }

        public void InformationsGeneralesSendKeys(string input, string InformationsGenerales)
        {
            string xpath_1 = "/html/body/div[97]/div[2]/div/div[2]/div[1]/div/div[3]/div/div[1]/div[3]/table/tbody/tr[";
            string xpath_2 = "]/td[1]";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, InformationsGenerales);

            driver.FindElement(By.XPath(xpath_1 + i + "]/td[2]")).Click();
            Thread.Sleep(2000);

            InputText.Clear();

            Thread.Sleep(2000);
            InputText.SendKeys(input);
        }

        public void TitreListClick()
        {
            TitreList.Click();
        }

        public void TitrePrérempliClick()
        {
            TitrePrérempli.Click();
        }

        public string DateDépôtText()
        {
            string xpath_1 = "//*[@id='casesDatesGrid']/div[2]/div/table/thead/tr/th[";
            string xpath_2 = "]/a";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, "Date");
            Console.WriteLine(i);

            string xpath_Date1 = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[1]/div[1]/div[1]/div[3]/table/tbody/tr[";
            string xpath_Date2 = "]/td["+ i +"]/div";

            int j = ComM.ParcourList(1, xpath_Date1, xpath_Date2, "Dépôt");
            Console.WriteLine(j);

            string xpath_Valeur1 = "//*[@id='casesDatesGrid']/div[2]/div/table/thead/tr/th[";
            string xpath_Valeur2 = "]/a";

            int k = ComM.ParcourList(1, xpath_Valeur1, xpath_Valeur2, "Valeur");
            Console.WriteLine(k);

            return driver.FindElement(By.XPath("//*[@id='casesDatesGrid']/div[3]/table/tbody/tr["+j+ "]/td["+k+ "]/div")).Text;
            
        }

        public string NuméroDépôtText()
        {
            string xpath_1 = "//*[@id='casesDatesGrid']/div[2]/div/table/thead/tr/th[";
            string xpath_2 = "]/a";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, "Date");
            Console.WriteLine(i);

            string xpath_Date1 = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[1]/div[1]/div[1]/div[3]/table/tbody/tr[";
            string xpath_Date2 = "]/td[" + i + "]/div";

            int j = ComM.ParcourList(1, xpath_Date1, xpath_Date2, "Dépôt");
            Console.WriteLine(j);

            string xpath_Valeur1 = "//*[@id='casesDatesGrid']/div[2]/div/table/thead/tr/th[";
            string xpath_Valeur2 = "]/a";

            int k = ComM.ParcourList(1, xpath_Valeur1, xpath_Valeur2, "Numéro");
            Console.WriteLine(k);

            return driver.FindElement(By.XPath("//*[@id='casesDatesGrid']/div[3]/table/tbody/tr[" + j + "]/td[" + k + "]/div")).Text;

        }

        public IList<string> ListeInfoInformationsGénérales(string text)
        {
            IList<string> ListInfoDateDépôt = new List<string>();

            string xpath_td1 = "//*[@id='casesGeneralitiesGrid']/div[3]/table/tbody/tr[";
            string xpath_td2 = "]/td[";
            string xpath_td3 = "]";

            ListInfoDateDépôt = ComM.Listinfo(1, xpath_td1, xpath_td2, xpath_td3, text, 3);
            return ListInfoDateDépôt;

        }

        public void DocumentsProcédureClick(string étape)
        {
            string xpath_1 = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[4]/div/div/div[1]/div[2]/div[1]/div[1]/ul/li/ul/li[";
            string xpath_2 = "]/div/span[2]";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, étape);

            Actions action = new Actions(driver);
            action.DoubleClick(driver.FindElement(By.XPath(xpath_1 + i + xpath_2))).Perform();
        }

        public void AvisDépôtEtapeClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(AvisDépôtEtape).Perform();
        }

        public string Date_NDepotNumText()
        {
            string Date_NDepot = null;
            int i = 0;
            int trouve = 0;

            while((i < Date_NDepotNum.Text.Length) && (trouve == 0) )
            {
                if (Date_NDepotNum.Text[i].ToString() == "(")
                {
                    trouve = 1;
                }
                else
                {
                    Date_NDepot = Date_NDepot + Date_NDepotNum.Text[i];
                    
                    i++;
                }
            }
            Date_NDepot = Date_NDepot.Remove(Date_NDepot.Length - 1);

            return Date_NDepot;

        }

        public void Date_NDepotNumClick(string date_NDepot)
        {
            Actions action = new Actions(driver);
            action.DoubleClick(driver.FindElement(By.XPath("//span[contains(text(),'"+ date_NDepot + "')]"))).Perform();
        }

        public void DocumentClick(string date_NDepot)
        {
            string xpath_1 = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[4]/div/div/div[1]/div[2]/div[1]/div[1]/ul/li/ul/li[1]/ul/li/ul/li[";
            string xpath_2 = "]/div/span[2]";

            string xpath_1_doument = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[4]/div/div/div[1]/div[2]/div[1]/div[1]/ul/li/ul/li[1]/ul/li/ul/li[";
            string xpath_2_doument = "]/ul/li/div/span";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, date_NDepot);

            driver.FindElement(By.XPath(xpath_1_doument + i + xpath_2_doument)).Click();
        }

        public string DocumentDisplayedText()
        {
            return DocumentDisplayed.GetAttribute("src");
        }

        public void GeneratePdfClick()
        {
            GeneratePdf.Click();
        }

        public string documentDetailTypeText()
        {
            return documentDetailType.GetAttribute("value");
        }

        public void DocumentPDFClick(string date_NDepot)
        {
            string xpath_1 = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[4]/div/div/div[1]/div[2]/div[1]/div[1]/ul/li/ul/li[1]/ul/li/ul/li[";
            string xpath_2 = "]/div/span[2]";

            string xpath_1_doument = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[4]/div/div/div[1]/div[2]/div[1]/div[1]/ul/li/ul/li[1]/ul/li/ul/li[";
            string xpath_2_doument = "]/ul/li/div/span[1]";

            string xpath_1_PDF = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[4]/div/div/div[1]/div[2]/div[1]/div[1]/ul/li/ul/li[1]/ul/li/ul/li[";
            string xpath_2_PDF = "]/ul/li/ul/li/div/span";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, date_NDepot);

            Actions action = new Actions(driver);
            action.DoubleClick(driver.FindElement(By.XPath(xpath_1_doument + i + xpath_2_doument))).Perform();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath(xpath_1_PDF + i + xpath_2_PDF)).Click();
        }

        public void ClickOKAlert()
        {
            if(ComM.isAlertPresent() == true)
            {
                IAlert alertOK = driver.SwitchTo().Alert();
                alertOK.Accept();
            }
        }

        public string ValorisationDEPOTNumText()
        {
            string ValorisationDepot = null;
            int i = 0;
            int trouve = 0;

            while ((i < ValorisationDEPOTNum.Text.Length) && (trouve == 0))
            {
                if (ValorisationDEPOTNum.Text[i].ToString() == "(")
                {
                    trouve = 1;
                }
                else
                {
                    ValorisationDepot = ValorisationDepot + ValorisationDEPOTNum.Text[i];

                    i++;
                }
            }
            ValorisationDepot = ValorisationDepot.Remove(ValorisationDepot.Length - 1);

            Console.WriteLine(ValorisationDepot.Equals("Valorisation DEPOT #3"));


            return ValorisationDepot;

        }

        public string EnCoursRadioButtonSelected()
        {
            return EnCoursRadioButton.GetAttribute("checked");
        }


        public void ValorisationDEPOTEtapeClick()
        {
            if (ComM.IsElementPresent(By.Id("EditCaseFloStepLaunchableTreeViewSpan100028758¤100026754")) == true)
            {
                Console.WriteLine("element displayed");

                Actions action = new Actions(driver);
                action.DoubleClick(ValorisationDEPOTEtape).Perform();

            }
            else
            {

                Console.WriteLine("element not displayed");

                Actions action = new Actions(driver);
                action.DoubleClick(AvisDépôt).Perform();

                Thread.Sleep(3000);

                Actions action2 = new Actions(driver);
                action2.DoubleClick(ValorisationDEPOTEtape).Perform();


            }
        }

        public string Procédureactive()
        {
            return ProcédureActive.GetAttribute("class");
        }

        public bool ValorisationDEPOTEchéanceDisplayed()
        {
            return ValorisationDEPOTEchéance.Displayed;
        }

        public string ValorisationDEPOTEchéanceText()
        {
            return  ValorisationDEPOTEchéance.Text;
        }

        public Boolean valorisationDepotEncoursDisplayed(string valorisationDepot)
        {
            return driver.FindElement(By.Id("CaseInvoicesGeneralTreeViewSpan100172699¤100128231¤" + valorisationDepot)).Displayed;
        }


        public void valorisationDepotEncoursClick(string valorisationDepot)
        {
            ComM.ExplicitWait(By.Id("CaseInvoicesGeneralTreeViewSpan100172699¤100128231¤" + valorisationDepot));
            driver.FindElement(By.Id("CaseInvoicesGeneralTreeViewSpan100172699¤100128231¤" + valorisationDepot)).Click();

        }

        public string TotalDépôtEnLigne()
        {
            string xpath_1 = "//*[@id='CaseWorkMadeDetailGrid']/div[2]/table/tbody/tr[";
            string xpath_2 = "]/td[2]/div";

            string xpath_1_Total = "//*[@id='CaseWorkMadeDetailGrid']/div[1]/div/table/thead/tr/th[";
            string xpath_2_Total = "]/a/div";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, "Dépôt en ligne");

            int j = ComM.ParcourList(1, xpath_1_Total, xpath_2_Total, "Total");

            return driver.FindElement(By.XPath(xpath_1 + i + "]/td[" + j + "]")).Text;
        }

        public void EnvoiRecommandéClick()
        {
            string xpath_1 = "//*[@id='CaseWorkMadeDetailGrid']/div[2]/table/tbody/tr[";
            string xpath_2 = "]/td[2]/div";

            string xpath_1_Total = "//*[@id='CaseWorkMadeDetailGrid']/div[1]/div/table/thead/tr/th[";
            string xpath_2_Total = "]/a/div";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, "Envoi recommandé");

            driver.FindElement(By.XPath(xpath_1 + i + xpath_2)).Click();

            int j = ComM.ParcourList(1, xpath_1_Total, xpath_2_Total, "Etat");

            Thread.Sleep(2000);

            driver.FindElement(By.XPath(xpath_1 + i + "]/td[" + j + "]")).Click();

        }

        public void NonFacturableClick()
        {
            string xpath_1 = "//*[@id='InvStateId_listbox']/li[";
            string xpath_2 = "]";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, "Non facturable");

            driver.FindElement(By.XPath("//li[contains(text(),'Non facturable')]")).Click();

        }

        public void FraisPhotocopiesClick()
        {
            string xpath_1 = "//*[@id='CaseWorkMadeDetailGrid']/div[2]/table/tbody/tr[";
            string xpath_2 = "]/td[2]/div";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, "Frais de photocopies");

            driver.FindElement(By.XPath(xpath_1 + i + xpath_2)).Click();

        }

        public void QuantitéValClick()
        {
            QuantitéVal.Click();
            Thread.Sleep(2000);

        }

        public void FacturationRadioButtonClick()
        {
            FacturationRadioButton.Click();
        }

        public void QuantitéValInputSendKeys(string qté)
        {
            Thread.Sleep(2000);
            QuantitéValInput.SendKeys(qté);
        }

        public void QuantitéFactClick()
        {
            QuantitéFact.Click();
            Thread.Sleep(2000);
        }

        public void QuantitéFactInputSendKeys(string qté)
        {
            Thread.Sleep(2000);
            QuantitéFactInput.SendKeys(qté);

            Thread.Sleep(2000);
            Input.Click();
        }

        public string BoldText()
        {
            string xpath_1 = "//*[@id='CaseWorkMadeDetailGrid']/div[2]/table/tbody/tr[";
            string xpath_2 = "]/td[2]/div";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, "Frais de photocopies");

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement element = driver.FindElement(By.XPath(xpath_1+i+ xpath_2));
            String fontWeight = (String)js.
                    ExecuteScript(
                            "return getComputedStyle(arguments[0]).getPropertyValue('font-weight');",
                            element);

            return fontWeight;

        }

        public void SauvegarderButtonClick()
        {
            SauvegrderButton.Click();
        }

        public void NouveauTarifClick()
        {
            NouveauTarif.Click();
        }

        public void TarifSendKeys(string tarif)
        {
            TarifInput.SendKeys(tarif);
        }

        public void ValiderButtonClick()
        {
            ValiderButton.Click();
        }

        public void ExportCongnosClick()
        {
            ExportCognos.Click();
        }

        public void TélécharferFichierClick()
        {
            TéléchargerFicherButton.Click();
        }

        public bool FraisPhotocopiesDisplayed()
        {
            string xpath_1 = "//*[@id='CaseWorkMadeDetailGrid']/div[2]/table/tbody/tr[";
            string xpath_2 = "]/td[2]/div";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, "Constitution de mandataire");

            return driver.FindElement(By.XPath(xpath_1 + i + xpath_2)).Displayed;
        }

        public int ExistFile()
        {
            string download = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads" + @"\";

            string[] filePaths = Directory.GetFiles(@download, "Valorisation par étape_*.pdf", SearchOption.AllDirectories);

            return filePaths.Length;


        }

        public void DeleteFile()
        {
            string download = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads" + @"\";

            Console.WriteLine(download);

            string[] filePaths = Directory.GetFiles(@download, "Valorisation par étape_*.pdf", SearchOption.AllDirectories);
            foreach (string file in filePaths)
            {
                File.Delete(file);
            }
        }

        public bool HistoriqueDisplayed()
        {
            return Historique.Displayed;
        }

        public void HistoriqueClick()
        {
            if (ComM.IsElementPresent(By.Id("CaseInvoicesGeneralTreeViewSpan100172699¤100005241")) == true)
            {
                Console.WriteLine("element displayed");

                Actions action = new Actions(driver);
                action.DoubleClick(Historique).Perform();

            }
            else
            {
                Console.WriteLine("element not displayed");

                Actions action = new Actions(driver);
                action.DoubleClick(Valorisation).Perform();

                Thread.Sleep(3000);

                Actions action2 = new Actions(driver);
                action2.DoubleClick(Historique).Perform(); 
            }
        }

        public bool valorisationDepotHistoriqueDisplayed(string valorisationDepot)
        {
            return driver.FindElement(By.Id("CaseInvoicesGeneralTreeViewSpan100172699¤100005241¤"+ valorisationDepot)).Displayed;                                 
        }

        public void valorisationDepotHistoriqueClick(string valorisationDepot)
        {
            driver.FindElement(By.Id("CaseInvoicesGeneralTreeViewSpan100172699¤100005241¤" + valorisationDepot)).Click();
        }

        public int TarifEnvoiRecommandéDisplayed()
        {
            string xpath_1 = "//*[@id='CaseWorkMadeDetailGrid']/div[2]/table/tbody/tr[";
            string xpath_2 = "]/td[2]/div";

            int trouveElement = ComM.ElementExist(1, xpath_1, xpath_2, "Envoi recommandé");

            return trouveElement;
        }

        public bool EnvoiRecommandéDisplayed()
        {
            return EnvoiRecommandéHistorique.Displayed;
        }

        public void FacturationClick()
        {
            Facturation.Click();
        }

        public void CheckBoxSupprimerLignesClick()
        {
            CheckBoxSupprimerLignes.Click();
        }

        public void FacturationButtonClick()
        {
            FacturationButton.Click();
        }
        public int ValorisationLigneDisplayed(string libellé)
        {
            string xpath_1_Total = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[2]/div[1]/div/div/div[1]/div/table/thead/tr/th[";
            string xpath_2_Total = "]/a/div";

            int j = ComM.ParcourList(1, xpath_1_Total, xpath_2_Total, "Libellé");

            Thread.Sleep(2000);

            string xpath_1 = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[2]/div[1]/div/div/div[2]/table/tbody/tr[";
            string xpath_2 = "]/td["+ j +"]/div";

            int trouveElement = ComM.ElementExist(1, xpath_1, xpath_2, libellé);
            

            return trouveElement;
        }

        public bool repertoireFactureDisplayed()
        {
            return repertoireFacture.Displayed;
        }

        public bool repertoireProcedureDisplayed()
        {
            return repertoireProcedure.Displayed;
        }

        public string idFactorisation()
        {
            string id = FactureId.GetAttribute("value");
            bool trouve = false;
            string idfact = "";
            int i = 0;

            while(i<id.Length)
            {
                if(id[i].ToString() == "¤")
                {
                    trouve = true;
                    i++;
                }

                if(trouve == true)
                {
                    idfact = idfact + id[i].ToString();
                }

                i++;
            }

            return idfact;


        }

        public bool FactureDisplayed(string facturation)
        {
            return driver.FindElement(By.Id("CaseInvoicesGeneralTreeViewSpan100128245¤100046176¤"+facturation)).Displayed;
        }

        public void FactureClick(string facturation)
        {
            Actions action = new Actions(driver);
            action.DoubleClick(driver.FindElement(By.Id("CaseInvoicesGeneralTreeViewSpan100128245¤100046176¤" + facturation))).Perform();
        }

        public string Taxes()
        {
            return TaxesDisplayed.Text;
        }

        public void NumérotationFactureClick()
        {
             NumérotationFacture.Click();
        }

        public void NumérotationFactureDateSendKey()
        {
            NumérotationFactureDate.Clear();
            NumérotationFactureDate.Click();
            Thread.Sleep(3000);

            DateTime now = DateTime.Today.AddDays(-1);
            NumérotationFactureDate.SendKeys(now.Day.ToString() + "/" + now.Month.ToString() + "/" + now.Year.ToString());

            Date.Click();

            Thread.Sleep(3000);
            dateFact = NumérotationFactureDate.GetAttribute("value");
        }

        public void NumérotationValiderClick()
        {
            NumérotationValiderButton.Click();
        }

        public string FactureTitleText()
        {
            return FactureTitle.Text;
        }

        public int DateTextDisplayed()
        {
            Console.WriteLine(dateFact.CompareTo(DateDisplayed.GetAttribute("Value")));
            return dateFact.CompareTo(DateDisplayed.GetAttribute("Value"));
        }

        public void CréditClick()
        {
            Crédit.Click();
        }

        public void DateClick()
        {
            Date.Click();
        }

        public bool AvoirsurFactureDisplayed()
        {
            return driver.FindElement(By.XPath("//div[contains(text(),'Avoir sur facture')]")).Displayed;
        }

        public string TaxeDisplayed()
        {
            return TaxesOfficiellestext.Text;
        }

        public string FraisHonDisplayed()
        {
            return FraisHonorairestext.Text;
        }

        public int ListEtatValorisationResult()
        {
            string xpath_1_colonne = "//*[@id='CaseWorkMadeDetailGrid']/div[1]/div/table/thead/tr/th[";
            string xpath_2_colonne = "]/a";

            int i = ComM.ParcourListWithEquals(1, xpath_1_colonne, xpath_2_colonne, "Etat");

            string xpath_1 = "//*[@id='CaseWorkMadeDetailGrid']/div[2]/table/tbody/tr[";
            string xpath_2 = "]/td[";
            string xpath_3 = "]/div";
            string text = "Facturable";

            int result = ComM.ParcourListNomComplet(1, xpath_1, xpath_2, xpath_3, i, text);
            Console.WriteLine(result);
            return result;
        }

        public void DropDownClick()
        {
            DropDown.Click();
        }

        public void TypeClick()
        {
            BrevetsRecherche.Click();
        }

        public void AddClick()
        {
            Add.Click();
        }

        public void NFactureSendKeys(string Nfacture)
        {
            NFacture.SendKeys(Nfacture);
        }

        public void DateFactureSendKeys(string dateFacture)
        {
            DateFacture.Clear();
            DateFacture.Click();
            Thread.Sleep(3000);
            DateFacture.SendKeys(dateFacture);
        }

        public void DocumentUploadClick()
        {
            Document.Click();
        }

        public void Fileupload()
        {
            string document = Environment.GetEnvironmentVariable("USERPROFILE") + @"\source\Workspaces\AlissiaIpr2\QA\MAT1\MAT1\Document" + @"\";
            FileUpload.SendKeys(@document + "Communication du dépôt au client.docx");
        }

        public void AjouterDocumentDéboursClick()
        {
            AjouterDocumentDébours.Click();
        }

        public string DocumentText()
        {
            return Document.GetAttribute("value");
        }

        public void DéboursSendKeys(string debours)
        {
            Débours.Click();
            DéboursInput.SendKeys(debours);
        }

        public void HonoraireSendKeys(string honoraire)
        {
            Honoraires.Click();
            HonorairesInput.SendKeys(honoraire);
            Thread.Sleep(2000);
            Débours.Click();
        }

        public string TotalTTCText()
        {
            return TotalTTC.GetAttribute("aria-valuenow");
        }

        public string DeviseText()
        {
            return Devise.GetAttribute("value");
        }

        public void EtapeClick()
        {
             Etape.Click();
        }

        public void EtapesProcédureClick()
        {
            EtapesProcédure.Click();
        }

        public void EtapesProcédureAvisDepotClick()
        {
            if (ComM.IsElementPresent(By.XPath("//*[@id='TimeSheetCaseAndStepEditorLaunchableStepsTree']//div[contains(text(),'Valorisation Dépôt')]")) == true)
            {
                Console.WriteLine("element displayed");

            }
            else
            {
                Console.WriteLine("element not displayed");

                Actions action = new Actions(driver);
                action.DoubleClick(EtapesProcédureAvisDepot).Perform();
            }
        }

        public void EtapesProcédureValorisationDepotClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(EtapesProcédureValorisationDepot).Perform();
        }

        public void EditerEtapeValidationButtonClick()
        {
            EditerEtapeValidationButton.Click();
        }

        public void IntervenantInputClick()
        {
            IntervenantInput.Click();
        }

        public void initialePersonneSendKeys(string initialePersonne)
        {
            PersonneInitiale.SendKeys(initialePersonne);
        }

        public void ListeUtilisateurValidationButtonClick()
        {
            ListeUtilisateurValidationButton.Click();
        }

        public void MotifSendKeys(string motif)
        {
            Motif.SendKeys(motif);
        }

        public void DeboursValidationButtonClick()
        {
            DeboursValidationButton.Click();
        }

        public string ElémentDeboursTest(string element)
        {
            string xpath_1_colonne = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[2]/div[1]/div/table/thead/tr/th[";
            string xpath_2_colonne = "]/a";

            int i = ComM.ParcourListWithEquals(1, xpath_1_colonne, xpath_2_colonne, element);

            Console.WriteLine(i);

            string xpath_1 = "/html/body/div[2]/section/div[3]/div[3]/div/div/div[8]/div[1]/div[3]/div/div[2]/div[2]/table/tbody/tr/td[";
            string xpath_2 = "]";

            return driver.FindElement(By.XPath(xpath_1+i+xpath_2)).Text;
        }

        public void valorisationClick(string valorisation)
        {
            driver.FindElement(By.Id("CaseInvoicesGeneralTreeViewSpan100172699¤100128231¤" + valorisation)).Click();
        }

        public void DéboursExternesClick()
        {
            string xpath_1 = "//*[@id='CaseWorkMadeDetailGrid']/div[2]/table/tbody/tr[";
            string xpath_2 = "]/td[2]/div";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, "Débours externes");

            driver.FindElement(By.XPath(xpath_1 + i + xpath_2)).Click();
        }

        public string IntervenantText()
        {
            return InterText.GetAttribute("value");
        }

        public string Etattext()
        {
            return EtatText.Text;
        }

        public string DéboursText()
        {
            return DeboursText.GetAttribute("aria-valuenow");
        }

        public string FraisTextDisplayed()
        {
            return FraisText.GetAttribute("aria-valuenow");
        }

        public string TotalTextTextDisplayed()
        {
            return TotalText.Text;
        }

        public string IntervenantInputTextDisplayed()
        {
            Console.WriteLine(driver.FindElement(By.XPath("//input[contains(@value,'Julien Cavaggion')]")).GetAttribute("value"));
            return IntervenantInputText.GetAttribute("value");
        }

        public string FournisseurTextDisplayed()
        {
            Console.WriteLine(FournisseurText.GetAttribute("value"));
            return FournisseurText.GetAttribute("value");
        }

        public string NFactureTextDisplayed()
        {
            Console.WriteLine(NFactureText.GetAttribute("value"));
            return NFactureText.GetAttribute("value");
        }

        public string DatetxtDisplayed()
        {
            Console.WriteLine(DateText.GetAttribute("value"));
            return DateText.GetAttribute("value");
        }

        public string TotalDeboursDisplayed()
        {
            Console.WriteLine(TotalDebours.Text);
            return TotalDebours.Text;
        }

        public string TotalFraisDisplayed()
        {
            Console.WriteLine(TotalFrais.Text);
            return TotalFrais.Text;
        }

        public string TotalDisplayed()
        {
            Console.WriteLine(Total.Text);
            return Total.Text;
        }

        public void DiversClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(Divers).Perform();
        }

        public bool DiversDocDisplayed()
        {
            return DiversDoc.Displayed;
        }

        public void NuméroAutomatiqueCheckBoxClick()
        {
            NuméroAutomatiqueCheckBox.Click();
        }

        public void RéférenceSendKeys(string référence)
        {
            Référence.SendKeys(référence);
        }

        public void DocumentIconClick()
        {
            documentIcon.Click();
        }

        public void OuvrirDocumentClick()
        {
            AutoItX3 auto = new AutoItX3();
            auto.ControlFocus("TEST AUTO - Alissia - Google Chrome", "", "");

            auto.MouseClick("LEFT", 1011, 190, 1, -1);
        }

        public void CompanySendKeys(string company)
        {
            AutoItX3 auto = new AutoItX3();
            auto.MouseClick("LEFT", 965, 484, 1, -1);
            auto.Send(company);
        }

        public void UsernameSendKeys(string username)
        {
            AutoItX3 auto = new AutoItX3();
            auto.MouseClick("LEFT", 965, 540, 1, -1);
            auto.Send(username);
        }

        public void PasswordSendKeys(string password)
        {
            AutoItX3 auto = new AutoItX3();
            auto.MouseClick("LEFT", 965, 597, 1, -1);
            auto.Send(password);
        }

        public void ConnexionClick()
        {
            AutoItX3 auto = new AutoItX3();
            auto.MouseClick("LEFT", 957, 690, 1, -1);
        }

        public void DocumentWordDisplayed()
        {
            Application application = new Application();
            Document document = application.Documents.Open("https://formationshare.alissia.fr/sites/patent-documents/Documents%20partages/Communication_du_d%C3%A9p%C3%B4t_au_client_(dossier_sans_priorit%C3%A9)_*.docx?web=1");

            // Loop through all words in the document.
            int count = document.Words.Count;

            Console.WriteLine(count);
        }

        public void Retour()
        {
            AutoItX3 auto = new AutoItX3();
            auto.MouseClick("LEFT", 1565, 9, 1, -1);
        }

        public void HistoriqueRadioButtonClick()
        {
            HistoriqueRadioButton.Click();
        }

        public void DateNDepotHistoriqueClick(string date_NDepot)
        {            
            if (ComM.IsElementPresent(By.XPath("//*[@id='EditCaseWorkflowHistoryTreeView']//div[contains(text(),'" + date_NDepot + "')]")) == true)
            {
                Console.WriteLine("element displayed");

                Actions action2 = new Actions(driver);
                action2.DoubleClick(driver.FindElement(By.XPath("//*[@id='EditCaseWorkflowHistoryTreeView']//div[contains(text(),'" + date_NDepot + "')]"))).Perform();
            }
            else
            {
                Console.WriteLine("element not displayed");

                Actions action = new Actions(driver);
                action.DoubleClick(driver.FindElement(By.XPath("//*[@id='EditCaseWorkflowHistoryTreeView']//div[contains(text(),'Avis de dépôt')]"))).Perform();

                Thread.Sleep(5000);

                Actions action2 = new Actions(driver);
                action2.DoubleClick(driver.FindElement(By.XPath("//*[@id='EditCaseWorkflowHistoryTreeView']//div[contains(text(),'" + date_NDepot + "')]"))).Perform();
            }
        }

        public bool HistoriqueTypeDis()
        {
            return HistoriqueTypeDisplayed.Displayed;
        }

        public bool HistoriqueDateDis()
        {
            return HistoriqueDateDisplayed.Displayed;
        }

        public bool HistoriquePaysDis()
        {
            return HistoriquePaysDisplayed.Displayed;
        }

        public bool HistoriqueNuméroDis()
        {
            return HistoriqueNuméroDisplayed.Displayed;
        }

        public void OuvrirLienClick()
        {
            Dossier.Click();
            Thread.Sleep(2000);
            Ouvrir.Click();
        }

        public void OngletDossiersClick()
        {
            OngletDossier.Click();
        }

        public void ObjetDuDossierClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(ObjetDuDossier).Perform();
        }

        public void EgaleàClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(Egaleà).Perform();
        }

        public void MarquesClick()
        {
            Marques.Click();
        }

        public void RéférenceDuDossierClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(RéférenceDuDossier).Perform();
        }

        public void CommencerParClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(CommencePar).Perform();
        }

        public void ValeurSendKeys(string valeur)
        {
            Valeur.SendKeys(valeur);
        }

        public void ValiderClick()
        {
            Valider.Click();
        }

        public void DossierEnVigueurClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(DossierEnVigueur).Perform();
        }

        public void ParamétrageColonnesClick()
        {
            ParamétrageColonnes.Click();
        }

        public void ImageDragAndDrop()
        {
            Actions action = new Actions(driver);
            action.DragAndDrop(Image, DonneurOrdre).Build().Perform();
        }

        public void ListeCaractéristiqueDragAndDrop()
        {
            Actions action = new Actions(driver);
            action.DragAndDrop(ListeDesCaractéristique, Voie).Build().Perform();
        }

        public void ProtectionDragAndDrop()
        {
            Actions action = new Actions(driver);
            action.DragAndDrop(Protection, Statut).Build().Perform();
        }

        public void SauvegarderClick()
        {
            Sauvegarder.Click();
        }

        public bool ColonneImageDisplayed()
        {
            return ComM.IsElementPresent(By.XPath("//*[@id='ResultGrid']//div[@title= 'Image']"));
        }

        public bool ColonneListeDesClassesDisplayed()
        {
            return ComM.IsElementPresent(By.XPath("//*[@id='ResultGrid']//div[@title= 'Liste des caractéristiques']"));
        }

        public bool ColonneProtectionDisplayed()
        {
            return ComM.IsElementPresent(By.XPath("//*[@id='ResultGrid']//div[@title= 'Protection']"));
        }

        public void DragAndDropInverse()
        {
            ParamétrageColonnes.Click();

            Thread.Sleep(8000);

            Actions action = new Actions(driver);
            action.DragAndDrop(ImageColonneSélectionné, Statut).Build().Perform();

            Thread.Sleep(5000);

            Actions action1 = new Actions(driver);
            action1.DragAndDrop(ListeDesCaractéristiqueColonneSélectionné, SousStatut).Build().Perform();

            Thread.Sleep(5000);

            Actions action2 = new Actions(driver);
            action2.DragAndDrop(ProtectionColonnesDisponible, PaysColonneSélectionné).Build().Perform();

            Thread.Sleep(5000);

            Sauvegarder.Click();
        }

        public void AjouterDocumentSendKeys()
        {
            string document = Environment.GetEnvironmentVariable("USERPROFILE") + @"\source\Workspaces\AlissiaIpr2\QA\MAT1\MAT1\Document" + @"\";
            AjouterDocument.SendKeys(@document + "Communication du dépôt au client.docx");

            AjouterDocument.Click();
        }

        public void AjoutFile()
        {
            AutoItX3 auto = new AutoItX3();
            auto.ControlFocus("Ouvrir", "", "Edit1");
            auto.ControlSetText("Ouvrir", "", "Edit1", @"C:\Users\insafki\Desktop\Documents-Ordipat\Communication.docx");

            Thread.Sleep(2000);
            auto.ControlClick("Ouvrir", "", "Button1");

            Thread.Sleep(5000);
            auto.ControlFocus("Ouvrir", "", "Edit1");
            auto.ControlSetText("Ouvrir", "", "Edit1", "Communication.docx");

            Thread.Sleep(2000);
            auto.ControlClick("Ouvrir", "", "Button1");
        }

        public void TitreBropBownClick()
        {
            TitreBropBown.Click();
        }

        public void TitreClick()
        {
            Console.WriteLine(Titre.Text);
            Titre.Click();
        }

        public string TitreText()
        {
            return Titre.Text;
        }

        public void NatureListClick()
        {
            NatureList.Click();
        }

        public void AdministratifBrevetsClick()
        {
            AdministratifBrevets.Click();
        }

        public void CommentaireSendKeys(string commentaire)
        {
            Commentaire.SendKeys(commentaire);
        }

        public void AjouterDocumentValidationButtonClick()
        {
            AjouterDocumentValidationButton.Click();
        }

        public void DragAndDropFile()
        {
            
        }

        public bool DocumentDiversDisplayed(string documentName)
        {
            return driver.FindElement(By.XPath("//*[@id='WorkflowDocumentsTreeView_tv_active']//span[contains(text(),'"+ documentName + "')]")).Displayed;
        }

        public string DocumentTitreText()
        {
            return DocumentTitre.GetAttribute("value");
        }

        public string DocumentTypeText()
        {
            return DocumentType.GetAttribute("value");
        }

        public bool DocumentNatureText()
        {
            return DocumentNature.Displayed;
        }

        public string DocumentCommentaireText()
        {
            return DocumentCommentaire.Text;
        }

        public bool DocumentDisplayedErreur()
        {
            return ComM.IsElementPresent(By.Id("WACErrorHeader"));
        }

        public void AjouterUnDocumentSendKeys()
        {
            string document = Environment.GetEnvironmentVariable("USERPROFILE") + @"\source\Workspaces\AlissiaIpr2\QA\MAT1\MAT1\Document" + @"\";
            AjouterUnDocument.SendKeys(@document + "Communication du dépôt au client.docx");
        }

        public void TitreInputClear()
        {
            TitreInput.Clear();
        }

        public void TitreInputSendKeys(string titre)
        {
            TitreInput.SendKeys(titre);
        }

        public void DossiersRechercheClick()
        {
            DossiersRecherche.Click();
        }

        public void dossierSelect()
        {
            if (ComM.IsElementPresent(By.Id("SearchEnginePopup_wnd_title")) == true)
            {
                DossierRéférenceList.Click();

                Thread.Sleep(5000);
                SélectionnezButton.Click();
            }

            else
            {
                //
            }
        }

        public void UploadLogo()
        {
            string document = Environment.GetEnvironmentVariable("USERPROFILE") + @"\source\Workspaces\AlissiaIpr2\QA\MAT1\MAT1\Document" + @"\";
            AjouterUnDocument.SendKeys(@document + "Alissia.jpg");
        }

        public void ImageprincipaleClick()
        {
            Imageprincipale.Click();
        }

        public void DisponibleSurPortailClick()
        {
            DisponibleSurPortail.Click();
        }

        public bool LogoDisplayed()
        {
            return ComM.IsElementPresent(By.Id("trademarkImageContainer"));
        }

        public bool LogoDiversDisplayed(string logoName)
        {
            return driver.FindElement(By.XPath("//*[@id='WorkflowDocumentsTreeView_tv_active']//span[contains(text(),'" + logoName + "')]")).Displayed;
        }

        public void DossierListClick(string dossier)
        {
            if (driver.FindElement(By.Id("SearchEnginePopup_wnd_title")).Displayed == true)
            {
                driver.FindElement(By.XPath("//*[@id='ResultGrid']//td[text()='" + dossier + "']")).Click();
            }
            else
            {
                Console.WriteLine("Element not présent");
            }

        }
    }
}
