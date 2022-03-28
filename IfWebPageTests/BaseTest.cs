using IfWebPageTests.PageObjects;
using IfWebPageTests.Utilities;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
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
            ManageWebdriver();
            HandleCookiesConsentBar();
        }

        [OneTimeTearDown]
        public void OneTimeTearDownScreenshotOnFail()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string testMethodName = TestContext.CurrentContext.Test.FullName;

                ScreenshotHandler.CaptureScreenshot(_webDriver, testMethodName);
            }
        }

        private void HandleCookiesConsentBar()
        {
            GlobalPage.ClickElement(_webDriver, _btnAcceptCookies);
            GlobalPage.ClickElement(_webDriver, _btnMainNavigation);
        }

        private void ManageWebdriver()
        {
            _webDriver.Manage().Cookies.DeleteAllCookies();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(TestConfigurations.BaseURL);
        }


    }
}
