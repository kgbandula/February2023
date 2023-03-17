using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February2023.Utilities
{
    //Fluent Wait
    public class Wait
    {
        //string should be in "" creating a string parameter 
        //setting the amount of time each element that ask selenium to wait
        //putting it to another paramenter (int seconds)
        //changing to static  = value allows to you without creating a object
        public static void WaitToBeClickable(IWebDriver driver, string locatorType, string locatorValue, int seconds) 
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds ));
            if (locatorType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if (locatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if(locatorType == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }
            
        }
    }
}
