using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Autocomplete

{
    class Button
    {

        IWebDriver driver;



        [SetUp]
        public void start_Browser()
        {
            // Local Selenium WebDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }


        [Test]
        public void test_search()
        {
      
            IWebDriver driver = new ChromeDriver();

          
            driver.Navigate().GoToUrl("https://material.angular.io/components/categories");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//div[text() = 'Autocomplete']")).Click();

            System.Threading.Thread.Sleep(2000);

            IWebElement field = driver.FindElement(By.Id("mat-input-0"));

            field.SendKeys("On");

            driver.FindElement(By.XPath("//span[@class='mat-option-text']")).Click();

            string result = field.GetAttribute("value");

            driver.Close();

            Console.WriteLine("Test Passed");

        }


        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}
