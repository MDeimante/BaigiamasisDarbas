using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Tests
{
    public class LogInTest : BaseTest
    {
        [TestCase("deimante.mikenaite@yahoo.com", "4ModivoTestBuyer", TestName = "Sekmingai prisijungete!")]
        [TestCase("neteisingasemailas", "4ModivoTestBuyer", TestName = "Neteisingas el. pašto adresas arba slaptažodis")]
        [TestCase("deimante.mikenaite@yahoo.com", "neteisingasslaptazodis", TestName = "Neteisingas el. pašto adresas arba slaptažodis")]
        [TestCase("neteisingasemailas", "neteisingas slaptazodis", TestName = "Neteisingas el. pašto adresas arba slaptažodis")]

        public static void PrisijungimoRezultatas(string firstValue, string secondValue)
        {
            _logInPage.NavigateToDefaultPage();
            _logInPage.InputEmail(firstValue);
            _logInPage.InputPasword(secondValue);
            _logInPage.Prisijungti();
            _logInPage.PrisijungimoPatvirtinimas();
        }
    }
}
/* ARBA???? public static void LogInTest1()
     {
         _logInPage.NavigateToDefaultPage();
         _logInPage.InputEmail("deimante.mikenaite@yahoo.com");
         _logInPage.InputPasword("4ModivoTestBuyer");
         _logInPage.Prisijungti();
         _logInPage.PrisijungimoPatvirtinimas();
     }

     public static void LogInTest2()
     {
         _logInPage.NavigateToDefaultPage();
         _logInPage.InputEmail();
         _logInPage.InputPasword("4ModivoTestBuyer");
         _logInPage.Prisijungti();
         _logInPage.PrisijungimoPatvirtinimas();
            
        ir tt??
     }
    */