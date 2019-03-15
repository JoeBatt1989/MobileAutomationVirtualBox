using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppTest.BasicLearning
{
    class BasicLearingNavigationMenu
    {
        HelperClasses.CloseAdvert closeAdverts = new HelperClasses.CloseAdvert();
        HelperClasses.WaitMethods wait = new HelperClasses.WaitMethods();
        IntroductionToAndroid.IntroToAndroid introToAndroid = new IntroductionToAndroid.IntroToAndroid();

        [FindsBy(How = How.XPath, Using = "//*[@text='Introduction to Android']")]
        public IWebElement introductionToAndroidLink { get; set; }

        public void basicLearningNavigation(AndroidDriver<AndroidElement> driver, string menuLink)
        {
            try
            {
                wait.WaitForElementVisibleByXPath(driver, "//*[@text='Introduction to Android']", 2);
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
                closeAdverts.checkPopupDisplayed(driver);
            }
            menuLink = menuLink.ToUpper();
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(10)));
            if (menuLink == "INTRODUCTION TO ANDROID")
            {
                introductionToAndroidLink.Click();
                introToAndroid.introToAndroidPage(driver);
            }
        }
    }
}
