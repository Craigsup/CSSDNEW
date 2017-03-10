using System.Collections.Generic;

namespace ModifiedTicketingSystem
{
    public class PurchasedTicketList {
        private readonly List<Ticket> _listOfTickets;
        
        public PurchasedTicketList() {
            _listOfTickets = new List<Ticket>();
        }

        public void AddTicket(Ticket x) {
            _listOfTickets.Add(x);
        }

        public Ticket GetTicketById(int id) {
            return null;
        }

        public Ticket GetTicketByDeparture(Departure x) {
            return null;
        }

        public Ticket GetTicketByRoute(Route x) {
            return null;
        }

    }
}