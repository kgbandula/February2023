using February2023.Pages;
using February2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace February2023.Tests
{
    //Test Scenario, collection of tests
    [TestFixture]
    //Test paralization
    [Parallelizable]

    //inherit CommonDriver class
    public class TM_Tests : CommonDriver
    {
        //Page object intialization
        HomPage homepageObj = new HomPage();       
        
        //initialize TMPage at class level
        TMPage tmPageObj = new TMPage();
    
        //Make it order type "Order()", add description to looks codes better
        [Test, Order (1), Description ("Check if user able to create time record with valid data.")]
        public void CreateTMTests()
        {
            //Page object initiallization
            //Home page object initialization and definition            
            homepageObj.GoToTMPage(driver);
            //Create TM, access to createTM
            tmPageObj.CreateTM(driver);
        }
        [Test, Order (2), Description ("Check if user able to edit an existing record with valid data.")]
        public void EditTMTests()
        {
            homepageObj.GoToTMPage(driver);
            //TM page object initialization and definition               
            tmPageObj.EditTM(driver);
        }
        [Test, Order (3), Description ("Check if user is able to delete an existing record.")]
        public void DeleteTMTests()
        {
            homepageObj.GoToTMPage(driver);                    
            //Delete TM
            tmPageObj.DeleteTM(driver);
        }       
    }
}

