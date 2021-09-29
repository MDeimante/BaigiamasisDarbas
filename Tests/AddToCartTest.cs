using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Tests
{
    class AddToCartTest : BaseTest
    {
        [Test]
           
        public static void AddToCartAndContinueShopping()
        {
            _addToCartPage.NavigateToDefaultPage();
            _addToCartPage.AddToCart();
            _addToCartPage.ContinueShopping();
            _addToCartPage.NavigateToDefaultPage();
        }

        [Test]
        public static void AddToCartAndGoToCart()
        {
            _addToCartPage.NavigateToDefaultPage();
            _addToCartPage.AddToCart();
            _addToCartPage.ContinueShopping();
            _addToCartPage.NavigateToCart();
        }

    }
}
