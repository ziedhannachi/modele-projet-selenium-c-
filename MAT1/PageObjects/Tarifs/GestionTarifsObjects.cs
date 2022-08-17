using MAT1.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MAT1.PageObjects.Tarifs
{
    class GestionTarifsObjects
    {

        public IWebDriver driver;
        static CommonMethod ComM;

        public GestionTarifsObjects(IWebDriver driver)
        {
            this.driver = driver;
            #pragma warning disable CS0618 // Le type ou le membre est obsolète
            PageFactory.InitElements(driver, this);
            #pragma warning restore CS0618 // Le type ou le membre est obsolète

            ComM = new CommonMethod(driver);
        }

        [FindsBy(How = How.LinkText, Using = "Finances")]
        public IWebElement FinancesLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='mainContent']//div[contains(text(), 'Tarifs')]")]
        public IWebElement Tarifs;

        [FindsBy(How = How.LinkText, Using = "Nouveau")]
        public IWebElement NouveauLink;

        [FindsBy(How = How.Id, Using = "FinancesNewTariffLabelCode")]
        public IWebElement CodeInput;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'LabelCode') and @name= 'Label.LabelCode']")]
        public IWebElement CodeLibelléParamétrage;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'LabelText') and @name= 'Label.LabelText']")]
        public IWebElement LibelléCourtLibelléParamétrage;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'LongLabelText') and @name= 'Label.LongLabelText']")]
        public IWebElement LibelléLongLibelléParamétrage;

        [FindsBy(How = How.Id, Using = "popupUpdateButton")]
        public IWebElement ValiderlibelléParamétrage;

        [FindsBy(How = How.Id, Using = "FinancesNewTariffUserLabelText")]
        public IWebElement LibelléUtilisateurs;

        [FindsBy(How = How.XPath, Using = "//*[@id='FinancesNewTariffPopup']//input[@aria-owns= 'FinancesNewTariffCountries_taglist FinancesNewTariffCountries_listbox']")]
        public IWebElement Pays;

        [FindsBy(How = How.XPath, Using = "//li[text()= 'FRANCE']")]
        public IWebElement PaysFrance;

        [FindsBy(How = How.XPath, Using = "//*[@id='FinancesNewTariffPopup']//span[text()= 'Selon le taux de copropriété']")]
        public IWebElement ModeRépartitionList;

        [FindsBy(How = How.XPath, Using = "//li[text()= 'Selon le taux de copropriété']")]
        public IWebElement SelectModeRépartition;

        [FindsBy(How = How.Id, Using = "FinancesNewTariffScaleDisplayText")]
        public IWebElement BarèmeInput;

        [FindsBy(How = How.Id, Using = "ListOfValueGridColumnHeaderFinancesNewTariffScaleLOVLabelCode")]
        public IWebElement BarèmeCode;

        [FindsBy(How = How.Id, Using = "ListOfValueValidateButtonFinancesNewTariffScaleLOV")]
        public IWebElement BarèmeValiderButton;

        [FindsBy(How = How.Id, Using = "FinancesNewTariffSelectCol100015899")]
        public IWebElement TaxesCheckbox;

        [FindsBy(How = How.XPath, Using = "/html/body/div[20]/div[2]/div[1]/table/tbody/tr[3]/td[2]/div[2]/div[2]/div[1]/label/span[2]/span/span/input[1]")]
        public IWebElement InitialiseràInput;

        [FindsBy(How = How.Id, Using = "FinancesNewTariffValidateButton")]
        public IWebElement NouveauTarifValidationButton;

        [FindsBy(How = How.Id, Using = "EditTariffSettingLabelCode")]
        public IWebElement CodeDisplayed;

        [FindsBy(How = How.Id, Using = "EditTariffSettingLabelText")]
        public IWebElement LibelléDisplayed;

        [FindsBy(How = How.Id, Using = "EditTariffUserLabelText")]
        public IWebElement LibelléUtilisateursDisplayed;

        [FindsBy(How = How.Id, Using = "EditTariffCountriesDisplay")]
        public IWebElement PaysDisplayed;

        [FindsBy(How = How.Id, Using = "EditTariffScale")]
        public IWebElement BarèmeDisplayed;

        [FindsBy(How = How.Id, Using = "OurFees")]
        public IWebElement HonorairePetiteEntité;

        [FindsBy(How = How.Id, Using = "ToolbarOptionMenuButton")]
        public IWebElement Option;

        [FindsBy(How = How.Id, Using = "FinancesEditTariffOptionMenuColumnAddButton")]
        public IWebElement AjouterColonne;

        [FindsBy(How = How.XPath, Using = "//*[@id='FinancesEditTariffOptionMenuColonneDetail']/div[1]/div[1]/div/span/span")]
        public IWebElement ColonneSelect;

        [FindsBy(How = How.XPath, Using = "//li[text()= 'Frais']")]
        public IWebElement ColonneFrais;

        [FindsBy(How = How.LinkText, Using = "Mise à jour du tarif")]
        public IWebElement MiseAJourTarif;

        [FindsBy(How = How.Id, Using = "FinancesEditTariffOptionMenuNewColumnValidateButton")]                                
        public IWebElement ValiderOptionButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[39]/div[2]/div[1]/div/div/div[2]/table/tbody/tr/td[1]/div/div[1]/div[2]/label/input")]
        public IWebElement HonoraireRadioButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[39]/div[2]/div[1]/div/div/div[2]/table/tbody/tr/td[2]/div/div[1]/div[2]/label/input")]
        public IWebElement AjouterRadioButton;

        [FindsBy(How = How.Id, Using = "FinancesEditTariffSaveButton")]
        public IWebElement SauvegarderIcon;

        [FindsBy(How = How.Id, Using = "FinancesEditTariffOptionMenuUpdateSaveButton")]
        public IWebElement ValiderButton;

        [FindsBy(How = How.Id, Using = "FinancesEditTariffOptionMenuUpdateStartDate")]
        public IWebElement EntréeEnVigueurDate;

        [FindsBy(How = How.Id, Using = "FinancesEditTariffOptionMenuClosePopupColumnButton")]
        public IWebElement FermerButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='FinancesEditTariffMainGrid']//div[contains(text(),'Frais')]")]
        public IWebElement FraisColonne;

        [FindsBy(How = How.XPath, Using = "//*[@id='FinancesEditTariffMainGrid']/div[1]/div/table/thead/tr/th[1]/div/div[3]/span/span/span[1]")]
        public IWebElement BarèmeList;

        [FindsBy(How = How.XPath, Using = "//li[contains(text(),'A partir du 20/04/2024')]")]
        public IWebElement ElementList;

        [FindsBy(How = How.LinkText, Using = "FR - Test auto")]
        public IWebElement Tarif;

        [FindsBy(How = How.XPath, Using = "//input[@aria-owns= 'FinancesNewTariffObjects_taglist FinancesNewTariffObjects_listbox']")]
        public IWebElement ObjetTarifList;

        [FindsBy(How = How.XPath, Using = "//li[text()= 'Brevets']")]
        public IWebElement Brevets;

        [FindsBy(How = How.Id, Using = "CaseWorkMadeDetailToolBarNewTariffButton")]
        public IWebElement NouveauTarif;

        [FindsBy(How = How.Id, Using = "CaseWorkMadeAddTariffPopupTariffCode")]
        public IWebElement TarifCodeInput;

        [FindsBy(How = How.Id, Using = "CaseWorkMadeAddTariffPopupTariffDisplayText")]
        public IWebElement TarifInput2;

        [FindsBy(How = How.Id, Using = "CaseWorkMadeAddTariffPopupValidateButton")]
        public IWebElement ValiderButtonNouveauTarif;

        [FindsBy(How = How.XPath, Using = "//*[@id='CaseWorkMadeDetailGrid']//div[contains(text(),'Test auto (utilisateur)')]")]
        public IWebElement TarifLigne;

        [FindsBy(How = How.XPath, Using = "//*[@id='FinancesNewTariffInitAmountContainer100015899']/span/span/input[1]")]
        public IWebElement TaxeInput1;

        [FindsBy(How = How.Id, Using = "FinancesNewTariffInitAmount100015899")]
        public IWebElement TaxeInput;

        [FindsBy(How = How.XPath, Using = "//*[@id='FinancesNewTariffInitAmountContainer100015898']/span/span/input[1]")]
        public IWebElement HonoraireInput1;

        [FindsBy(How = How.Id, Using = "FinancesNewTariffInitAmount100015898")]
        public IWebElement HonoraireInput;

        [FindsBy(How = How.XPath, Using = "//*[@id='FinancesEditTariffOptionMenuUpdateAddPercentContainer']/span/span/input[1]")]
        public IWebElement HonoraireMontantInput1;

        [FindsBy(How = How.Id, Using = "FinancesEditTariffOptionMenuUpdateAddPercent")]
        public IWebElement HonoraireMontantInput;

        public void FinancesLinkClick()
        {
            FinancesLink.Click();
        }

        public void NouveauLinkClick()
        {
            NouveauLink.Click();
        }

        public void TarifsClick()
        {
            Tarifs.Click();
        }

        public void CodeInputClick()
        {
            CodeInput.Click();
        }

        public void CodeLibelléParamétrageSendKeys(string code)
        {
            CodeLibelléParamétrage.SendKeys(code);
        }

        public void LibelléCourtLibelléParamétrageClear()
        {
            LibelléCourtLibelléParamétrage.Click();
            Thread.Sleep(3000);

            string a = LibelléCourtLibelléParamétrage.GetAttribute("value");
            while (LibelléCourtLibelléParamétrage.GetAttribute("value").Length != 0)
            {
                LibelléCourtLibelléParamétrage.SendKeys(Keys.Backspace);
                a = LibelléCourtLibelléParamétrage.GetAttribute("value");
            }
        }

        public void LibelléCourtLibelléParamétrageClick()
        {
            LibelléCourtLibelléParamétrage.Click();
        }

        public void LibelléCourtLibelléParamétrageSendKeys(string LibelléCourt)
        {
            LibelléCourtLibelléParamétrage.SendKeys(LibelléCourt);
        }

        public void LibelléLongLibelléParamétrageClick()
        {
            LibelléLongLibelléParamétrage.Click();
            Thread.Sleep(3000);

            string a = LibelléLongLibelléParamétrage.GetAttribute("value");
            while (LibelléLongLibelléParamétrage.GetAttribute("value").Length != 0)
            {
                LibelléLongLibelléParamétrage.SendKeys(Keys.Backspace);
                a = LibelléLongLibelléParamétrage.GetAttribute("value");
            }
        }

        public void LibelléLongLibelléParamétrageSendKeys(string LibelléLong)
        {
            LibelléLongLibelléParamétrage.SendKeys(LibelléLong); 
        }

        public void ValiderlibelléParamétrageClick()
        {
            ValiderlibelléParamétrage.Click();
        }

        public void LibelléUtilisateursClick()
        {
            LibelléUtilisateurs.Click();
        }

        public void ClickOKAlert()
        {
            if (ComM.isAlertPresent() == true)
            {
                IAlert alertOK = driver.SwitchTo().Alert();
                alertOK.Accept();
            }
        }

        public void PaysClick()
        {
            Pays.Click();
        }

        public void PaysFranceClick()
        {
            PaysFrance.Click();
        }

        public void ModeRépartitionListClick()
        {
            ModeRépartitionList.Click();
        }

        public void SelectModeRépartitionClick()
        {
            SelectModeRépartition.Click();
        }

        public void BarèmeInputClick()
        {
            BarèmeInput.Click();
        }

        public void BarèmeCodeSendKeys(string code)
        {
            BarèmeCode.SendKeys(code);
        }

        public void BarèmeValiderButtonClick()
        {
            BarèmeValiderButton.Click();
        }

        public void TaxesCheckboxClick()
        {
            TaxesCheckbox.Click();
        }

        public void TaxeInputSendKeys(string taxe)
        {
            TaxeInput1.Click();

            Thread.Sleep(3000);
            
            string a = TaxeInput.GetAttribute("value");
            while (TaxeInput.GetAttribute("value").Length != 0)
            {
                TaxeInput.SendKeys(Keys.Backspace);
                a = TaxeInput.GetAttribute("value");
            }

            Thread.Sleep(3000);
            TaxeInput.SendKeys(taxe);
        }

        public void HonoraireInputSendKeys(string honoraire)
        {
            HonoraireInput1.Click();

            Thread.Sleep(3000);

            string a = HonoraireInput.GetAttribute("value");
            while (HonoraireInput.GetAttribute("value").Length != 0)
            {
                HonoraireInput.SendKeys(Keys.Backspace);
                a = HonoraireInput.GetAttribute("value");
            }

            Thread.Sleep(3000);
            HonoraireInput.SendKeys(honoraire);
        }

        public void HonoraireMontantInputSendKeys(string honoraire)
        {
            HonoraireMontantInput1.Click();

            Thread.Sleep(3000);

            string a = HonoraireMontantInput.GetAttribute("value");
            while (HonoraireMontantInput.GetAttribute("value").Length != 0)
            {
                HonoraireMontantInput.SendKeys(Keys.Backspace);
                a = HonoraireMontantInput.GetAttribute("value");
            }

            Thread.Sleep(3000);
            HonoraireMontantInput.SendKeys(honoraire);
        }

        public void InitialiseràInputClick()
        {
            InitialiseràInput.Click();
            driver.FindElement(By.Id("FinancesNewTariffInitAmount100015897")).SendKeys("300");
        }

        public void NouveauTarifValidationButtonClick()
        {
            NouveauTarifValidationButton.Click();
        }

        public string CodeDisplayedText()
        {
            return CodeDisplayed.GetAttribute("value");
        }

        public string LibelléDisplayedText()
        {
            return LibelléDisplayed.GetAttribute("value");
        }

        public string LibelléUtilisateursDisplayedText()
        {
            return LibelléUtilisateursDisplayed.GetAttribute("value");
        }

        public string PaysDisplayedText()
        {
            return PaysDisplayed.GetAttribute("value");
        }

        public string BarèmeDisplayedText()
        {
            return BarèmeDisplayed.GetAttribute("value");
        }

        public void HonoraireClick(string elementText)
        {
            string xpath_1 = "//*[@id='FinancesEditTariffMainGrid']/div[2]/table/tbody/tr[";
            string xpath_2 = "]/td[1]";

            string xpath_1_Total = "/html/body/div[2]/section/div[5]/div/div[1]/div/div/div[1]/div/table/thead/tr/th[";
            string xpath_2_Total = "]/div/div[1]";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, elementText);

            driver.FindElement(By.XPath(xpath_1 + i + xpath_2)).Click();

            int j = ComM.ParcourList(1, xpath_1_Total, xpath_2_Total, "Honoraires");

            Thread.Sleep(2000);

            driver.FindElement(By.XPath(xpath_1 + i + "]/td[" + j + "]")).Click();

        }

        public void HonoraireSendKeys(string honoraire)
        {
            HonorairePetiteEntité.SendKeys(honoraire);
        }

        public void OptionClick()
        {
            Option.Click();
        }

        public void AjouterColonneClick()
        {
            AjouterColonne.Click();
        }

        public void ColonneSelectClick()
        {
            ColonneSelect.Click();
        }

        public void ColonneFraisClick()
        {
            ColonneFrais.Click();
        }

        public void MiseAJourTarifClick()
        {
            MiseAJourTarif.Click();
        }

        public void ValiderOptionButtonClick()
        {
            ValiderOptionButton.Click();
        }

        public void HonoraireRadioButtonClick()
        {
            HonoraireRadioButton.Click();
        }

        public void AjouterRadioButtonClick()
        {
            AjouterRadioButton.Click();
        }

        public void SauvegarderIconClick()
        {
            SauvegarderIcon.Click();
        }

        public void ValiderButtonClick()
        {
            ValiderButton.Click();
        }

        public void EntréeEnVigueurDateSendKeys(string date)
        {
            EntréeEnVigueurDate.Clear();
            EntréeEnVigueurDate.Click();
            Thread.Sleep(3000);
            EntréeEnVigueurDate.SendKeys(date);
        }

        public void FermerButtonClick()
        {
            FermerButton.Click();
        }

        public bool FraisColonneDisplayed()
        {
            return FraisColonne.Displayed;
        }

        public void BarèmeListClick()
        {
            BarèmeList.Click();
        }

        public void ElementListClick()
        {
            ElementList.Click();
        }

        public void TarifClick()
        {
            Tarif.Click();
        }

        public void ObjetTarifListClick()
        {
            ObjetTarifList.Click();
        }

        public void BrevetsClick()
        {
            Brevets.Click();
        }

        public void NouveauTarifClick()
        {
            NouveauTarif.Click();
        }

        public void TarifCodeInputSendKeys(string tarifCode)
        {
            TarifCodeInput.SendKeys(tarifCode);
        }

        public void ValiderButtonNouveauTarifClick()
        {
            ValiderButtonNouveauTarif.Click();
        }

        public bool TarifLigneDisplayed()
        {
            return TarifLigne.Displayed;
        }
    }
}
