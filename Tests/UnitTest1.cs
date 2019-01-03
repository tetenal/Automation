using NUnit.Framework;
using System;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"/Users/Tetenal/Documents/Automation/", "chromedriver.exe");
            driver = new ChromeDriver(service);
            driver.Url = "https://www.youtube.com";
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Test1()
        {

            Assert.Pass();
        }
    }
}