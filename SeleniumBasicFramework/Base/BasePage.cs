using SeleniumBasicFramework.Driver;
using SeleniumExtras.PageObjects;

namespace SeleniumBasicFramework.Base
{
    public class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(SingletonBrowserClass.GetInstanceOfSingletonBrowserClass().GetDriver(), this);
        }
    }
}
