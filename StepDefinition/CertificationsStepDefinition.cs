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
    public sealed class CertificationsStepDefinition
    {
             
            [Given(@"I login to the website with valid email id and password")]
            public void GivenILoginToTheWebsiteWithValidEmailIdAndPassword()
            {
                var login = new LoginPage();
                login.LoginSteps();
            }

            [When(@"I add certificate")]
            public void WhenIAddCertificate()
            {
                var addcertificate = new CertificationPage();
                addcertificate.AddCertificate();
            }

            [Then(@"Seller is able to verify the certificate in the profile details")]
            public void ThenSellerIsAbleToVerifyTheCertificateInTheProfileDetails()
            {
                var certificateadded = new CertificationPage();
                certificateadded.CertificateAddded();
            }
        [Given(@"I login to the Mars Portal with valid email id and password")]
        public void GivenILoginToTheMarsPortalWithValidEmailIdAndPassword()
        {
            var login = new LoginPage();
            login.LoginSteps();
        }

        [When(@"I edit the existing certificates")]
            public void WhenIEditTheExistingCertificates()
            {
                var editcertificate = new CertificationPage();
                editcertificate.EditCertificate();
            }

            [Then(@"I am able to verify the updated certificates")]
            public void ThenIAmAbleToVerifyTheUpdatedCertificates()
            {
                var certificateedited = new CertificationPage();
                certificateedited.CertificateEdited();
            }

        [Given(@"I Login to the website with valid credentials")]
        public void GivenILoginToTheWebsiteWithValidCredentials()
        {
            var login = new LoginPage();
            login.LoginSteps();
        }

        [When(@"I try to delete existing certificate")]
            public void WhenITryToDeleteExistingCertificate()
            {
                var deletecertificate = new CertificationPage();
                deletecertificate.DeleteCertificate();
            }

            [When(@"I am able to delete the exsisting certificate")]
            public void WhenIAmAbleToDeleteTheExsistingCertificate()
            {
                var certificatedeleted = new CertificationPage();
                certificatedeleted.Certificatedeleted();
            }
        }
    }

