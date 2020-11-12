using MarsOct2020.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MarsOct2020.Pages
{
    class EducationPage
    {
        internal void AddEdu(string country, string title, string year)
        {
            //click on education tab
            IWebElement addEdu = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            addEdu.Click();
            Thread.Sleep(15000);

            //click on add new education button
            IWebElement addnewEdu = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addnewEdu.Click();
            Thread.Sleep(5000);


            // Add educational details--country from dropdown list

            IWebElement countrydpdn = Driver.driver.FindElement(By.Name("country"));
            countrydpdn.Click();
            new SelectElement(Driver.driver.FindElement(By.Name("country"))).SelectByText(country);
            Thread.Sleep(5000);

            //choose title from dropdownlist
            IWebElement titledrp = Driver.driver.FindElement(By.Name("title"));
            titledrp.Click();
            Thread.Sleep(1000);
            new SelectElement(Driver.driver.FindElement(By.Name("title"))).SelectByText(title);
            Thread.Sleep(1000);

            // choose year from dropdown list
            IWebElement yeardpdn = Driver.driver.FindElement(By.Name("yearOfGraduation"));
            yeardpdn.Click();
            new SelectElement(Driver.driver.FindElement(By.Name("yearOfGraduation"))).SelectByText(year);

            //input institute name
            IWebElement institute = Driver.driver.FindElement(By.Name("instituteName"));
            institute.SendKeys("Punjab University");


            // input degree
            IWebElement degree = Driver.driver.FindElement(By.Name("degree"));
            degree.SendKeys("Bachelor in Computer Application");
            Thread.Sleep(1000);

            //Clcik on add button
            IWebElement addnewbtn = Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
            addnewbtn.Click();
            Thread.Sleep(1000);


            //add second(2nd) education detail
            //click on add new button
            IWebElement addsecondnew = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addsecondnew.Click();
            Thread.Sleep(5000);

            //Add country
            IWebElement newctountrydrpn = Driver.driver.FindElement(By.Name("country"));
            newctountrydrpn.Click();
            new SelectElement(Driver.driver.FindElement(By.Name("country"))).SelectByText("New Zealand");
            Thread.Sleep(5000);

            //Select title from dropdown list
            IWebElement newctitledrpn = Driver.driver.FindElement(By.Name("title"));
            newctitledrpn.Click();
            new SelectElement(Driver.driver.FindElement(By.Name("title"))).SelectByText("M.B.A");
            Thread.Sleep(5000);

            //select year drom dropdown list
            IWebElement newyeardrpn = Driver.driver.FindElement(By.Name("yearOfGraduation"));
            newyeardrpn.Click();
            new SelectElement(Driver.driver.FindElement(By.Name("yearOfGraduation"))).SelectByText("2013");
            Thread.Sleep(5000);

            //input institution name
            IWebElement newinstitute = Driver.driver.FindElement(By.Name("instituteName"));
            newinstitute.SendKeys("Delhi University");

            //input degree
            IWebElement newdegree = Driver.driver.FindElement(By.Name("degree"));
            newdegree.SendKeys("Masters in Bussiness Management");
            Thread.Sleep(1000);


            //clcik on add button
            IWebElement addsecondnewbtn = Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
            addsecondnewbtn.Click();
            Thread.Sleep(1000);

        }

        internal void EduAdded()
        {
            Thread.Sleep(1000);
            IWebElement addededu = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            if (addededu.Text == "India")

            {
                Console.WriteLine("Education Added Sucessfully");
            }
            else
            {
                Console.WriteLine("Education is not Added");

            }
        }

        internal void UpdateEdu(string titleName)
        {

            //click on education
            IWebElement eduupdate = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            eduupdate.Click();
            Thread.Sleep(1000);

            //click on update icon
            IWebElement updatebtn = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
            updatebtn.Click();
            Thread.Sleep(10000);

            //select title from dropdownlist to update title
            IWebElement titledn = Driver.driver.FindElement(By.Name("title"));
            titledn.Click();
            Thread.Sleep(1000);
            new SelectElement(Driver.driver.FindElement(By.Name("title"))).SelectByText(titleName);

            // click on update education
            IWebElement update = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
            update.Click();

        }

        internal void EduUpdated()
        {
            //validate education updated sucessfully or not

            Thread.Sleep(1000);
            IWebElement eduupdated = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
            if (eduupdated.Text == "M.Tech")
            {
                Console.WriteLine("Education Updated Sucessfully");
            }
            else
            {
                Console.WriteLine("Education not Updated");
            }
        }

        internal void DeleteEdu()
        {
            //click on education
            IWebElement edu = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            edu.Click();
            Thread.Sleep(1000);

            //click on edu that you want to delete(year)
            IWebElement edudelete = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[5]"));
            edudelete.Click();
            Thread.Sleep(1000);

            //clcik on cross icon corresponding the education that you want to delete
            IWebElement crossdelete = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[6]/span[2]/i"));
            crossdelete.Click();

        }

        internal void EduDeleted()
        {

            Thread.Sleep(1000);

            IWebElement edudelete = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));
            if (edudelete.Text != "2013")
            {
                Console.WriteLine("Education Deleted Sucessfully");
            }
            else
            {
                Console.WriteLine("Education is not Deleted");
            }
        }
    }
}
