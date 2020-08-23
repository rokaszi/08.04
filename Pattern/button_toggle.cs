using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Components
{
    class toggle
    {
         private IWebDriver driver;
        private WebDriverWait wait;
        public toggle(IWebDriver driver)

       
        public void start_Browser()
        {
            // Local Selenium WebDriver
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.Manage().Window.Maximize();
        }



            IWebDriver driver = new ChromeDriver();

            IWebElement button = driver.FindElement(By.Id("mat-button-toggle-14"));

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

