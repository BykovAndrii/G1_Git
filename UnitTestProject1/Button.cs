using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UnitTestProject1
{
    public class Button
    {
        private IWebElement _webElement;

        public Button(IWebElement webElement)
        {
            _webElement = webElement;
        }

        //[FindsBy]
        public void Click()
        {
            _webElement.Click();
        }
    }
}
