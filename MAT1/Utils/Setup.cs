using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MAT1.Utils
{
    [Binding]
    public class Setup
    {
        private readonly IObjectContainer _objectContainer;
        private IWebDriver driver;

        public Setup(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;

        }



        [BeforeScenario]
        public void CallBrowser1()
        {
            driver = InitBrowser("Chrome");
            _objectContainer.RegisterInstanceAs<IWebDriver>(driver);


            driver.Manage().Window.Maximize();
        }

        [AfterScenario]

        public void TearDown()
        {
            if (ScenarioContext.Current.TestError != null)
            {
                String ScreeanshotFolderPath = System.Configuration.ConfigurationManager.AppSettings["FolderScreeanshotPath"];

                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                //ss.SaveAsFile(@ScreeanshotFolderPath + "Alissia_Screenshot.Png", OpenQA.Selenium.ScreenshotImageFormat.Png);

            }

            //driver.Dispose();
        }

        public IWebDriver InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    if (driver == null)
                    {
                        driver = new FirefoxDriver();

                    }
                    break;

                case "IE":
                    if (driver == null)
                    {
                        driver = new InternetExplorerDriver();

                    }
                    break;

                case "Chrome":
                    if (driver == null)
                    {
                        driver = new ChromeDriver();

                    }
                    break;
            }

            return driver;
        }




    }
}
