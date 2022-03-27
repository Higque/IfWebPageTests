using IfWebPageTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace IfWebPageTests
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.if.lv");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("onetrust-accept-btn-handler")).Click();
            driver.FindElement(By.XPath("//a[@href='#main-navigation']")).Click();
        }

        [Test]
        public void Test1()
        {
            var mainPage = new MainPage(driver);
            mainPage
                .NavigateToAboutPage()
                .NavigateToWorkPage()
                .NavigateToVacanciesPage()
                .NavigateToQATestAutomationVacancy()
                .CheckJobPageHeading();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}