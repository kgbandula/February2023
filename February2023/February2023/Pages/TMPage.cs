using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February2023.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNew.Click();

            //Select Time
            IWebElement typeCodeDropdownBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
            typeCodeDropdownBox.Click();
            Thread.Sleep(2000);
            IWebElement time = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            time.Click();

            //Click on Code Textbox and enter code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.Click();
            codeTextbox.SendKeys("BAN");

            //Click on Description Textbox and enter description
            IWebElement descripitonTextbox = driver.FindElement(By.Id("Description"));
            descripitonTextbox.Click();
            descripitonTextbox.SendKeys("Feb");
            Thread.Sleep(3000);

            //Click on Price Textbox and enter price
            IWebElement pricePerUnit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            pricePerUnit.SendKeys("20");


            //Click on save button
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            saveButton.Click();
            Thread.Sleep(3000);

            //Click on lastpage pagination 
            IWebElement gotoLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
            gotoLastPage.Click();

            //Find last record 
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));

            Assert.That(newCode.Text == "BAN", "Record created successfully.");
            Assert.That(newDescription.Text == "Feb", "Actual description and expected description do match.");

            //if (lastRecord.Text == "BAN")
            //{
            //    Console.WriteLine("T&M Record created successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("T&M Record is not created.");
            //}


        }
        public void EditTM(IWebDriver driver)
        {
            Thread.Sleep(5000);
            //Click on lastpage pagination                         
            IWebElement gotoLastPageEd = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
            gotoLastPageEd.Click();
            
            //Find last record 
            IWebElement lastRecordToBeEd = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(3000);

            if (lastRecordToBeEd.Text == "BAN")
            {
                //Navigate to edit 
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
            }
            else
            {
                Assert.Fail("Record to be edited can't find");
            }

            //Select Material
            IWebElement typeCodeDropdownBoxEd = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
            typeCodeDropdownBoxEd.Click();

            IWebElement material = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[1]"));
            material.Click();

            //Click on Code Textbox and enter code 
            IWebElement codeTextboxEd = driver.FindElement(By.Id("Code"));
            codeTextboxEd.Click();
            codeTextboxEd.Clear();
            codeTextboxEd.SendKeys("BANEDIT");

            //Click on Description Textbox and enter description
            IWebElement descripitonTextboxEd = driver.FindElement(By.Id("Description"));
            descripitonTextboxEd.Click();
            descripitonTextboxEd.Clear();
            descripitonTextboxEd.SendKeys("Feb2023BAN");
            Thread.Sleep(3000);

            //Click on Price Textbox and enter price

            IWebElement pricePerUnitEd = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement priceTag = driver.FindElement(By.Id("Price"));
            pricePerUnitEd.Click();
            priceTag.Click();
            priceTag.Clear();
            pricePerUnitEd.Click();
            priceTag.SendKeys("200");


            //Click on save button
            IWebElement saveButtonEd = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            saveButtonEd.Click();
            Thread.Sleep(3000);

            //Click on lastpage pagination 
            IWebElement gotoLastPageEdited = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
            gotoLastPageEdited.Click();

            //Find last record 
            IWebElement lastRecordEdited = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (lastRecordEdited.Text == "BANEDIT")
            {
                Console.WriteLine("T&M Record edited successfully.");
            }
            else
            {
                Console.WriteLine("T&M Record is not edited.");
            }
            Thread.Sleep(3000);
        }
        public void DeleteTM(IWebDriver driver)
        {
            Thread.Sleep(3000);
            
            IWebElement gotoLastPageEdited = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
            gotoLastPageEdited.Click();

            IWebElement lastRecordToBeDeleted = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if(lastRecordToBeDeleted.Text == "BANEDIT")
            {           
                //Delete edited record
                IWebElement delete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                delete.Click();
            }
            else
            {
                Assert.Fail("Record to be deleted can not be found.");
            }

            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();

            IWebElement deleteText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));

            Assert.That(deleteText.Text != "BANEDIT", "Record has been deleted.");

            //if (deleteText.Text != "Feb2023BAN")
            //{
            //    Console.WriteLine("T&M edit record was not deleted.");
            //}
            //else
            //{
            //    Console.WriteLine("T&M edit record deleted successfully.");
            //}

        }

    }
}
