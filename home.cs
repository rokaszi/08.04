using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;

namespace shopTest
{
    public class HomePage 
    {
        private string home = "https://dovydenas.lt/sandboxone";
        private WebDriverWait wait;

        public HomePage(IWebDriver driver)
        {

        }

        //Search

        private By elem_searchInput = By.Id("search");

        private By elem_searchButton = By.XPath("//*[@id='search_mini_form']/div/button");


        public void ToHome()
        {
            Driver.Navigate().GoToUrl(home);
        }


        public void SearchText(string userInput)
        {
            field.SendKeys("testproduct");
        }

        public void Search()
        {
            Click.(elem_searchButton);
        }

    }
}
