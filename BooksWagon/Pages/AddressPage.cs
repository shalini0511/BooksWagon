using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BooksWagon.Pages
{
    public class AddressPage
    {
        public AddressPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/form[1]/div[3]/div[3]/div[2]/div[1]/div[2]/div[1]/div[1]")]
        [CacheLookup]
        public IWebElement validateAddress;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_lvCustomerAdd_ctrl0_btnUseAddress")]
        [CacheLookup]
        public IWebElement address;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_ShoppingCart_lvCart_savecontinue")]
        [CacheLookup]
        public IWebElement saveAndContinue;

    }
}
