using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace February2023.Pages
{
    public class LoginPage
    {
        //parameters in () = paranthesis
        //when you declare parameters = webdriver is the driver (IWebdriver driver)
        //that is the chromedriver in program.cs(TM_Tests.cs)
        //string = section of characters
        
        public void loginActions(IWebDriver driver)
        {
            //loginPage methods
            

            driver.Manage().Window.Maximize();

            //Open TurnUp Portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //Handling the exception - fixing a bug - label as fail and log a bug
            try
            {
                //Identify the username textbox and enter valid username
                IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
                usernameTextBox.SendKeys("hari");
            }
            catch (Exception ex)
            {
                Assert.Fail("TurnUp portal home page did not launch.", ex.Message);
            }

            //Try and Catch implemented instead of following
            ////Identify the username textbox and enter valid username
            //IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
            //usernameTextBox.SendKeys("hari");


            //Identify the password textbox and enter the password
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");

            //Identify the login button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(2000);

            //Check if user successfully logged in
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
        }
    }
}
