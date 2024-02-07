using NewPom.Model;
using NewPom.PageObjects;
using NewPom.Utils;
using OpenQA.Selenium;

namespace NewPom;

public class Tests
{
    static IWebDriver driver;
    HomePage homePage;
    SearchPage searchPage;

    [SetUp]
    public void Setup()
    {
        driver = BaseClass.InitChromeDriver();
        homePage = new HomePage(driver);
        searchPage = new SearchPage(driver);
    }

    [Test]
    public void MicrosoftSearchTest()
    {
        driver.Navigate().GoToUrl("https://www.microsoft.com/en-us/");
        homePage.search("xbox");
        Assert.IsTrue(searchPage.getPageUrl().Contains("xbox"));
        searchPage.cancelLanguageWindow();
    }

    //TODO: delete this snippet, it is just for demo on the Serialization and Deserialization of a JSON, String and Object.
    /*     public void JsonTest()
        {
            string jsonDemo = DataTransformer.transformJsonToString("/Users/cesar.rodriguez/Workspace/CSharp/NewPom/Resources/Searches.json");
            Searches searches = DataTransformer.transformStringToObject(jsonDemo);
            System.Console.WriteLine($"searchOne: {searches.searchOne}");
            System.Console.WriteLine($"searchTwo: {searches.searchTwo}");
            System.Console.WriteLine($"searchThree: {searches.searchThree}");
            System.Console.WriteLine($"searchFour: {searches.searchFour}");
            System.Console.WriteLine($"searchFive: {searches.searchFive}");

        } */

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}