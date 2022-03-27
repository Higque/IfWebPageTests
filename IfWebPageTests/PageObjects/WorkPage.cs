using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace IfWebPageTests.PageObjects
{
    internal class WorkPage
    {
        private IWebDriver _webDriver;
        private string _link = "//a[text()='{0}' and contains(@class,'if shortcut')]";

        public WorkPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private void NavigateToPage(string pageName)
        {
            Thread.Sleep(1000);
            string xpath = String.Format(_link, pageName);
            _webDriver.FindElement(By.XPath(xpath)).Click();
        }

        public VacanciesPage NavigateToVacanciesPage()
        {
            NavigateToPage("Vakances");

            return new VacanciesPage(_webDriver);
        }
    }
}
