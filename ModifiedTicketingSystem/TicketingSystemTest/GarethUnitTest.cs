using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModifiedTicketingSystem;
using System.Collections.Generic;

namespace TicketingSystemTest
{
    [TestClass]
    public class GarethUnitTest
    {
        //if the scanner function ValidateTicket is true barrier is opened inside the function otherwise the barrier remains closed
        // SINGLE JOURNEY TICKET TESTS
        [TestMethod]
        public void SingleJourneyTicketAtCorrectEntryScannerTest() {
            //setup for ticket and file creation
            Ticket initTicket = new Ticket();
            initTicket.InitialiseTicketId();

            CustomerAccount bobAccount = new CustomerAccount(1, 38.50m, 1, "Bob", "password", "Bob Shanks", false);
            AccountList accList = new AccountList(false);
            accList.AddCustomerAccount(bobAccount);
            accList.SaveCustomerData();

            DepartureList departureList = new DepartureList();
            departureList.AddDeparture(new Departure(new Station("Sheffield"), new DateTime(2017, 02, 20, 15, 05, 0)));

            Station startStation = new Station(departureList, "Newcastle");
            Station endStation = new Station(new DepartureList(), "Sheffield");

            RouteList startStationRouteList = new RouteList();
            startStationRouteList.AddRoute(new Route(startStation, endStation, 2.70m));

            Route route = startStationRouteList.GetRouteByStations(startStation, endStation);

            Ticket ticket = new Ticket(route, true, DateTime.Now, null, "single", bobAccount.GetAccountId());
            ticket.InitialiseTicketId();
            startStation.InitialiseTicketList(ticket);
            endStation.InitialiseTicketList(ticket);

            //create an entry scanner with the correct start station
            Scanner scanner = new Scanner(startStation, true);

            scanner.AddScannedTicket(ticket);
            Assert.IsTrue(scanner.ValidateTicket());
        }

        [TestMethod]
        public void SingleJourneyTicketAtIncorrectEntryScannerTest() {
            //setup for ticket and file creation
            Ticket initTicket = new Ticket();
            initTicket.InitialiseTicketId();

            CustomerAccount bobAccount = new CustomerAccount(1, 38.50m, 1, "Bob", "password", "Bob Shanks", false);
            AccountList accList = new AccountList(false);
            accList.AddCustomerAccount(bobAccount);
            accList.SaveCustomerData();

            DepartureList departureList = new DepartureList();
            departureList.AddDeparture(new Departure(new Station("Sheffield"), new DateTime(2017, 02, 20, 15, 05, 0)));

            Station startStation = new Station(departureList, "Newcastle");
            Station endStation = new Station(new DepartureList(), "Sheffield");

            RouteList startStationRouteList = new RouteList();
            startStationRouteList.AddRoute(new Route(startStation, endStation, 2.70m));

            Route route = startStationRouteList.GetRouteByStations(startStation, endStation);

            Ticket ticket = new Ticket(route, true, DateTime.Now, null, "single", bobAccount.GetAccountId());
            ticket.InitialiseTicketId();
            startStation.InitialiseTicketList(ticket);
            endStation.InitialiseTicketList(ticket);

            //create an entry scanner with an incorrect start station
            Scanner scanner = new Scanner(endStation, true);

            scanner.AddScannedTicket(ticket);
            Assert.IsFalse(scanner.ValidateTicket());
        }

        [TestMethod]
        public void SingleJourneyTicketAtCorrectExitScannerTest() {
            //setup for ticket and file creation
            Ticket initTicket = new Ticket();
            initTicket.InitialiseTicketId();

            CustomerAccount bobAccount = new CustomerAccount(1, 38.50m, 1, "Bob", "password", "Bob Shanks", false);
            AccountList accList = new AccountList(false);
            accList.AddCustomerAccount(bobAccount);
            accList.SaveCustomerData();

            DepartureList departureList = new DepartureList();
            departureList.AddDeparture(new Departure(new Station("Sheffield"), new DateTime(2017, 02, 20, 15, 05, 0)));

            Station startStation = new Station(departureList, "Newcastle");
            Station endStation = new Station(new DepartureList(), "Sheffield");

            RouteList startStationRouteList = new RouteList();
            startStationRouteList.AddRoute(new Route(startStation, endStation, 2.70m));

            Route route = startStationRouteList.GetRouteByStations(startStation, endStation);

            Ticket ticket = new Ticket(route, true, DateTime.Now, null, "single", bobAccount.GetAccountId());
            ticket.InitialiseTicketId();
            startStation.InitialiseTicketList(ticket);
            endStation.InitialiseTicketList(ticket);

            //create an exit scanner with the correct end station
            Scanner scanner = new Scanner(endStation, false);

            scanner.AddScannedTicket(ticket);
            Assert.IsTrue(scanner.ValidateTicket());
        }

        [TestMethod]
        public void SingleJourneyTicketAtIncorrectExitScannerTest() {
            //setup for ticket and file creation
            Ticket initTicket = new Ticket();
            initTicket.InitialiseTicketId();

            CustomerAccount bobAccount = new CustomerAccount(1, 38.50m, 1, "Bob", "password", "Bob Shanks", false);
            AccountList accList = new AccountList(false);
            accList.AddCustomerAccount(bobAccount);
            accList.SaveCustomerData();

            DepartureList departureList = new DepartureList();
            departureList.AddDeparture(new Departure(new Station("Sheffield"), new DateTime(2017, 02, 20, 15, 05, 0)));

            Station startStation = new Station(departureList, "Newcastle");
            Station endStation = new Station(new DepartureList(), "Sheffield");

            RouteList startStationRouteList = new RouteList();
            startStationRouteList.AddRoute(new Route(startStation, endStation, 2.70m));

            Route route = startStationRouteList.GetRouteByStations(startStation, endStation);

            Ticket ticket = new Ticket(route, true, DateTime.Now, null, "single", bobAccount.GetAccountId());
            ticket.InitialiseTicketId();
            startStation.InitialiseTicketList(ticket);
            endStation.InitialiseTicketList(ticket);

            //create an exit scanner with an incorrect end station
            Scanner scanner = new Scanner(startStation, false);

            scanner.AddScannedTicket(ticket);
            Assert.IsFalse(scanner.ValidateTicket());
        }

        [TestMethod]
        public void SingleJourneyTicketAtCorrectExitScannerReuseTest() {
            //setup for ticket and file creation
            Ticket initTicket = new Ticket();
            initTicket.InitialiseTicketId();

            CustomerAccount bobAccount = new CustomerAccount(1, 38.50m, 1, "Bob", "password", "Bob Shanks", false);
            AccountList accList = new AccountList(false);
            accList.AddCustomerAccount(bobAccount);
            accList.SaveCustomerData();

            DepartureList departureList = new DepartureList();
            departureList.AddDeparture(new Departure(new Station("Sheffield"), new DateTime(2017, 02, 20, 15, 05, 0)));

            Station startStation = new Station(departureList, "Newcastle");
            Station endStation = new Station(new DepartureList(), "Sheffield");

            RouteList startStationRouteList = new RouteList();
            startStationRouteList.AddRoute(new Route(startStation, endStation, 2.70m));

            Route route = startStationRouteList.GetRouteByStations(startStation, endStation);

            Ticket ticket = new Ticket(route, true, DateTime.Now, null, "single", bobAccount.GetAccountId());
            ticket.InitialiseTicketId();
            startStation.InitialiseTicketList(ticket);
            endStation.InitialiseTicketList(ticket);

            //create an exit scanner with the correct end station
            Scanner scanner = new Scanner(endStation, false);

            scanner.AddScannedTicket(ticket);
            scanner.ValidateTicket();

            //try to use the ticket at the same barrier again (should fail)
            Assert.IsFalse(scanner.ValidateTicket());
        }

        //TIMED PASS TESTS
        [TestMethod]
        public void TimedPassInDateAtEntryBarrier() {
            //setup for ticket and file creation
            Ticket initTicket = new Ticket();
            initTicket.InitialiseTicketId();

            CustomerAccount bobAccount = new CustomerAccount(1, 38.50m, 1, "Bob", "password", "Bob Shanks", false);
            AccountList accList = new AccountList(false);
            accList.AddCustomerAccount(bobAccount);
            accList.SaveCustomerData();

            Station startStation = new Station("Newcastle");
            Station endStation = new Station("Sheffield");

            Ticket ticket = new Ticket(true, DateTime.Now.AddDays(-4), "timed", DateTime.Now.AddDays(3), bobAccount.GetAccountId());
            ticket.InitialiseTicketId();
            ticket.InitialiseTickets();

            //create an entry barrier with any station
            Scanner scanner = new Scanner(new Station(new DepartureList(), "Birmingham"), true);

            scanner.AddScannedTicket(ticket);
            Assert.IsTrue(scanner.ValidateTicket());
        }

        //Should not open the entry barrier
        [TestMethod]
        public void TimedPassExpiredAtEntryBarrier() {
            //setup for ticket and file creation
            Ticket initTicket = new Ticket();
            initTicket.InitialiseTicketId();

            CustomerAccount bobAccount = new CustomerAccount(1, 38.50m, 1, "Bob", "password", "Bob Shanks", false);
            AccountList accList = new AccountList(false);
            accList.AddCustomerAccount(bobAccount);
            accList.SaveCustomerData();

            Station startStation = new Station("Newcastle");
            Station endStation = new Station("Sheffield");

            Ticket ticket = new Ticket(true, DateTime.Now.AddDays(-8), "timed", DateTime.Now.AddDays(-1), bobAccount.GetAccountId());
            ticket.InitialiseTicketId();
            ticket.InitialiseTickets();

            //create an entry barrier with any station
            Scanner scanner = new Scanner(new Station(new DepartureList(), "Birmingham"), true);

            scanner.AddScannedTicket(ticket);
            Assert.IsFalse(scanner.ValidateTicket());
        }

        //Should open the exit barrier
        [TestMethod]
        public void TimedPassInDateAtExitBarrier() {
            //setup for ticket and file creation
            Ticket initTicket = new Ticket();
            initTicket.InitialiseTicketId();

            CustomerAccount bobAccount = new CustomerAccount(1, 38.50m, 1, "Bob", "password", "Bob Shanks", false);
            AccountList accList = new AccountList(false);
            accList.AddCustomerAccount(bobAccount);
            accList.SaveCustomerData();

            Station startStation = new Station("Newcastle");
            Station endStation = new Station("Sheffield");

            Ticket ticket = new Ticket(true, DateTime.Now.AddDays(-4), "timed", DateTime.Now.AddDays(3), bobAccount.GetAccountId());
            ticket.InitialiseTicketId();
            ticket.InitialiseTickets();

            //create an exit barrier with any station
            Scanner scanner = new Scanner(new Station(new DepartureList(), "Birmingham"), false);

            scanner.AddScannedTicket(ticket);
            Assert.IsTrue(scanner.ValidateTicket());
        }

        //Should not open the exit barrier
        [TestMethod]
        public void TimedPassExpiredAtExitBarrier() {
            //setup for ticket and file creation
            Ticket initTicket = new Ticket();
            initTicket.InitialiseTicketId();

            CustomerAccount bobAccount = new CustomerAccount(1, 38.50m, 1, "Bob", "password", "Bob Shanks", false);
            AccountList accList = new AccountList(false);
            accList.AddCustomerAccount(bobAccount);
            accList.SaveCustomerData();

            Station startStation = new Station("Newcastle");
            Station endStation = new Station("Sheffield");

            Ticket ticket = new Ticket(true, DateTime.Now.AddDays(-8), "timed", DateTime.Now.AddDays(-1), bobAccount.GetAccountId());
            ticket.InitialiseTicketId();
            ticket.InitialiseTickets();

            //create an exit barrier with any station
            Scanner scanner = new Scanner(new Station(new DepartureList(), "Birmingham"), false);

            scanner.AddScannedTicket(ticket);
            Assert.IsFalse(scanner.ValidateTicket());
        }
    }
}
