using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstTests;

public class TitleTests
{
    private IWebDriver driver = null!;

    [SetUp]
    public void Setup()
    {
        //  Mở trình duyệt Chrome
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
    }

    [Test]
    public void OpenSeleniumSite_TitleShouldContainSelenium()
    {
        // Điều hướng đến trang web
        driver.Navigate().GoToUrl("https://www.selenium.dev/");

        // Đọc và in tiêu đề trang
        string title = driver.Title;
        Console.WriteLine("Tieu de trang: " + title);
        TestContext.WriteLine("Tieu de trang: " + title);

        // Assert kết quả mong đợi
        Assert.That(title, Does.Contain("Selenium"));
    }

    [TearDown]
    public void TearDown()
    {
        // Đóng trình duyệt
        driver.Quit();
        driver.Dispose();
    }
}