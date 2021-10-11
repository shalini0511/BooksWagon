using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace BooksWagon
{
    [TestFixture]
    [AllureNUnit]
    public class Tests:BaseClass.BaseClass
    {

        /*[Test,Order(0)]
        public void SignUpTest()
        {
            DoActions.DoAction.SignUp();
        }
        [Test,Order(1)]
        [AllureTag("LoginPage")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("Shalini")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        public void LoginPageTest()
        {
            DoActions.DoAction.Login();
        }
        [Test,Order(2)]
        public void SearchPageTest()
        {
            DoActions.DoAction.Search();
        }
        [Test, Order(3)]
        public void CartPageTest()
        {
            DoActions.DoAction.BuyNow();
        }
        [Test,Order(4)]
        public void PlaceOrderTest()
        {
            DoActions.DoAction.PlaceOrder();
        }
        [Test, Order(5)]
        public void CheckoutPageTest()
        {
            DoActions.DoAction.Checkout();
        }
        [Test, Order(6)]
        public void AddressPageTest()
        {
            DoActions.DoAction.Address();
        }*/
        [Test, Order(7)]
        public void LogoutPageTest()
        {
            DoActions.DoAction.Logout();
        }
       /* [Test, Order(7)]
        public void NegativeTest()
        {
            DoActions.DoAction.InvalidUserDetails();
        }*/
    }
}