using MarsOct2020.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace MarsOct2020.Pages
{
    class LoginPage
    {
        //public string username { get; private set; }
        internal void LoginSteps()
        {
            // click on signin button

            IWebElement signin = Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signin.Click();
            Thread.Sleep(5000);

            //enter users email address 
            IWebElement email = Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            email.SendKeys("zorabadhan@gmail.com");
            //email.SendKeys(ExcelLibHelpers.ReadData(2, "username"));

            //enter passward
            IWebElement password = Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            password.SendKeys("zorawar");
            //password.SendKeys(ExcelLibHelpers.ReadData(2, "password"));

            //identify login button and click login button
            IWebElement loginbutton = Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginbutton.Click();
            Thread.Sleep(20000);

            try
            {
                //validate if the seller had login sucessfully

                var loginCheck = "text";

                loginCheck = Driver.driver.FindElement(By.XPath("//*[contains(text(),'Zorawar Badhan')]")).GetAttribute("innerText");

                Assert.That(loginCheck == "Zorawar Badhan");
            }
            catch (Exception ex)
            {
                Assert.Fail("validate log in failed", ex.Message);
            }
        }
    }
}    

