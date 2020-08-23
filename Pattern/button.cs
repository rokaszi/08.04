using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Components
{
    class Button
    {
      private IWebDriver driver;
        private WebDriverWait wait;
        public Autocompleate(IWebDriver driver)

       
        public void start_Browser()
        {
            // Local Selenium WebDriver
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            driver.Manage().Window.Maximize();
        }

        

            IWebDriver driver = new ChromeDriver();

            IWebElement button = driver.FindElement(By.XPath("//button[@class='mat-focus-indicator mat-raised-button mat-button-base mat-warn']"));



       public void ClickButton()
        {
            button.Click();
        }
    }
}
