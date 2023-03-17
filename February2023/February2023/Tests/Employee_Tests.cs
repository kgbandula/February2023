using February2023.Pages;
using February2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace February2023.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employee_Tests : CommonDriver
    {
        //Page object intialization
        HomPage homepageObj = new HomPage();
        EmployeePage employeePageObj = new EmployeePage();         
        

        [Test, Order (1)]
        public void CreateEmployeeTests()
        {
            //Employee page object initialization and definition          
            homepageObj.GoToEmployeePage(driver);                       
            employeePageObj.CreateEmployee(driver);
        }
        
        [Test, Order (2)]
        public void EditEmployeeTests()
        {
            homepageObj.GoToEmployeePage(driver);
            employeePageObj.EditEmployee(driver);
        }

        [Test, Order (3) ]
        public void DeleteEmployeeTests()
        {
            homepageObj.GoToEmployeePage(driver);
            employeePageObj.DeleteEmployee(driver);
        }       
    }
}
