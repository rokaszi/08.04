using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace radio_button
{
    class radio
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

            driver.FindElement(By.XPath("//div[text() = 'Radio button']")).Click();

            System.Threading.Thread.Sleep(2000);

            IWebElement radio = driver.FindElement(By.Id("mat-radio-2"));
            System.Threading.Thread.Sleep(2000);

            radio.Click();


            string classes = radio.GetAttribute("class");


            Console.WriteLine("Test Passed");



        }

        [TearDown]

        public void close_Browser()
        {
            driver.Quit();
        }
    }
}

