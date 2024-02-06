using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace NewPom.Utils
{
    public class BaseClass
    {
        public static IWebDriver driver;
        public static ChromeOptions chromeOptions;

        public static IWebDriver InitChromeDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--incognito");

            driver = new ChromeDriver(chromeOptions);
            driver.Manage().Window.Maximize();
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            return driver;
        }
    }
}