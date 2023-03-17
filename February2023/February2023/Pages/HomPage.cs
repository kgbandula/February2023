using February2023.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February2023.Pages
{
    public class HomPage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            ////Implement Implecit Wait
            //WebDriverWait wait = new WebDriverWait (driver, TimeSpan.FromSeconds (5));

            ////Explicit wait need nugget packages (DotNetSeleniumExtras.WaitHelpers)
            ////most used elementexist, elementtobevisible, elementtobeclickable
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")));

            //Navigate to Administration
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();
            Thread.Sleep(20000);

            //Select Time & Material
            Wait .WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 5000);
            IWebElement timeMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterial.Click();
        }
        public void GoToEmployeePage(IWebDriver driver) 
        {
            //Click Administration
            IWebElement administration2 = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration2.Click();

            //Select Employees
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[2]", 5000);
            IWebElement employees = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]"));
            employees.Click();
        }
    }
}
