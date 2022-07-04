using SeleniumBasicFramework.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace SeleniumBasicFramework.Pages
{
    public class SignInPage : BasePage
    {

        #region Elements
        [FindsBy(How = How.XPath, Using = "//input[@id='email']")]
        IWebElement EmailAddressTB;

        [FindsBy(How = How.XPath, Using = "//input[@id='passwd']")]
        IWebElement PasswordTB;

        [FindsBy(How = How.XPath, Using = "//button[@id='SubmitLogin']")]
        IWebElement LoginBtn;

        [FindsBy(How = How.XPath, Using = "//div[@class='alert alert-danger']//li")]
        IWebElement AuthnticationErrorText;

        #endregion

        #region Page Methods

        public void EnterEmailAndPassword(string username, string password)
        {
            
        }

        public void ClickloginBtn()
        {
            LoginBtn.Click();
            Thread.Sleep(5000);
        }

        public string GetErrorMessage()
        {
            return AuthnticationErrorText.Text;
        }

        #endregion

    }
}
