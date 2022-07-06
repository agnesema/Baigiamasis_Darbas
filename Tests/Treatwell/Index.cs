
using NUnit.Framework;
using Framework;

using Framework.Pages.TreatwellPages;

namespace Tests.Treatwell
{
    public class Index
    {
        [SetUp]
        public static void setUp()
        {
            Driver.setDriver();
            Driver.open("https://www.treatwell.lt/");
        }

        [Test]
        public static void searchForService()
        {
            string expectedSearchResult = "salonai siūlantys paslaugą: veidas šalia Justiniškes, Vilnius";
            string actualSearchResult;

            IndexPage.clickAcceptCookies();
            IndexPage.enterServiceName("Veidas");
            IndexPage.enterLocation("Justiniškės");
            IndexPage.chooseDateTomorrow();
            IndexPage.clickSearchButton();

            actualSearchResult = IndexPage.getServiceSearchResultMessage();
            Assert.IsTrue(actualSearchResult.Contains(expectedSearchResult));
        }

        [Test]
        public static void searchForSalon()
        {
            string expectedSearchResult = "Look Good by A. Lo";
            string actualSearchResult;

            IndexPage.clickAcceptCookies();
            IndexPage.clickSalonBar();
            IndexPage.enterSalonName("Look Good");
            IndexPage.clickSearchButtonSalonBar();

            actualSearchResult = IndexPage.getSalonSearchResultMessage();
            Assert.AreEqual(expectedSearchResult, actualSearchResult);
        }
    }
}
