using AutomationFramework.DriverCore;
using NUnit.Framework;

namespace OCGTest.PageObject
{
    public class HomePage : WebDriverAction
    {
        private string searchBoxField = "//input[contains(@aria-label, \"Tìm kiếm\")]";
        private string searchBtn = "(//input[contains(@aria-label, \"Tìm trên Google\")])[2]";
        private string googleLogo = "//img[contains(@alt, \"Google\")]";

        public HomePage() : base()
        {

        }

        public void VerifyUserIsInTheHomePage()
        {
            VerifyElementIsDisplayed(googleLogo);
        }

        public void InputTextToSearchBox(string text)
        {
            SendKeys(searchBoxField, text);
        }

        public void PressEnterToFind()
        {
            PressEnter(searchBtn);
        }
    }
}
