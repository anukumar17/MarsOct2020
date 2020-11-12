using MarsOct2020.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsOct2020.StepDefinition
{
    [Binding]
    public sealed class SkillsStepDefinition
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
            // close the window and realease the memeory
            //driver.Dispose();
        //}
        [Given(@"I login to the website with valid credentials")]
        public void GivenILoginToTheWebsiteWithValidCredentials()
        {
            var login = new LoginPage();
            login.LoginSteps();
        }

        [When(@"I add skills")]
        public void WhenIAddSkills()
        {
            var addskills = new SkillsPage();
            addskills.AddSkills();
        }

        [Then(@"Seller is able to verify the skills in the profile details")]
        public void ThenSellerIsAbleToVerifyTheSkillsInTheProfileDetails()
        {
            var skilladded = new SkillsPage();
            skilladded.SkillsAdded();
        }
        [When(@"I edit the existing skills")]
        public void WhenIEditTheExistingSkills()
        {
            var editskills = new SkillsPage();
            editskills.EditSkills();
        }

        [Then(@"I am able to verify the updated skills")]
        public void ThenIAmAbleToVerifyTheUpdatedSkills()
        {
            var skillsedited = new SkillsPage();
            skillsedited.SkillsEdited();
        }

        [Given(@"I Login to the website with valid UserId and Password")]
        public void GivenILoginToTheWebsiteWithValidUserIdAndPassword()
        {
            var login = new LoginPage();
            login.LoginSteps();
        }

        [When(@"I try to delete existing skills")]
        public void WhenITryToDeleteExistingSkills()
        {
            var deleteskills = new SkillsPage();
            deleteskills.DeleteSkills();
        }

        [When(@"I am able to delete the skills")]
        public void WhenIAmAbleToDeleteTheSkills()
        {
            var skillsdeleted = new SkillsPage();
            skillsdeleted.SkillsDeleted();
        }
    }
}
