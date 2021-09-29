using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Tests
{
    public class NewsLetterTest : BaseTest
    {
        [Test]
        public static void SubscribeToNewsLetter1()
        {
            _newsLetterPage.NavigateToDefaultPage();
            _newsLetterPage.ScrollToContainer();
            _newsLetterPage.SpaustiSutinku();
            _newsLetterPage.CheckMoteris();
            _newsLetterPage.InsertEmailToInputField("vardaspavarde@email.com");
            _newsLetterPage.SpaustiSutinku();
            _newsLetterPage.PrenumeratosPatvirtinimas();
            
        }

        [Test]
        public static void SubscribeToNewsLetter2()
        {
            _newsLetterPage.NavigateToDefaultPage();
            _newsLetterPage.ScrollToContainer();
            _newsLetterPage.SpaustiSutinku();
            _newsLetterPage.CheckVyras();
            _newsLetterPage.InsertEmailToInputField("vardaspavarde@email.com");
            _newsLetterPage.Prenumeruoti();
            _newsLetterPage.PrenumeratosPatvirtinimas();
        }

        [Test]
        public static void SubscribeToNewsLetterFail()
        {
            _newsLetterPage.NavigateToDefaultPage();
            _newsLetterPage.ScrollToContainer();
            _newsLetterPage.SpaustiSutinku();
            _newsLetterPage.CheckMoteris();
            _newsLetterPage.InsertEmailToInputField("lalala");
            _newsLetterPage.Prenumeruoti();
            _newsLetterPage.PrenumeratosPatvirtinimas();
        }


    }

  
}
