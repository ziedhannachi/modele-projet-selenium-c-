using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.MarkupUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MAT1.Utils
{
    public class AssertHelper
    {
        private IWebDriver driver;
        static Screenshots screen;

        public AssertHelper(IWebDriver _driver)
        {
            driver = _driver;
            screen = new Screenshots();
        }
        public void AssertFail(string exept, string found)
        {
            try
            {
                Assert.IsTrue(exept.Equals(found));

            }catch(Exception e)
            {
                string path = screen.TakeScreenshot(driver);
                Hooks._scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail("Échec de Assert.IsTrue.").AddScreenCaptureFromPath(path);
            }
        }

        public void AssertFail(int exept, int found)
        {
            try
            {
                Assert.IsTrue(exept.Equals(found));

            }
            catch (Exception e)
            {
                string path = screen.TakeScreenshot(driver);
                Hooks._scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail("Échec de Assert.IsTrue.").AddScreenCaptureFromPath(path);
            }
        }

        public void AssertFail(bool exept, bool found)
        {
            try
            {
                Assert.IsTrue(exept.Equals(found));

            }
            catch (Exception e)
            {
                string path = screen.TakeScreenshot(driver);
                Hooks._scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail("Échec de Assert.IsTrue.").AddScreenCaptureFromPath(path);
            }
        }

    }
}
