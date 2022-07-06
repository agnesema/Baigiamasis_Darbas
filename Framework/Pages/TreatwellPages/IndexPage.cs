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

        public static string getSearchResultMessage()
        {
            string locator = "//*[@class='ResultsSummary-module--resultsSummary--69bb6c']";
            return Common.getElementText(locator);
        }

        public static void clickSearchButton()
        {
            string locator = "//*[text()='Ieškoti']";
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
