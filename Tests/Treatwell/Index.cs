
using NUnit.Framework;
using Framework;
using Framework.Pages.TreatwellPages;
using Tests.BaseClasses;

namespace Tests.Treatwell
{
    public class Index : BaseTest
    {
        [SetUp]
        public static void open()
        {
            Driver.open("https://www.treatwell.lt/");
            IndexPage.clickAcceptCookies();
        }

        [Test]
        public static void searchForService()
        {
            string expectedSearchResult = "salonai siūlantys paslaugą: veidas šalia Justiniškes, Vilnius";
            string actualSearchResult;

            
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
                        
            IndexPage.clickSalonBar();
            IndexPage.enterSalonName("Look Good");
            IndexPage.clickSearchButtonSalonBar();

            actualSearchResult = IndexPage.getSalonSearchResultMessage();
            Assert.AreEqual(expectedSearchResult, actualSearchResult);
        }
    }
}
