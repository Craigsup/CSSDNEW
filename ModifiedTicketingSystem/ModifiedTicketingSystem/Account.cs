using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ModifiedTicketingSystem {
    [Serializable]
    [DataContract]
    public class Account {
        [DataMember]
        protected int _accountId;
        [DataMember]
        protected string _fullName;
        [DataMember]
        protected string _password;
        [DataMember]
        protected bool _loginStatus;
        [DataMember]
        protected string _username;

        /// <summary>
        /// A constructor for the Account class that takes parameters
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        /// <param name="loginStatus"></param>
        public Account(int accountId, string username, string password, string fullName, bool loginStatus) {
            _accountId = accountId;
            _fullName = fullName;
            _password = password;
            _loginStatus = loginStatus;
            _username = username;
        }

        /// <summary>
        /// a constructor for the Account class
        /// </summary>
        public Account() {

        }

        /// <summary>
        /// This should never be used. Huge security risk.
        /// </summary>
        /// <returns>Do not use me.</returns>
        public Account GetAccount() {
            return this;
        }

        /// <summary>
        /// This is a getter for the _fullname attribute.
        /// </summary>
        /// <returns>A string containing the full name of the account holder.</returns>
        public string GetName() {
            return _fullName;
        }

        /// <summary>
        /// This is a getter for the _username attribute.
        /// </summary>
        /// <returns>A string containing the username of the account holder.</returns>
        public string GetUsername() {
            return _username;
        }

        /// <summary>
        /// This is a getter for the _accountId attribute.
        /// </summary>
        /// <returns>An integer </returns>
        public int GetAccountId() {
            return _accountId;
        }

        /// <summary>
        /// This function takes the username and password entered by the user.
        /// It then calls the function to read the Accounts file; this then verifies the entered details
        /// against the stored details. If both match, it returns the accountId.
        /// </summary>
        /// <param name="username">A string containing the username the user entered when attempting to log in.</param>
        /// <param name="password">A string containing the password the user entered when attempting to log in.</param>
        /// <returns>If successful, the accountId, else -1 to signal a failure.</returns>
        public int VerifyLogin(string username, string password) {
            if (username.StartsWith("admin")) {
                var accs = ReadFromBinaryFile<List<AdminAccount>>(@"AdminAccounts.txt");
                foreach (var account in accs) {
                    if (account._username == username && account._password == password) {
                        if (account._loginStatus) {
                            return -2;
                        }
                        account._loginStatus = true;
                        var temp = new AccountList(accs);
                        temp.SaveAdminData();
                        return account._accountId;
                    }
                }
                return -1;
            }
            else {
                var accs = ReadFromBinaryFile<List<CustomerAccount>>(@"Accounts.txt");
                foreach (var account in accs) {
                    if (account._username == username && account._password == password) {
                        if (account._loginStatus) {
                            return -2;
                        }
                        account._loginStatus = true;
                        var temp = new AccountList(accs);
                        temp.SaveCustomerData();
                        return account._accountId;
                    }
                }
                return -1;
            }
        }

        /// <summary>
        /// Logs a user out of their account and sets loginStatus to false
        /// </summary>
        /// <param name="accountId">AccountID of the account to be logged out</param>
        /// <returns>-1 for the gui to sets it's current account ID to</returns>
        public int Logout(int accountId) {
            var accs = ReadFromBinaryFile<List<CustomerAccount>>(@"Accounts.txt");
            foreach (var account in accs) {
                if (account._accountId == accountId) {
                    account._loginStatus = false;
                    var temp = new AccountList(accs);
                    temp.SaveCustomerData();
                    return -1;
                }
            }

            return -1;
        }

        /// <summary>
        /// Deserialises data that is saved in a file.
        /// </summary>
        /// <param name="filePath"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns>(T)binaryFormatter.Deserialize(stream)</returns>
        public static T ReadFromBinaryFile<T>(string filePath) {
            using (Stream stream = File.Open(filePath, FileMode.Open)) {
                var binaryFormatter = new BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
