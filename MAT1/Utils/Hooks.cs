
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.MarkupUtils;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System;
using System.Reflection;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Bindings;

namespace MAT1.Utils
{
    [Binding]
    public class Hooks
    {
        public static ExtentTest _feature;
        public static ExtentTest _scenario;
        public static ExtentReports _extent;
        public static ExtentReports extent;
        // private static readonly string PathReport = $"{AppDomain.CurrentDomain.BaseDirectory}ExtentReport.html";

        private IWebDriver driver;

        static Screenshots screen;

        public Hooks(IWebDriver _driver)
        {
            driver = _driver;
            screen = new Screenshots();
        }

        [BeforeTestRun]
        public static void ConfigureReport()
        {
            String FolderExtentReportPath = System.Configuration.ConfigurationManager.AppSettings["FolderExtentReportPath"];
            DateTime now = DateTime.Now;

            var PathReport = new ExtentHtmlReporter(@FolderExtentReportPath + "Alissia_Report" + now.Day + "-" + now.Month + "-" + now.Year + "_" + now.Hour + "-" + now.Minute + "-" + now.Second + ".html");
            PathReport.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            // var reporter = new ExtentHtmlReporter();
            _extent = new ExtentReports();
            _extent.AttachReporter(PathReport);
        }


        [BeforeFeature]
        public static void CreateFeature()
        {
            _feature = _extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);

        }

        [BeforeScenario]
        public static void CreateScenario()
        {
            _scenario = _feature.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
            _scenario.Log(Status.Info, MarkupHelper.CreateLabel("testttttttt", ExtentColor.Yellow));

        }

        [AfterStep]
        public void InsertReportingSteps()
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            PropertyInfo PInfo = typeof(ScenarioContext).GetProperty("ScenarioExecutionStatus", BindingFlags.Instance | BindingFlags.Public);
            MethodInfo Getter = PInfo.GetGetMethod(nonPublic: true);
            object TestResult = Getter.Invoke(ScenarioContext.Current, null);

            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                {
                    _scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                }

                if (stepType == "When")
                {
                    _scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                }

                if (stepType == "Then")
                {
                    if (ScenarioStepContext.Current.StepInfo.Text.Equals("Vérification du temps d'affichage du résultat et La liste des informations est affiché"))
                    {

                    }
                    else
                    {
                        _scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);

                    }
                }
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                {
                    string path = screen.TakeScreenshot(driver);
                    _scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message).AddScreenCaptureFromPath(path);
                }

                if (stepType == "When")
                {
                    string path = screen.TakeScreenshot(driver);
                    _scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message).AddScreenCaptureFromPath(path);
                }

                if (stepType == "Then")
                {
                    if (ScenarioStepContext.Current.StepInfo.Text.Equals("La ligne tarif Envoi recommandé doit être supprimé du tableau"))
                    {

                    }
                    else
                    {
                        string path = screen.TakeScreenshot(driver);
                        _scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message).AddScreenCaptureFromPath(path);
                    }
                }
            }

            if (TestResult.ToString() == "StepDefinitionPending")
            {
                if (stepType == "Given")
                {
                    _scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definiion Pending");
                }

                if (stepType == "When")
                {
                    _scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definiion Pending");

                }

                if (stepType == "Then")
                {
                    _scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definiion Pending");
                }
            }

        }

        [AfterTestRun]
        public static void FlushExtent()
        {
            _extent.Flush();
        }


        [AfterFeature]
        public static void FlushExtent1()
        {
            _extent.Flush();
        }


    }
}
