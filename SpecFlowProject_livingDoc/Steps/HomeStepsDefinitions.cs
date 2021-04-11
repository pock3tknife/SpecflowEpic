using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SpecFlowProject_livingDoc.Steps
{
    [Binding]
    public sealed class HomeStepsDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        IWebDriver Driver = new ChromeDriver();
        private readonly ScenarioContext _scenarioContext;

        [Given(@"I navigate to URl")]
        public void GivenINavigateToURl()
        {
            Driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");
        }

        [Given(@"I click to Input form")]
        public void GivenIClickToInputForm()
        {
            Driver.FindElement(By.XPath("//*[@id='navbar-brand-centered']/ul[1]/li[1]/a")).Click();
        }

        [Given(@"User is on the input form Page")]
        public void GivenUserIsOnTheInputFormPage()
        {
            Task.Delay(5000).Wait();
            Console.WriteLine("User is on the page");
            Driver.FindElement(By.XPath("//*[@id='at-cv-lightbox-close']")).Click();
            Driver.FindElement(By.XPath("//*[@id='navbar-brand-centered']/ul[1]/li[1]/ul/li[1]/a")).Click();
        }


        [When(@"User enter ""(.*)"" in input")]
        public void WhenUserEnterInInput(string msg)
        {
            ScenarioContext.Current.Add("msg", msg);
            Driver.FindElement(By.XPath("//*[@id='user-message']")).SendKeys(msg);
        }

        [When(@"User click to Show button")]
        public void WhenUserClickToShowButton()
        {
            Driver.FindElement(By.XPath("//*[@id='get-input']/button")).Click();

        }

        [Then(@"User can see the text")]
        public void ThenUserCanSeeTheText()
        {
            string msg = ScenarioContext.Current["msg"].ToString();
            string browsertext = Driver.FindElement(By.XPath("//*[@id='display']")).Text.ToString();
            Console.WriteLine("msg coming form the above step : " + msg);
            Assert.IsTrue(msg.Contains(browsertext));
            //Task.Delay(5000).Wait();
        }
    }
}
