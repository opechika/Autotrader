using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace Autotrader.StepDefinitions
{
    [Binding]
    public sealed class AutotraderSearchSteps
    {
        IWebDriver driver;
        IWebElement Code;
        IWebElement DistanceFromPostcode;
        IWebElement CarMake;
        IWebElement CarModel;
        IWebElement SearchButton;
        IWebElement CookiesBar;



        [Given(@"I am on Autotrader homepage")]
        public void GivenIAmOnAutotraderHomepage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.autotrader.co.uk/");
            driver.Manage().Window.Maximize();
        }

        [When(@"I enter postcode as ""(.*)""")]
        public void WhenIEnterPostcodeAs(string pcode)
        {
            Code = driver.FindElement(By.Id("postcode"));
            Code.SendKeys(pcode);
        }

        [When(@"I select distance from Postcode as ""(.*)""")]
        public void WhenISelectDistanceFromPostcodeAs(string distance)
        {
            DistanceFromPostcode = driver.FindElement(By.Id("radius"));
            SelectElement select = new SelectElement(DistanceFromPostcode);
            select.SelectByText(distance);
            
        }

        [When(@"I select the Car Make as ""(.*)""")]
        public void WhenISelectTheCarMakeAs(string make)
        {
            Thread.Sleep(5000);
            CarMake = driver.FindElement(By.Id("searchVehiclesMake"));
            SelectElement select = new SelectElement(CarMake);
            select.SelectByValue(make.ToUpper());
          
        }

        [When(@"I select the Car Model as ""(.*)""")]
        public void WhenISelectTheCarModelAs(string model)
        {
            Thread.Sleep(5000);
            CarModel = driver.FindElement(By.Id("searchVehiclesModel"));
            SelectElement select = new SelectElement(CarModel);
            select.SelectByValue(model.ToUpper());

          

        }

        [Then(@"I click on the search for car button")]
        public void ThenIClickOnTheSearchForCarButton()
        {
            CookiesBar = driver.FindElement(By.Id("js-cookie-alert-close"));
            CookiesBar.Click();
            Thread.Sleep(3000);
            SearchButton = driver.FindElement(By.Id("js-search-button"));
            SearchButton.Click();
        }

        [Then(@"the result of car ""(.*)"" is displayed")]
        public void ThenTheResultOfCarIsDisplayed(string result)
        {

        }
    }
}
