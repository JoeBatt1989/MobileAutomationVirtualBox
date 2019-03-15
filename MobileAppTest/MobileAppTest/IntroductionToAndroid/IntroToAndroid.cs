using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppTest.IntroductionToAndroid
{
    class IntroToAndroid
    {
        HelperClasses.CloseAdvert closeAdverts = new HelperClasses.CloseAdvert();
        HelperClasses.WaitMethods wait = new HelperClasses.WaitMethods();

        //[FindsBy(How = How.XPath, Using = "//*[@text='TextView']")]
        //public IWebElement introductionToAndroidLink { get; set; }

        public void introToAndroidPage(AndroidDriver<AndroidElement> driver)
        {
            try
            {
                wait.WaitForElementVisibleByXPath(driver, "//*[@text='based on the Linux kerenl']", 2);
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
                closeAdverts.checkPopupDisplayed(driver);
            }
        }
    }
}
