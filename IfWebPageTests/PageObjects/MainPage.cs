using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace IfWebPageTests.PageObjects
{
    class MainPage
    {
        private IWebDriver _webDriver;

        private string _link = "//a[text()='{0}' and contains(@class,'menu-action')]";

        public MainPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private void NavigateToPage(string pageName){
            string xpath = String.Format(_link, pageName);
            Thread.Sleep(1000);
            _webDriver.FindElement(By.XPath(xpath)).Click();
            //_webDriver.FindElement(By.XPath(xpath)).Click();
        }

        public AboutPage NavigateToAboutPage()
        {
            NavigateToPage("Par If");
            
            return new AboutPage(_webDriver);
        }
    }
}
