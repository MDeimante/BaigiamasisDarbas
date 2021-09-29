using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NUnit.Core.NUnitFramework;

namespace BaigiamasisDarbas.Page
{
    public class WishlistPage : BasePage
    {
        private const string _pageAddress = "https://modivo.lt/p/guess-rankines-noelle-zg-mini-hwzg78-79780-vysnine";
        private IWebElement _wishlistButton => Driver.FindElement(By.ClassName("button-with-icon button-add-to-wishlist base-button pure normal"));

        private IWebElement _addToWishlistMessage => Driver.FindElement(By.CssSelector("#__layout > div > main > article > div:nth-child(2) > div > div > div.product-details > div > button > div.content > span"));
        private IWebElement _successMessage => Driver.FindElement(By.CssSelector("#__layout > div > main > article > div:nth-child(2) > div > div > div.product-details > div > button > div.content > span"));


        public WishlistPage(IWebDriver webDriver) : base(webDriver) { }

        public WishlistPage NavigateToDefaultPage()
        {
            if (Driver.Url != _pageAddress)
            {
                Driver.Url = _pageAddress;
            }

            Driver.Url = _pageAddress;
            return this;
        }

        public void ClickWishlistButton()
        {
            if (!_wishlistButton.Selected)
                _wishlistButton.Click();
        }

        public void AssertWishlistButton()
        {
            Assert.AreEqual(_successMessage, _addToWishlistMessage);
        }
    }
}
