using OpenQA.Selenium;

namespace IfWebPageTests.PageObjects
{
    internal class WorkPage
    {
        private IWebDriver _webDriver;

        public WorkPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public VacanciesPage NavigateToVacanciesPage()
        {
            GlobalPage.NavigateToPageFromShortcut(_webDriver, "Vakances");

            return new VacanciesPage(_webDriver);
        }
    }
}
