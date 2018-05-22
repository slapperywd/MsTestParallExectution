using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace MsTestParallExectution
{
    [TestClass]
    public class UnitTest1 : BaseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            this.Driver.Navigate().GoToUrl("https://blogs.msdn.microsoft.com/devops/2018/01/30/mstest-v2-in-assembly-parallel-test-execution/");
            Console.WriteLine(TestContext.TestName);
            Thread.Sleep(500);

        }

        [TestMethod]
        public void TestMethod2()
        {
            this.Driver.Navigate().GoToUrl("https://msdn.microsoft.com/en-us/library/jj635153.aspx");
           // this.Driver.ClickUsingJavascript(this.Driver.FindElement(By.Id("breadcrumbDropDownButton")));
            var a =this.Driver.GetText(this.Driver.FindElement(By.CssSelector(".topic h1")));
            Thread.Sleep(500);
        }

        [TestMethod]
        public void TestMethod3()
        {
            this.Driver.Navigate().GoToUrl("https://msdn.microsoft.com/en-us/library/jj635153.aspx");
            // this.Driver.ClickUsingJavascript(this.Driver.FindElement(By.Id("breadcrumbDropDownButton")));
            bool partialCheck = this.Driver.IsElementPartiallyInView(this.Driver.FindElement(By.XPath("(//div[@class='contentTableWrapper']/table)[3]")));
            bool entireCheck = this.Driver.IsElementEntirelyInView(this.Driver.FindElement(By.XPath("(//div[@class='contentTableWrapper']/table)[3]")));

            Thread.Sleep(500);
        }
    }
}
