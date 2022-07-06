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
            IndexPage.clickAcceptCookies();
            HaircutWomenPage.clickFilter();
            HaircutWomenPage.sortByLowestPrice();
            HaircutWomenPage.sortByAmenities();
            HaircutWomenPage.sortByTopRatedSalons();
            HaircutWomenPage.clickShowResultsButton();
        }


        
    }
}
