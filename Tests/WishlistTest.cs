using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Tests
{
    public class WishlistTest : BaseTest
    {
        [Test]

        public static void AddElementToWishlist()
        {
            _wishlistPage.NavigateToDefaultPage();
            _wishlistPage.ClickWishlistButton();
            _wishlistPage.AssertWishlistButton();
        }
    }
}
