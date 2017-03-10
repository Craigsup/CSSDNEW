using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModifiedTicketingSystem;
using System.Collections.Generic;

namespace TicketingSystemTest {
    [TestClass]
    public class CraigUnitTest {
        [TestMethod]
        public void ValidAccountSaved() {
            AccountList accList = new AccountList(false);
            CustomerAccount bobAccount = new CustomerAccount(1, 38.50m, 1, "Bob", "password", "Bob Shanks", false);

            accList.AddCustomerAccount(bobAccount);
            Assert.AreEqual(accList.GetAccountById(bobAccount.GetAccountId()), bobAccount);
            //Assert.AreEqual<Customer(accList.GetAccountById(bobAccount.GetAccountId()) == bobAccount);
        }

        [TestMethod]
        public void SavedAccountComaparison() {
            AccountList accList = new AccountList(false);
            CustomerAccount bobAccount = new CustomerAccount(1, 38.50m, 1, "Bob", "password", "Bob Shanks", false);

            accList.AddCustomerAccount(bobAccount);
            accList.SaveCustomerData();
            accList.LoadCustomerData();
            var newAcc = accList.GetAccountById(bobAccount.GetAccountId());
            Assert.IsTrue(bobAccount.ToString() == newAcc.ToString());
        }

        [TestMethod]
        public void LoginAndOutOfAccount() {
            CustomerAccount bobAccount = new CustomerAccount(1, 38.50m, 1, "Bob", "password", "Bob Shanks", false);

            // Log in
            var result = new CustomerAccount().VerifyLogin(bobAccount.GetUsername(), "password");
            Assert.IsTrue(result > -1);

            // Log out
            result = new Account().Logout(result);
            Assert.IsTrue(result == -1);
        }

        [TestMethod]
        public void UpdateAccountTest() {
            AccountList accList = new AccountList(false);
            CustomerAccount bobAccount = new CustomerAccount(1, 38.50m, 1, "Bob", "password", "Bob Shanks", false);
            //var bobAccount = accList.GetAccountById(1);
            new CustomerAccount(bobAccount.GetAccountId()).AddPaymentCard(bobAccount.GetAccountId(), "012345678910", "01/2020", bobAccount.GetName());

            accList.LoadCustomerData();
            bobAccount = accList.GetAccountById(1);

            var cards = bobAccount.GetXByAccountId<List<PaymentCard>>(bobAccount.GetAccountId(), "savedpaymentmethods");
            var one = cards[cards.Count-1].ToString();
            var two = new PaymentCard("012345678910", new DateTime(2020, 01, 01), bobAccount.GetName()).ToString();

            

            Assert.AreEqual(one, two);

        }
    }
}
