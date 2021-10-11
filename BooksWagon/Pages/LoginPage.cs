using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace BooksWagon.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.LinkText, Using = "Login")]
        [CacheLookup]
        public IWebElement login;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_txtEmail")]
        [CacheLookup]
        public IWebElement loginEmail;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_txtPassword")]
        [CacheLookup]
        public IWebElement LoginPassword;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_btnLogin")]
        [CacheLookup]
        public IWebElement loginBtn;
    }
}
