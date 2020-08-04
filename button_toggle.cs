using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Button_toggle
{
    class toggle
    {
        IWebDriver driver;

        [SetUp]

        public void start_Browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }




        [Test]

        public void test_search()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://material.angular.io/components/categories");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//div[text() = 'Button toggle']")).Click();

            System.Threading.Thread.Sleep(2000);

            IWebElement button = driver.FindElement(By.Id("mat-button-toggle-14"));

            button.Click();

            string classes = button.GetAttribute("class");

            Console.WriteLine("Test Passed");

        }

        [TearDown]

        public void close_Browser()
        {
            driver.Quit();
        }
    }
}

