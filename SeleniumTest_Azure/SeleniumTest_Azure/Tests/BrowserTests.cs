using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;

namespace Selenium.Test
{
    [TestFixture]
    public class BrowserTests
    {
        private static IWebDriver _chrome;
       

        [SetUp]
        public static void SetUp()
        {
            // Get the current directory.
            string path = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine("The current directory is {0}", path);
            _chrome = new ChromeDriver(@path);
          
        }

        [Test]
        public void GoToIndex()
        {
            _chrome.Navigate().GoToUrl("https://corridor.pramati.com/cas/login#?authType=password");
            _chrome.Close();

            _chrome.Dispose();
        }
    }
}
