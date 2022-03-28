using OpenQA.Selenium;

namespace IfWebPageTests.PageObjects
{
    internal class AboutPage
    {
        private IWebDriver _webDriver;

        public AboutPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public WorkPage NavigateToWorkPage()
        {
            GlobalPage.NavigateToPageFromMenu(_webDriver, "Darbs If");

            return new WorkPage(_webDriver);
        }
    }
}
