using OpenQA.Selenium;

namespace IfWebPageTests.PageObjects
{
    internal class QAJobPage
    {
        private IWebDriver _webDriver;

        private readonly By _qaJobTitleHeading = By.TagName("h1");

        public QAJobPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public string GetJobPageHeading()
        {
            return GlobalPage.GetElementText(_webDriver, _qaJobTitleHeading);
        }
    }
}
