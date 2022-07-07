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

        internal static void selectOptionByValue(string locator, string value)
        {
            IWebElement element = getElement(locator);
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByText(value);
        }

        internal static void clickElement(string locator)
        {
            getElement(locator).Click();
        }

        internal static void sendKeysToElement(string locator, string keys)
        {
            getElement(locator).SendKeys(keys);
        }              

        internal static string getElementText(string locator)
        {
            return getElement(locator).Text;
        }

        internal static void waitForElementToBeVisible(string locator)
        {
            WebDriverWait w = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10));
            w.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }
        internal static void waitForElementToBeClickable(string locator)
        {
            WebDriverWait w = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10));
            w.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        }        
    }
}
