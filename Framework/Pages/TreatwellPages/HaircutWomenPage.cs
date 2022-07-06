using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.TreatwellPages
{
    public class HaircutWomenPage
    {
        public static void clickFilter()
        {
            string locator = "//*[@class = 'Button-module_button__3VGaT Button-module_secondary__fQhgj Button-module_sm__lk94L']";
            Common.clickElement(locator);
        }

        public static void sortByLowestPrice()
        {
            string locator = "//*[text()='Žemiausia kaina']";
            Common.clickElement(locator);
        }

        public static void sortByAmenities()
        {
            string locatorAll = "//*[text()='Žiūrėti visus Patogumus']"; 
            string locatorFirst = "//*[text()='Draugiška gyvūnams']";
            string locatorSecond = "//*[text()='Mieste']";
            string locatorThird = "//*[text()='Popiečio arbata']";
            Common.clickElement(locatorAll);
            Common.clickElement(locatorFirst);
            Common.clickElement(locatorSecond);
            Common.clickElement(locatorThird);
        }

        public static string getResultMessage()
        {
            string locator = "//*[@class='Summary-module--services--c3d157']";
            return Common.getElementText(locator);
        }

        public static void clickBookButton()
        {
            string locator = "(//*[text()='Rezervuoti'])[10]";
            //Common.waitForElementToBeClickable(locator);
            Common.clickElement(locator);
        }

        public static void selectSecondOptionWomanHaircut()
        {
            string locator = "//div[@id='container']//*[text()='Moteriškas  kirpimas']";
            Common.waitForElementToBeClickable(locator);
            Common.clickElement(locator);
        }

        public static void clickShowResultsButton()
        {
            string locator = "//*[text()='Rodyti rezultatus']";
            Common.clickElement(locator);
        }
    }
}
