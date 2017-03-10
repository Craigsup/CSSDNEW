using System;

namespace ModifiedTicketingSystem {
    public class Ticket {
        private int _ticketId;
        private Departure _departure;
        private Route _aRoute;
        private bool _isValid;
        private DateTime _printTime;
        private string _seatReservaton;
        private string _ticketType;
        private DateTime _expiryDate;

        public Ticket(int ticketId, Departure departure, Route aRoute, bool isValid, DateTime printTime, string seatReservaton, string ticketType, DateTime expiryDate) {
            _ticketId = ticketId;
            _departure = departure;
            _aRoute = aRoute;
            _isValid = isValid;
            _printTime = printTime;
            _seatReservaton = seatReservaton;
            _ticketType = ticketType;
            _expiryDate = expiryDate;
        }

        public int TicketId() {
            return 0;
        }

        public Departure GetDeparture() {
            return null;
        }

        public Route GetRoute() {
            return null;
        }

        public void SetIsValid() {
            
        }

        public bool GetIsValid() {
            return false;
        }

        public DateTime GetPrintTime() {
            return DateTime.Now;
        }

        public String GetSeatReservation() {
            return "";
        }

        public DateTime GetExpiryDate() {
            return DateTime.Now;
        }
    }
}
