using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NewPom.PageObjects
{
    public class SearchPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        private By languageWindow = By.XPath("//div[@class='modal-content']");
        private By cancelButton = By.XPath("//button[@aria-label='Cancel']");
        private By selectUnitedStatesButton = By.XPath("//button[@class='btn btn-primary btn-block redirect-reject preferred-redirect-reject']");
        private By selectMexicoLink = By.XPath("//a[@class='btn btn-primary btn-block redirect-confirm preferred-redirect-confirm']");

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
        }

        public string getPageUrl()
        {
            return driver.Url;
        }
        public void cancelLanguageWindow()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(languageWindow));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(cancelButton));
            driver.FindElement(cancelButton).Click();
        }
    }
}