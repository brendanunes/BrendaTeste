using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using OpenQA.Selenium.IE;

namespace Loja
{
    [TestClass]
    public class SkipLogin
    {
        [TestMethod]
        public void TestSkipLogin()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://demo.automationtesting.in/Index.html");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("btn2")).Click();

            driver.Quit();
        }
    }
}
