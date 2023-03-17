using February2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;


namespace February2023.Pages
{
    public class EmployeePage 
    {
        public void CreateEmployee(IWebDriver driver)
        {
            //Click on Create 
            IWebElement create = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            create.Click();
            Thread.Sleep(5000);

            //Enter Name
            IWebElement nameLog = driver.FindElement(By.XPath("//*[@id=\"Name\"]"));
            IWebElement nameTextbox = driver.FindElement(By.Id("Name"));
            nameLog.Click();
            nameTextbox.Click();
            nameTextbox.SendKeys("Udana");

            //Enter Username
            IWebElement usernameTextbox = driver.FindElement(By.Id("Username"));
            usernameTextbox.Click();
            usernameTextbox.SendKeys("Tisama");

            //Enter contact
            IWebElement contactTextbox = driver.FindElement(By.Id("ContactDisplay"));
            contactTextbox.Click();
            contactTextbox.SendKeys("0718532122");

            //Enter password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.Click();
            passwordTextbox.SendKeys("Vid@r@2016");

            //Retype password
            IWebElement retypePassword = driver.FindElement(By.Id("RetypePassword"));
            retypePassword.Click();
            retypePassword.SendKeys("Vid@r@2016");

            //Right click on IsAdmin
            IWebElement isAdminCheckbox = driver.FindElement(By.XPath("//*[@id=\"IsAdmin\"]"));
            isAdminCheckbox.Click();

            //Enter vehicle
            IWebElement vehicleListbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicleListbox.Click();
            vehicleListbox.SendKeys("Toyota");
            Thread.Sleep(3000);

            //Find Tests from the list
            IWebElement listSelection = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]/input"));
            listSelection.Click();
            listSelection.SendKeys("Trainee");

            //Click on save
            IWebElement saveButton2 = driver.FindElement(By.Id("SaveButton"));
            saveButton2.Click();

            //Click on back to list
            IWebElement backToList = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToList.Click();

            //Click on lastpage pagination 
            IWebElement gotoLastPage2 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]"));
            gotoLastPage2.Click();
            Thread.Sleep(2000);

            //Find last record 
            IWebElement lastRecord2 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (lastRecord2.Text == "Udana")
            {
                Console.WriteLine("Employee record created successfully.");
            }
            else
            {
                Console.WriteLine("Employee record is not created.");
            }
            ////Find last record 
            //IWebElement lastRecord2 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            //IWebElement userName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));
            
            //Assert.That(userName.Text == "Tisama", "Record created successfully");                         
        }
        public void EditEmployee(IWebDriver driver) 
        {
            //GoToTheLastPage
            IWebElement goToTheLastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]"));
            goToTheLastPage.Click();
                        
            //Navigate to edit 
            IWebElement edit = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            edit.Click();

            //Enter Name
            IWebElement nameTextboxEd = driver.FindElement(By.Id("Name"));
            nameTextboxEd.Click();
            nameTextboxEd.Clear();
            nameTextboxEd.SendKeys("Udana Tisama Vidara");

            //Enter Username
            IWebElement usernameTextboxEd = driver.FindElement(By.Id("Username"));
            usernameTextboxEd.Click();
            usernameTextboxEd.Clear();
            usernameTextboxEd.SendKeys("Wimalasena");

            //Enter contact
            IWebElement contactTextboxEd = driver.FindElement(By.Id("ContactDisplay"));
            contactTextboxEd.Click();
            contactTextboxEd.SendKeys("0718000888");

            //Enter password
            IWebElement passwordTextboxEd = driver.FindElement(By.Id("Password"));
            passwordTextboxEd.Click();
            passwordTextboxEd.SendKeys("Vid@r@20");

            //Retype password
            IWebElement retypePasswordEd = driver.FindElement(By.Id("RetypePassword"));
            retypePasswordEd.Click();
            retypePasswordEd.SendKeys("Vid@r@20");

            //Right click on IsAdmin
            IWebElement isAdminCheckboxEd = driver.FindElement(By.XPath("//*[@id=\"IsAdmin\"]"));
            isAdminCheckboxEd.Click();

            //Enter vehicle
            IWebElement vehicleListboxEd = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicleListboxEd.Click();
            vehicleListboxEd.SendKeys("ToyotaPascal");

            //Enter groups 
            IWebElement groupsListboxEd = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]/input"));
            groupsListboxEd.Click();
            groupsListboxEd.SendKeys("Trained");
            Thread.Sleep(3000);

            //Click on save
            IWebElement saveButtonEd2 = driver.FindElement(By.Id("SaveButton"));
            saveButtonEd2.Click();

            //Click on back to list
            IWebElement backToListEd = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToListEd.Click();

            //Click on lastpage pagination 
            IWebElement gotoLastPageEd2 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]"));
            gotoLastPageEd2.Click();
            Thread.Sleep(2000);

            //Find last record 
            IWebElement lastRecordEd2 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));

            if (lastRecordEd2.Text == "Wimalasena")
            {
                Console.WriteLine("Employee record edited successfully.");
            }
            else
            {
                Console.WriteLine("Employee record is not edited.");
            }
        }
        public void DeleteEmployee(IWebDriver driver) 
        {
            //Go to the last page
            IWebElement goToTheLastPage2 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]"));
            goToTheLastPage2.Click();

            //Delete edited record
            IWebElement delete2 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[5]/td[3]/a[2]"));
            delete2.Click();

            IAlert employee = driver.SwitchTo().Alert();
            employee.Accept();

            IWebElement deleteText2 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));

            if (deleteText2.Text != "Wimalasena")
            {
                Console.WriteLine("Employee record deleted successfully.");
            }
            else
            {
                Console.WriteLine("Employee record was not deleted.");
            }
        }

    }
}
