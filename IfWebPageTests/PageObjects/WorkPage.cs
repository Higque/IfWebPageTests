using IfWebPageTests.Utilities;
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
            string xpath = string.Format(_link, pageName);
            Wait.WaitUntilElementIsClickable(_webDriver,By.XPath(xpath));
            _webDriver.FindElement(By.XPath(xpath)).Click();
        }

        public VacanciesPage NavigateToVacanciesPage()
        {
            NavigateToPage("Vakances");

            return new VacanciesPage(_webDriver);
        }
    }
}
