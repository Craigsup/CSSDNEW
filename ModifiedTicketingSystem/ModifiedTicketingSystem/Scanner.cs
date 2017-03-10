using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ModifiedTicketingSystem
{
    public class Scanner {
        private SmartCard _aSmartCard;
        private bool _entry;
        private Ticket _aTicket;
        private TokenValidator _validator;
        private Barrier _aBarrier;
        private ScannerFeedback _feedback;
        private DateTime _scanTime;
        private PaymentList _payment;
        private Station _location;
        private CustomerAccount _account;
        private AccountList _accounts;
        private decimal _dayPassPrice;
        private RouteList _routeList;

        /// <summary>
        /// Constructor which takes in a station and entry boolean
        /// </summary>
        /// <param name="location">Station the scanner is located at</param>
        /// <param name="entry">Whether this is an entry of exit barrier. True if entry, false if exit.</param>
        public Scanner(Station location, bool entry) {
            _location = location;
            _entry = entry;
            _accounts = new AccountList(ReadFromBinaryFile<List<CustomerAccount>>(@"Accounts.txt"));

            _routeList = new RouteList();

        }

        /// <summary>
        /// Constructor which takes in a station, entry boolean, list of all accounts and list of routes
        /// </summary>
        /// <param name="location">Station the scanner is located at</param>
        /// <param name="entry">Whether this is an entry of exit barrier. True if entry, false if exit.</param>
        /// <param name="a">The list of all customer accounts</param>
        /// <param name="b">List of the routes that exit from this station</param>
        public Scanner(Station location, bool entry, AccountList a, RouteList b) {
            _location = location;
            _entry = entry;
            _accounts = a;

            _routeList = new RouteList();
            _routeList = b;

        }

        /// <summary>
        /// If this is an entry barrier, sets the scanned time. If exit, makes a payment.
        /// </summary>
        /// <param name="x">Card that has been scanned at the scanner</param>
        /// <returns>True if the scan succeeds, otherwise false</returns>
        public bool AddScannedCard(SmartCard x) {
            _scanTime = DateTime.Now;
            SetActiveAccount(_accounts.GetAccountByCardId(x.GetCardId()));
            _aSmartCard = x;

            if (_entry) {
                if(IsStartPointDefined()) {
                    return false;
                } else {
                    x.SetScannedTime();
                    _account.SetStartPoint(_location);
                    return true;
                }
            } else {
                if (IsStartPointDefined()) {
                    return MakePayment();
                } else {
                    return false;
                }
            }

        }

        /// <summary>
        /// Sets the ticket in the scanner to the one scanned
        /// </summary>
        /// <param name="x">Ticket that has been scanned</param>
        public void AddScannedTicket(Ticket x) {
            _aTicket = x;
        }

        /// <summary>
        /// Unused method from class diagram
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool ValidateCard(SmartCard x) {
            return false;
        }

        /// <summary>
        /// Unused method from class diagram
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool ValidateTicket(Ticket x) {
            return false;
        }

        /// <summary>
        /// Returns the time at which the current card or ticket was scanned
        /// </summary>
        /// <returns>_scanTime</returns>
        public DateTime GetScannedTime() {
            return _scanTime;
        }

        /// <summary>
        /// Sets the scan time to the current time
        /// </summary>
        public void SetScannedTime() {
            _scanTime = DateTime.Now;
        }

        /// <summary>
        /// Gets the route and price from the start and end stations. If peak time, adjusts the price. Checks if the user qualifies for free travel.
        /// </summary>
        /// <returns>True if free travel or customer has paid. False if something has gone wrong</returns>
        public bool MakePayment() {
            var start = _account.GetStartPoint();
            var end = _account.GetEndPoint();
            var route = _routeList.GetRouteByStations(start, end);
            var price = route.GetPrice();

            if (start.GetDepartures().GetDeparture(end, _aSmartCard.GetScannedTime()).IsPeakDeparture()) {
                price *= 1.3m;
            }

            // PAYMENT SHIT GOES HERE.
            if (_account.GetFreeTravel()) {
                return true;
            }
            if (_account.GetTotalPaidByDate(GetScannedTime()) > _dayPassPrice) {
                _account.SetFreeTravel(true);
                return true;
            }
            if (_account.GetBalance() >= price) {
                _account.UpdateBalance(-price);
                _account.SetStartPoint(null);
                _account.SetEndPoint(null);
                return true;
            }
            else {
                return false;
            }
        }

        /// <summary>
        /// Checks if start point exists for the user scanning the card. Sets the end point if this scanner is an exit scanner.
        /// </summary>
        /// <returns>True if the start point exists. False if this is an entry barrier or the user doesn't have a start point</returns>
        public bool IsStartPointDefined() {
            if (_entry) {
                return false;
            }

            if (_account.GetStartPoint() == null) {
                return false;
            }
            _account.SetEndPoint(_location);
            return true;
        }

        /// <summary>
        /// Sets the account that is currently being accessed.
        /// </summary>
        /// <param name="x">The CustomerAccount to be used</param>
        public void SetActiveAccount(CustomerAccount x) {
            _account = x;
        }

        /// <summary>
        /// Unused method from class diagram
        /// </summary>
        /// <returns></returns>
        public float TotalDailyPayment() {
            return 0f;
        }
        
        /// <summary>
        /// Deserialises data that is saved in a file.
        /// </summary>
        /// <typeparam name="T">The type of data stored in the file</typeparam>
        /// <param name="filePath">The location of the file that is being opened</param>
        /// <returns>The deserialised data in the file</returns>
        public static T ReadFromBinaryFile<T>(string filePath) {
            using (Stream stream = File.Open(filePath, FileMode.Open)) {
                var binaryFormatter = new BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
