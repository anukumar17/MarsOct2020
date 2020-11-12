using MarsOct2020.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsOct2020.StepDefinition
{
    [Binding]
    public sealed class LanguageStepDefinition
    {

        [Given(@"I login to website with valid login And password")]
        public void GivenILoginToWebsiteWithValidLoginAndPassword()
        {

            var login = new LoginPage();
            login.LoginSteps();
        }

        [When(@"I add new language on the profile detail")]
        public void WhenIAddNewLanguageOnTheProfileDetail()
        {
            var addlan = new LanguagePage();
            addlan.AddLanguage();
        }

        [Then(@"I should able to add new language successfully")]
        public void ThenIShouldAbleToAddNewLanguageSuccessfully()
        {
            var lanaddSucessfully = new LanguagePage();
            lanaddSucessfully.LanAdded();
        }
        [Given(@"I login to website with valid credentials")]
        public void GivenILoginToWebsiteWithValidCredentials()
        {
            var login = new LoginPage();
            login.LoginSteps();
        }
        [When(@"I Delete existing language")]
        public void WhenIDeleteExistingLanguage()
        {
            var deletelan = new LanguagePage();
            deletelan.DeleteLanguage();
        }

        [Then(@"I am able to delete existing language successfully")]
        public void ThenIAmAbleToDeleteExistingLanguageSuccessfully()
        {
            var landeleted = new LanguagePage();
            landeleted.LanDeleted();
        }

        [Given(@"I login to mars portal with valid login And password")]
        public void GivenILoginToMarsPortalWithValidLoginAndPassword()
        {
            var login = new LoginPage();
            login.LoginSteps();
        }


        [When(@"I click on update existing language")]
        public void WhenIClickOnUpdateExistingLanguage()
        {
          var updatelan = new LanguagePage();
                updatelan.UpdateLan();
        }

        [Then(@"I am able to update existing language")]
        public void ThenIAmAbleToUpdateExistingLanguage()
        {
            var lanupdate = new LanguagePage();
            lanupdate.LanUpdated();
        }

    }
}
