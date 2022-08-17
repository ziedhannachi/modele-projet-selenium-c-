using MAT1.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MAT1.PageObjects.ValorisationDevisPages
{
    class GestionValorisationDevisObjects
    {
        public IWebDriver driver;
        static CommonMethod ComM;

        public GestionValorisationDevisObjects(IWebDriver driver)
        {
            this.driver = driver;
            #pragma warning disable CS0618 // Le type ou le membre est obsolète
            PageFactory.InitElements(driver, this);
            #pragma warning restore CS0618 // Le type ou le membre est obsolète

            ComM = new CommonMethod(driver);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='mainContent']//div[contains(text(),'Valorisation & Devis')]")]
        public IWebElement ValorisationDevis;

        [FindsBy(How = How.LinkText, Using = "Saisie des heures")]
        public IWebElement SaisieDesHeures;

        [FindsBy(How = How.Id, Using = "FinancesEditTimeSheetToolBarNewTariffButton")]
        public IWebElement AjouterLigne;

        [FindsBy(How = How.Id, Using = "WorkDate")]
        public IWebElement DateInput;

        [FindsBy(How = How.Id, Using = "CaseReferenceDisplayText")]
        public IWebElement RéférenceInput;

        [FindsBy(How = How.Id, Using = "CommentText")]
        public IWebElement MotifInput;

        [FindsBy(How = How.Id, Using = "FloStepDisplayText")]
        public IWebElement Etape;

        [FindsBy(How = How.XPath, Using = "//input[@value='NEW']")]
        public IWebElement EtapeProcedure;

        [FindsBy(How = How.XPath, Using = "//*[@id='TimeSheetCaseAndStepEditorLaunchableStepsTree']/ul/li/ul/li[4]/div/span[2]")]
        public IWebElement EtapesProcédureAvisDepot;

        [FindsBy(How = How.XPath, Using = "//*[@id='TimeSheetCaseAndStepEditorLaunchableStepsTree']//div[contains(text(),'Valorisation DEPOT')]")]
        public IWebElement EtapesProcédureValorisationDepot;

        [FindsBy(How = How.Id, Using = "TimeSheetCaseAndStepEditorValidateButton")]
        public IWebElement ValiderButton;

        [FindsBy(How = How.Id, Using = "ScaleNumberDisplayText")]
        public IWebElement EchelonInput;

        [FindsBy(How = How.XPath, Using = "//*[@id='ListOfValueGridTimeSheetScaleLineLOV']//td[contains(text(),'3ème Echelon')]")]
        public IWebElement Echelon3;

        [FindsBy(How = How.Id, Using = "ListOfValueValidateButtonTimeSheetScaleLineLOV")]
        public IWebElement Valider;

        [FindsBy(How = How.XPath, Using = "//*[@id='FinancesEditTimeSheetsGrid']/div[3]/table/tbody/tr/td[12]/span[1]/span/input[1]")]
        public IWebElement Input1QtéVal;

        [FindsBy(How = How.Id, Using = "MainWorkedValueNumberHour")]
        public IWebElement QtéValInput;

        [FindsBy(How = How.XPath, Using = "//*[@id='FinancesEditTimeSheetsGrid']/div[3]/table/tbody/tr/td[13]/span[1]/span/input[1]")]
        public IWebElement Input1QtéFac;

        [FindsBy(How = How.Id, Using = "MainInvoicedValueNumberHour")]
        public IWebElement QtéFacInput;

        [FindsBy(How = How.Id, Using = "FinancesEditTimeSheetToolBarSaveButton")]
        public IWebElement Sauvegarder;

        [FindsBy(How = How.XPath, Using = "//*[@id='FinancesEditTimeSheetsGrid']//div[contains(text(),'TEST AUTO')]")]
        public IWebElement BoldText;

        [FindsBy(How = How.XPath, Using = "//span[@aria-activedescendant= 'QuickSearchObject_option_selected']")]
        public IWebElement DropDown;

        [FindsBy(How = How.XPath, Using = "//*[@id='QuickSearchObject_listbox']//div[contains(text(),'Brevets')]")]
        public IWebElement BrevetsRecherche;

        [FindsBy(How = How.LinkText, Using = "Saisie des débours")]
        public IWebElement SaisieDébours;

        [FindsBy(How = How.Id, Using = "DisbursementPartyShortNameAutocomplete")]
        public IWebElement FournisseurInput;

        [FindsBy(How = How.Id, Using = "AlissiaDebugLastNotification")]
        public IWebElement Notification;

        [FindsBy(How = How.Id, Using = "DisbursementAddNewButton")]
        public IWebElement AjouterDébours;

        [FindsBy(How = How.Id, Using = "DisbursementSaveButton")]
        public IWebElement EnregistrerDébours;

        [FindsBy(How = How.Id, Using = "DisbursementDate")]
        public IWebElement DateFacture;

        [FindsBy(How = How.Id, Using = "DisbursementText")]
        public IWebElement NFacture;

        [FindsBy(How = How.XPath, Using = "//*[@id='InvDisbursementGrid']/div[2]/table/tbody/tr/td[10]/span[1]/span/input[1]")]
        public IWebElement HonoraireInput1;

        [FindsBy(How = How.Id, Using = "DisbursmentMainOurFees")]
        public IWebElement HonoraireInput;

        [FindsBy(How = How.Id, Using = "InvDisbursementDocumentHelper-upload")]
        public IWebElement DocumentInput;

        [FindsBy(How = How.ClassName, Using = "TotalAmountDecimalWithoutVAT")]
        public IWebElement TotalTH;

        [FindsBy(How = How.ClassName, Using = "TotalAmountDecimal")]
        public IWebElement TotalTTC;

        [FindsBy(How = How.ClassName, Using = "VatAmountDecimal")]
        public IWebElement TVA;

        [FindsBy(How = How.ClassName, Using = "Document")]
        public IWebElement Document;

        [FindsBy(How = How.ClassName, Using = "CaseReference")]
        public IWebElement Référence;

        [FindsBy(How = How.XPath, Using = "//*[@id='InvDisbursementGrid']//div[contains(@class,'CaseReferenceTemplate')]")]
        public IWebElement RéférenceButton;

        [FindsBy(How = How.Id, Using = "TimeSheetCaseAndStepEditorCaseReferenceText")]
        public IWebElement RéférenceDossierInput;

        [FindsBy(How = How.Id, Using = "TimeSheetCaseAndStepEditorCaseTitleText")]
        public IWebElement TitreDossierInput;

        [FindsBy(How = How.XPath, Using = "//*[@id='TimeSheetCaseAndStepEditorStepsTree_tv_active']//div[contains(text(),'Valorisation Dépôt')]")]
        public IWebElement ÉtapeDisplayed;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Brevet - Dépôts étrangers')]")]
        public IWebElement EvénementDisplayed;

        [FindsBy(How = How.XPath, Using = "//*[@id='TimeSheetCaseAndStepEditorTrfPortfolioTariffsGrid']//td[text()= 'Dossiers Brevets']")]
        public IWebElement FiltreEvénementsDisplayed;

        [FindsBy(How = How.XPath, Using = "//*[@id='TimeSheetCaseAndStepEditorTrfPortfolioTariffsGrid']//td[text()= 'Débours externes']")]
        public IWebElement DéboursDisplayed;

        [FindsBy(How = How.XPath, Using = "//*[@id='TimeSheetCaseAndStepEditorTrfPortfolioTariffsGrid']//td[text()= 'Facturable']")]
        public IWebElement EtatValorisationDisplayed;

        [FindsBy(How = How.Id, Using = "CaseMiscLinkToWorKMadePartyShortDisplayText194900")]
        public IWebElement BelinInput;

        [FindsBy(How = How.Id, Using = "CaseMiscLinkToWorKMadePartyLongDisplayText194900")]
        public IWebElement Société;

        [FindsBy(How = How.Id, Using = "TimeSheetCaseAndStepEditorValidateButton")]
        public IWebElement ValiderEtSauvegarder;

        [FindsBy(How = How.XPath, Using = "//*[@id='InvDisbursementGrid']/div[2]/table/tbody/tr/td[1]/a")]
        public IWebElement Détails;

        [FindsBy(How = How.XPath, Using = "//*[@id='InvDisbursementDetailGrid']//div[contains(@class,'WorkDate')]")]
        public IWebElement DateValorisation;

        [FindsBy(How = How.XPath, Using = "//td[contains(@class,'CaseReference')]")]
        public IWebElement RéférenceDisplayed;

        [FindsBy(How = How.XPath, Using = "//td[contains(@class,'CaseTitle')]")]
        public IWebElement TitreDisplayed;

        [FindsBy(How = How.XPath, Using = "//td[contains(@class,'StepOrAnnuityLabel')]")]
        public IWebElement EtapeDisplayed;

        [FindsBy(How = How.XPath, Using = "//*[@id='InvDisbursementDetailGrid']/div[2]/table/tbody/tr/td[13]/div")]
        public IWebElement HonoraireDisplayed;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'PartiesList')]")]
        public IWebElement TiersDisplayed;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'PartiesList')]")]
        public IWebElement Tiersdisplayed;

        [FindsBy(How = How.XPath, Using = "//*[@id='InvDisbursementDetailGrid']/div[1]/div/table/thead/tr/th[13]/a/div")]
        public IWebElement HonoraireColor;

        [FindsBy(How = How.XPath, Using = "//*[@id='InvDisbursementGrid']//img[@class= 'DisbursementDetailAddNewIconIMG']")]
        public IWebElement AjouterDtail;

        [FindsBy(How = How.Id, Using = "RateDecimal']")]
        public IWebElement CoefInput;

        
        public void ValorisationDevisClick()
        {
            ComM.ExplicitWait(By.XPath("//*[@id='mainContent']//div[contains(text(),'Valorisation & Devis')]"));
            ValorisationDevis.Click();
        }

        public void SaisieDesHeuresClick()
        {
            SaisieDesHeures.Click();
        }

        public void AjouterLigneClick()
        {
            ComM.ExplicitWait(By.Id("FinancesEditTimeSheetToolBarNewTariffButton"));
            AjouterLigne.Click();
        }
        
        public void DateInputSendKeys(string date)
        {
            DateInput.Clear();
            DateInput.Click();
            Thread.Sleep(3000);

            DateInput.SendKeys(date);
        }

        public void RéférenceInputSendKeys(string référence)
        {
            RéférenceInput.SendKeys(référence);
        }

        public void MotifInputSendKeys(string motif)
        {
            MotifInput.SendKeys(motif);
        }

        public void EtapeClick()
        {
            Etape.Click();
        }

        public void EtapeProcedureClick()
        {
            EtapeProcedure.Click();
        }

        public void LancerEtapeValorisation()
        {
            if (EtapesProcédureValorisationDepot.Displayed == true)
            {
                Console.WriteLine("element displayed");

                Actions action = new Actions(driver);
                action.DoubleClick(EtapesProcédureValorisationDepot).Perform();

            }
            else
            {
                Console.WriteLine("element not displayed");

                Actions action = new Actions(driver);
                action.DoubleClick(EtapesProcédureAvisDepot).Perform();

                Thread.Sleep(5000);

                Actions action1 = new Actions(driver);
                action1.DoubleClick(EtapesProcédureValorisationDepot).Perform();
            }
        }

        public void ValiderButtonClick()
        {
            ValiderButton.Click();
        }

        public void EchelonInputClick()
        {
            ComM.ExplicitWait(By.Id("ScaleNumberDisplayText"));
            EchelonInput.Click();
        }

        public void Echelon3Click()
        {
            ComM.ExplicitWait(By.XPath("//*[@id='ListOfValueGridTimeSheetScaleLineLOV']//td[contains(text(),'3ème Echelon')]"));
            Echelon3.Click();
        }

        public void ValiderClick()
        {
            Valider.Click();
        }

        public void QtéValSendKeys(string heure)
        {
            Input1QtéVal.Click();

            Thread.Sleep(5000);

            QtéValInput.SendKeys(heure);
        }

        public void QtéFacSendKeys(string heure)
        {
            Input1QtéFac.Click();

            Thread.Sleep(5000);

            QtéFacInput.SendKeys(heure);
        }

        public void SauvegarderClick()
        {
            Sauvegarder.Click();
        }

        public string BoldTextDisplayed()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            String fontWeight = (String)js.
                    ExecuteScript(
                            "return getComputedStyle(arguments[0]).getPropertyValue('font-weight');",
                            BoldText);

            return fontWeight;
        }

        public void DropDownClick()
        {
            DropDown.Click();
        }

        public void TypeClick()
        {
            BrevetsRecherche.Click();
        }

        public void SaisieDéboursClick()
        {
            SaisieDébours.Click();
        }

        public void FournisseurInputSendKeys(string fournisseur)
        {
            ComM.ExplicitWait(By.Id("DisbursementPartyShortNameAutocomplete"));
            FournisseurInput.SendKeys(fournisseur);
        }

        public string NotificationText()
        {
            return Notification.GetAttribute("messagetodisplay");
        }

        public void AjouterDéboursClick()
        {
            AjouterDébours.Click();
        }

        public void EnregistrerDéboursClick()
        {
            EnregistrerDébours.Click();
        }

        public void DateFactureSendkeys(string date)
        {
            DateFacture.SendKeys(Keys.Control + "a");
            Thread.Sleep(3000);

            DateFacture.SendKeys(date);
        }

        public void NFactureSendKeys(string nFacture)
        {
            NFacture.SendKeys(nFacture);
        }

        public void HonoraireInputSendKeys(string honoraire)
        {
            HonoraireInput1.Click();

            Thread.Sleep(2000);

            string a = HonoraireInput.GetAttribute("value");
            while (HonoraireInput.GetAttribute("value").Length != 0)
            {
                HonoraireInput.SendKeys(Keys.Backspace);
                a = HonoraireInput.GetAttribute("value");
            }
            HonoraireInput.SendKeys(honoraire);
        }

        public void DocumentInputClick()
        {

            Document.Click();
        }

        public string TotalTHText()
        {
            Console.WriteLine(TotalTH.Text);
            return TotalTH.Text;
        }

        public string TotalTTCText()
        {
            Console.WriteLine(TotalTTC.Text);
            return TotalTTC.Text;
        }

        public string TVAText()
        {
            return TVA.Text;
        }

        public void DocumentInputSendKeys()
        {
            string document = Environment.GetEnvironmentVariable("USERPROFILE") + @"\source\Workspaces\AlissiaIpr2\QA\MAT1\MAT1\Document" + @"\";
            DocumentInput.SendKeys(@document + "Communication du dépôt au client.docx");
        }

        public void RéférenceClick()
        {
            Référence.Click();
        }

        public void RéférenceButtonClick()
        {
            RéférenceButton.Click();
        }

        public void RéférenceDossierInputSendKeys(string référence)
        {
            ComM.ExplicitWait(By.Id("TimeSheetCaseAndStepEditorCaseReferenceText"));
            RéférenceDossierInput.SendKeys(référence);
        }

        public bool Étapedisplayed()
        {
            return ÉtapeDisplayed.Displayed;
        }

        public bool Evénementdisplayed()
        {
            return EvénementDisplayed.Displayed;
        }

        public bool FiltreEvénementsdisplayed()
        {
            return FiltreEvénementsDisplayed.Displayed;
        }

        public bool Déboursdisplayed()
        {
            return DéboursDisplayed.Displayed;
        }

        public bool EtatValorisationdisplayed()
        {
            return EtatValorisationDisplayed.Displayed;
        }

        public string BelinInputText()
        {
            return BelinInput.GetAttribute("value");
        }

        public string SociétéInputText()
        {
            return Société.GetAttribute("value");
        }

        public void ValiderEtSauvegarderClick()
        {
            ValiderEtSauvegarder.Click();
        }

        public void DétailsClick()
        {
            Détails.Click();
        }

        public string DateValorisationText()
        {
            return DateValorisation.Text;
        }

        public string RéférenceDisplayedText()
        {
            return RéférenceDisplayed.Text;
        }

        public string TitreDisplayedText()
        {
            return TitreDisplayed.Text;
        }

        public string EtapeDisplayedText()
        {
            return EtapeDisplayed.Text;
        }

        public string HonoraireDisplayedText()
        {
            Console.WriteLine(HonoraireDisplayed.Text);
            return HonoraireDisplayed.Text;
        }

        public string TiersDisplayedText()
        {
            return Tiersdisplayed.Text;
        }

        public string honoraireDisplayed()
        {
            return HonoraireColor.GetAttribute("class");
        }

        public void AjouterDtailClick()
        {
            AjouterDtail.Click();
        }

        public bool CoefInputDisplayed()
        {
            ComM.ExplicitWait(By.Id("RateDecimal"));
            return CoefInput.Displayed;
        }
    }
}
