using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotestung
{
    internal class Class1
    {
        private IWebDriver driver;
        public Class1(IWebDriver _driver){
            driver = _driver;
        }
        private readonly By _ClosBaner = By.XPath("//div[@class='banner_close close to___process']");
        private readonly By _ButtonAuth = By.XPath("//a[@class='btn-login-js']");

        private readonly By _singButton = By.XPath("//a[text()='Авторизация']");
        private readonly By _LoginInutButton = By.XPath("//input[@name='login']");
        private readonly By _PasswordInutButton = By.XPath("//input[@name='password']");
        private readonly By _ButtonEnter = By.XPath("//button[text()='Войти']");

        private const string _login = "123456789";
        private const string _password = "123456789";

        public void ClickByAuth()
        {
            {
                driver.FindElement(_ButtonAuth).Click();
                var singin = driver.FindElement(_singButton);
                singin.Click();
            }
        }
        public void inputLogin(string _login)
        {
            var login = driver.FindElement(_LoginInutButton);
            login.SendKeys(_login);
        }
        public void inputPasword(string _pasword)
        {
            var password = driver.FindElement(_PasswordInutButton);
            password.SendKeys(_password);

        }

        

    }
}
