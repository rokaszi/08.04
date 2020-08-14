using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;

namespace AjaxWait
{
    public class FirstPage 
    {
        private string first = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/DataGrid/Overview/jQuery/Light/";
        private WebDriverWait wait;

        public FirstPage(IWebDriver driver)
        {

            wait = new WebDriverWait(Driver, new TimeSpan(10));

        }


       // webelement mydynamicelement = (new webdriverwait(driver, 10))
       //.until(expectedconditions.presenceofelementlocated(by.id("mydynamicelement")));



        //Search

        //nextdemopage kitam testui
        private By nextdemopage = By.XPath("//html/body/div/div[2]/div/div[3]/div/div[1]/div[3]/a[2]/span");

        //region bandau rasti kelia
        private By hundredrows = By.XPath("//*[@id='gridContainer']/div/div[11]/div[1]/div[4]");

        private By regionasc = By.XPath("//*[@id='dx-b308cd4c-2269-2fcc-737d-f3b3d33894fc']/div/ul/li[1]/div/div/span");

        //

        private By elem_searchInput = By.XPath("//*[@id='gridContainer']/div/div[4]/div/div/div[3]/div/div/div/div/div[1]/input");


        //laukimu variantas, nezinau ar teisingai pagavau per console
        private By firstWait = By.ClassName("load-panel");

        private By secondWait = By.ClassName("dx-overlay dx-widget dx-loadpanel");

        // private By elem_searchButton = By.XPath("//*[@id='search_mini_form']/div/button");


        //start
        public void navigate()
        {
            Driver.Navigate().GoToUrl(first);
        }


        /*
        public void SearchText(string userInput)
        {
            field.SendKeys("test");
        }

        public void Search()
        {
            Click.(elem_searchButton);
        }

        */


        public void Wait1()
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists(wait1));
        }

        public void Wait2()
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists(wait2));
        }

        public string sorting()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement hundredrows = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='gridContainer']/div/div[11]/div[1]/div[4]")));
            return hundredrows.Text;
        }


        public string sortingReg()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement regionasc = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='dx-b308cd4c-2269-2fcc-737d-f3b3d33894fc']/div/ul/li[1]/div/div/span")));
            return regionasc.Text;
        }


        //reikia asertinimo !




    }
}
