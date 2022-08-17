using MAT1.PageObjects.AuthentificationPage;
using MAT1.PageObjects.HomePages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MAT1.StepDefinitions.Authentification
{
    [Binding]
    public class AuthentificationSteps
    {
        private IWebDriver driver;


        static AuthentificationPage authentification;
        static HomePage homeP;

        public AuthentificationSteps(IWebDriver _driver)
        {
            driver = _driver;
            authentification = new AuthentificationPage(driver);
            homeP = new HomePage(driver);
        }

        [Given(@"naviguer à l'application Alissia Formation")]
        public void GivenNaviguerALApplicationAlissiaFormation()
        {
            authentification.OuvrirLeSiteAlissiaFormation();
            Thread.Sleep(4000);
        }

        [When(@"entrer le company login '(.*)'")]
        public void WhenEntrerLeCompanyLogin(string companyLogin)
        {
            authentification.SaisirCompanyLogin(companyLogin);
        }

        [When(@"entrer le username '(.*)'")]
        public void WhenEntrerLeUsername(string username)
        {
            authentification.SaisirUsername(username);
        }


        [When(@"entrer le mot de passe '(.*)'")]
        public void WhenEntrerLeMotDePasse(string MotPasse)
        {
            authentification.SaisirMotDePass(MotPasse);
        }

        [When(@"cliquer sur Connexion")]
        public void WhenCliquerSurConnexion()
        {
            authentification.ClickConnexion();

            Thread.Sleep(4000);

            authentification.EtapeInitiée();

            Thread.Sleep(4000);

            authentification.AlertDeleteDocument();

            Thread.Sleep(4000);
        }

        [Then(@"utilisateur connecté à l'(.*)'accueil est affichée")]
        public void ThenUtilisateurConnecteALAccueilEstAffichee(string p0)
        {
            Assert.IsTrue(homeP.AccueilLinkClass().Contains("active"));
        }

        
    }
}
