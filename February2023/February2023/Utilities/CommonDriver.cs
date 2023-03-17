using February2023.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Inheritance
namespace February2023.Utilities
{
    public class CommonDriver
    {
        //Initiate what our driver going to be
        //static - dont want to object
        public IWebDriver driver;

        [SetUp]
        public void Loginsteps()
        {
            driver = new ChromeDriver(@"F:\");
            
            //Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.loginActions(driver);
        }
        //close test
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
