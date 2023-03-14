using NUnit.Framework;
using OCGTest.PageObject;
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
            HomePage.IsGoogleHomePageDisplay();
            HomePage.InputTextToSearchBox("OpenCommerce Group");
            HomePage.PressEnterToFind();
            SearchResultPage.IsResulStatDisplay();
        }
    }
}
