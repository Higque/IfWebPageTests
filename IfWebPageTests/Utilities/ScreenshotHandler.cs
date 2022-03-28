using OpenQA.Selenium;
using System;
using System.IO;

namespace IfWebPageTests.Utilities
{
    internal class ScreenshotHandler
    {
        public static void CaptureScreenshot(IWebDriver _webDriver, string testMethodName)
        {
            Screenshot ss = ((ITakesScreenshot)_webDriver).GetScreenshot();
            string screenshot = ss.AsBase64EncodedString;
            byte[] screenshotAsByteArray = ss.AsByteArray;
            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string Timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
            string fileName = dir + @"/Screenshots/" + Timestamp + testMethodName + ".png";
            ss.SaveAsFile(fileName, ScreenshotImageFormat.Png);
        }
    }
}
