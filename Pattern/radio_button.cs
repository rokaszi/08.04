using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Components
{
    class radio
    {

        private IWebDriver driver;
        private WebDriverWait wait;
        public radio(IWebDriver driver)

       
        public void start_Browser()
        {
            // Local Selenium WebDriver
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            driver.Manage().Window.Maximize();
        }


            IWebDriver driver = new ChromeDriver();

            IWebElement radio = driver.FindElement(By.Id("mat-radio-2"));

        
 public void ClickRadioButton()
        {
            radio.Click();
        }
    }
}

