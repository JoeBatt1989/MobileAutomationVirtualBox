using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppTest.HelperClasses
{
    class Navigation
    {
        CloseAdvert closeAdverts = new CloseAdvert();
        WaitMethods wait = new WaitMethods();
        
        [FindsBy(How = How.XPath, Using = "//*[@contentDescription='Navigate up']")]
        public IWebElement backNavigtaionLink { get; set; }

        public void navigateBack(AndroidDriver<AndroidElement> driver)
        {
            bool navSuccess = false;
            int attempts = 0;
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(10)));
            closeAdverts.checkPopupDisplayed(driver);
            while (navSuccess.Equals(false)){
                attempts++;
                if(attempts >= 2)
                {
                    Debug.Write("Unable to select back button");
                    break;
                }
                wait.WaitForElementVisibleByXPath(driver, "//*[@contentDescription='Navigate up']");
                backNavigtaionLink.Click();
                navSuccess = true;
            }
        }
    }
}
