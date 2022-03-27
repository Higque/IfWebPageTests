using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace IfWebPageTests.PageObjects
{
    internal class AboutPage
    {   
        private IWebDriver _webDriver;
        private string _link = "//a[text()='{0}' and contains(@class,'menu-action')]";

        public AboutPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private void NavigateToPage(string pageName)
        {
            Thread.Sleep(1000);
            string xpath = String.Format(_link, pageName);
            _webDriver.FindElement(By.XPath(xpath)).Click();
           // _webDriver.FindElement(By.XPath(xpath)).Click();
        }

        public WorkPage NavigateToWorkPage()
        {
            NavigateToPage("Darbs If");

            return new WorkPage(_webDriver);
        }
    }
}
