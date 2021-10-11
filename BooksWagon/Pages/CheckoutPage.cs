using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BooksWagon.Pages
{
    public class CheckoutPage
    {
        public CheckoutPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/form/div[3]/div[3]/div[1]/h1")]
        [CacheLookup]
        public IWebElement validateCheckout;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Continue')]")]
        [CacheLookup]
        public IWebElement checkout;
    }
}
