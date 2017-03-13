using System;
using System.Collections.Generic;

namespace ModifiedTicketingSystem {
    public class Scanner {
        protected SmartCard _aSmartCard;
        protected bool _entry;
        protected Ticket _aTicket;
        protected TokenValidator _validator;
        protected Barrier _aBarrier;
        protected ScannerFeedback _feedback;
        protected DateTime _scanTime;
        protected PaymentList _payment;
        protected Station _location;
        protected CustomerAccount _account;
        protected AccountList _accounts;
        protected decimal _dayPassPrice;
        protected RouteList _routeList;

        /// <summary>
        /// Constructor for the scanner class that takes two parameters
        /// </summary>
        /// <param name="location"></param>
        /// <param name="entry"></param>
        public Scanner(Station location, bool entry) {
            _location = location;
            _entry = entry;
            _accounts = new AccountList(Persister.ReadFromBinaryFile<List<CustomerAccount>>(@"Accounts.txt"));
            _aBarrier = new Barrier();
            _routeList = new RouteList();

        }

        /// <summary>
        /// constructor for the scanner class that takes four parameters
        /// </summary>
        /// <param name="location"></param>
        /// <param name="entry"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Scanner(Station location, bool entry, AccountList a, RouteList b) {
            _location = location;
            _entry = entry;
            _accounts = a;
            _aBarrier = new Barrier();
            _routeList = new RouteList();
            _routeList = b;

        }

        /// <summary>
        /// Getter for the scanners barrier
        /// </summary>
        /// <returns>_aBarrier</returns>
        public Barrier GetBarrier() {
            return _aBarrier;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns>true or false</returns>
        public bool AddScannedCard(SmartCard x) {
            _scanTime = DateTime.Now;
            SetActiveAccount(_accounts.GetAccountByCardId(x.GetCardId()));
            _aSmartCard = x;

            if (_entry) {
                if (IsStartPointDefined()) {
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
        /// Getter for the scanners type
        /// </summary>
        /// <returns>_entry</returns>
        public bool GetScannerType() {
            return _entry;
        }

        /// <summary>
        /// setter for the scanners Ticket object _aTicket 
        /// </summary>
        /// <param name="x"></param>
        public void AddScannedTicket(Ticket x) {
            _aTicket = x;
        }

        /// <summary>
        /// validates that the smartcard passed in to the function is equal to the smartcard stored in the scanner
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool ValidateCard(SmartCard x) {
            return _aSmartCard.Equals(x);
        }

        /// <summary>
        /// a function that checks whether a ticket meets the correct criteria to allow entry through the scanners barrier
        /// </summary>
        /// <returns>true or false</returns>
        public bool ValidateTicket() {
            // the ticket is valid
            if(_aTicket.GetIsValid() == true) {
                // the ticket is for a single journey
                if (_aTicket.GetTicketType() == "single") {
                    // this is an entry scanner
                    if (_entry == true) {
                        // the start station of the tickets route matches the location of this scanner
                        if (_aTicket.GetRoute().GetStartPoint().GetLocation() == _location.GetLocation()){
                            _aBarrier.OpenBarrier();
                            return true;
                        // the start station of the tickets route does not match the location of this scanner
                        } else {
                            return false;
                        }
                    // this is an exit scanner
                    } else {
                        // the end station of the tickets route matches the location of this scanner
                        if (_aTicket.GetRoute().GetEndPoint().GetLocation() == _location.GetLocation()) {
                            _aBarrier.OpenBarrier();
                            _aTicket.SetIsValid(false);
                            _location.RemoveTicketFromList(_aTicket);
                            return true;
                        // the end station of the tickets route does not match the location of this scanner
                        } else {
                            return false;
                        }
                    }
                // the ticket is a timed pass      
                } else if(_aTicket.GetTicketType() == "timed") {
                    // the expiry date is valid
                    if (_aTicket.CheckExpiryDate() == true){
                        _aBarrier.OpenBarrier();
                        return true;
                        // the expiry date is not valid
                    } else {
                        _location.RemoveTimedTicketFromList(_aTicket);
                        return false;
                    }
                // this should not happen but will catch the faulty ticket if the string is incorrect
                } else {
                    _aTicket.SetIsValid(false);
                    _location.RemoveTimedTicketFromList(_aTicket);
                    return false;
                }
            // the ticket is not valid
            } else {
                // if single journey type
                if (_aTicket.GetTicketType() == "single" ) {
                    _location.RemoveTicketFromList(_aTicket);
                //if timed pass type
                } else {
                    _location.RemoveTimedTicketFromList(_aTicket);
                }
                return false;
            }
        }


        /// <summary>
        /// Getter method for the scanners _scanTime DateTime object
        /// </summary>
        /// <returns></returns>
        public DateTime GetScannedTime() {
            return _scanTime;
        }

        /// <summary>
        /// Setter method for the _scanTime DateTime object that sets the object to the current date and time
        /// </summary>
        public void SetScannedTime() {
            _scanTime = DateTime.Now;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>true or false</returns>
        public bool MakePayment() {
            var start = _account.GetStartPoint();
            var end = _account.GetEndPoint();
            var route = _routeList.GetRouteByStations(start, end);
            var price = route.GetPrice();

            if (start.GetDepartures().GetDeparture(end, _aSmartCard.GetScannedTime()).IsPeakDeparture()) {
                price *= 1.3m;
            }

            // PAYMENT GOES HERE.
            /*if (_account.GetTotalPaidByDate(GetScannedTime()) > _dayPassPrice) {
                _account.SetFreeTravel(true);
            }
            else {
                if (_account.GetBalance() >= price) {
                    _account.UpdateBalance(-price);
                    _account.SetStartPoint(null);
                    _account.SetEndPoint(null);
                }
                else {
                    
                }
            }*/

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
            } else {
                return false;
            }

            /*PaymentList payList = new PaymentList();
            Payment payment1 = new Payment(price, 0);
            payList.AddPayment(payment1);
            payList.AddPayment(new Payment(payList.GetPaymentByIndex(0).GetBalance()-price, price));

            var temp = payList;*/
            // Basing _scanTime as time they scanned the exit 
            //hold departure time in smart card so that the scanner can know if the journey was a peak time journey.
        }

        /// <summary>
        /// Runs checks and then sets an accounts endpoint to the station object stored inside the scanner if it was successful true is returned if not then false
        /// </summary>
        /// <returns>true or false</returns>
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
        /// Setter for the scanners _account account object
        /// </summary>
        /// <param name="x"></param>
        public void SetActiveAccount(CustomerAccount x) {
            _account = x;
        }


        /// <summary>
        /// returns a zero floating point object
        /// </summary>
        /// <returns>0f</returns>
        public float TotalDailyPayment() {
            return 0f;
        }

        /// <summary>
        /// Getter for the scanners _location station object 
        /// </summary>
        /// <returns>_location</returns>
        public Station GetStation() {
            return _location;
        }
    }
}
