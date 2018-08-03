using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using OpenQA.Selenium.IE;

namespace Login
{
    [TestClass]
    public class LoginOk
    {
        [TestMethod]
        public void TesteLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://demo.automationtesting.in/Index.html");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("email")).SendKeys("brenda.nunes23@gmail.com");
            driver.FindElement(By.Id("enterimg")).Click();

            driver.Quit();
        }
    }
}
