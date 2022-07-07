
using NUnit.Framework;
using Framework;
using Framework.Pages.TreatwellPages;
using Tests.BaseClasses;

namespace Tests.Treatwell
{
    public class TreatwellMain : BaseTest
    {
        [SetUp]
        public static void open()
        {
            Driver.open("https://www.treatwell.lt/");
            TreatwellMainPage.clickAcceptCookies();
        }

        [Test]
        public static void searchForService()
        {
            string expectedSearchResult = "salonai siūlantys paslaugą: veidas šalia Justiniškes, Vilnius";
            string actualSearchResult;


            TreatwellMainPage.enterServiceName("Veidas");
            TreatwellMainPage.enterLocation("Justiniškės");
            TreatwellMainPage.chooseDateTomorrow();
            TreatwellMainPage.clickSearchButton();

            actualSearchResult = TreatwellMainPage.getServiceSearchResultMessage();
            Assert.IsTrue(actualSearchResult.Contains(expectedSearchResult));
        }

        [Test]
        public static void searchForSalon()
        {
            string expectedSearchResult = "Look Good by A. Lo";
            string actualSearchResult;

            TreatwellMainPage.clickSalonBar();
            TreatwellMainPage.enterSalonName("Look Good");
            TreatwellMainPage.clickSearchButtonSalonBar();

            actualSearchResult = TreatwellMainPage.getSalonSearchResultMessage();
            Assert.AreEqual(expectedSearchResult, actualSearchResult);
        }
    }
}
