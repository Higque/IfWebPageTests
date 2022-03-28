using OpenQA.Selenium;

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
            GlobalPage.ClickElement(_webDriver, _qaVacancyLink);

            return new QAJobPage(_webDriver);
        }
    }
}
