using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BooksWagon.Pages
{
    public class LogoutPage
    {
        public LogoutPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.LinkText, Using = "Logout")]
        [CacheLookup]
        public IWebElement logout;
    }
}
