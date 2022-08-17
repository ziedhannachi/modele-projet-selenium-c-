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

namespace MAT1.PageObjects.Accueil
{
    class GestionPageAccueilObjects
    {
        public IWebDriver driver;
        static CommonMethod ComM;
        static string dateFact;


        public GestionPageAccueilObjects(IWebDriver driver)
        {
            this.driver = driver;
            #pragma warning disable CS0618 // Le type ou le membre est obsolète
            PageFactory.InitElements(driver, this);
            #pragma warning restore CS0618 // Le type ou le membre est obsolète

            ComM = new CommonMethod(driver);
        }

        [FindsBy(How = How.Id, Using = "ToolbarUserDisplaySettings")]
        public IWebElement Paramètrage;

        [FindsBy(How = How.XPath, Using = "//*[@id='mainHomeDisplaySettingsContainer']/table/tbody/tr/td[2]/span/span/span[1]")]
        public IWebElement NbPavé;

        [FindsBy(How = How.XPath, Using = "//li[contains(text(),'5 Pavés')]")]
        public IWebElement Pavé_5;

        [FindsBy(How = How.XPath, Using = "//li[contains(text(),'4 Pavés')]")]
        public IWebElement Pavé_4;

        [FindsBy(How = How.Id, Using = "validateGridTypeButton")]
        public IWebElement ValiderModèle;

        [FindsBy(How = How.XPath, Using = "//td[contains(text(),'Documents récents')]")]
        public IWebElement DocumentsRècents;

        [FindsBy(How = How.Name, Using = "11")]
        public IWebElement Pavet1;

        [FindsBy(How = How.XPath, Using = "//td[contains(text(),'Requête Mes délais + 6 mois')]")]
        public IWebElement RequêteMesDélaisProcédure;

        [FindsBy(How = How.Name, Using = "31")]
        public IWebElement Pavet2;

        [FindsBy(How = How.XPath, Using = "//td[contains(text(),'Requête État dans Gelé + inactif')]")]
        public IWebElement RequêteDossiersResponsable;

        [FindsBy(How = How.Name, Using = "12")]
        public IWebElement Pavet3;

        [FindsBy(How = How.XPath, Using = "//td[contains(text(),'inférieur ou égal à auj')]")]
        public IWebElement DossiersAnnée;

        [FindsBy(How = How.Name, Using = "21")]
        public IWebElement Pavet4;

        [FindsBy(How = How.XPath, Using = "//td[contains(text(),'Réceptacle')]")]
        public IWebElement Réceptacle;

        [FindsBy(How = How.Name, Using = "32")]
        public IWebElement Pavet5;

        [FindsBy(How = How.Id, Using = "saveGridSettingsButton")]
        public IWebElement SauvegaderButton;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'derniers documents')]")]
        public IWebElement DocumentsRècentsDisplayed;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Mes délais + 6 mois')]")]
        public IWebElement RequêteMesDélaisProcédureDisplayed;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'État dans Gelé + inactif')]")]
        public IWebElement RequêteDossiersResponsableDisplayed;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Réceptacle')]")]
        public IWebElement RéceptacleDisplayed;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'inférieur ou égal à auj')]")]
        public IWebElement DossiersAnnéeDisplayed;

        [FindsBy(How = How.XPath, Using = "//td[contains(text(),'Créer nouveau pavé de requête')]")]
        public IWebElement CréerNouveauPavé;

        [FindsBy(How = How.Id, Using = "NewRequestBlockCreateButton")]
        public IWebElement NouveauPavéButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='HomeRequestsNewRequestContainer']//div[contains(text(),'Dossiers')]")]
        public IWebElement NouveauPavéList;

        [FindsBy(How = How.XPath, Using = "//*[@id='SearchEngineRequestBlockCreateNewRequestObjectDropDown_listbox']//div[contains(text(),'Délais')]")]
        public IWebElement Délais;

        [FindsBy(How = How.Id, Using = "SearchRequestBlockCreateButton")]
        public IWebElement RechercheButton;

        [FindsBy(How = How.Id, Using = "SearchEngineTreeViewSpan420001362")]
        public IWebElement TypeEchéance;

        [FindsBy(How = How.Id, Using = "SearchEngineOperatorTreeViewSpan450000013")]
        public IWebElement Dans;

        [FindsBy(How = How.Id, Using = "GridOfValueGridOfValueLine100032775")]
        public IWebElement ClientAction;

        [FindsBy(How = How.Id, Using = "GridOfValueGridOfValueLine100173345")]
        public IWebElement FacturationAction;

        [FindsBy(How = How.Id, Using = "GridOfValueGridOfValueLine100032774")]
        public IWebElement InterneAction;

        [FindsBy(How = How.Id, Using = "GridOfValueGridOfValueLine100032770")]
        public IWebElement OfficielAction;

        [FindsBy(How = How.LinkText, Using = "Eléments")]
        public IWebElement Eléments;

        [FindsBy(How = How.Id, Using = "SearchEngineTreeViewSpan420001387")]
        public IWebElement DateEchéance;

        [FindsBy(How = How.Id, Using = "SearchEngineOperatorTreeViewSpan450000031")]
        public IWebElement Entre;

        [FindsBy(How = How.LinkText, Using = "Date relative")]
        public IWebElement DateRelative;

        [FindsBy(How = How.XPath, Using = "//*[@id='SearchEngineDateValueFormTabStrip-2']/div/div[2]/div[1]/span/span/input[1]")]
        public IWebElement AnnéeInput1;

        [FindsBy(How = How.Id, Using = "SearchEngineDateValueFormYearsEditor")]
        public IWebElement AnnéeInput2;

        [FindsBy(How = How.Id, Using = "SearchEngineValueFormValidateButton")]
        public IWebElement ValiderButton;

        [FindsBy(How = How.Id, Using = "SearchEngineTreeViewSpan420001396")]
        public IWebElement ResponsableEtape;

        [FindsBy(How = How.Id, Using = "SearchEngineOperatorTreeViewSpan450000094")]
        public IWebElement Egale;

        [FindsBy(How = How.Id, Using = "SearchEngineValueFilterInitialsCode")]
        public IWebElement InitialesPersonne;

        [FindsBy(How = How.Id, Using = "SearchEngineSaveQueryButton")]
        public IWebElement SauvegarderRequête;

        [FindsBy(How = How.Id, Using = "SaveQueryModuleSetLabelText")]
        public IWebElement LibelléRequête;

        [FindsBy(How = How.Id, Using = "SearchEngineSaveQueryValidateButton")]
        public IWebElement Sauvegarder;

        [FindsBy(How = How.Id, Using = "ValidateRequestBlockCreateButton")]
        public IWebElement ValiderRequête;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Délais Olivier')]")]
        public IWebElement DélaisDisplayed;


        public void ParamètrageClick()
        {
            Paramètrage.Click();
        }

        public void NbPavéClick()
        {
            NbPavé.Click();
        }

        public void Pavé_5_Click()
        {
            if (ComM.IsElementPresent(By.XPath("//span[contains(text(),'5 Pavés')]")) == true)
            {
                Pavé_4.Click();

                Thread.Sleep(3000);
                ValiderModèle.Click();

                Thread.Sleep(3000);
                NbPavé.Click();

                Thread.Sleep(3000);
                Pavé_5.Click();

            }
            else
            {
                Pavé_5.Click();
            }
            
        }

        public void ValiderModèleClick()
        {
            ValiderModèle.Click();
        }

        public void dragDropDocumentsRècents()
        {

            string java_script =
                "var src=arguments[0],tgt=arguments[1];var dataTransfer={dropEffe" +
                "ct:'',effectAllowed:'all',files:[],items:{},types:[],setData:fun" +
                "ction(format,data){this.items[format]=data;this.types.append(for" +
                "mat);},getData:function(format){return this.items[format];},clea" +
                "rData:function(format){}};var emit=function(event,target){var ev" +
                "t=document.createEvent('Event');evt.initEvent(event,true,false);" +
                "evt.dataTransfer=dataTransfer;target.dispatchEvent(evt);};emit('" +
                "dragstart',src);emit('dragenter',tgt);emit('dragover',tgt);emit(" +
                "'drop',tgt);emit('dragend',src);";

            ((IJavaScriptExecutor)driver).ExecuteScript(java_script, DocumentsRècents, Pavet1);
            
        }

        public void DragDropRequêteMesDélaisProcédure()
        {
            string java_script =
                "var src=arguments[0],tgt=arguments[1];var dataTransfer={dropEffe" +
                "ct:'',effectAllowed:'all',files:[],items:{},types:[],setData:fun" +
                "ction(format,data){this.items[format]=data;this.types.append(for" +
                "mat);},getData:function(format){return this.items[format];},clea" +
                "rData:function(format){}};var emit=function(event,target){var ev" +
                "t=document.createEvent('Event');evt.initEvent(event,true,false);" +
                "evt.dataTransfer=dataTransfer;target.dispatchEvent(evt);};emit('" +
                "dragstart',src);emit('dragenter',tgt);emit('dragover',tgt);emit(" +
                "'drop',tgt);emit('dragend',src);";

            ((IJavaScriptExecutor)driver).ExecuteScript(java_script, RequêteMesDélaisProcédure, Pavet2);

        }

        public void DragDropRequêteDossiersResponsable()
        {
            string java_script =
                "var src=arguments[0],tgt=arguments[1];var dataTransfer={dropEffe" +
                "ct:'',effectAllowed:'all',files:[],items:{},types:[],setData:fun" +
                "ction(format,data){this.items[format]=data;this.types.append(for" +
                "mat);},getData:function(format){return this.items[format];},clea" +
                "rData:function(format){}};var emit=function(event,target){var ev" +
                "t=document.createEvent('Event');evt.initEvent(event,true,false);" +
                "evt.dataTransfer=dataTransfer;target.dispatchEvent(evt);};emit('" +
                "dragstart',src);emit('dragenter',tgt);emit('dragover',tgt);emit(" +
                "'drop',tgt);emit('dragend',src);";

            ((IJavaScriptExecutor)driver).ExecuteScript(java_script, RequêteDossiersResponsable, Pavet3);
            
        }

        public void DragDropDossiersAnnée()
        {
            string java_script =
                "var src=arguments[0],tgt=arguments[1];var dataTransfer={dropEffe" +
                "ct:'',effectAllowed:'all',files:[],items:{},types:[],setData:fun" +
                "ction(format,data){this.items[format]=data;this.types.append(for" +
                "mat);},getData:function(format){return this.items[format];},clea" +
                "rData:function(format){}};var emit=function(event,target){var ev" +
                "t=document.createEvent('Event');evt.initEvent(event,true,false);" +
                "evt.dataTransfer=dataTransfer;target.dispatchEvent(evt);};emit('" +
                "dragstart',src);emit('dragenter',tgt);emit('dragover',tgt);emit(" +
                "'drop',tgt);emit('dragend',src);";

            ((IJavaScriptExecutor)driver).ExecuteScript(java_script, DossiersAnnée, Pavet4);
            
        }

        public void DragDropRéceptacle()
        {
            string java_script =
                "var src=arguments[0],tgt=arguments[1];var dataTransfer={dropEffe" +
                "ct:'',effectAllowed:'all',files:[],items:{},types:[],setData:fun" +
                "ction(format,data){this.items[format]=data;this.types.append(for" +
                "mat);},getData:function(format){return this.items[format];},clea" +
                "rData:function(format){}};var emit=function(event,target){var ev" +
                "t=document.createEvent('Event');evt.initEvent(event,true,false);" +
                "evt.dataTransfer=dataTransfer;target.dispatchEvent(evt);};emit('" +
                "dragstart',src);emit('dragenter',tgt);emit('dragover',tgt);emit(" +
                "'drop',tgt);emit('dragend',src);";

            ((IJavaScriptExecutor)driver).ExecuteScript(java_script, Réceptacle, Pavet5);
        }

        public void SauvegaderButtonClick()
        {
            SauvegaderButton.Click();
        }

        public bool DocumentsRècentsdisplayed()
        {
            return DocumentsRècentsDisplayed.Displayed;
        }

        public bool RequêteMesDélaisprocéduredisplayed()
        {
            return RequêteMesDélaisProcédureDisplayed.Displayed;
        }

        public bool RequêteDossiersResponsabledisplayed()
        {
            return RequêteDossiersResponsableDisplayed.Displayed;
        }

        public bool Réceptacledisplayed()
        {
            return RéceptacleDisplayed.Displayed;
        }

        public bool DossiersAnnéedisplayed()
        {
            return DossiersAnnéeDisplayed.Displayed;
        }

        public void dragDropCréerNouveauPavé()
        {
            string java_script =
                "var src=arguments[0],tgt=arguments[1];var dataTransfer={dropEffe" +
                "ct:'',effectAllowed:'all',files:[],items:{},types:[],setData:fun" +
                "ction(format,data){this.items[format]=data;this.types.append(for" +
                "mat);},getData:function(format){return this.items[format];},clea" +
                "rData:function(format){}};var emit=function(event,target){var ev" +
                "t=document.createEvent('Event');evt.initEvent(event,true,false);" +
                "evt.dataTransfer=dataTransfer;target.dispatchEvent(evt);};emit('" +
                "dragstart',src);emit('dragenter',tgt);emit('dragover',tgt);emit(" +
                "'drop',tgt);emit('dragend',src);";

            ((IJavaScriptExecutor)driver).ExecuteScript(java_script, CréerNouveauPavé, Pavet1);
        }

        public void NouveauPavéButtonClick()
        {
            NouveauPavéButton.Click();
        }

        public void NouveauPavéListClick()
        {
            NouveauPavéList.Click();
        }

        public void DélaisClick()
        {
            Délais.Click();
        }

        public void RechercheButtonClick()
        {
            RechercheButton.Click();
        }

        public void TypeEchéanceClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(TypeEchéance).Perform();
        }

        public void DansClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(Dans).Perform();
        }

        public void ClientActionClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(ClientAction).Perform();
        }

        public void FacturationActionClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(FacturationAction).Perform();
        }

        public void InterneActionClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(InterneAction).Perform();
        }

        public void OfficielActionClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(OfficielAction).Perform();
        }

        public void ElémentsClick()
        {
            Eléments.Click();
        }

        public void DateEchéanceClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(DateEchéance).Perform();
        }

        public void EntreClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(Entre).Perform();
        }

        public void AnnéeSendKeys(string année)
        {
            AnnéeInput1.Click();

            Thread.Sleep(5000);

            AnnéeInput2.SendKeys(année);
        }

        public void ValiderButtonClick()
        {
            ValiderButton.Click();
        }

        public void Année2SendKeys(string année)
        {
            AnnéeInput1.Click();

            Thread.Sleep(5000);
            AnnéeInput2.Clear();

            Thread.Sleep(5000);
            AnnéeInput1.Click();

            Thread.Sleep(5000);

            AnnéeInput2.SendKeys(année);
        }


        public void ResponsableEtapeClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(ResponsableEtape).Perform();
        }

        public void EgaleClick()
        {
            Actions action = new Actions(driver);
            action.DoubleClick(Egale).Perform();
        }

        public void DateRelativeClick()
        {
            DateRelative.Click();
        }

        public void InitialesPersonneSendKeys(string initialesPersonne)
        {
            InitialesPersonne.SendKeys(initialesPersonne);
        }

        public void SauvegarderRequêteClick()
        {
            SauvegarderRequête.Click();
        }

        public void LibelléRequêteSendKeys(string libellé)
        {
            LibelléRequête.Clear();
            Thread.Sleep(3000);
            LibelléRequête.SendKeys(libellé);
        }

        public void SauvegarderClick()
        {
            Sauvegarder.Click();
        }

        public void ValiderRequêteClick()
        {
            ValiderRequête.Click();
        }

        public bool Délaisdisplayed()
        {
            return DélaisDisplayed.Displayed;
        }
    }
}
