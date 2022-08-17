using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAT1.PageObjects.HomePages
{
    class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            #pragma warning disable CS0618 // Le type ou le membre est obsolète
            PageFactory.InitElements(driver, this);
            #pragma warning restore CS0618 // Le type ou le membre est obsolète
        }

        [FindsBy(How = How.Name, Using = "QuickSearchValueField_input")]
        public IWebElement SearchInput;

        [FindsBy(How = How.XPath, Using = "/html/body/header/div/div[2]/img[2]")]
        public IWebElement SearchButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='cssmenu']/ul/li[1]")]
        public IWebElement AccueilLink;

        public void SaisirNomDossier(string folderName)
        {
            SearchInput.SendKeys(folderName);
        }

        public void ClickEntrer()
        {
            SearchInput.SendKeys(Keys.Enter);
        }

        public string AlertTest()
        {
            IAlert alertOK = driver.SwitchTo().Alert();

            string alertText = alertOK.Text;

            alertOK.Accept();
            return alertText;
        }

        public void ClickSearchButton()
        {
            SearchButton.Click();
        }

        public string AccueilLinkClass()
        {
            Console.WriteLine(AccueilLink.GetAttribute("class"));
            return AccueilLink.GetAttribute("class");
        }
    }
}
