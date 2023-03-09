//Open Chrome Browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//Open TurnUp Portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//Identify the username textbox and enter valid username
IWebElement usernameTextBox = driver.FindElement (By.Id("UserName"));
usernameTextBox.SendKeys("hari");


//Identify the password textbox and enter the password
IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
passwordTextBox.SendKeys("123123");

//Identify the login button and click on it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

//Check if user successfully logged in
IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (hellohari.Text == "Hello hari!")
{
    Console.WriteLine("Successfully logged in.");
}
else
{
    Console.WriteLine("Login Failed.");
}




driver.Quit();
