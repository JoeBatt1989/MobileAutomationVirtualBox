using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppTest.HelperClasses
{
    class GestureControl
    {
        public void swipe(AndroidDriver<AndroidElement> driver, int startWidth, int startHeight, int endWidth, int endHeight, int duration)
        {
            driver.Swipe(startWidth, startHeight, endWidth, endHeight, duration);
        }
    }
}
