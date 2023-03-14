using AutomationFramework.DriverCore;
using NUnit.Framework;

namespace OCGTest.PageObject
{
    public class SearchResultPage : WebDriverAction
    {
        private string resultStat = "//div[contains(@id, \"result-stats\")]";

        public SearchResultPage() : base()
        { }

        public void VerifyUserIsDirectedToTheSearchResultPage()
        {
            VerifyElementIsDisplayed(resultStat);
        }
    }
}
