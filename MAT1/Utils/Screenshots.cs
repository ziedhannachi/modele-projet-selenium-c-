using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAT1.Utils
{
    public class Screenshots
    {

        public string TakeScreenshot(IWebDriver driver)
        {
            DateTime now = DateTime.Now;
            String ScreeanshotFolderPath = System.Configuration.ConfigurationManager.AppSettings["FolderScreeanshotPath"] + "Alissia_Screenshot" + now.Day + "-" + now.Month + "-" + now.Year + "_" + now.Hour + "-" + now.Minute + "-" + now.Second + ".Png";
            

            OpenQA.Selenium.Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(@ScreeanshotFolderPath, OpenQA.Selenium.ScreenshotImageFormat.Png);

            return ScreeanshotFolderPath;
        }
    }
}
