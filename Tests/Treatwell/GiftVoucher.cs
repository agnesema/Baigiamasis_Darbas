using Framework;
using Framework.Pages.TreatwellPages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Treatwell
{
    public class GiftVoucher
    {
        [SetUp]
        public static void open()
        {
            Driver.setDriver();
            Driver.open("https://www.treatwell.lt/dovanu-kuponas/");
        }

        [Test]
        public static void giftVoucher()
        {
            string expectedMessage = "1 paslauga ";
            string actualMessage;

            IndexPage.clickAcceptCookies();
            GiftVoucherPage.selectPriceByValue("35,00 €");

        }
    }
}
