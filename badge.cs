using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Badge
{
    class Button
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

            driver.FindElement(By.XPath("//div[text() = 'Badge']")).Click();

            System.Threading.Thread.Sleep(2000);

            IWebElement button = driver.FindElement(By.XPath("//button[@class='mat-focus-indicator mat-badge mat-raised-button mat-button-base mat-badge-overlap mat-badge-above mat-badge-after mat-badge-medium']"));

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

