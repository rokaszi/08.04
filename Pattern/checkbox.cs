using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Components
{
    class Check
    {

        private IWebDriver driver;
        private WebDriverWait wait;
        public Check(IWebDriver driver)

       
        public void start_Browser()
        {
            // Local Selenium WebDriver
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            driver.Manage().Window.Maximize();
        }



            IWebDriver driver = new ChromeDriver();
            IWebElement checkbox = driver.FindElement(By.Id("mat-checkbox-1"));
            

           
public void ClickCheckbox()
        {
            checkbox.Click();
        }
    }
}

