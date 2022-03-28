using IfWebPageTests.Utilities;
using OpenQA.Selenium;

namespace IfWebPageTests.PageObjects
{
    public static class GlobalPage
    {
        private readonly static string _lnkMenu = "//a[text()='{0}' and contains(@class,'menu-action')]";
        private readonly static string _lnkShortcut = "//a[text()='{0}' and contains(@class,'if shortcut')]";

        public static void NavigateToPageFromMenu(IWebDriver _webDriver, string pageName)
        {
            string xpath = string.Format(_lnkMenu, pageName);
            ClickElement(_webDriver, By.XPath(xpath));
        }

        public static void NavigateToPageFromShortcut(IWebDriver _webDriver, string pageName)
        {
            string xpath = string.Format(_lnkShortcut, pageName);
            ClickElement(_webDriver, By.XPath(xpath));
        }

        public static void ClickElement(IWebDriver _webDriver, By element)
        {
            Wait.WaitUntilElementVisible(_webDriver, element);
            Wait.WaitUntilElementIsClickable(_webDriver, element);
            _webDriver.FindElement(element).Click();
        }

        public static string GetElementText(IWebDriver _webDriver, By element)
        {
            Wait.WaitUntilElementVisible(_webDriver, element);
            Wait.WaitUntilElementIsClickable(_webDriver, element);
            return _webDriver.FindElement(element).Text;
        }
    }
}
