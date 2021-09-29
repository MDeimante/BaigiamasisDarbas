using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NUnit.Core.NUnitFramework;

namespace BaigiamasisDarbas.Page
{
    public class NewsLetterPage : BasePage
    {
        private const string _pageAddress = "https://modivo.lt/";
        private IWebElement _sutinkuButton => Driver.FindElement(By.ClassName("base-button secondary normal"));
        private IWebElement _moterisButton => Driver.FindElement(By.Id("women"));
        private IWebElement _vyrasButton => Driver.FindElement(By.Id("men"));

        private IWebElement _emailInputField => Driver.FindElement(By.Id("newsletter"));
        private IWebElement _webContainer => Driver.FindElement(By.ClassName("container-content container"));

        private IWebElement _prenumeruotiButton => Driver.FindElement(By.ClassName("submit-button base-button primary normal"));
        private IWebElement _expectedResultPrenumerataPatvirtinta => Driver.FindElement(By.ClassName("modal"));
        private IWebElement _klaidosPranesimas => Driver.FindElement(By.ClassName("error - msg"));

  

        public NewsLetterPage(IWebDriver webDriver) : base(webDriver) { }

        public NewsLetterPage NavigateToDefaultPage()
        {
            if (Driver.Url != _pageAddress)
            {
                Driver.Url = _pageAddress;
            }

            Driver.Url = _pageAddress;
            return this;
        }

        public void SpaustiSutinku()
        {
            if (_sutinkuButton.Displayed)
            _sutinkuButton.Click();
        }

        public void ScrollToContainer()
        {
            Actions actions = new Actions(Driver);
            actions.MoveToElement(_webContainer);
            actions.Perform();
        }

        public void CheckMoteris()
        {
            if (!_moterisButton.Selected)
            {
                _moterisButton.Click();
            }
        }

        public void CheckVyras()
        {
            if (!_vyrasButton.Selected)
            {
                _vyrasButton.Click();
            }
        }

        public void InsertEmailToInputField(string text)
        {
            _emailInputField.Clear();
            _emailInputField.SendKeys(text);
        }

        public void Prenumeruoti()
        {
            _prenumeruotiButton.Click();
        }

        public void PrenumeratosPatvirtinimas()
        {
            Assert.AreEqual(_expectedResultPrenumerataPatvirtinta, _klaidosPranesimas);
        }  
    }
}
