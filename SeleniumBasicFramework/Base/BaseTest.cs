using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumBasicFramework.Driver;
using System.Configuration;
using System.Threading;

namespace SeleniumBasicFramework.Base
{
    public class BaseTest
    {
        [TearDown]
        public void TearDown()
        {
            IWebDriver Driver = SingletonBrowserClass.GetInstanceOfSingletonBrowserClass().GetDriver();
            Driver.Close();
            Driver.Dispose();
            SingletonBrowserClass.ResetSingletonBrowserInstance();
        }

    }
}
