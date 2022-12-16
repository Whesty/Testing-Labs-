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

        [SetUp]
        public void Setup()
        {
            
            driver =  DrivarSingilton.GetWebDriver();
            driver.Navigate().GoToUrl("https://www.marko.by/");
            

        }
        public const string Errors_AnyCreditUser = "Неверный телефон или пароль";
        public const string Errors_EmptyLogin = "Введите, пожалуйста, Ваш номер телефона!";
        public const string Errors_EmptyPassword = "Введите, пожалуйста, Ваш пароль!";
        /*[Test]
        public void LoginWithAnyUser()
        {
            Page.LoginPage loginPage = new Page.LoginPage(driver);
            Assert.AreEqual(Errors_AnyCreditUser, loginPage.Login(UserCreator.WithCredentialsFromProperty()));
        }*/


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
        public static String SearchErrrorsResult = "По данному запросу ничего не найдено";
        public static String SearchErrorsEmptyResult = "Пустой поисковый запрос";
        [Test]
        public void SearchForAnyWords()
        {
            Page.SearchPage searchPage = new Page.SearchPage(driver);
            searchPage.Search(SearchServices.WithSearchErrorsFromProperty());
            Assert.AreEqual(SearchErrrorsResult, searchPage.MessageErors);
        }

        [Test]
        public void SearchForEmptyWords()
        {
            Page.SearchPage searchPage = new Page.SearchPage(driver);
            searchPage.Search(SearchServices.WithEmptySearch());
            Assert.AreEqual(SearchErrorsEmptyResult, searchPage.MessageErors);
        }
        [Test]
        public void SearchForWords()
        {
            Page.SearchPage searchPage = new Page.SearchPage(driver);
            searchPage.Search(SearchServices.WithSearchFromProperty());
            Assert.AreEqual(SearchServices.WithSearchFromProperty().SearchTest, searchPage.MessageErors);
        }
    }
}