using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppTest.Beginner
{
    class BeginnerNavigationMenu
    {
        HelperClasses.CloseAdvert closeAdverts = new HelperClasses.CloseAdvert();
        HelperClasses.WaitMethods wait = new HelperClasses.WaitMethods();

        //[FindsBy(How = How.XPath, Using = "//*[@text='TextView']")]
        //public IWebElement introductionToAndroidLink { get; set; }

        public void beginnerNavigation(AndroidDriver<AndroidElement> driver)
        {
            try
            {
                wait.WaitForElementVisibleByXPath(driver, "//*[@text='TextView']", 2);
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
                closeAdverts.checkPopupDisplayed(driver);
            }
        }
    }
}
