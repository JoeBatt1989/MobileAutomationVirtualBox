using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Diagnostics;

namespace MobileAppTest.MainMenu
{
    class MainMenuNavigation
    {
        HelperClasses.CloseAdvert closeAdverts = new HelperClasses.CloseAdvert();
        HelperClasses.WaitMethods wait = new HelperClasses.WaitMethods();
        Beginner.BeginnerNavigationMenu beginnerNavigation = new Beginner.BeginnerNavigationMenu(); 

        [FindsBy(How = How.XPath, Using = "//*[@text='INTRODUCTION']")]
        public IWebElement introductionLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='BASIC LEARNING']")]
        public IWebElement basicLearningLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='BEGINNER']")]
        public IWebElement beginnerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='ADVANCE']")]
        public IWebElement advanceLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='PROFESSIONAL']")]
        public IWebElement professionalLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@text='TIPS & TRICKS']")]
        public IWebElement tipsTricksLink { get; set; }

        public void mainMenuNavigation(AndroidDriver<AndroidElement> driver, string menuLink)
        {
            try
            {
                wait.WaitForElementVisibleByXPath(driver, "//*[@text='INTRODUCTION']", 2);
            }
            catch(Exception e)
            {
                Debug.Print(e.ToString());
                closeAdverts.checkPopupDisplayed(driver);
            }
            menuLink = menuLink.ToUpper();
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(10)));
            if(menuLink == "INTRODUCTION")
            {
                introductionLink.Click();
            }
            else if (menuLink == "BASIC LEARNING")
            {
                basicLearningLink.Click();
            }
            else if (menuLink == "BEGINNER")
            {
                beginnerLink.Click();
                beginnerNavigation.beginnerNavigation(driver);
            }
            else if (menuLink == "ADVANCE")
            {
                advanceLink.Click();
            }
            else if (menuLink == "PROFESSIONAL")
            {
                professionalLink.Click();
            }
            else if (menuLink == "TIPS & TRICKS")
            {
                tipsTricksLink.Click();
            }
            else
            {
                Debug.Write("Manu link given does not match any of the links coded");
            }
        }
    }
}
