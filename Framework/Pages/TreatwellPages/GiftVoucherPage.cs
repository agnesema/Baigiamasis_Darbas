using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.TreatwellPages
{
    public class GiftVoucherPage
    {
        public static void selectPriceByValue(string value)
        {
            string locator = $"//*[@id='gift-card-amount-menu']//*[text()='40,00 €']";
            string locator2 = "//*[@id='gift-card-amount-button']";
            Common.clickElement(locator2);
            Common.clickElement(locator);
            //Common.waitForElementToBeClickable(locator);
            //Common.selectOptionByValue(locator, value);
        }
    }
}
