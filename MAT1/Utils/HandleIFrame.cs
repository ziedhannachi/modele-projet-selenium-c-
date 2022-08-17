using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAT1.Utils
{
    class HandleIFrame : AbstractPage
    {
        public HandleIFrame(IWebDriver driver)
        {

        }

        //IFrames Gestion des Fournisseurs
        public void HandleIFrameGestionDesFournisseurs()
        {
            IWebElement iframeElement = driver.FindElement(By.XPath("//*[@id='slider-wrapper']/div[3]/div[5]/iframe"));
            driver.SwitchTo().Frame(iframeElement);
        }
        public void HandleIFrameCreationDUnFournisseur()
        {
            IWebElement iframeElement = driver.FindElement(By.XPath("//*[@id='slider-wrapper']/div[3]/div[6]/iframe"));
            driver.SwitchTo().Frame(iframeElement);
        }

        //IFrames Consultation des Fournisseurs
        public void HandleIFrameConsultationDesFournisseurs()
        {
            IWebElement iframeElement = driver.FindElement(By.XPath("//*[@id='slider-wrapper']/div[3]/div[5]/iframe"));
            driver.SwitchTo().Frame(iframeElement);
        }
    }
}
