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
    }
}
