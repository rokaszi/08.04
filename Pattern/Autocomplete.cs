using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Components

{
    class Complete
    {

        private IWebDriver driver;
        private WebDriverWait wait;
        public Complete(IWebDriver driver)

       
        public void start_Browser()
        {
            // Local Selenium WebDriver
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            driver.Manage().Window.Maximize();
        }

      
            IWebDriver driver = new ChromeDriver();

            driver.FindElement(By.XPath("//div[text() = 'Autocomplete']")).Click();

            System.Threading.Thread.Sleep(2000);

            IWebElement fld = driver.FindElement(By.XPath("//span[@class='mat-option-text']"));


        public void TextInput(string text)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            field.SendKeys("On"); 
        }



          public void Clickfld()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            fld.Click(); 
        }


        public string ResultAndClose()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            return result = field.GetAttribute("value");
            driver.Close();
        }

    }
}
