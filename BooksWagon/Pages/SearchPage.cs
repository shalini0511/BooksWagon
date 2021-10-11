using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace BooksWagon.Pages
{
    public class SearchPage
    {
        public SearchPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "ctl00_TopSearch1_txtSearch")]
        [CacheLookup]
        public IWebElement search;

        [FindsBy(How = How.Id, Using = "ctl00_TopSearch1_Button1")]
        [CacheLookup]
        public IWebElement searchBtn;

        [FindsBy(How = How.ClassName, Using = "btn-black")]
        [CacheLookup]
        public IWebElement wishList;
    }
}

