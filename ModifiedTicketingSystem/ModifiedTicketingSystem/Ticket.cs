using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ModifiedTicketingSystem {
    [Serializable]
    public class Ticket {
        [DataMember]
        protected int _ticketId;
        [DataMember]
        protected int _accountId;
        //[DataMember]
        //protected Departure _departure;
        [DataMember]
        protected Route _aRoute;
        [DataMember]
        protected bool _isValid;
        [DataMember]
        protected DateTime _printTime;
        [DataMember]
        protected string _seatReservaton;
        [DataMember]
        protected string _ticketType;
        [DataMember]
        protected DateTime _expiryDate;

        public Ticket(Route aRoute, bool isValid, DateTime printTime, string seatReservation, string ticketType, int accountId) {
            _ticketId = GetNewTicketId();
            _aRoute = aRoute;
            _isValid = isValid;
            _printTime = printTime;
            _seatReservaton = seatReservation;
            _ticketType = ticketType;
            _accountId = accountId;
        }

        public Ticket(bool isValid, DateTime printTime, string ticketType, DateTime expiryDate, int accountId) {
            _ticketId = GetNewTicketId();
            _isValid = isValid;
            _printTime = printTime;
            _ticketType = ticketType;
            _expiryDate = expiryDate;
            _accountId = accountId;
        }

        public Ticket() {
            _ticketId = 0;
            _isValid = false;
        }

        public void SerialiseTickets() {
            InitialiseTicketId();
            var tickets = Persister.ReadFromBinaryFile<List<Ticket>>(@"Tickets.txt");
            tickets.Add(this);
            Persister.WriteToBinaryFile(@"Tickets.txt", tickets, false);
        }

        public void InitialiseTicketId() {
            Persister.WriteToBinaryFile(@"LastTicket.txt", this, false);
        }

        public void InitialiseTickets() {
            List<Ticket> ticketList = new List<Ticket>();
            ticketList.Add(this);
            Persister.WriteToBinaryFile(@"Tickets.txt", ticketList, false);
        }

        public int GetNewTicketId() {
            var ticket = Persister.ReadFromBinaryFile<Ticket>(@"LastTicket.txt");
            return ticket.TicketId() + 1;
        }

        public int TicketId() {
            return _ticketId;
        }

        public string GetTicketType() {
            return _ticketType;
        }

        //public Departure GetDeparture() {
        //    return _departure;
        //}

        public Route GetRoute() {
            return _aRoute;
        }

        public int GetTicketId() {
            return _ticketId;
        }

        public bool HasExpiryDate() {
            if (_expiryDate != null) {
                return true;
            } else {
                return false;
            }
        }

        public bool CheckExpiryDate() {
            if (_expiryDate.CompareTo(DateTime.Now) > 0) {
                SetIsValid(true);
                return true;
            } else {
                SetIsValid(false);
                return false;
            }
        }

        public void SetIsValid(bool isValid) {
            _isValid = isValid;
        }

        public bool GetIsValid() {
            return _isValid;
        }

        public DateTime GetPrintTime() {
            //return DateTime.Now;
            return _printTime;
        }

        public String GetSeatReservation() {
            return _seatReservaton;
        }

        public DateTime GetExpiryDate() {
            //return DateTime.Now;
            return _expiryDate;
        }
    }
}
