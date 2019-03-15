using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;

namespace MobileAppTest
{
    [TestFixture]
    public class Hooks
    {
        MobileCapabilities mobileCaps = new MobileCapabilities();
        protected AndroidDriver<AndroidElement> driver = null;
        DesiredCapabilities caps = new DesiredCapabilities();


        public void setUp(String deviceName)
        {
            caps = mobileCaps.mobileCaps(deviceName);
            driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4724/wd/hub"), caps);
        }

        public static IEnumerable<String> deviceToRunWith()
        {
            String[] devices = { "SamsungS9", "SamsungS8" };

            foreach (String d in devices)
            {
                yield return d;
            }
        }

        [TearDown]
        public void tearDown() => driver.Quit();
    }
}
