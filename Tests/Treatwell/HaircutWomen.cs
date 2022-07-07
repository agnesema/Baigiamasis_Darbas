using Framework;
using Framework.Pages.TreatwellPages;
using NUnit.Framework;

namespace Tests.Treatwell
{
    public class HaircutWomen
    {
        [SetUp]
        public static void open()
        {
            Driver.setDriver();
            Driver.open("https://www.treatwell.lt/salonai/procedura-kirpimas-ir-plauku-prieziura/pasiulymo-tipas-vietinis/kur-lietuva/");
        }

        [Test]
        public static void findSalon()
        {
            string expectedMessage = "1 paslauga ";
            string actualMessage;

            IndexPage.clickAcceptCookies();
            HaircutWomenPage.clickFilter();
            HaircutWomenPage.sortByLowestPrice();
            HaircutWomenPage.sortByAmenities();
            HaircutWomenPage.clickShowResultsButton();
            HaircutWomenPage.selectSecondOptionWomanHaircut();
            HaircutWomenPage.clickBookButton();

            actualMessage = HaircutWomenPage.getResultMessage();
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public static void reserveService()
        {
            string expectedPrice;
            string actualPrice;

            IndexPage.clickAcceptCookies();
            HaircutWomenPage.clickOnFirstSalon();
            expectedPrice = HaircutWomenPage.readPrice();
            HaircutWomenPage.selectHaircutService();
            HaircutWomenPage.clickChooseTimeButton();
            HaircutWomenPage.selectDate();
            HaircutWomenPage.clickSubmit();
            actualPrice = HaircutWomenPage.readActualPrice();
            
            Assert.AreEqual(expectedPrice, actualPrice);
        }


        
    }
}
