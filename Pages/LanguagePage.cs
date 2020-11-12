using MarsOct2020.Helpers;
using MarsOct2020.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsOct2020.Pages
{
    class LanguagePage
    {
        internal void AddLanguage()
        {

            //Identify add new language button and click on add new button
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 10000);
            IWebElement addnewlan = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewlan.Click();
            //Thread.Sleep(1000);

            // Identify input add language text box and enter language
            IWebElement enterlan = Driver.driver.FindElement(By.Name("name"));
            enterlan.Click();
            IWebElement enterlang = Driver.driver.FindElement(By.Name("name"));
            enterlang.SendKeys("English");
            Thread.Sleep(1000);

            //identify   choose language level button and select language level
            IWebElement lanlev = Driver.driver.FindElement(By.Name("level"));
            lanlev.Click();
            new SelectElement(Driver.driver.FindElement(By.Name("level"))).SelectByText("Fluent");
            Thread.Sleep(1000);

            //click on add button
            IWebElement add = Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
            add.Click();
            Thread.Sleep(10000);


            //Add second language ...click on add new
            IWebElement addnewlan1 = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewlan1.Click();
            Thread.Sleep(5000);

            //Add second language
            IWebElement enterlan1 = Driver.driver.FindElement(By.Name("name"));
            enterlan1.Click();
            IWebElement enterlang1 = Driver.driver.FindElement(By.Name("name"));
            enterlang1.SendKeys("Punjabi");
            Thread.Sleep(5000);

            // choose language level button and select language level
            IWebElement lanlev1 = Driver.driver.FindElement(By.Name("level"));
            lanlev1.Click();
            new SelectElement(Driver.driver.FindElement(By.Name("level"))).SelectByText("Native/Bilingual");
            Thread.Sleep(5000);

            //click on add button
            IWebElement add1 = Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
            add1.Click();
            Thread.Sleep(10000); //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]
        }

        internal void LanDeleted()
        {
            Thread.Sleep(10000);

            // Wait.WaitForElement(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 1000);

            IWebElement landelete = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            if (landelete.Text != "Punjabi")
            {
                Console.WriteLine("Language deleted succesfully");

            }
            else
            {
                Console.WriteLine("language is not deleted sucessfully");

            }

        }

        internal void LanUpdated()
        {
            Thread.Sleep(5000);
            //validate language update successfully...english
            IWebElement langupd = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            if (langupd.Text == "Basic")                            //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]
            {
                    Console.WriteLine("Language update Successfully");
                }
            else {
                    Console.WriteLine("Language is not updated");
                } 
        }

        internal void UpdateLan()
        {

            //Click on language that want to be update
            Thread.Sleep(5000);
            //Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]", 10000);
            IWebElement lanupdate = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            lanupdate.Click();                                          
            Thread.Sleep(10000);
            //click on update icon infront of language              
            IWebElement update = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
            update.Click();                                             
            Thread.Sleep(10000);                                        

            //select languagelevel from the dropdownlist that want to be update
            IWebElement langLevel = Driver.driver.FindElement(By.Name("level"));
            langLevel.Click();
            new SelectElement(Driver.driver.FindElement(By.Name("level"))).SelectByText("Basic");
            Thread.Sleep(5000);

            //click on update button
            IWebElement add2 = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            add2.Click();
            Thread.Sleep(1000);                                    
        }

        internal void LanAdded()
        {

            //Thread.Sleep(1000);
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]", 5000);
            IWebElement addedelang = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            if (addedelang.Text == "English")                     
            {
                Console.WriteLine("Language added succesfully");

            }
            else
            {
                Console.WriteLine("New language is not added");

            }
        }

        internal void DeleteLanguage()
        {
            //Wait.WaitForElement(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 5000);
            //try
            //{
            Thread.Sleep(1000);
            // Select language to delete
            IWebElement lanToDel = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            lanToDel.Click();                                   
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("canot able to locate element", ex.Message);
            //}

            //click on delete cross button
            IWebElement crossbtn = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[2]/i"));
            crossbtn.Click();
        }
    }
}