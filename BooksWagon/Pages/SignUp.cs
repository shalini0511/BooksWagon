using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BooksWagon.Pages
{
    public class SignUp
    {
        //Using page factory for initialization of Page objects
        public SignUp(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //using FindsBy locating the element
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/form[1]/div[4]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]")]
        [CacheLookup]
        public IWebElement ValidatesignUp;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Signup')]")]
        [CacheLookup]
        public IWebElement signUpBtn;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignUp_txtEmail")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignUp_txtPassword")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignUp_txtConfirmPwd")]
        [CacheLookup]
        public IWebElement confirmPassword;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignUp_btnSubmit")]
        [CacheLookup]
        public IWebElement createAccount;
    }
}
