using MAT1.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAT1.PageObjects.AuthentificationPage
{
    public class AuthentificationPage
    {

        public IWebDriver driver;
        static CommonMethod ComM;

        public AuthentificationPage(IWebDriver driver)
        {
            this.driver = driver;
            #pragma warning disable CS0618 // Le type ou le membre est obsolète
            PageFactory.InitElements(driver, this);
            #pragma warning restore CS0618 // Le type ou le membre est obsolète

            ComM = new CommonMethod(driver);
        }

        [FindsBy(How = How.Id, Using = "CompanyLogin")]
        public IWebElement CompanyId;

        [FindsBy(How = How.Id, Using = "UserName")]
        public IWebElement UsernameId;

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement PasswordName;

        [FindsBy(How = How.XPath, Using = "//*[@id='loginForm']/form/fieldset/p/input")]
        public IWebElement BtnConnexionXpath;

        [FindsBy(How = How.ClassName, Using = "UserName")]
        public IWebElement SessionUserName;

        [FindsBy(How = How.Id, Using = "UncompletedStepPopupDeleteStepButton")]
        public IWebElement SupprimerEtapeInitButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[53]/div[2]/div/button[1]")]
        public IWebElement SupprimerDocument;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Attention')]")]
        public IWebElement AttentionAlert;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Oui')]")]
        public IWebElement OuiButton;

        public void OuvrirLeSiteAlissia()
        {
            String URL = System.Configuration.ConfigurationManager.AppSettings["URL"];
            driver.Navigate().GoToUrl(URL);
        }

        public void OuvrirLeSiteAlissiaFormation()
        {
            String URL = System.Configuration.ConfigurationManager.AppSettings["URLFormation"];
            driver.Navigate().GoToUrl(URL);
        }

        public void SaisirCompanyLogin(string companyLogin)
        {
            CompanyId.SendKeys(companyLogin);
        }

        public void SaisirUsername(string username)
        {
            UsernameId.SendKeys(username);
        }

        public void SaisirMotDePass(string motdepasse)
        {
            PasswordName.SendKeys(motdepasse);
        }

        public void ClickConnexion()
        {
            BtnConnexionXpath.Click();
        }

        public string GetSessionUserName()
        {
            return SessionUserName.Text;
        }

        public void EtapeInitiée()
        {
            if (driver.FindElement(By.Id("UncompletedStepPopupDeleteStepButton")).Displayed)
            {
                Console.WriteLine("element displayed");
                SupprimerEtapeInitButton.Click();
            }
            else
            {
                Console.WriteLine("no elemnt displayed");
            }
        }

        public void AlertDeleteDocument()
        {
            if (ComM.IsElementPresent(By.XPath("//button[contains(text(),'Oui')]")) == true)
            {
                Console.WriteLine("element displayed");
                OuiButton.Click();
            }
            else
            {
                Console.WriteLine("no elemnt displayed");
            }
        }

    }
}
