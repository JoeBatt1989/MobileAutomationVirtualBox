using NUnit.Framework;
using OpenQA.Selenium;

namespace MobileAppTest.MobileAppTests
{
    [TestFixture]
    [NonParallelizable]
    class MobileAppTest : Hooks
    {
        HelperClasses.WaitMethods waits = new HelperClasses.WaitMethods();
        HelperClasses.AssertionMethods assertions = new HelperClasses.AssertionMethods();
        MainMenu.MainMenuNavigation mainMenu = new MainMenu.MainMenuNavigation();
        HelperClasses.Navigation navigation = new HelperClasses.Navigation();
        HelperClasses.GestureControl gesture = new HelperClasses.GestureControl();
        BasicLearning.BasicLearingNavigationMenu basicLearing = new BasicLearning.BasicLearingNavigationMenu();

        [Parallelizable(ParallelScope.All)]
        [Test]
        [TestCaseSource("deviceToRunWith")]
        public void basicNavigation(string deviceName)
        {
            setUp(deviceName);
            mainMenu.mainMenuNavigation(driver, "beginner");
            gesture.swipe(driver, 910, 955, 910, -1000, 1000);
            navigation.navigateBack(driver);
            mainMenu.mainMenuNavigation(driver, "BASIC LEARNING");
            basicLearing.basicLearningNavigation(driver, "Introduction to Android");
            gesture.swipe(driver, 910, 955, 910, -2000, 1000);
        }

        //[Parallelizable(ParallelScope.All)]
        [Test]
        [TestCaseSource("deviceToRunWith")]
        public void closeFacebookAdvert(string deviceName)
        {
            setUp(deviceName);
            driver.FindElement(By.XPath("//*[@text='TIPS & TRICKS']")).Click();
            driver.FindElement(By.XPath("//*[@text='General Tips']")).Click();
            driver.FindElement(By.XPath("//*[@contentDescription='Navigate up']")).Click();
            driver.FindElement(By.XPath("//*[@contentDescription='Navigate up']")).Click();
            driver.FindElement(By.XPath("//*[@class='android.widget.ImageView' and ./parent::*[@class='android.widget.FrameLayout']]")).Click();

        }
    }
}
