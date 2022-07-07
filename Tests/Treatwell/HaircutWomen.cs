using Framework;
using Framework.Pages.TreatwellPages;
using NUnit.Framework;
using Tests.BaseClasses;

namespace Tests.Treatwell
{
    public class HaircutWomen : BaseTest
    {
        [SetUp]
        public static void open()
        {
            Driver.open("https://www.treatwell.lt/salonai/procedura-kirpimas-ir-plauku-prieziura/pasiulymo-tipas-vietinis/kur-lietuva/");
            HaircutWomenPage.clickAcceptCookies();
        }

        [Test]
        public static void findFilteredSalonListAndBookHaircut ()
        {
            string expectedMessage = "1 paslauga ";
            string actualMessage;
                       
            HaircutWomenPage.clickFilter();
            HaircutWomenPage.sortByLowestPrice();
            HaircutWomenPage.sortByAmenities();
            HaircutWomenPage.clickShowResultsButton();
            HaircutWomenPage.selectSecondSalonWomanHaircutoption();
            HaircutWomenPage.clickBookButton();

            actualMessage = HaircutWomenPage.getResultMessage();
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public static void bookServiceAndCheckPrice()
        {
            string expectedPrice;
            string actualPrice;

            HaircutWomenPage.clickOnFirstSalon();
            expectedPrice = HaircutWomenPage.readPrice();
            HaircutWomenPage.selectHaircutService();            
            actualPrice = HaircutWomenPage.readActualPrice();

            Assert.AreEqual(expectedPrice, actualPrice);
        }     
    }
}
