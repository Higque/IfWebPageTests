using IfWebPageTests.PageObjects;
using IfWebPageTests.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace IfWebPageTests
{
    public class BaseTest
    {
        protected IWebDriver _webDriver;

        private readonly By _btnAcceptCookies = By.Id("onetrust-accept-btn-handler");
        private readonly By _btnMainNavigation = By.XPath("//a[@href='#main-navigation']");

        [OneTimeSetUp]
        protected void SetUpBeforeAllTests()
        {
           _webDriver = new ChromeDriver();
        }

        [OneTimeTearDown]
        protected void TearDownAfterAllTests()
        {
            _webDriver.Quit();
        }

        [SetUp]
        protected void SetUpBeforeEachTest()
        {
            _webDriver.Manage().Cookies.DeleteAllCookies();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(TestConfigurations.BaseURL);
            HandleCookiesConsentBar();
        }

        private void HandleCookiesConsentBar()
        {
            Wait.WaitUntilElementIsClickable(_webDriver, _btnAcceptCookies);
            _webDriver.FindElement(_btnAcceptCookies).Click();
            Wait.WaitUntilElementIsClickable(_webDriver, _btnMainNavigation);
            _webDriver.FindElement(_btnMainNavigation).Click();
        }
    }
}
