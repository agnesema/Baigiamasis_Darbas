
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
        public static void something()
        {
            IndexPage.clickAcceptCookies();
        }
    }
}
