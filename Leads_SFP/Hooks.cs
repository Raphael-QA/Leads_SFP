using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Leads_SFP
{
    [Binding]
    class Hooks
    {

        public static IWebDriver driver;
        [BeforeScenario]
        public static void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            FeatureContext.Current["driver"] = driver;
        }
        [AfterScenario]
        public static void AfterScenario()
        {
            driver = (IWebDriver)FeatureContext.Current["driver"];
            driver.Close();
        }
    }
}
