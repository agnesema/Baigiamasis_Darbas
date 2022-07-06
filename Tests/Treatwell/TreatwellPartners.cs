using Framework;
using Framework.Pages.TreatwellPages;
using NUnit.Framework;

namespace Tests.Treatwell
{
    internal class TreatwellPartners
    {
        [SetUp]
        public static void open()
        {
            Driver.setDriver();
            Driver.open("https://www.treatwell.lt/partneriai/");
        }

        [Test]
        public static void fillBecomePartnerForm()
        {
            string expectedMessage = "Vienas ar daugiau laukų su klaidomis. Patikrinkite ir pataisę pabandykite iš naujo.";
            string actualMessage;

            IndexPage.clickAcceptCookies();
            TreatwellPartnersPage.clickBecomePartnerButton();
            TreatwellPartnersPage.enterEmail("email");
            TreatwellPartnersPage.selectPartnerByText("Salonas, įsikūręs namuose");
            TreatwellPartnersPage.clickSubmitButton();

            actualMessage = TreatwellPartnersPage.getResponseText();
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
