using OpenQA.Selenium;

namespace Autotestung
{
    public class Tests
    {
        private IWebDriver driver;
        private readonly By _ClosBaner = By.XPath("//div[@class='banner_close close to___process']");
        private readonly By _ButtonAuth = By.XPath("//a[@class='btn-login-js']");

        private readonly By _singButton = By.XPath("//a[text()='Авторизация']");
        private readonly By _LoginInutButton = By.XPath("//input[@name='login']");
        private readonly By _PasswordInutButton = By.XPath("//input[@name='password']");
        private readonly By _ButtonEnter = By.XPath("//button[text()='Войти']");

        private const string _login = "123456789";
        private const string _password = "123456789";

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Edge.EdgeDriver();
            driver.Navigate().GoToUrl("https://www.marko.by/");
            //driver.Manage().Window.Maximize();
            
        }

        [Test]
        public void Test1()
        {
            driver.FindElement(_ButtonAuth).Click();
            var singin = driver.FindElement(_singButton);
            singin.Click();
            
            var login = driver.FindElement(_LoginInutButton);
            login.SendKeys(_login);
            var password = driver.FindElement(_PasswordInutButton);
            password.SendKeys(_password);
            var enter = driver.FindElement(_ButtonEnter);
            enter.Click();
        }
    }
}