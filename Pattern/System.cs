using System;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;


namespace Components
{
    public class Tests
    {
    

        public void Autocomplete()
        {
            string expResult = "One";
            string input = "On";
            IWebDriver driver = new ChromeDriver();
            ComponentsPage page = new ComponentsPage(driver);
            page.goToPage();
            System.Threading.Thread.Sleep(2000);

            Autocomplete complete = page.GoToAutocompleate();
            System.Threading.Thread.Sleep(2000);
            complete.TextInput(input);
            System.Threading.Thread.Sleep(2000);
            complete.Clickfld();
            System.Threading.Thread.Sleep(2000);
            Assert.That(expResult = complete.ResultAndClose());
        }

         public void radio()
        {
            IWebDriver driver = new ChromeDriver();
            ComponentsPage page = new ComponentsPage(driver);
            page.GoToRadio();
            radio radio = new radio(driver);
            radio.ClickRadioButton();
        }

        public void Badge()
        {
            public string badgeCss = "mat-badge-hidden";
            IWebDriver driver = new ChromeDriver();
            ComponentsPage page = new ComponentsPage(driver);
            page.GoToBadge();
            Badge button = new Badge(driver);
            button.Click();
            Assert.That(button.GetAttribute, Does.Contain(badgeCss), "Pass");
        }

    
        public void checkbox()
        {
            IWebDriver driver = new ChromeDriver();
            ComponentsPage page = new ComponentsPage(driver);
            page.GoToCheckbox();
            Check checkbox = new checkbox(driver);
            checkbox.ClickCheckbox();
        }

        public void Button()
        {

            IWebDriver driver = new ChromeDriver();
            ComponentsPage page = new ComponentsPage(driver);
            Button button = page.GoToButton(); 
            button.ClickButton();
        }

        public void toggle()
        {
            IWebDriver driver = new ChromeDriver();
            ComponentsPage page = new ComponentsPage(driver);
            page.GoToButtonToggle();
            ButtonToggle toggle = new toggle(driver);
            button.Click();
            
        }
    }
}