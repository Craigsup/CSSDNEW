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

        /// <summary>
        /// Ticket constructor for a single journey ticket
        /// </summary>
        /// <param name="aRoute"></param>
        /// <param name="isValid"></param>
        /// <param name="printTime"></param>
        /// <param name="seatReservation"></param>
        /// <param name="ticketType"></param>
        /// <param name="accountId"></param>
        public Ticket(Route aRoute, bool isValid, DateTime printTime, string seatReservation, string ticketType, int accountId) {
            _ticketId = GetNewTicketId();
            _aRoute = aRoute;
            _isValid = isValid;
            _printTime = printTime;
            _seatReservaton = seatReservation;
            _ticketType = ticketType;
            _accountId = accountId;
        }

        /// <summary>
        /// Ticket constructor for a timed pass
        /// </summary>
        /// <param name="isValid"></param>
        /// <param name="printTime"></param>
        /// <param name="ticketType"></param>
        /// <param name="expiryDate"></param>
        /// <param name="accountId"></param>
        public Ticket(bool isValid, DateTime printTime, string ticketType, DateTime expiryDate, int accountId) {
            _ticketId = GetNewTicketId();
            _isValid = isValid;
            _printTime = printTime;
            _ticketType = ticketType;
            _expiryDate = expiryDate;
            _accountId = accountId;
        }

        /// <summary>
        /// ticket constructor for unused ticket to create files and set first ticket id from
        /// </summary>
        public Ticket() {
            _ticketId = 0;
            _isValid = false;
        }

        /// <summary>
        /// A method that calls InitialiseTicketId() and then reads existing tickets into a list of the ticket class and then adds the ticket to the list and writes the list to the file.
        /// </summary>
        public void SerialiseTickets() {
            InitialiseTicketId();
            var tickets = Persister.ReadFromBinaryFile<List<Ticket>>(@"Tickets.txt");
            tickets.Add(this);
            Persister.WriteToBinaryFile(@"Tickets.txt", tickets, false);
        }

        /// <summary>
        /// A method that writes a ticket to LastTicket.txt which is used to keep ticketids unique
        /// </summary>
        public void InitialiseTicketId() {
            Persister.WriteToBinaryFile(@"LastTicket.txt", this, false);
        }

        /// <summary>
        /// a method that creates a new list of the ticket class, adds the ticket to the list and then writes the list to file
        /// </summary>
        public void InitialiseTickets() {
            List<Ticket> ticketList = new List<Ticket>();
            ticketList.Add(this);
            Persister.WriteToBinaryFile(@"Tickets.txt", ticketList, false);
        }

        /// <summary>
        /// a method that reads in a ticket from file and then returns the ticketId + 1
        /// </summary>
        /// <returns>the _ticketId integer + 1</returns>
        public int GetNewTicketId() {
            var ticket = Persister.ReadFromBinaryFile<Ticket>(@"LastTicket.txt");
            return ticket.TicketId() + 1;
        }

        /// <summary>
        /// A getter method which returns the int _ticketId
        /// </summary>
        /// <returns>_ticketId</returns>
        public int TicketId() {
            return _ticketId;
        }

        /// <summary>
        /// A getter method which returns the string _ticketType
        /// </summary>
        /// <returns>_ticketType</returns>
        public string GetTicketType() {
            return _ticketType;
        }

        //public Departure GetDeparture() {
        //    return _departure;
        //}

        /// <summary>
        /// A getter method which returns the Route _aRoute
        /// </summary>
        /// <returns>_aRoute</returns>
        public Route GetRoute() {
            return _aRoute;
        }

        /// <summary>
        /// A getter method which returns the int _ticketId
        /// </summary>
        /// <returns>_ticketId</returns>
        public int GetTicketId() {
            return _ticketId;
        }

        /// <summary>
        /// a method that checks that a ticket has a DateTime object _expirydate set
        /// </summary>
        /// <returns>true or false</returns>
        public bool HasExpiryDate() {
            if (_expiryDate != null) {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// a method that checks that the DateTime object _expiryDate is greater than the current date and time and then sets the tickets validity
        /// </summary>
        /// <returns>true or false</returns>
        public bool CheckExpiryDate() {
            if (_expiryDate.CompareTo(DateTime.Now) > 0) {
                SetIsValid(true);
                return true;
            } else {
                SetIsValid(false);
                return false;
            }
        }

        /// <summary>
        /// A setter method for the boolean _isValid
        /// </summary>
        /// <param name="isValid"></param>
        public void SetIsValid(bool isValid) {
            _isValid = isValid;
        }

        /// <summary>
        /// A getter method that returns the boolean _isValid
        /// </summary>
        /// <returns>_isValid</returns>
        public bool GetIsValid() {
            return _isValid;
        }

        /// <summary>
        /// A getter method that returns the DateTime object _printTime
        /// </summary>
        /// <returns>_printTime</returns>
        public DateTime GetPrintTime() {
            //return DateTime.Now;
            return _printTime;
        }

        /// <summary>
        /// a getter method that returns the string _seatReservation
        /// </summary>
        /// <returns>_seatReservation</returns>
        public String GetSeatReservation() {
            return _seatReservaton;
        }

        /// <summary>
        /// a getter method that returns the DateTime object _expiryDate
        /// </summary>
        /// <returns>_expiryDate</returns>
        public DateTime GetExpiryDate() {
            //return DateTime.Now;
            return _expiryDate;
        }
    }
}
