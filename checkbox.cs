using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Checkbox
{
    class Check
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

            driver.FindElement(By.XPath("//div[text() = 'Checkbox']")).Click();

            System.Threading.Thread.Sleep(2000);


            IWebElement checkbox = driver.FindElement(By.Id("mat-checkbox-1"));
            System.Threading.Thread.Sleep(2000);

            checkbox.Click();


            string classes = checkbox.GetAttribute("class");


            Console.WriteLine("Test Passed");



        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}

