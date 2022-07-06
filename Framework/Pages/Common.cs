using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;


namespace Framework.Pages
{
    internal class Common
    {
        internal static IWebElement getElement(string locator)
        {
            return Driver.getDriver().FindElement(By.XPath(locator));
        }

        internal static void clickElement(string locator)
        {
            getElement(locator).Click();
        }

        internal static void sendKeysToElement(string locator, string keys)
        {
            getElement(locator).SendKeys(keys);
        }

        internal static void waitForElementToBeClickable(string locator)
        {
            WebDriverWait w = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10));
            w.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        }

        internal static void clickEnter()
        {
            Actions action = new Actions(Driver.getDriver());
            action.SendKeys(Keys.Enter).Perform();
        }

        internal static string getElementText(string locator)
        {
            return getElement(locator).Text;
        }
    }
}
