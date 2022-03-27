using IfWebPageTests.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace IfWebPageTests.PageObjects
{
    internal class QAJobPage
    {
        private IWebDriver _webDriver;

        private readonly By _qaJobTitleHeading = By.TagName("h1");

        public QAJobPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void CheckJobPageHeading (){
            Wait.WaitUntilElementVisible(_webDriver, _qaJobTitleHeading);
            string heading = _webDriver.FindElement(_qaJobTitleHeading).Text;
            Assert.AreEqual("Quality Assurance/Test Automation Specialist", heading, "Heading is not correct!");
       }
    }
}
