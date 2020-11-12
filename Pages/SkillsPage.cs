using MarsOct2020.Helpers;
using MarsOct2020.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MarsOct2020.Pages
{
    class SkillsPage
    {
        internal void AddSkills()
        {
            //Click on skills
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 10000);
            IWebElement skillbtn = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillbtn.Click();

            //click on add new button
            Wait.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 10000);
            IWebElement addbtn = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addbtn.Click();
            //Thread.Sleep(1000);

            // input skill
            IWebElement addnewskill = Driver.driver.FindElement(By.Name("name"));
            addnewskill.SendKeys("Problem Solving");
            Thread.Sleep(1000);

            // select skill level
            IWebElement newskilllevel = Driver.driver.FindElement(By.Name("level"));
            newskilllevel.Click();
            new SelectElement(Driver.driver.FindElement(By.Name("level"))).SelectByText("Expert");
            Thread.Sleep(1000);

            //click add button
            //click on add
            IWebElement add = Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
            add.Click();
            Thread.Sleep(1000);

            // add second skill......

            //Click on skills
            IWebElement secondskillbtn = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            secondskillbtn.Click();
            Thread.Sleep(1000);

            //click on add new button
            IWebElement secondaddbtn = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
             secondaddbtn.Click();
            Thread.Sleep(1000);

            // input skill
            IWebElement addsecondskill = Driver.driver.FindElement(By.Name("name"));
            addsecondskill.SendKeys("Computer");
            Thread.Sleep(1000);

            // select skill level
            IWebElement secondskilllevel = Driver.driver.FindElement(By.Name("level"));
            secondskilllevel.Click();
            new SelectElement(Driver.driver.FindElement(By.Name("level"))).SelectByText("Beginner");
            Thread.Sleep(1000);

            //click add button
            //click on add
            IWebElement add1 = Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
            add1.Click();
            Thread.Sleep(1000);
        }
        //validate skill deleted
        internal void SkillsDeleted()
        {
            Thread.Sleep(1000);
            IWebElement deletedskills = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
                //div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[1]"));
       if (deletedskills.Text!="Problem Solving")                          
            {
                Console.WriteLine("Skills Deleted Successfully");
            }
        else
            {
                Console.WriteLine("Skills not deleted");
            }

        }


        internal void DeleteSkills()
        {
            //click on 
            IWebElement skillsbtn = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsbtn.Click();
            Thread.Sleep(1000);

            //select skill that you want to be delete
            IWebElement selectskill = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            selectskill.Click();
            Thread.Sleep(1000);

            // click on cross button corresponding to that..
            IWebElement skillcross = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
            skillcross.Click();
            Thread.Sleep(1000);

        }

        //validate skill updated
        internal void SkillsEdited()
        {
            Thread.Sleep(1000);
            //Wait.WaitForElementVisibility(driver, "XPath",//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[2]",5000);
           IWebElement skillsedidted = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[2]"));
            if (skillsedidted.Text== "Intermediate")
            {
                Console.WriteLine("Skill Edited Successfully");
            }
            else
            {
                Console.WriteLine("Skill is not Edited");
            }

        }
        //Edit exsisting skill
        internal void EditSkills()
        {
            // click on skills
            IWebElement skillbtn = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillbtn.Click();
            Thread.Sleep(1000);

            // click on skill that you want to be edited.....computer
            IWebElement skilledit = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[1]"));
            skilledit.Click();

            // click on edit icon corrosponding to skill (computer)
            IWebElement editicon = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[1]/i"));
            editicon.Click();

            // select level
            IWebElement leveledit = Driver.driver.FindElement(By.Name("level"));
            leveledit.Click();
            new SelectElement(Driver.driver.FindElement(By.Name("level"))).SelectByText("Intermediate");

            // click on update button
            IWebElement update = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td/div/span/input[1]"));
            update.Click();
        }

        internal void SkillsAdded()
        {
            Thread.Sleep(1000);
            //validate skill added
            IWebElement skilladded = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            if (skilladded.Text == "Problem Solving")
            {
                Console.WriteLine("Skill Added Sucessfully");
            }
            else
            {
                Console.WriteLine("skill is not Added");

            }

        }
    }
}
