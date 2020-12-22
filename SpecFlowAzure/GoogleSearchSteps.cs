using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework.Internal;


namespace Visual2019
{
    [Binding]
    public class DecafyingLibrariySteps
    {
        ChromeOptions options = new ChromeOptions();

        IWebDriver driver;// new ChromeDriver();

        [Given(@"That I am on the Google Search Page")]
        public void GivenThatIAmOnTheGoogleSearchPage()
        {
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.Navigate().GoToUrl("https://google.com");
            Thread.Sleep(5000); 

        }

        [When(@"I Search for Edgewords")]
        public void WhenISearchForEdgewords()
        {
            driver.FindElement(By.Name("q")).SendKeys("Orsted" + Keys.Enter);
            Thread.Sleep(5000);
        }

        [Then(@"I expect to see Edgewords on the first page")]
        public void ThenIExpectToSeeEdgewordsOnTheFirstPage()
        {
            /*
            IWebElement msg = driver.FindElement(By.Id("rcnt"));
            String text = msg.Text;
            Assert.IsTrue(text.Contains("EdgeWords"));
            */
        }


    }
}
