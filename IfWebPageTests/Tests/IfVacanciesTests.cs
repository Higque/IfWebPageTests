using IfWebPageTests.PageObjects;
using NUnit.Framework;


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
           string heading = mainPage
                .NavigateToAboutPage()
                .NavigateToWorkPage()
                .NavigateToVacanciesPage()
                .NavigateToQATestAutomationVacancy()
                .GetJobPageHeading();

            Assert.AreEqual("Quality Assurance/Test Automation Specialist", heading, "Heading is not correct!");
        }
    }
}