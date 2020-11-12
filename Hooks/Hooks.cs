using MarsOct2020.Helpers;
using System.Threading;
using TechTalk.SpecFlow;


namespace MarsOct2020.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [BeforeScenario]
        public void Setup()
        {
            //Defining the browser 
            // initialize the browser
            Driver driver = new Driver();
            driver.Initialize();

            
            //ExcelLibHelpers.PopulateInCollection(@"D:\MarsOct2020\MarsOct2020\SpecFlow\Test\Data\Mars.xlsx", "Credentials");
            //Thread.Sleep(5000);                   
        }

        [AfterScenario]
        public void AfterScenario() 
        {
            // close the window and release the memory
             Driver.driver.Dispose();

        }
    }
}
