using OpenQA.Selenium;

namespace IfWebPageTests.PageObjects
{
    class MainPage
    {
        private IWebDriver _webDriver;

        public MainPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public AboutPage NavigateToAboutPage()
        {
            GlobalPage.NavigateToPageFromMenu(_webDriver, "Par If");

            return new AboutPage(_webDriver);
        }
    }
}
