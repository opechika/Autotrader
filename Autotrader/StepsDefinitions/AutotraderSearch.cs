using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Autotrader.StepsDefinitions
{
    

    [Binding]
    public sealed class AutotraderSearch
    {
        IWebDriver driver;

       

        [Given(@"I am on Autotrader homepage")]
        public void GivenIAmOnAutotraderHomepage()
        {
            
        }

        [When(@"I enter postcode as ""(.*)""")]
        public void WhenIEnterPostcodeAs(string postcode)
        {
            
        }

        [When(@"I select distance from Postcode as ""(.*)""")]
        public void WhenISelectDistanceFromPostcodeAs(string distance)
        {
            
        }

        [When(@"I select the Car Make as ""(.*)""")]
        public void WhenISelectTheCarMakeAs(string make)
        {
            
        }

        [When(@"I select the Car Model as ""(.*)""")]
        public void WhenISelectTheCarModelAs(string model)
        {
            
        }

        [Then(@"I click on the search for car button")]
        public void ThenIClickOnTheSearchForCarButton()
        {
            
        }

        [Then(@"the result of car ""(.*)"" is displayed")]
        public void ThenTheResultOfCarIsDisplayed(string result)
        {
            
        }

    }
}
