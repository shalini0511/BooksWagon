using System;
using BooksWagon.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BooksWagon.DoActions
{
    public class DoAction:BaseClass.BaseClass
    {
        public static void SignUp()
        {
            try
            {
                SignUp signUp = new SignUp(driver);
                signUp.signUpBtn.Click();
                //Validation
                string expected = "New Customers";
                string actual = signUp.ValidatesignUp.Text;
                Console.WriteLine("Message:{0}", actual);
                Assert.AreEqual(expected, actual);
                System.Threading.Thread.Sleep(1000);
                //Path for read data from Excel sheet
                ExcelOperations.SignUpExcelOperation.PopulateInCollection(@"C:\Users\HP\source\repos\BooksWagon\BooksWagon\Resources\SignUpData.xlsx");
                signUp.email.SendKeys(ExcelOperations.SignUpExcelOperation.ReadData(1, "email"));
                System.Threading.Thread.Sleep(1000);
                signUp.password.SendKeys(ExcelOperations.SignUpExcelOperation.ReadData(1, "password"));
                System.Threading.Thread.Sleep(1000);
                signUp.confirmPassword.SendKeys(ExcelOperations.SignUpExcelOperation.ReadData(1, "confirmpassword"));
                System.Threading.Thread.Sleep(1000);
                signUp.createAccount.Click();
                System.Threading.Thread.Sleep(2000);
                try
                {
                    log.Info("SignUp Successfull");
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                }

            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Webdriver unable to locate element");
            }

        }
        //For Login Page
        public static void Login()
        {
            try
            {
                Assert.AreEqual(driver.Title, "Online Bookstore | Buy Books Online | Read Books Online");
                LoginPage login = new LoginPage(driver);
                login.login.Click();
                System.Threading.Thread.Sleep(1000);
                //Path for read data from Excel sheet
                ExcelOperations.SignUpExcelOperation.PopulateInCollection(@"C:\Users\HP\source\repos\BooksWagon\BooksWagon\Resources\SignUpData.xlsx");
                login.loginEmail.SendKeys(ExcelOperations.SignUpExcelOperation.ReadData(1, "email"));
                System.Threading.Thread.Sleep(1000);
                login.LoginPassword.SendKeys(ExcelOperations.SignUpExcelOperation.ReadData(1, "password"));
                System.Threading.Thread.Sleep(1000);
                login.loginBtn.Click();
                System.Threading.Thread.Sleep(5000);

                try
                {
                    log.Info("Login Successfull");
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                }

            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Webdriver unable to locate element");
            }


        }
        //For Search Page 
        public static void Search()
        {
            try
            {
                Login();
                SearchPage search = new SearchPage(driver);
                System.Threading.Thread.Sleep(3000);
                //Path for read data from Excel sheet
                ExcelOperations.SignUpExcelOperation.PopulateInCollection(@"C:\Users\HP\source\repos\BooksWagon\BooksWagon\Resources\SignUpData.xlsx");
                search.search.SendKeys(ExcelOperations.SignUpExcelOperation.ReadData(1, "search"));
                System.Threading.Thread.Sleep(8000);
                /*search.search.SendKeys(Keys.ArrowDown);
                search.search.SendKeys(Keys.Enter);*/
                //Validation
                Assert.True(search.search.Displayed);
                search.searchBtn.Click();
                System.Threading.Thread.Sleep(8000);
                search.wishList.Click();
                System.Threading.Thread.Sleep(4000);
                try
                {
                    log.Info("Search is done");
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                }
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Webdriver unable to locate element");
            }

        }
        public static void BuyNow()
        {
            try
            {
                Search();
                BuyNowPage cart = new BuyNowPage(driver);
                //Validation
                string expected = "My Wishlist";
                string actual = cart.validataBuyNow.Text;
                Console.WriteLine("Message: {0}", actual);
                Assert.AreEqual(expected, actual);
                System.Threading.Thread.Sleep(2000);
                cart.select.Click();
                System.Threading.Thread.Sleep(3000);
                cart.buyNow.Click();
                System.Threading.Thread.Sleep(3000);
                

            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Webdriver unable to locate element");
            }

        }
        public static void PlaceOrder()
        {
            try
            {
                BuyNow();
                driver.SwitchTo().Frame(0);
                PlaceOrderPage order = new PlaceOrderPage(driver);
                //order.quanity.SendKeys("2");
                /*string expected = "My Shopping Cart";
                string actual = order.ValidateCart.Text;
                Console.WriteLine(" Meassage: {0}", actual);
                Assert.AreEqual(expected, actual);
                System.Threading.Thread.Sleep(4000);*/
                order.placeOrder.Click();
                System.Threading.Thread.Sleep(4000);

            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Webdriver unable to locate element");
            }

        }
        public static void Checkout()
        {
            try
            {
                PlaceOrder();
                CheckoutPage checkouts = new CheckoutPage(driver);
                //Validation
                string expected = "Checkout Your Cart";
                string actual = checkouts.validateCheckout.Text;
                Console.WriteLine("Message:{0}", actual);
                Assert.AreEqual(expected, actual);
                checkouts.checkout.Click();
                System.Threading.Thread.Sleep(3000);

            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Webdriver unable to locate element");
            }

        }

        public static void Address()
        {
            try
            {
                Checkout();
                AddressPage addr = new AddressPage(driver);
                // Validation
                string expected = "Shipping Address";
                string actual = addr.validateAddress.Text;
                Console.WriteLine("Message:{0}", actual);
                Assert.AreEqual(expected, actual);
                addr.address.Click();
                System.Threading.Thread.Sleep(3000);
                addr.saveAndContinue.Click();
                System.Threading.Thread.Sleep(3000);

            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Webdriver unable to locate element");
            }

        }

        public static void Logout()
        {
            try
            {
                Address();
                LogoutPage logout = new LogoutPage(driver);
                //Validation
                string expected = "Logout";
                string actual = logout.logout.Text;
                Console.WriteLine("Message:{0}", actual);
                Assert.AreEqual(expected, actual);
                logout.logout.Click();
                System.Threading.Thread.Sleep(3000);
                
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Webdriver unable to locate element");
            }

        }
        public static void InvalidUserDetails()
        {
            
            Assert.AreEqual(driver.Title, "Online Bookstore | Buy Books Online | Read Books Online");
            NegativeTestCase.InvalidLoginDetails invalid = new NegativeTestCase.InvalidLoginDetails(driver);
            invalid.login.Click();
            System.Threading.Thread.Sleep(1000);
            //Path for read data from Excel sheet
            ExcelOperations.InvalidDataExcelOperation.PopulateInCollection(@"C:\Users\HP\source\repos\BooksWagon\BooksWagon\Resources\InvalidUserData.xlsx");
            invalid.loginEmail.SendKeys(ExcelOperations.InvalidDataExcelOperation.ReadData(1, "email"));
            System.Threading.Thread.Sleep(1000);
            invalid.LoginPassword.SendKeys(ExcelOperations.InvalidDataExcelOperation.ReadData(1, "password"));
            System.Threading.Thread.Sleep(1000);
            invalid.loginBtn.Click();
            System.Threading.Thread.Sleep(5000);
            //Validation for neagtive test case
            Assert.True(invalid.errorMessage.Displayed);

        }
    }
}
