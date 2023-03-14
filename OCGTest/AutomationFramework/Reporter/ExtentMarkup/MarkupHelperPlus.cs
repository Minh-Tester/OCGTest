using AutomationFramework.APICore;
using AventStack.ExtentReports.MarkupUtils;

namespace AutomationFramework.Reporter.ExtentMarkup
{
    public class MarkupHelperPlus
    {
        public static IMarkup CreateAPIRequestLog(APIRequest request, APIResponse response)
        {
            return new APIRequestLog(request, response);
        }
    }
}
