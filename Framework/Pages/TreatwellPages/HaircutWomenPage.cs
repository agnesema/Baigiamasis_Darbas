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

        public static string readPrice()
        {
            string locator = "(//*[@class='Text-module_bodyHeavy__1LMI1'])[9]";
            return Common.getElementText(locator);
        }

        public static string readActualPrice()
        {
            string locator = "//*[@class='Summary-module--price--6b426e']";
            Common.waitForElementToBeVisible(locator);
            return Common.getElementText(locator);
        }

            public static void clickChooseTimeButton()
        {
            string locator = "//*[@class='Button-module--buttonContents--e56373']";
            Common.clickElement(locator);
        }

        public static void clickSubmit()
        {
            string locator = "//*[text()='Į užsakymo puslapį']";
            Common.clickElement(locator);
        }

        public static void selectDate()
        {
            string locator = "//*[@data-date='2022-07-20']";
            Common.clickElement(locator);
        }

        public static void selectHaircutService()
        {
            string locator = "//*[@id='container']/div/div[2]/div/div[2]/div[2]/div[1]/div/div/div[3]/div/div[3]/div/button/div/span";
            //Common.waitForElementToBeClickable(locator);
            Common.clickElement(locator);
        }

        public static void clickBookButton()
        {
            string locator = "(//*[text()='Rezervuoti'])[10]";
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

        public static void clickOnFirstSalon()
        {
            string locator = "//*[text()='Marina @ Yoly']";
            Common.clickElement(locator);
        }

        public static void clickOkOnAlertBox()
        {
            Common.alertAccept();
        }
    }
}
