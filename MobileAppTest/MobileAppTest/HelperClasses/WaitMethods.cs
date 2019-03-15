using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;

namespace MobileAppTest.HelperClasses
{
    class WaitMethods
    {
        public WebDriverWait wait;

        public void WaitForElementVisibleByCss(AndroidDriver<AndroidElement> driver, string cssString, int time = 10)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(cssString)));
        }

        public void WaitForElementVisibleByXPath(AndroidDriver<AndroidElement> driver, string xpathString, int time = 10)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpathString)));
        }

        public void WaitForElementClickableByXPath(AndroidDriver<AndroidElement> driver, string xpathString, int time = 10)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(xpathString)));
        }
    }
}
