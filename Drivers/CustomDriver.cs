using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Drivers
{
    public class CustomDriver //SITA KLASE LEIDZIA DARYTI TESUTS ANT SKIRTINGU BROWSERIU
    {
        //metodas, kuriame kvieciame chrome:
        public static IWebDriver GetChromeDriver()
        {
            //return GetChromeDriver() + susikurti atskira enum klase kurioje nurodytos driverio reiksmes.
            //susikuriam nauja klase pavadinimu Browsers

            return GetDriver(Browsers.Chrome); //jei getdriver  braukia raudonai, tai nes neturim get driver mnetodo
        }

        public static IWebDriver FireFoxDriver()
        {
            return GetDriver(Browsers.FireFox);
        }

        private static IWebDriver GetDriver(Browsers BrowserName) //browser name pakels browseri kurio paprasysim testuose
        {
            IWebDriver webDriver = null;//pradines reiksmes nera, aprasysim dabar, kurio mums reikia/ naudosim if arba switch:

            switch (BrowserName)
            {
                case Browsers.Chrome:
                    webDriver = new ChromeDriver();
                    break;
                case Browsers.FireFox:
                    webDriver = new FirefoxDriver();
                    break;
                default:
                    webDriver = new ChromeDriver();
                    break;
            }

            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            return webDriver;
        }
    }
}
