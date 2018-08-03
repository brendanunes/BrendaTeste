using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;


namespace Conta
{
    [TestClass]
    public class MyAccount
    {
        [TestMethod]
        public void EditMyAccount()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://demo.automationtesting.in/Register.html");
            driver.Manage().Window.Maximize();

            //acessando site
            driver.FindElement(By.LinkText("Practice Site")).Click();

            //clicando na opção
            driver.FindElement(By.LinkText("My Account")).Click();

            //Acessando a Conta
            driver.FindElement(By.Id("username")).SendKeys("brenda.nunes23@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("ExactSalesTeste#123");
            driver.FindElement(By.Name("login")).Click();


            //editando dados da conta
            driver.FindElement(By.LinkText("Account Details")).Click();
            driver.FindElement(By.Id("account_first_name")).SendKeys("Brenda");
            driver.FindElement(By.Id("account_last_name")).SendKeys("Nunes");
            driver.FindElement(By.Id("password_current")).SendKeys("ExactSalesTeste#123");
            driver.FindElement(By.Name("save_account_details")).Click();
            driver.Quit();
        }
    }
}