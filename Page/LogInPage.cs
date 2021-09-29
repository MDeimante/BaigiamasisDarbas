using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NUnit.Core.NUnitFramework;

namespace BaigiamasisDarbas.Page
{
    public class LogInPage : BasePage

    {
        private const string _pageAddress = "https://modivo.lt/login";
        private IWebElement _emailInputField => Driver.FindElement(By.Id("email"));
        private IWebElement _paswordInputField => Driver.FindElement(By.Id("password"));
        private IWebElement _prisijungtiButton => Driver.FindElement(By.ClassName("submit base-button primary normal"));
        private IWebElement _expectedResult => Driver.FindElement(By.ClassName("content"));
        private IWebElement _errorMessage => Driver.FindElement(By.ClassName("error-msg"));

        public LogInPage(IWebDriver webDriver) : base(webDriver) { }

        public LogInPage NavigateToDefaultPage()
        {
            if (Driver.Url != _pageAddress)
            {
                Driver.Url = _pageAddress;
            }
                Driver.Url = _pageAddress;
                return this;
        }

        public void InputEmail(string text)
        {
            _emailInputField.Clear();
            _emailInputField.SendKeys(text);


        }

        public void InputPasword(string text)
        {
            _paswordInputField.Clear();
            _paswordInputField.SendKeys(text);
        }

        public void Prisijungti()
        {
            _prisijungtiButton.Click();
        }

        public void PrisijungimoPatvirtinimas()
        {

            Assert.AreEqual(_expectedResult, _errorMessage);  
        }
    }
}
