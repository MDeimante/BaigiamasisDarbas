using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Page
{
    public class AddToCartPage : BasePage
    {
        private const string _pageAddress = "https://modivo.lt/p/michael-kors-auskarai-pave-mk-stud-mkc1496an710-auksine";
        private const string _pageAddress2 = "https://modivo.lt/checkout/cart";
        private IWebElement _addToCartButton => Driver.FindElement(By.ClassName("base-button primary big"));
        private IWebElement _continueShoppingButton => Driver.FindElement(By.ClassName("continue-shopping-button base-button tertiary normal"));
        private IWebElement _goToCartButton => Driver.FindElement(By.ClassName("go-to-cart-button base-button primary normal"));


        public AddToCartPage(IWebDriver webDriver) : base(webDriver) { }

        public AddToCartPage NavigateToDefaultPage()
        { 
            if (Driver.Url != _pageAddress)
            {
                Driver.Url = _pageAddress;
            }
            Driver.Url = _pageAddress;
            return this;
        }

        public void AddToCart()
        {
            _addToCartButton.Click();
        }

        public void ContinueShopping()
        {
            _continueShoppingButton.Click();

        }

        public void GoToCartButton()
        {
            _goToCartButton.Click();
        }

        public AddToCartPage NavigateToCart()
        {
            if (Driver.Url != _pageAddress2)
            {
                Driver.Url = _pageAddress2;
            }
            Driver.Url = _pageAddress2;

            return this;
        }




    }
    //jeigu spaudi continue shopping, grizta i page address
    //jeigu spaudi go to cart, nukelia i cart page
}

