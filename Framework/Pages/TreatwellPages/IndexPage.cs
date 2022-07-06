using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.TreatwellPages
{
    public class IndexPage
    {
        public static void clickAcceptCookies()
        {
            string locator = "//button[text() = 'Leisti visus slapukus']";
            Common.waitForElementToBeClickable(locator);
            Common.clickElement(locator);
        }
    }
}
