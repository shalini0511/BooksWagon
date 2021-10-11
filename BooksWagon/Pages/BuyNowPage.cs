using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BooksWagon.Pages
{
    public class BuyNowPage
    {
        public BuyNowPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "ctl00_phBody_WishList_lvWishList_ctrl0_chkAdd")]
        [CacheLookup]
        public IWebElement select;

        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[4]/div[2]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[4]/div[4]/table[1]/tbody[1]/tr[3]/td[1]/div[1]/a[1]/input[1]")]
        [CacheLookup]
        public IWebElement buyNow;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_lblheading")]
        [CacheLookup]
        public IWebElement validataBuyNow;


    }
}
