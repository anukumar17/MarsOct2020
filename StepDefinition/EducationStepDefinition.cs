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
    public sealed class EducationStepDefinition
    {

        //IWebDriver driver = new ChromeDriver();
        //[BeforeScenario]
        //public void Launchbrowser()
        //{
        //    driver = new ChromeDriver();
        //}

        //[AfterScenario]
        //public void Dispose()
        //{
        //    // close the window and realease the memeory
        //    driver.Dispose();
        //}

        [Given(@"I login the website with valid credentials")]
        public void GivenILoginTheWebsiteWithValidCredentials()
        {
            var login = new LoginPage();
            login.LoginSteps();
        }

        [When(@"I add Education details '(.*)', '(.*)', '(.*)'")]
        public void WhenIAddEducationDetails(string country, string title, string year)
        {
            var addedu = new EducationPage();
            addedu.AddEdu( country, title, year);
        }

        [Then(@"seller should able to add Education details successfully")]
        public void ThenSellerShouldAbleToAddEducationDetailsSuccessfully()
        {
            var addededu = new  EducationPage();
            addededu.EduAdded();
        }
        [Given(@"I login to Mars portal with valid login And password")]
        public void GivenILoginToMarsPortalWithValidLoginAndPassword()
        {
            var login = new LoginPage();
            login.LoginSteps();
        }


        [When(@"I Update the Education detail'(.*)'")]
        public void WhenIUpdateTheEducationDetail(string title)
        {
            var updateedu = new EducationPage();
            updateedu.UpdateEdu( title);
        }

        [Then(@"seller should able to update Education details successfully")]
        public void ThenSellerShouldAbleToUpdateEducationDetailsSuccessfully()
        {
            var eduupdate = new EducationPage();
            eduupdate.EduUpdated();
        }

        [Given(@"I gotto website with valid login And password")]
        public void GivenIGottoWebsiteWithValidLoginAndPassword()
        {
            var login = new LoginPage();
            login.LoginSteps();
        }

        [When(@"I delete the Education details")]
        public void WhenIDeleteTheEducationDetails()
        {
            var deleteedu = new EducationPage();
            deleteedu.DeleteEdu();
        }

        [Then(@"Seller should able to delete Education details successfully")]
        public void ThenSellerShouldAbleToDeleteEducationDetailsSuccessfully()
        {

            var edudeleted = new EducationPage();
            edudeleted.EduDeleted();
        }

        }
}
