using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MsTestParallExectution
{
    public static class DriverExtensions
    {
        public static IJavaScriptExecutor Script(this IWebDriver driver) => (driver as IJavaScriptExecutor);

        public static void ClickUsingJavascript(this IWebDriver driver, IWebElement element)
            => (driver as IJavaScriptExecutor).ExecuteScript("$(arguments[0]).click()", element);

        public static string GetText(this IWebDriver driver, IWebElement element) =>
            (string) (driver as IJavaScriptExecutor).ExecuteScript("return $(arguments[0]).val()", element);

        public static bool IsElementEntirelyInView(this IWebDriver driver, IWebElement element)
        {
            string script = @" var el = arguments[0];
                  var top = el.offsetTop;
                  var left = el.offsetLeft;
                  var width = el.offsetWidth;
                  var height = el.offsetHeight;

                  while(el.offsetParent) {
                    el = el.offsetParent;
                    top += el.offsetTop;
                    left += el.offsetLeft;
                  }

                  return (
                    top >= window.pageYOffset &&
                    left >= window.pageXOffset &&
                    (top + height) <= (window.pageYOffset + window.innerHeight) &&
                    (left + width) <= (window.pageXOffset + window.innerWidth)
                  );";

            return (bool) driver.Script().ExecuteScript(script, element);
        }

        public static bool IsElementPartiallyInView(this IWebDriver driver, IWebElement element)
        {
            string script = @" var el = arguments[0];
                  var top = el.offsetTop;
                  var left = el.offsetLeft;
                  var width = el.offsetWidth;
                  var height = el.offsetHeight;

                  while(el.offsetParent) {
                    el = el.offsetParent;
                    top += el.offsetTop;
                    left += el.offsetLeft;
                  }

                  return (
                    top < (window.pageYOffset + window.innerHeight) &&
                    left < (window.pageXOffset + window.innerWidth) &&
                    (top + height) > window.pageYOffset &&
                    (left + width) > window.pageXOffset
                  );";

            return (bool)driver.Script().ExecuteScript(script, element);
        }
    }
}
