using System;
using System.Net.Http;
using System.Threading.Tasks;
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
        public async Task ExecuteSqlAndVerifyResultAsync()
        {
            const string ExpectedProductName = "Grandmas Boysenberry Spread";
            const string SqlSiteUrl = "https://www.tutorialrepublic.com/codelab.php?topic=sql&file=select-all";

            var Api_dev_key = "yhIfRatXXrq1LACyqOvuCjxR3nE1hV6G";
            var Api_user_key = "";
            var Api_results_limit = "100";
            var url = "https://pastebin.com/api/api_post.php";
            string content = "api_dev_key=yhIfRatXXrq1LACyqOvuCjxR3nE1hV6G&api_user_name=Aditya_Jain&api_user_password=Aditya@05101992";
            HttpClientHandler handler = new HttpClientHandler();
            HttpClient httpClient = new HttpClient(handler);
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            var response = await httpClient.SendAsync(request);

            IWebDriver Driver = SingletonBrowserClass.GetInstanceOfSingletonBrowserClass().GetDriver();
            Driver.Url = SqlSiteUrl;
            Driver.Manage().Window.Maximize();

            string query = "SELECT product_name FROM products where product_id IN (SELECT product_id FROM order_details where order_id IN(SELECT order_id FROM orders where cust_id IN " +
                "(SELECT cust_id FROM customers where cust_name = 'Hanna Moos') " +
                "ORDER BY cust_id ASC LIMIT 1)); ";

            Page.Home.EnterSqlQeuryAndExecute(query);
            Assert.AreEqual(ExpectedProductName, Page.Home.GetOutputTableFirstRowFirstColumnResults());
        }
    }
}
