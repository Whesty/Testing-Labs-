using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using OpenQA.Selenium.Edge;

namespace Autotestung.Driver
{
    internal static class DrivarSingilton
    {
        private static IWebDriver _webDriver;

        public static IWebDriver GetWebDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
             _webDriver = new ChromeDriver();
            return _webDriver;
        }
        
        public static void TearDown()
        {
            _webDriver.Quit();
        }


        private const string _login = "123456789";
        private const string _password = "123456789";

       
    }
}
