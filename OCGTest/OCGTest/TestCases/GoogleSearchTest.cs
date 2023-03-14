using NUnit.Framework;
using OCGTest.PageObject;
using OCGTest.TestData;
using OCGTest.WebTestSetup;

namespace OCGTest.TestCases
{

    public class GoogleSearchTest : NUnitWebTestSetUp
    {
        public GoogleSearchTest(string browser, int width, int height) : base(browser, width, height)
        {

        }

        [Test]
        public void SearchByTextAndPressEnter()
        {
            Asserter.AssertElementIsDisplayed(HomePageData.GoogleLogo);
            HomePage.InputTextToSearchBox("OpenCommerce Group");
            HomePage.PressEnterToFind();
            Asserter.AssertElementIsDisplayed(SearchResultPageData.ResultStat);
        }
    }
}
