using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BiotusSeleniumTests
{
    public class BaseTest1 : IDisposable
    {
        private IWebDriver _driver;

        public IWebDriver StartDriverWithURL (string url)
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(url);
            return _driver;
        }
        public void Dispose()
        {
           //_driver.Quit();
        }
    }
}
