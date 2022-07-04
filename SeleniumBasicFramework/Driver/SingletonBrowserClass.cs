using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasicFramework.Driver
{
    public class SingletonBrowserClass
    {
        private static SingletonBrowserClass InstanceOfSingletonBrowserClass = null;

        private IWebDriver Driver;

        private SingletonBrowserClass()
        {
            Driver = new ChromeDriver();
        }

        public static SingletonBrowserClass GetInstanceOfSingletonBrowserClass()
        {
            if (InstanceOfSingletonBrowserClass == null)
            {
                InstanceOfSingletonBrowserClass = new SingletonBrowserClass();
            }
            return InstanceOfSingletonBrowserClass;
        }

        public static void ResetSingletonBrowserInstance()
        {
            InstanceOfSingletonBrowserClass = null;
        }

        public IWebDriver GetDriver()
        {
            return Driver;
        }
    }
}
