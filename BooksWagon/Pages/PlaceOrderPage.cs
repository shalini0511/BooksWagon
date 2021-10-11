using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BooksWagon.Pages
{
    public class PlaceOrderPage
    {
        public PlaceOrderPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[3]/div[1]/h1[1]")]
        [CacheLookup]
        public IWebElement ValidateCart;

        [FindsBy(How = How.Id, Using = "BookCart_lvCart_ctrl0_txtQty")]
        [CacheLookup]
        public IWebElement quanity;


        [FindsBy(How = How.Name, Using = "BookCart$lvCart$imgPayment")]
        [CacheLookup]
        public IWebElement placeOrder;
    }
}
