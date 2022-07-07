

namespace Framework.Pages.TreatwellPages
{
    public class TreatwellPartnersPage
    {
        public static void selectPartnerByText(string input)
        {
            string locator = "//*[@id='md-salon-type']";
            Common.selectOptionByValue(locator, input);
        }

        public static void clickBecomePartnerButton()
        {
            string locator = "//*[@id='menu-item-3255']";
            Common.clickElement(locator);
        }

        public static void enterEmail(string input)
        {
            string locator = "//*[@id='md-email']";
            Common.sendKeysToElement(locator, input);
        }

        public static string getResponseText()
        {
            string locator = "//*[@class='wpcf7-response-output']";
            Common.waitForElementToBeVisible(locator);
            return Common.getElementText(locator);
        }

        public static void clickSubmitButton()
        {
            string locator = "//*[@value='Susisiek dabar']";            
            Common.clickElement(locator);
        }

        public static void clickAcceptCookies()
        {
            string locator = "//button[text() = 'Leisti visus slapukus']";
            Common.waitForElementToBeClickable(locator);
            Common.clickElement(locator);
        }
    }
}
