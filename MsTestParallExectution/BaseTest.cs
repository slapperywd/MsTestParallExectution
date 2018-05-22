using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MsTestParallExectution
{
    public class BaseTest
    {
        protected IWebDriver Driver { get; }

        public TestContext TestContext { get; set; }

        public BaseTest()
        {
            this.Driver = new ChromeDriver();
            this.Driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            this.Driver.Quit();
        }
    }
}
