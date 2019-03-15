using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppTest.HelperClasses
{
    class CloseAdvert
    {
        WaitMethods wait = new WaitMethods();

        [FindsBy(How = How.XPath, Using = "//*[@class='android.widget.ImageView' and ./parent::*[@class='android.widget.FrameLayout']]")]
        public IWebElement facebookPopup { get; set; }

        public void checkPopupDisplayed(AndroidDriver<AndroidElement> driver)
        {
            try
            {
                wait.WaitForElementVisibleByXPath(driver, "//*[@class='android.widget.ImageView' and ./parent::*[@class='android.widget.FrameLayout']]", 3);
                closeFacebookPopup(driver);
            }
            catch (Exception e)
            {
                Debug.Write(e);
            }
        }

        public void closeFacebookPopup(AndroidDriver<AndroidElement> driver)
        {
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(10)));
            facebookPopup.Click();
        }
    }
}
