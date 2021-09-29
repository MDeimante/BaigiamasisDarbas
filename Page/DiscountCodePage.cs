using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NUnit.Core.NUnitFramework;

namespace BaigiamasisDarbas.Page
{
    public class DiscountCodePage : BasePage
    {
        private const string _pageAddress = "https://modivo.lt/checkout/cart";
        //private const string _discountCode = "MODIVOPROGA";
        private IWebElement _discountCodeCheckbox => Driver.FindElement(By.Id("add-code"));
        private IWebElement _addDiscountCodeMessage => Driver.FindElement(By.CssSelector("#__layout > div > main > div > div.checkout-cart > div > div > div.column.summary > div > div > div.summary-block > div:nth-child(2) > div > div.add-discount-code > form > fieldset > div > div > label"));
        
        private IWebElement _discountCodeInputField => Driver.FindElement(By.Id("code"));
        private IWebElement _checkOutButton => Driver.FindElement(By.ClassName("proceed - to - checkout base - button primary normal"));
        private IWebElement _applyCodeButton => Driver.FindElement(By.ClassName("submit base-button secondary small"));

        public DiscountCodePage(IWebDriver webDriver) : base(webDriver) { }

        public DiscountCodePage NavigateToDefaultPage()
        {
            if (Driver.Url != _pageAddress)
            {
                Driver.Url = _pageAddress;
            }
            Driver.Url = _pageAddress;
            return this;
        }

        public void AddDiscountCodeCheckbox()
        {
                if (!_discountCodeCheckbox.Selected)
                {
                    _discountCodeCheckbox.Click();
                }
        }

        public void AssertDiscountCodeCheckbox()
        {
            Assert.AreEqual(_addDiscountCodeMessage, _checkOutButton);
        }

        public void ApplyDiscountCode(string text)
        {
            _discountCodeInputField.Click();
            _discountCodeInputField.Clear();
            _discountCodeInputField.SendKeys(text);
            _applyCodeButton.Click();
        }

        public void GoToCheckOut()
        {
            _checkOutButton.Click();
        }
    }
}
