using Autotestung.Driver;
using Autotestung.Services;
using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System.Runtime.CompilerServices;

namespace Autotestung
{
    public class Tests
    {
        private IWebDriver driver;
        private Logger logger;

        [SetUp]
        public void Setup()
        {
            
            driver =  DrivarSingilton.GetWebDriver();
            driver.Navigate().GoToUrl("https://www.marko.by/");
            

        }
        public const string Errors_AnyCreditUser = "Неверный телефон или пароль";
        public const string Errors_EmptyLogin = "Введите, пожалуйста, Ваш номер телефона!";
        public const string Errors_EmptyPassword = "Введите, пожалуйста, Ваш пароль!";
        //[Test]
        //public void LoginWithAnyUser()
        //{
        //    Page.LoginPage loginPage = new Page.LoginPage(driver);
        //    Assert.AreEqual(Errors_EmptyLogin, loginPage.Login(UserCreator.WithCredentialsFromProperty()));
        //}


        [Test]
        public void LoginWithEmptyCredentials()
        {
            Page.LoginPage loginPage = new Page.LoginPage(driver);
            Assert.AreEqual(Errors_EmptyLogin, loginPage.Login(UserCreator.WithEmptyCredentials()));
        }
        [Test]
        public void LoginWithEmptyLogin()
        {
            Page.LoginPage loginPage = new Page.LoginPage(driver);
            String Test_MessageErors = loginPage.Login(UserCreator.WhithEmptyLogin());
            Assert.AreEqual(Errors_EmptyLogin, Test_MessageErors);
        }
        [Test]
        public void LoginWithEmptyPassword()
        {
            Page.LoginPage loginPage = new Page.LoginPage(driver);
            Assert.AreEqual(Errors_EmptyPassword, loginPage.Login(UserCreator.WhithEmptyPassword()));
        }
    }
}