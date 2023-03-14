using AutomationFramework.DriverCore;
using FluentAssertions;

namespace OCGTest.Asserter
{
    public class Asserter : WebDriverAction
    {
        public Asserter() : base()
        {
        }
        #region ELEMENT DISPLAY ASSERTION
        public void AssertElementIsDisplayed(string locator)
        {
            VerifyElementIsDisplayed(locator).Should().BeTrue();
        }
        #endregion

        #region CHECK EQUALS
        public void AssertViewUserEquals(string actual, string expected)
        {
            AssertEquals(actual, expected);
        }
        public void AssertDetailedUserEquals(string actual, string expected)
        {
            AssertEquals(actual, expected);
        }


        #endregion
    }
}
