using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MarsOct2020.Hooks
{
    internal class Driver
    { //initialize the browser
        public static IWebDriver driver;
        internal void Initialize()
        {
            //launch driver and enter url
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");


            // minimize web brower
            driver.Manage().Window.Maximize();

        }
    }
}