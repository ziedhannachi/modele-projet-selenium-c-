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

namespace MAT1.PageObjects.Tiers
{
    class GestionTiersObjects
    {
        public IWebDriver driver;
        static CommonMethod ComM;

        public GestionTiersObjects(IWebDriver driver)
        {
            this.driver = driver;
            #pragma warning disable CS0618 // Le type ou le membre est obsolète
            PageFactory.InitElements(driver, this);
            #pragma warning restore CS0618 // Le type ou le membre est obsolète

            ComM = new CommonMethod(driver);

        }

        [FindsBy(How = How.LinkText, Using = "Tiers")]
        public IWebElement TiersLink;

        [FindsBy(How = How.LinkText, Using = "Nouveau")]
        public IWebElement NouveauLink;

        [FindsBy(How = How.Id, Using = "newNameText")]
        public IWebElement NomAbrégé;

        [FindsBy(How = How.Id, Using = "newLongNameText")]
        public IWebElement NomComplet;

        [FindsBy(How = How.Id, Using = "SaveNewParty")]
        public IWebElement SauvegarderButton;

        [FindsBy(How = How.Id, Using = "NameText")]
        public IWebElement NomAbrégéFiche;

        [FindsBy(How = How.Id, Using = "LongNameText")]
        public IWebElement NomCompletFiche;

        [FindsBy(How = How.Id, Using = "PartyCountryLabelText")]
        public IWebElement Pays;

        [FindsBy(How = How.XPath, Using = "//*[@id='ParTypeGrid']//*[text()='Insérer']")]
        public IWebElement InsérerLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='ParTypeGrid']//span[text()='ADVERS  -  Adversaire']")]
        public IWebElement Types;

        [FindsBy(How = How.Id, Using = "ParTypeLabelId_option_selected")]
        public IWebElement ADVERSAdversaireTypes;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/section/div[4]/div/div/div/div[1]/div[1]/div/div/div/div[1]/div[1]/div[3]/table/tbody/tr/td[3]/a[1]/span")]
        public IWebElement ValidationButton;

        [FindsBy(How = How.Id, Using = "AccontNumberGererationButton")]
        public IWebElement NuméroCompteAutomatique;

        [FindsBy(How = How.Id, Using = "AccountNumberSaveButton")]
        public IWebElement SauvegarderCompetButton;

        [FindsBy(How = How.Id, Using = "ToolbarStandardSave")]
        public IWebElement EnregistrerButton;

        [FindsBy(How = How.Id, Using = "MainClientAccounting")]
        public IWebElement CompteClientInput;

        [FindsBy(How = How.XPath, Using = "//li[text()='CLIDIR  -  Client Direct']")]
        public IWebElement TypesList;

        [FindsBy(How = How.XPath, Using = "//*[@id='ParTypeGrid']//td[text()='CLIDIR  -  Client Direct']")]
        public IWebElement TypeText;

        [FindsBy(How = How.LinkText, Using = "BADOIT")]
        public IWebElement BadoitTiersLink;

        [FindsBy(How = How.Id, Using = "AddressLine1Text")]
        public IWebElement adresseInput;

        [FindsBy(How = How.Id, Using = "ZipCodeText")]
        public IWebElement CodePostalInput;

        [FindsBy(How = How.Id, Using = "SaveAddressButton")]
        public IWebElement SauvegarderAdresseButton;

        [FindsBy(How = How.Id, Using = "CityLabel")]
        public IWebElement VilleInput;

        [FindsBy(How = How.LinkText, Using = "Ajouter une note")]
        public IWebElement AjouterNote;

        [FindsBy(How = How.Id, Using = "noteTemplateTitle-0")]
        public IWebElement TitreInput;

        [FindsBy(How = How.Id, Using = "noteTemplateValueText-0")]
        public IWebElement NoteInput;

        [FindsBy(How = How.Id, Using = "noteTemplateIsCaseAlert-0")]
        public IWebElement FicheDossier;

        [FindsBy(How = How.XPath, Using = "//*[@id='noteTemplate0']/div[1]/table/tbody/tr[7]/td[3]/div/div/div")]
        public IWebElement Select;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/section/div[4]/div/div/div/div[2]/div[2]/div/div[2]/div/div/div[2]/a[1]")]
        public IWebElement ValidationAddNoteButton;

        [FindsBy(How = How.XPath, Using = "//input[@value='Procédure de facturation']")]
        public IWebElement TitreDisplayed;

        [FindsBy(How = How.XPath, Using = "//textarea[text()='Procédure de facturation brevets français']")]
        public IWebElement NoteDisplayed;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Val/Fac')]")]
        public IWebElement OngletDisplayed;

        [FindsBy(How = How.XPath, Using = "//*[@id='partyMainTabStrip']/ul/li[3]/a")]
        public IWebElement Contacts;

        [FindsBy(How = How.Id, Using = "ParContactNewToolbarButton")]
        public IWebElement AjouterContact;

        [FindsBy(How = How.Id, Using = "ListOfValueValidateButtonNewContactLov")]
        public IWebElement AjouterTypeContactButton;

        [FindsBy(How = How.Id, Using = "ParContactAddNewLastName")]
        public IWebElement NomInput;

        [FindsBy(How = How.Id, Using = "ParContactAddNewFirstName")]
        public IWebElement PrénomInput;

        [FindsBy(How = How.Id, Using = "SaveNewContactButton")]
        public IWebElement AjouterButton;

        [FindsBy(How = How.Id, Using = "ListOfValueGridColumnHeaderNewContactLovLabelText")]
        public IWebElement LibelléCourt;

        [FindsBy(How = How.LinkText, Using = "Insérer")]
        public IWebElement InsérerButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='PortfolioParMailFiltersGrid']//div[@class='clickableDivForEdit ObjectLabel']")]
        public IWebElement Objet;

        [FindsBy(How = How.Id, Using = "ListOfValueGridColumnHeaderParMailObjectLOVLabelText")]
        public IWebElement Libellé;

        [FindsBy(How = How.Id, Using = "ListOfValueValidateButtonParMailObjectLOV")]
        public IWebElement Valider;

        [FindsBy(How = How.XPath, Using = "//*[@id='PortfolioParMailFiltersGrid']//a[@title='Éditer']")]
        public IWebElement ValiderCorresp;

        [FindsBy(How = How.XPath, Using = "//*[@id='PartiesPortfoliosTreeview']//span[contains(text(),'Brevets')]")]
        public IWebElement Brevets;

        [FindsBy(How = How.Id, Using = "PortfolioParMailDetailsGridAddButton")]
        public IWebElement IsérerRèglesCorrespondances;

        [FindsBy(How = How.XPath, Using = "//*[@id='PortfolioParMailDetailsGrid']//td[@class='RecipientLabel']")]
        public IWebElement Destinataire;

        [FindsBy(How = How.Id, Using = "MailsPopupContactAutocomplete")]
        public IWebElement Contact;

        [FindsBy(How = How.Id, Using = "ListOfValueGridColumnHeaderPortfolioContactLOVLastNameText")]
        public IWebElement Nom;

        [FindsBy(How = How.Id, Using = "ListOfValueValidateButtonPortfolioContactLOV")]
        public IWebElement ValidationChoixContactButton;

        [FindsBy(How = How.Id, Using = "PortfolioMailPopupSaveButton")]
        public IWebElement ValidationChoixDestinataireButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='PortfolioParMailDetailsGrid']//a[@title= 'Éditer']")]
        public IWebElement RèglesCorrespondancesValidationButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='PartiesPortfoliosTreeview_tv_active']//span[contains(text(),'Libellé à BADOIT (MAISONEUVE) ')]")]
        public IWebElement règleCorrespondance;

        [FindsBy(How = How.XPath, Using = "//span[@aria-activedescendant= 'QuickSearchObject_option_selected']")]
        public IWebElement DropDown;

        [FindsBy(How = How.Id, Using = "SearchEngineResultGridValidateValueButton")]
        public IWebElement SélectionnerButton;

        [FindsBy(How = How.LinkText, Using = "Ouvrir")]
        public IWebElement OuvrirLink;

        [FindsBy(How = How.Id, Using = "SearchEngineTreeViewSpan100011595")]
        public IWebElement NomCompletLink;

        [FindsBy(How = How.Id, Using = "SearchEngineOperatorTreeViewSpan450000006")]
        public IWebElement EgaleButton;

        [FindsBy(How = How.Id, Using = "Value")]
        public IWebElement ValeurInput;

        [FindsBy(How = How.Id, Using = "SearchEngineExecuteQueryButton")]
        public IWebElement RechercherButton;

        [FindsBy(How = How.Name, Using = "QuickSearchValueField_input")]
        public IWebElement SearchInput;

        [FindsBy(How = How.Id, Using = "SearchEngineValueFormValidateButton")]
        public IWebElement ValiderButton;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Notes')]")]
        public IWebElement NoteLink;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Contacts')]")]
        public IWebElement ContactLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='ParContactsMainGrid']//td[contains(text(),'MAISONEUVE')]")]
        public IWebElement ContactNom;

        [FindsBy(How = How.XPath, Using = "//*[@id='ParContactsMainGrid']//td[contains(text(),'Paul')]")]
        public IWebElement ContactPrénom;

        [FindsBy(How = How.XPath, Using = "//*[@id='ParContactsMainGrid']//td[contains(text(),'DIRECTION')]")]
        public IWebElement ContactType;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Portefeuilles')]")]
        public IWebElement PortefeuillesLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='PartiesPortfoliosTreeview']//span[contains(text(),'Correspondance')]")]
        public IWebElement Correspondance;

        [FindsBy(How = How.XPath, Using = "//*[@id='QuickSearchObject_listbox']//div[contains(text(),'Tiers')]")]
        public IWebElement TiersRecherche;

        [FindsBy(How = How. Id, Using = "SearchEnginePopup_wnd_title")]
        public IWebElement TiersMoteurRecherche;

        [FindsBy(How = How.XPath, Using = "//*[@id='ResultGrid']//td[text()='BADOIT']")]
        public IWebElement BadoitList;

        public void TiersLinkClick()
        {
            TiersLink.Click();
        }

        public void NouveauLinkClick()
        {
            NouveauLink.Click();
        }

        public void NomAbrégéSendKeys(string nomAbrégé)
        {
            NomAbrégé.SendKeys(nomAbrégé);
        }

        public void NomCompletSendKeys(string nomComplet)
        {
            NomComplet.Click();

            Thread.Sleep(2000);

            string a = NomComplet.GetAttribute("value");
            while (NomComplet.GetAttribute("value").Length != 0)
            {
                NomComplet.SendKeys(Keys.Backspace);
                a = NomComplet.GetAttribute("value");
            }

            NomComplet.SendKeys(nomComplet);
        }

        public void SauvegarderButtonClick()
        {
            SauvegarderButton.Click();
        }

        public string NomAbrégéFicheText()
        {
            return NomAbrégéFiche.GetAttribute("Value");
        }

        public string NomCompletFicheText()
        {
            return NomCompletFiche.GetAttribute("Value");
        }

        public string PaysText()
        {
            return Pays.GetAttribute("Value");
        }

        public void InsérerLinkClick()
        {
            InsérerLink.Click();
        }

        public void TypesClick()
        {
            Types.Click();
        }

        public void ADVERSAdversaireTypesClick()
        {
            TypesList.Click();
        }

        public void ValidationButtonClick()
        {
            ValidationButton.Click();
        }

        public void NuméroCompteAutomatiqueClick()
        {
            NuméroCompteAutomatique.Click();
        }

        public void SauvegarderCompetButtonClick()
        {
            SauvegarderCompetButton.Click();
        }

        public void EnregistrerButtonClick()
        {
            EnregistrerButton.Click();
        }

        public string CompteClientInputText()
        {
            return CompteClientInput.GetAttribute("Value");
        }

        public string TextType()
        {
            return TypeText.Text;
        }

        public void BadoitTiersLinkClick()
        {
            BadoitTiersLink.Click();
        }

        public void adresseInputSendKeys(string adresse)
        {
            adresseInput.SendKeys(adresse);
        }

        public void CodePostalInputSendKeys(string codePostal)
        {
            CodePostalInput.SendKeys(codePostal);
        }

        public void SauvegarderAdresseButtonClick()
        {
            SauvegarderAdresseButton.Click();
        }

        public string adresseInputText()
        {
            return adresseInput.GetAttribute("value");
        }

        public string CodePostalInputText()
        {
            return CodePostalInput.GetAttribute("value");
        }

        public string VilleInputText()
        {
            return VilleInput.GetAttribute("value");
        }

        public void NoteClick()
        {
            NoteLink.Click();
        }

        public void AjouterNoteClick()
        {
            AjouterNote.Click();
        }

        public void TitreInputSendKeys(string titre)
        {
            TitreInput.SendKeys(titre);
        }

        public void NoteInputSendKeys(string note)
        {
            NoteInput.SendKeys(note);
        }

        public void FicheDossierClick()
        {
            FicheDossier.Click();
        }

        public void OngletSelect()
        {
            Select.Click();

            Thread.Sleep(5000);

            string xpath_1 = "/html/body/div[107]/div/ul/li[";
            string xpath_2 = "]";
            string text = "Val/Fac";

            int i = ComM.ParcourList(1, xpath_1, xpath_2, text);
            driver.FindElement(By.XPath(xpath_1 + i + xpath_2)).Click();

        }

        public void ValidationAddNoteButtonClick()
        {
            ValidationAddNoteButton.Click();
        }

        public string TitreInputText()
        {
            return TitreDisplayed.GetAttribute("value");
        }

        public string NoteInputText()
        {
            return NoteDisplayed.Text;
        }

        public string OngletText()
        {
            Console.WriteLine(OngletDisplayed.Text);
            return OngletDisplayed.Text;
        }

        public void ContactLinkClick(string linkText)
        {
            ContactLink.Click();
        }

        public void AjouterContactClick()
        {
            AjouterContact.Click();
        }

        public void AjouterTypeContactButtonClick()
        {
            AjouterTypeContactButton.Click();
        }

        public void NomInputSendKeys(string nom)
        {
            NomInput.SendKeys(nom);
        }

        public void PrénomInputSendKeys(string prénom)
        {
            PrénomInput.SendKeys(prénom);
        }

        public void AjouterButtonClick()
        {
            AjouterButton.Click();
        }

        public void LibelléCourtSendKeys(string libellé)
        {
            LibelléCourt.SendKeys(libellé);
        }

        public void SendKeys(string libellé)
        {
            LibelléCourt.SendKeys(libellé);
        }

        public bool ContactNomDisplayed()
        {
            return ContactNom.Displayed;
        }

        public bool ContactPrénomDisplayed()
        {
            return ContactPrénom.Displayed;
        }

        public bool ContactTypeDisplayed()
        {
            return ContactType.Displayed;
        }

        public void PortefeuillesClick(string linkText)
        {
            PortefeuillesLink.Click();
            Thread.Sleep(2000);
        }

        public void CorrespondanceClick()
        {
            Correspondance.Click();
        }

        public void InsérerButtonClick()
        {
            InsérerButton.Click();
        }

        public void ObjetClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(Objet).Perform();
        }

        public void LibelléSendKeys(string libellé)
        {
            Libellé.SendKeys(libellé);
        }

        public void ValiderClick()
        {
            Valider.Click();
        }

        public void ValiderCorrespClick()
        {
            ValiderCorresp.Click();
        }

        public void CorrespDoubleClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(Correspondance).Perform();
        }

        public void BrevetsClick()
        {
            Brevets.Click();
        }

        public void IsérerRèglesCorrespondancesClick()
        {
            IsérerRèglesCorrespondances.Click();
        }

        public void DestinataireClick()
        {
            Destinataire.Click();
        }

        public void ContactClick()
        {
            Contact.Click();
        }

        public void NomSendKeys(string nom)
        {
            Nom.SendKeys(nom);
        }

        public void ValidationChoixContactClick()
        {
            ValidationChoixContactButton.Click();
        }

        public void ValidationChoixDestinataireClick()
        {
            ValidationChoixDestinataireButton.Click();
        }

        public void RèglesCorrespondancesValidationButtonClick()
        {
            RèglesCorrespondancesValidationButton.Click();
        }

        public string RègleCorrespondanceText()
        {
            return règleCorrespondance.Text;
        }

        public void TiersClick(string tiers)
        {
            if(driver.FindElement(By.Id("SearchEnginePopup_wnd_title")).Displayed == true)
            {
                driver.FindElement(By.XPath("//*[@id='ResultGrid']//td[text()='"+ tiers + "']")).Click();
            }
            else
            {
                Console.WriteLine("Element not présent");
            }
            
        }

        public void SélectionnerButtonClick()
        {
            if (driver.FindElement(By.Id("SearchEnginePopup_wnd_title")).Displayed == true)
            {
                SélectionnerButton.Click();
            }
            else
            {
                Console.WriteLine("Element not présent");
            }
        }


        public void OuvrirLinkClick()
        {
            OuvrirLink.Click();
        }

        public void NomCompletLinkClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(NomCompletLink).Perform();
        }

        public void EgalButtonClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(EgaleButton).Perform();
        }

        public void ValeurInputSendKey(string valeur)
        {
            ValeurInput.SendKeys(valeur);
        }

        public void RechercheButtonClick()
        {
            RechercherButton.Click();
        }

        public int ListTiersResult()
        {
            string xpath_1_colonne = "//*[@id='ResultGrid']/div[3]/div/table/thead/tr/th[";
            string xpath_2_colonne = "]/a[2]";

            int i = ComM.ParcourListWithEquals(1, xpath_1_colonne, xpath_2_colonne, "Nom complet");

            string xpath_1 = "//*[@id='ResultGrid']/div[4]/table/tbody/tr[";
            string xpath_2 = "]/td[";
            string xpath_3 = "]";
            string text = "TINTIN";

            int result = ComM.ParcourListNomComplet(1, xpath_1, xpath_2, xpath_3, i, text);
            return result;
        }

        public void DropDownClick()
        {
            DropDown.Click();
        }

        public void TypeClick()
        {
            TiersRecherche.Click();
        }

        public void SaisirNomDossier(string folderName)
        {
            SearchInput.SendKeys(folderName);
        }

        public void ClickEntrer()
        {
            SearchInput.SendKeys(Keys.Enter);
        }

        public void ValiderButtonClick()
        {
            ValiderButton.Click();
        }

    }
}
