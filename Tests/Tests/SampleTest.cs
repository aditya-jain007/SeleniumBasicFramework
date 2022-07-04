using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBasicFramework.Base;
using SeleniumBasicFramework.Driver;
using SeleniumBasicFramework.Pages;
using expected = SeleniumExtras.WaitHelpers;

namespace SeleniumBasicFramework.Tests
{
    [TestFixture]
    public class SampleTest : BaseTest
    {
        [Test]
        public void OpenURLAndClick()
        {
            //Click on the dresses
            Page.Home.ClickOnDressesLink<HomePage>();
            //Page.SignInPage.ClickloginBtn();
            //Verify dresses text is visible to user as a header
            string HeaderValue = Page.Home.GetHeaderText();
            Assert.IsTrue(HeaderValue.Contains("DRESSES"), "User can not see dresses as header value in UI");

        }

        [Test]
        public void OpenURLAndClick_2()
        {
            //Open Driver session and navigate to url
            IWebDriver Driver = SingletonBrowserClass.GetInstanceOfSingletonBrowserClass().GetDriver();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            HomePage HomePageObject = new HomePage();

            //Click on the dresses
            wait.Until(expected.ExpectedConditions.ElementToBeClickable(HomePageObject.DreesesButton)).Click();

            //Verify dresses text is visible to user as a header
            string HeaderValue = wait.Until(expected.ExpectedConditions.ElementToBeClickable(HomePageObject.DreesesTextHeader)).Text;
            Assert.IsTrue(HeaderValue.Contains("DRESSES"), "User can not see dresses as header value in UI");

        }

    }
}
