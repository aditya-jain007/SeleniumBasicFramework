using SeleniumBasicFramework.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using expected = SeleniumExtras.WaitHelpers;
using SeleniumBasicFramework.Driver;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace SeleniumBasicFramework.Pages
{
    public class HomePage : BasePage
    {
        public static IWebDriver Driver = SingletonBrowserClass.GetInstanceOfSingletonBrowserClass().GetDriver();
        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));

        [FindsBy(How = How.XPath, Using = "//div[@class='CodeMirror-sizer']")]
        public IWebElement SqlQueryTextBox;

        [FindsBy(How = How.XPath, Using = "//a[@class='btn execute-btn']")]
        public IWebElement ExecuteSqlButton;

        [FindsBy(How = How.XPath, Using = "//table[@class='table table-bordered']//tbody/tr[1]/td[1]")]
        public IWebElement OutputTableFirstRow;

        public HomePage EnterSqlQeuryAndExecute(string query)
        {
            SqlQueryTextBox.SendKeys(query);
            ExecuteSqlButton.Click();
            return new HomePage();
        }

        public string GetOutputTableFirstRowFirstColumnResults()
        {
            return OutputTableFirstRow.Text;
        }
    }
}
