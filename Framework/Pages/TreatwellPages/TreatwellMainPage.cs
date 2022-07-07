

namespace Framework.Pages.TreatwellPages
{
    public class TreatwellMainPage
    {
        public static void clickAcceptCookies()
        {
            string locator = "//button[text() = 'Leisti visus slapukus']";
            Common.waitForElementToBeClickable(locator);
            Common.clickElement(locator);
        }

        public static void enterServiceName(string input)
        {
            string locator = "//input[@class='InputField-module--input--ba477c']";
            Common.sendKeysToElement(locator, input);
        }

        public static void enterLocation(string input)
        {
            string locatorLocationField = "(//input[@class='InputField-module--input--ba477c'])[2]";
            string locatorLocationOption = "//*[text()='Justiniškes, Vilnius']";
            Common.sendKeysToElement(locatorLocationField, input);
            Common.waitForElementToBeClickable(locatorLocationOption);
            Common.clickElement(locatorLocationOption);            
        }

        public static string getServiceSearchResultMessage()
        {
            string locator = "//*[@class='ResultsSummary-module--resultsSummary--69bb6c']";
            return Common.getElementText(locator);
        }

        public static void enterSalonName(string input)
        {
            string locatorField = "(//input[@class='InputField-module--input--ba477c'])[4]";
            string locatorOption = "//*[text()='Look Good by A. Lo']";
            Common.sendKeysToElement(locatorField, input);
            Common.waitForElementToBeClickable(locatorOption);
            Common.clickElement(locatorOption);
        }

        public static string getSalonSearchResultMessage()
        {
            string locator = "//*[@class='Text-module_smHero__2uXfi style-module--name--9886df']";
            return Common.getElementText(locator);
        }

        public static void clickSalonBar()
        {
            string locator = "//*[text()='Salonas']";
            Common.clickElement(locator);
        }

        public static void clickSearchButton()
        {
            string locator = "(//*[@class = 'Button-module--label--47a4ba'])[1]";
            Common.clickElement(locator);
        }
        public static void clickSearchButtonSalonBar()
        {
            string locator = "(//*[@class = 'Button-module--label--47a4ba'])[2]";
            Common.clickElement(locator);
        }

        public static void chooseDateTomorrow()
        {
            string locatorDateField = "(//input[@class='InputField-module--input--ba477c'])[3]";
            string locatorTomorrowButton = "//*[text()='Rytoj']";
            string locatorSearchButton = "(//*[text()='Ieškoti'])[3]";
            Common.clickElement(locatorDateField);
            Common.clickElement(locatorTomorrowButton);            
            Common.clickElement(locatorSearchButton);
        }

        
    }
}
