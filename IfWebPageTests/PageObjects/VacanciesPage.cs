﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace IfWebPageTests.PageObjects
{
    internal class VacanciesPage
    {
        private IWebDriver _webDriver;
        private readonly By _qaVacancyLink = By.XPath("//a[contains(@href,'test-automation')]");

        public VacanciesPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public QAJobPage NavigateToQATestAutomationVacancy()
        {
            Thread.Sleep(1000);
            _webDriver.FindElement(_qaVacancyLink).Click();
            return new QAJobPage(_webDriver);
        }
    }
}
