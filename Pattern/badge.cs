using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Components
{
    class Badge
    {
  
        private IWebDriver driver;
        private WebDriverWait wait;
        public Badge(IWebDriver driver)

       
        public void start_Browser()
        {
            // Local Selenium WebDriver
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.Manage().Window.Maximize();
        }


            IWebDriver driver = new ChromeDriver();

            IWebElement button = driver.FindElement(By.XPath("//button[@class='mat-focus-indicator mat-badge mat-raised-button mat-button-base mat-badge-overlap mat-badge-above mat-badge-after mat-badge-medium']"));

            button.Click();


       public void Click()
        {
            button.Click();
        }


        public string getAttribute()
        {
            return button.GetAttribute("class");
        }


    }
}

