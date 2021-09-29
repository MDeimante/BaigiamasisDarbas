using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Tests
{
    public class DiscountCodeTest : BaseTest
    {
        [Test]
        public static void ApplyCorrectDiscountCode()
        {
            _discountCodePage.NavigateToDefaultPage();
            _discountCodePage.AddDiscountCodeCheckbox();
            _discountCodePage.AssertDiscountCodeCheckbox();
            _discountCodePage.ApplyDiscountCode("MODIVOPROGA");
            _discountCodePage.GoToCheckOut();
        }

        [Test]
        public static void ApplyIncorrectDiscountCode()
        {
            _discountCodePage.NavigateToDefaultPage();
            _discountCodePage.AddDiscountCodeCheckbox();
            _discountCodePage.AssertDiscountCodeCheckbox();
            _discountCodePage.ApplyDiscountCode("neteisingaskodas");
            _discountCodePage.GoToCheckOut();
        }
    }
}
