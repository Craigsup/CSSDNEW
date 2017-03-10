using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ModifiedTicketingSystem
{
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

        public Scanner(Station location, bool entry) {
            _location = location;
            _entry = entry;
            _accounts = new AccountList(ReadFromBinaryFile<List<CustomerAccount>>(@"Accounts.txt"));
            _aBarrier = new Barrier();
            _routeList = new RouteList();

        }

        public Scanner(Station location, bool entry, AccountList a, RouteList b) {
            _location = location;
            _entry = entry;
            _accounts = a;

            _routeList = new RouteList();
            _routeList = b;

        }

        public Barrier GetBarrier() {
            return _aBarrier;
        }

        public void AddScannedCard(SmartCard x) {
            if (_entry) {
                x.SetScannedTime();
            }

            _scanTime = DateTime.Now;
            SetActiveAccount(_accounts.GetAccountByCardId(x.GetCardId()));
            _aSmartCard = x;
            IsStartPointDefined();
            MakePayment();
        }

        public bool GetScannerType() {
            return _entry;
        }

        public void AddScannedTicket(Ticket x) {
            _aTicket = x;
        }

        public bool ValidateCard(SmartCard x) {
            return _aSmartCard.Equals(x);
        }

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

        public DateTime GetScannedTime() {
            return _scanTime;
        }

        public void SetScannedTime() {
            _scanTime = DateTime.Now;
        }

        public void MakePayment() {
            var start = _account.GetStartPoint();
            var end = _account.GetEndPoint();
            var route = _routeList.GetRouteByStations(start, end);
            var price = route.GetPrice();
//            if (_aSmartCard.GetScannedTime().ToLocalTime().Hour > 9 &&
//                _aSmartCard.GetScannedTime().ToLocalTime().Hour < 17) {
//                price *= 1.3m;
//            }

            if (start.GetDepartures().GetDeparture(end, _aSmartCard.GetScannedTime()).IsPeakDeparture()) {
                price *= 1.3m;
            }

            //_account


            // PAYMENT SHIT GOES HERE.
            if (_account.GetTotalPaidByDate(GetScannedTime()) > _dayPassPrice) {
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
            }

            /*PaymentList payList = new PaymentList();
            Payment payment1 = new Payment(price, 0);
            payList.AddPayment(payment1);
            payList.AddPayment(new Payment(payList.GetPaymentByIndex(0).GetBalance()-price, price));

            var temp = payList;*/
            // Basing _scanTime as time they scanned the exit 
            //hold departure time in smart card so that the scanner can know if the journey was a peak time journey.
        }

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

        public void SetActiveAccount(CustomerAccount x) {
            _account = x;
        }

        public float TotalDailyPayment() {
            return 0f;
        }

        public Station GetStation() {
            return _location;
        }
        
        public static T ReadFromBinaryFile<T>(string filePath) {
            using (Stream stream = File.Open(filePath, FileMode.Open)) {
                var binaryFormatter = new BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
