using Framework;
using Framework.Pages.TreatwellPages;
using NUnit.Framework;
using Tests.BaseClasses;

namespace Tests.Treatwell
{
    internal class TreatwellPartners : BaseTest
    {
        [SetUp]
        public static void open()
        {
            Driver.open("https://www.treatwell.lt/partneriai/");
            TreatwellPartnersPage.clickAcceptCookies();
        }

        [Test]
        public static void fillBecomePartnerForm()
        {
            string expectedMessage = "Vienas ar daugiau laukų su klaidomis. Patikrinkite ir pataisę pabandykite iš naujo.";
            string actualMessage;

            
            TreatwellPartnersPage.clickBecomePartnerButton();
            TreatwellPartnersPage.enterEmail("email");
            TreatwellPartnersPage.selectPartnerByText("Salonas, įsikūręs namuose");
            TreatwellPartnersPage.clickSubmitButton();

            actualMessage = TreatwellPartnersPage.getResponseText();
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
