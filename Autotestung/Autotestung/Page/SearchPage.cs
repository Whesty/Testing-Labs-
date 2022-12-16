using OpenQA.Selenium;

namespace Autotestung.Page
{
    internal class SearchPage
    {
        private IWebDriver driver;
        private readonly By _SearchButton = By.XPath("//div[@class='search-form__btn']");
        private readonly By _SearchInput = By.XPath("//input[@class='search-form__input field-effects-js']");
        private readonly By _SearchResultErrors = By.XPath("//i[text()='По данному запросу ничего не найдено']");
        private readonly By _SearchResult = By.XPath("//div[@class='prod__title']");
        private readonly By _SearchCatalog = By.XPath("//div[@class='catalog__main']");

        public String MessageErors;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private readonly By _ClosBaner = By.XPath("//div[@class='banner_close close to___process']");
        private void CloseBaner()
        {
            if (driver.FindElements(_ClosBaner).Count > 0)
                driver.FindElement(_ClosBaner).Click();
           
        }

        private void ClickSearchButton()
        {
           // CloseBaner();
            driver.FindElement(_SearchButton).Click();
        }
        private void InputSearch(string search)
        {
            driver.FindElement(_SearchInput).SendKeys(search);
        }
        private void Result( bool Errors)
        {
            if (Errors)
            {
                MessageErors = driver.FindElement(_SearchCatalog).FindElement(By.XPath("./div")).FindElement(By.XPath("./p")).FindElement(By.XPath("./i")).Text;
            }
            else MessageErors = driver.FindElement(_SearchResult).FindElement(By.XPath("./span")).Text;
        }
        
        public string Search(Model.Search search )
        {

            InputSearch(search.SearchTest);
            ClickSearchButton();
            Result(search.SearchTestErrors);
            return MessageErors;
        }
    }
}