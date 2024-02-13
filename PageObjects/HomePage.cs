using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NewPom.PageObjects
{
    public class HomePage
    {
        private IWebDriver driver;

        private WebDriverWait wait;
        private By microsoftLogo = By.Id("uhfLogo");
        private By searchButton = By.Id("search");
        private By searchBarInput = By.Id("cli_shellHeaderSearchInput");
        private By cancelSearchButton = By.Id("cancel-search");
        private By shoppingCartLink = By.Id("uhf-shopping-cart");
        private By iFrameShoppingCartPreview = By.Id("shell-cart-count");
        private By yourAccountLink = By.Id("mectrl_main_trigger");


        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
        }

        public void showSearchBar()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(searchButton));
            driver.FindElement(searchButton).Click();
        }

        public void clickOnSearchButton()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(searchButton));
            driver.FindElement(searchButton).Click();
        }

        public void type(string anything)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(searchBarInput));
            driver.FindElement(searchBarInput).SendKeys(anything);
        }

    }
}