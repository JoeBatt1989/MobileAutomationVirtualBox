using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppTest.HelperClasses
{
    class AssertionMethods
    {
        public void assertStringsEqual(string expected, string actual)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}
