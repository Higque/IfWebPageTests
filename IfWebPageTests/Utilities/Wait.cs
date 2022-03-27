using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace IfWebPageTests.Utilities
{
    public static class Wait
    {
        private static TimeSpan waitTime = TimeSpan.FromSeconds(10);
        public static void WaitUntilElementVisible(IWebDriver webDriver, By webElement)
        {
            try
            {
                new WebDriverWait(webDriver, waitTime).Until(ExpectedConditions.ElementIsVisible(webElement));
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new NotFoundException("Element with data [" + webElement.ToString() + "] was not found.", ex);
            }
        }

        public static void WaitUntilElementIsClickable(IWebDriver webDriver, By webElement)
        {
            new WebDriverWait(webDriver, waitTime).Until(ExpectedConditions.ElementToBeClickable(webElement));
        }
    }
}
