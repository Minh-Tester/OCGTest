using AutomationFramework.DriverCore;
using NUnit.Framework;

namespace OCGTest.PageObject
{
    public class HomePage : WebDriverAction
    {
        private string searchBoxField = "//input[contains(@aria-label, \"Tìm kiếm\")]";
        private string googleLogo = "//img[contains(@alt, \"Google\")]";
        private string searchBtn = "(//input[contains(@aria-label, \"Tìm trên Google\")])[2]";

        public HomePage() : base()
        {

        }

        public Boolean IsGoogleHomePageDisplay()
        {
            try 
            {
                WaitToBeVisible(googleLogo);
                TestContext.WriteLine("Go to Google Home page successfully!");
                return true;
            }
            catch
            {
                TestContext.WriteLine("Go to Google Home page unsuccessfully!");
                return false;
            }
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
