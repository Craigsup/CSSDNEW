using System;
using System.Collections.Generic;
using System.IO;

namespace ModifiedTicketingSystem {
    [Serializable]
    public class Station {
        protected DepartureList _departureList;
        protected List<Ticket> _validTicketList;
        protected readonly string _location;

        public Station(DepartureList departureList, string location) {
            _departureList = departureList;
            _location = location;
            if (File.Exists(@_location + "_tickets.txt")) {
                _validTicketList = Persister.ReadFromBinaryFile<List<Ticket>>(@_location + "_tickets.txt");
            } else {
                _validTicketList = new List<Ticket>();
            }
        }

        public Station(string Location) {
            _location = Location;
            if (File.Exists(@_location + "_tickets.txt")) {
                _validTicketList = Persister.ReadFromBinaryFile<List<Ticket>>(@_location + "_tickets.txt");
            } else {
                _validTicketList = new List<Ticket>();
            }
        }

        public DepartureList GetDepartures() {
            return _departureList;
        }

        public string GetLocation() {
            return _location;
        }

        public override string ToString() {
            return _location;
        }

        public Ticket GetTicketByTicketId(int ticketId) {
            Ticket aTicket = new Ticket();
            //check if it is a single ticket
            var singleTickets = Persister.ReadFromBinaryFile<List<Ticket>>(@_location + "_tickets.txt");

            foreach (var ticket in singleTickets) {
                if (ticket.GetTicketId() == ticketId) {
                    return ticket;
                }
            }
            //check if it is a timed ticket
            var timedTickets = Persister.ReadFromBinaryFile<List<Ticket>>(@"Tickets.txt");

            foreach (var ticket in timedTickets) {
                if (ticket.GetTicketId() == ticketId) {
                    return ticket;
                }
            }
            //not used
            return aTicket;
        }

        public void InitialiseTicketList(Ticket ticket) {
            _validTicketList = new List<Ticket>();
            _validTicketList.Add(ticket);
            Persister.WriteToBinaryFile(@_location + "_tickets.txt", _validTicketList, false);
        }

        public void AddTicketToList(Ticket ticket) {
            ticket.InitialiseTicketId();
            _validTicketList = Persister.ReadFromBinaryFile<List<Ticket>>(@_location + "_tickets.txt");
            _validTicketList.Add(ticket);
            Persister.WriteToBinaryFile(@_location + "_tickets.txt", _validTicketList, false);
        }

        public void RemoveTicketFromList(Ticket ticket) {
            _validTicketList = Persister.ReadFromBinaryFile<List<Ticket>>(@_location + "_tickets.txt");
            foreach(var tick in _validTicketList) {
                if(tick.GetTicketId() == ticket.GetTicketId()) {
                    _validTicketList.Remove(tick);
                    break;
                }
            }
            Persister.WriteToBinaryFile(@_location + "_tickets.txt", _validTicketList, false);
        }

        public void RemoveTimedTicketFromList(Ticket ticket) {
            var tickets = Persister.ReadFromBinaryFile<List<Ticket>>(@"Tickets.txt");
            tickets.Remove(ticket);
            Persister.WriteToBinaryFile(@"Tickets.txt", tickets, false);
        }
    }
}
