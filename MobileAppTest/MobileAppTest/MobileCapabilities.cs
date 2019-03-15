using NUnit.Framework;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppTest
{
    class MobileCapabilities
    {
        private const string CapabilityValue = ".MainActivity";
        private string reportDirectory = "reports";
        private string reportFormat = "xml";

        public enum deviceType
        {
            SamsungS9,
            SamsungS8
        }

        public DesiredCapabilities mobileCaps(string deviceName)
        {
            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability("reportDirectory", reportDirectory);
            caps.SetCapability("reportFormat", reportFormat);
            caps.SetCapability("testName", TestContext.CurrentContext.Test.Name);
            if (deviceName.Equals("SamsungS9"))
            {
                caps.SetCapability(MobileCapabilityType.Udid, "192.168.43.101:5555");
                // caps.SetCapability("deviceName", "Samsung S9");
            }
            if (deviceName.Equals("SamsungS8"))
            {
                caps.SetCapability(MobileCapabilityType.Udid, "192.168.43.102:5555");
                // caps.SetCapability("deviceName", "Samsung S8");
            }
            caps.SetCapability(AndroidMobileCapabilityType.AppPackage, "com.hussainlabs.androiddevelopmentcourse");
            caps.SetCapability(AndroidMobileCapabilityType.AppActivity, CapabilityValue);
            return caps;
        }
    }
}
