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

        public static void sortByTopRatedSalons()
        {
            string locator = "//*[text()='Top Rated salonai']";
            Common.clickElement(locator);
        }

        public static void clickShowResultsButton()
        {
            string locator = "//*[text()='Rodyti rezultatus']";
            Common.clickElement(locator);
        }
    }
}
