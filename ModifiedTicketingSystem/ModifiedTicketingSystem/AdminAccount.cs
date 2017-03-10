using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace ModifiedTicketingSystem {
    /// <summary>
    /// 
    /// </summary>
    /// 
    [Serializable]
    [DataContract]
    public class AdminAccount : Account {
        [DataMember]
        protected RouteList _routes;
        /// <summary>
        /// Constructor for the AdminAccount class
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="fullName"></param>
        /// <param name="password"></param>
        /// <param name="username"></param>
        /// <param name="loginStatus"></param>
        public AdminAccount(int accountId, string username, string password, string fullName, bool loginStatus) : base(accountId, username, password, fullName, loginStatus) {
            
        }

        public AdminAccount() {
        }

        public AdminAccount(int id) {
            var temp = new AccountList(true).GetAdminAccountById(id);

            _routes = temp._routes;
            _loginStatus = temp._loginStatus;
            _accountId = temp._accountId;
            _fullName = temp._fullName;
            _password = temp._password;
            _username = temp._username;
        }

        public T GetXByAccountId<T>(int accountId, string x) {
            var accs = ReadFromBinaryFile<List<AdminAccount>>(@"AdminAccounts.txt");
            foreach (var account in accs) {
                if (accountId == account._accountId) {
                    switch (x) {
                        case "routes":
                            return (T)Convert.ChangeType(account._routes, typeof(T));
                        case "fullname":
                            return (T)Convert.ChangeType(account._fullName, typeof(T));
                        case "username":
                            return (T)Convert.ChangeType(account._username, typeof(T));
                    }
                }
            }
            return default(T);
        }

        /// <summary>
        /// A method that returns null
        /// </summary>
        /// <returns>null</returns>
        public PurchasedTicketList GetTicketList() {
            return null;
        }

        /// <summary>
        /// A method that returns the list of routes
        /// </summary>
        /// <returns>list of routes</returns>
        public RouteList GetRoutes() {
            return _routes;
        }

        /// <summary>
        /// A method that returns null
        /// </summary>
        /// <returns>null</returns>
        public JourneyList GetJourneyList() {
            return null;
        }

        /// <summary>
        /// A method that does nothing
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void NewDeparture(Station x, DateTime y) {

        }
        
        /// <summary>
        /// A method that does nothing
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public void NewRoute(Station x, Station y, decimal z) {
            if (_routes == null) {
                _routes = new RouteList();
            }
            _routes.AddRoute(new Route(x, y, z));
        }

        public int GetId() {
            return _accountId;
        }
    }
}
