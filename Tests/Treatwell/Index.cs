
using NUnit.Framework;
using Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            actualSearchResult = IndexPage.getSearchResultMessage();
            Assert.IsTrue(actualSearchResult.Contains(expectedSearchResult));
        }
    }
}
