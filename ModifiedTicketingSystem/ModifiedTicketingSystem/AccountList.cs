using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace ModifiedTicketingSystem {
    /// <summary>
    /// 
    /// </summary>
    public class AccountList {
        private List<CustomerAccount> _listOfAccounts;
        private List<AdminAccount> _listOfAdminAccounts;
        private Persister _persister = new Persister();

        /// <summary>
        /// Constructor that creates a new list of customer accounts
        /// </summary>
        public AccountList(bool accountType) {
            if (accountType == true) {
                _listOfAdminAccounts = new List<AdminAccount>();
            } else {
                _listOfAccounts = new List<CustomerAccount>();
            }
        }

        /// <summary>
        /// Constructor that sets the list of customer accounts to be equal to the list of customer accounts parameter
        /// </summary>
        /// <param name="accs"></param>
        public AccountList(List<CustomerAccount> accs) {
            _listOfAccounts = new List<CustomerAccount>(accs);
        }

        public AccountList(List<AdminAccount> accs) {
            _listOfAdminAccounts = new List<AdminAccount>(accs);
        }

        /// <summary>
        /// A method that adds a customer account parameter to the list of accounts
        /// </summary>
        /// <param name="x"></param>
        public void AddCustomerAccount(CustomerAccount x) {
            _listOfAccounts.Add(x);
        }

        public void AddAdminAccount(AdminAccount x) {
            _listOfAdminAccounts.Add(x);
        }

        /// <summary>
        /// A method that returns an account from the list of customer accounts with a CardId that matches the integer parameter
        /// </summary>
        /// <param name="x"></param>
        /// <returns>an account</returns>
        public CustomerAccount GetAccountByCardId(int x) {
            return _listOfAccounts.Where(y => y.GetCardId() == x).FirstOrDefault();
        }

        /// <summary>
        /// A method that returns an account from the list of customer accounts with a username that matches the string passed in
        /// </summary>
        /// <param name="x"></param>
        /// <returns>an account</returns>
        public CustomerAccount GetAccountByUsername(string x) {
            return _listOfAccounts.Where(y => y.GetUsername() == x).First();
        }

        /// <summary>
        /// Returns an account based on the accountID given
        /// </summary>
        /// <param name="x">accountID ot be searched for</param>
        /// <returns>CustomerAccount from the listOfAccounts</returns>
        public CustomerAccount GetAccountById(int x) {
            if (!_listOfAccounts.Any()) {
                LoadCustomerData();
            }

            return _listOfAccounts.Where(y => y.GetId() == x).First();
        }

        public AdminAccount GetAdminAccountById(int x) {
            if (!_listOfAdminAccounts.Any()) {
                LoadAdminData();
            }

            return _listOfAdminAccounts.Where(y => y.GetId() == x).First();
        }

        /// <summary>
        /// A method that calls the private Persister.WriteToBinaryFile method with the required parameters
        /// </summary>
        public void SaveCustomerData() {
            Persister.WriteToBinaryFile(@"Accounts.txt", _listOfAccounts, false);
        }

        public void SaveAdminData() {
            Persister.WriteToBinaryFile(@"AdminAccounts.txt", _listOfAdminAccounts, false);
        }

        /// <summary>
        /// A method that calls the private Persister.ReadFromBinaryFile method with the required parameters
        /// </summary>
        public void LoadCustomerData() {
            _listOfAccounts = Persister.ReadFromBinaryFile<List<CustomerAccount>>(@"Accounts.txt");
        }

        public void LoadAdminData() {
            _listOfAdminAccounts = Persister.ReadFromBinaryFile<List<AdminAccount>>(@"AdminAccounts.txt");
        }

        /// <summary>
        /// This method gets the valid user account and calls the update balance method to add the amount they wish to top up to their account balance.
        /// </summary>
        /// <param name="accountId">The account ID of which account to top up.</param>
        /// <param name="topup">How much the user wishes to top up.</param>
        public void UpdateData(int accountId, decimal topup) {
            var accs = Persister.ReadFromBinaryFile<List<CustomerAccount>>(@"Accounts.txt");
            foreach (var account in accs) {
                if (accountId == account.GetAccountId()) {
                    account.UpdateBalance(topup);

                }
            }
            _listOfAccounts = accs;
            SaveCustomerData();
        }

        /// <summary>
        /// Updates a single account in the listOfAccounts and then saves the listOfAccounts to file
        /// Used in various locations to allow easy updating of any attribute of an account.
        /// </summary>
        /// <param name="accountT">CustomerAccount to be updated</param>
        public void UpdateAccount(CustomerAccount accountT) {
            if (File.Exists(@"Accounts.txt")) {
                var accs = Persister.ReadFromBinaryFile<List<CustomerAccount>>(@"Accounts.txt");
                for (int i = 0; i < accs.Count; i++) {
                    if (accountT.GetId() == accs[i].GetAccountId()) {
                        accs[i] = accountT;
                        break;
                    }
                }

                _listOfAccounts = accs;
                SaveCustomerData();
            }
        }

        /// <summary>
        /// Returns the listOfAccounts
        /// </summary>
        /// <returns>the contained listOfAccounts</returns>
        public List<CustomerAccount> ToList() {
            return _listOfAccounts;
        }
    }
}