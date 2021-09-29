using BaigiamasisDarbas.Drivers;
using BaigiamasisDarbas.Page;
using NUnit.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Tests
{
    public class BaseTest
    {
        protected static IWebDriver Driver;
        public static NewsLetterPage _newsLetterPage;
        public static LogInPage _logInPage;
        public static AddToCartPage _addToCartPage;
        public static DiscountCodePage _discountCodePage;
        public static WishlistPage _wishlistPage;

        [OneTimeSetUp]
        public static void SetUp()
        {
            Driver = CustomDriver.GetChromeDriver();
            _newsLetterPage = new NewsLetterPage(Driver);
            _logInPage = new LogInPage(Driver);
            _addToCartPage = new AddToCartPage(Driver);
            _discountCodePage = new DiscountCodePage(Driver);
            _wishlistPage = new WishlistPage(Driver);
        }


        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreenshot();
            }

        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Driver.Close();
        }
    }

    
}
