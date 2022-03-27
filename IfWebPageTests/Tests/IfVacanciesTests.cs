using IfWebPageTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace IfWebPageTests
{
    [TestFixture]
    public class IfVacanciesTests : BaseTest
    {
        MainPage mainPage;

        [SetUp]
        protected void SetUp()
        {
            mainPage = new MainPage(_webDriver);
        }

        [Test]
        public void VacancyHeading_IsCorrect()
        {
            mainPage
                .NavigateToAboutPage()
                .NavigateToWorkPage()
                .NavigateToVacanciesPage()
                .NavigateToQATestAutomationVacancy()
                .CheckJobPageHeading();
        }
    }
}