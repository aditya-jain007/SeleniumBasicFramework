using SeleniumBasicFramework.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using expected = SeleniumExtras.WaitHelpers;
using SeleniumBasicFramework.Driver;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasicFramework.Pages
{
    public class HomePage : BasePage
    {
        public static IWebDriver Driver = SingletonBrowserClass.GetInstanceOfSingletonBrowserClass().GetDriver();
        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));

        [FindsBy(How = How.XPath, Using = "//a[@class='login']")]
        public IWebElement SignInButton;

        [FindsBy(How = How.XPath, Using = "//div[@id='block_top_menu']/ul/li/a[text()='Dresses']")]
        public IWebElement DreesesButton;

        [FindsBy(How = How.XPath, Using = "//h2[@class='title_block']")]
        public IWebElement DreesesTextHeader;

        public T ClickOnDressesLink<T>() where T : new()
        {
            wait.Until(expected.ExpectedConditions.ElementToBeClickable(DreesesButton)).Click();            
            return new T();
        }

        public string GetHeaderText()
        {
            return wait.Until(expected.ExpectedConditions.ElementToBeClickable(DreesesTextHeader)).Text;
        }

    }
}
