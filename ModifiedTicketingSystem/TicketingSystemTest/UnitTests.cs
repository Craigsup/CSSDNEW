using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModifiedTicketingSystem;
using System.Windows;
using System.Reflection;

namespace TicketingSystemTest {
    [TestClass]
    public class UnitTests {
        /*
         * This unit test will create two barriers for which a user will be loaded in 
         * and scanned through the barriers to simulate them taking a train ride.
         */

        [TestMethod]
        public void EntryScanner() {
            // Bob's smart card
            CustomerAccount bobAccount = new CustomerAccount(1, 38.50m, 1, "Bob", "password", "Bob Shanks", false);
            SmartCard bobSmartCard = new SmartCard(bobAccount.GetCardId());
            bobSmartCard.SetScannedTime(new DateTime(2017, 02, 20, 15, 0, 0));

            DepartureList departureList = new DepartureList();
            departureList.AddDeparture(new Departure(new Station("Sheffield"), new DateTime(2017, 02, 20, 15, 05, 0)));

            Station startStation = new Station(departureList, "Newcastle");
            Station endStation = new Station(new DepartureList(), "Sheffield");
            RouteList startStationRouteList = new RouteList();
            startStationRouteList.AddRoute(new Route(startStation, endStation, 2.70m));
            Scanner scannerA = new Scanner(startStation, true, new AccountList(new List<CustomerAccount> { bobAccount }), startStationRouteList);

            Assert.IsTrue(scannerA.AddScannedCard(bobSmartCard));
        }

        [TestMethod]
        public void ExitScanner() {
            // Bob's smart card
            CustomerAccount bobAccount = new CustomerAccount(1, 38.50m, 1, "Bob", "password", "Bob Shanks", false);
            //bobAccount.SetFreeTravel(true);
            SmartCard bobSmartCard = new SmartCard(bobAccount.GetCardId());
            bobSmartCard.SetScannedTime(new DateTime(2017, 02, 20, 15, 0, 0));

            DepartureList departureList = new DepartureList();
            departureList.AddDeparture(new Departure(new Station("Sheffield"), new DateTime(2017, 02, 20, 15, 05, 0)));

            Station startStation = new Station(departureList, "Newcastle");
            Station endStation = new Station(new DepartureList(), "Sheffield");
            RouteList startStationRouteList = new RouteList();
            startStationRouteList.AddRoute(new Route(startStation, endStation, 2.70m));
            Scanner scannerA = new Scanner(endStation, false, new AccountList(new List<CustomerAccount> {bobAccount}),
                startStationRouteList);
            bobAccount.SetStartPoint(startStation);


            Assert.IsTrue(scannerA.AddScannedCard(bobSmartCard));
        }

        [TestMethod]
        public void AccountListTest() {
            AccountList _accounts = new AccountList(false);
            CustomerAccount bobAccount = new CustomerAccount(1, 38.50m, 1, "Bob", "password", "Bob Shanks", false);
            _accounts.AddCustomerAccount(bobAccount);
            Assert.AreEqual(_accounts.GetAccountByUsername("Bob"), bobAccount);
            Assert.AreEqual(_accounts.GetAccountById(1), bobAccount);
            Assert.AreEqual(_accounts.GetAccountByCardId(1), bobAccount);

            _accounts.SaveCustomerData();
            AccountList _accountsCopy = new AccountList(false);
            _accountsCopy.LoadCustomerData();

            var acc1 = _accounts.ToList();
            var acc2 = _accountsCopy.ToList();
            for (int i = 0; i < acc1.Count; i++) {
                Assert.IsTrue(acc1[i].ToString() == acc2[i].ToString());
            }

            _accounts.GetAccountById(bobAccount.GetId()).SetFreeTravel(true);
            _accounts.UpdateAccount(_accounts.GetAccountById(bobAccount.GetId()));
            _accounts.GetAccountById(bobAccount.GetId()).SetFreeTravel(false);
            _accounts.LoadCustomerData();
            Assert.IsTrue(_accounts.GetAccountById(bobAccount.GetId()).GetFreeTravel());
        }

        [TestMethod]
        public void BarrierTest() {
            Barrier _barrier = new Barrier();
            _barrier.OpenBarrier();
            Assert.IsTrue(_barrier.CheckIsOpen());
            _barrier.CloseBarrier();
            Assert.IsFalse(_barrier.CheckIsOpen());
        }

        [TestMethod]
        public void RouteTest() {
            DepartureList departureList = new DepartureList();
            departureList.AddDeparture(new Departure(new Station("Sheffield"), new DateTime(2017, 02, 20, 15, 05, 0)));

            Station startStation = new Station(departureList, "Newcastle");
            Station endStation = new Station(new DepartureList(), "Sheffield");
            decimal amount = 67.24m;
            Route _route = new Route(startStation, endStation, amount);
            Assert.AreEqual(_route.GetStartPoint(), startStation);
            Assert.AreEqual(_route.GetEndPoint(), endStation);
            Assert.AreEqual(_route.GetPrice(), amount);
        }

        [TestMethod]
        public void JourneyTest() {
            DepartureList departureList = new DepartureList();
            departureList.AddDeparture(new Departure(new Station("Sheffield"), new DateTime(2017, 02, 20, 15, 05, 0)));

            Station startStation = new Station(departureList, "Newcastle");
            Station endStation = new Station(new DepartureList(), "Sheffield");
            decimal amount = 67.24m;
            Route _route = new Route(startStation, endStation, amount);
            DateTime _time = DateTime.Now;
            Journey _journey = new Journey(_route, _time);
            Assert.AreEqual(_journey.GetRoute(), _route);
            Assert.AreEqual(_journey.GetCompletionTime(), _time);
        }
    }
}
