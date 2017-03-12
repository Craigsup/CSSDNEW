using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ModifiedTicketingSystem {
    public partial class Form1 : Form {
        string selectedStartStation, selectedEndStation;

        private Counter counter;
        private RouteList routes;

        /// <summary>
        /// Main GUI for selecting which GUI is wanted.
        /// </summary>
        public Form1() {
            InitializeComponent();
            counter = new Counter();
            routes = new RouteList();
            Setup();

        }

        private void btnAddNewGUI_Click(object sender, EventArgs e) {
            TokenMachineGUI gui = new TokenMachineGUI(counter);
            gui.Show();
            counter.RegisterObserver(gui);
            routes.RegisterObserver(gui);
            routes.NotifyObservers();
        }

        private void button1_Click(object sender, EventArgs e) {
            MobileAppGUI gui = new MobileAppGUI();
            gui.Show();
        }
        
        private void btnScannerCreator_Click(object sender, EventArgs e) {
            ScannerCreatorGUI gui = new ScannerCreatorGUI();
            gui.Show();
        }

        private void btnAdminGUI_Click(object sender, EventArgs e) {
            AdminGUI gui = new AdminGUI(routes);
            gui.Show();
            counter.RegisterObserver(gui);
            routes.RegisterObserver(gui);
            counter.NotifyObservers();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void Setup() {
            CustomerSetup();
            InitialStationLoad();
            TicketSetup();
            AdminSetup();
            RouteSetup();
        }

        private void CustomerSetup() {
            Random rand = new Random();
            var acc0 = new CustomerAccount(0, 0, 0, "GUEST", "djkffsdf", "GUEST ACCOUNT", true);
            var acc1 = new CustomerAccount(rand.Next(1000000, 9999999), 0, 1, "Bob", "password", "Bob Hitler", false);
            var acc2 = new CustomerAccount(rand.Next(1000000, 9999999), 0, 2, "Rudy", "password", "Rudy Smeg", false);
            var acc3 = new CustomerAccount(rand.Next(1000000, 9999999), 0, 3, "Judy", "password", "Judy Spagghettio", false);
            var acc4 = new CustomerAccount(rand.Next(1000000, 9999999), 0, 4, "John", "password", "John Smith", false);
            var acc5 = new CustomerAccount(rand.Next(1000000, 9999999), 0, 5, "Clarence", "password", "Clarence Angel", false);

            AccountList accList = new AccountList(false);
            accList.AddCustomerAccount(acc0);
            accList.AddCustomerAccount(acc1);
            accList.AddCustomerAccount(acc2);
            accList.AddCustomerAccount(acc3);
            accList.AddCustomerAccount(acc4);
            accList.AddCustomerAccount(acc5);

            accList.SaveCustomerData();
        }

        private void InitialStationLoad() {
            var stations = File.ReadAllLines(@"StationNames.txt");
            List<Station> stationsj = new List<Station>();
            foreach (var singleLine in stations) {
                stationsj.Add(new Station(new DepartureList(), singleLine));
            }
            Persister.WriteToBinaryFile<List<Station>>(@"Stations.txt", stationsj, false);
        }

        private StationList LoadStations(StationList _stations) {
            List<Station> stationsTemp = Persister.ReadFromBinaryFile<List<Station>>(@"Stations.txt");
            _stations = new StationList(stationsTemp);
            return _stations;
        }

        public void TicketSetup() {
            selectedStartStation = "Birmingham";
            selectedEndStation = "Birmingham";

            Ticket ticket = new Ticket();
            ticket.InitialiseTicketId();
            ticket.InitialiseTickets();

            List<Station> stationList = Persister.ReadFromBinaryFile<List<Station>>(@"Stations.txt");
            foreach (var station in stationList) {
                station.InitialiseTicketList(ticket);
            }
            //StationList _stations = new StationList();
            //_stations = new StationList(stationList);
        }

        private void AdminSetup() {
            var acc0 = new AdminAccount(0, "admin-pete-w", "password", "Pete Wilkinson", false);

            AccountList accList = new AccountList(true);
            accList.AddAdminAccount(acc0);
            accList.SaveAdminData();
        }

        private void RouteSetup() {
            StationList _stations = new StationList();
            _stations = LoadStations(_stations);
            routes.AddRoute(new Route(_stations.GetStationByLocation("Sheffield"), _stations.GetStationByLocation("Meadowhall"), 25.00m));
            routes.AddRoute(new Route(_stations.GetStationByLocation("Sheffield"), _stations.GetStationByLocation("Leeds"), 15.00m));
            routes.AddRoute(new Route(_stations.GetStationByLocation("Nottingham"), _stations.GetStationByLocation("Sheffield"), 12.50m));
            routes.AddRoute(new Route(_stations.GetStationByLocation("London"), _stations.GetStationByLocation("Brighton"), 23.00m));
            routes.AddRoute(new Route(_stations.GetStationByLocation("Manchester"), _stations.GetStationByLocation("Liverpool"), 27.60m));
            routes.AddRoute(new Route(_stations.GetStationByLocation("Liverpool"), _stations.GetStationByLocation("Sheffield"), 32.00m));
            routes.AddRoute(new Route(_stations.GetStationByLocation("London"), _stations.GetStationByLocation("Birmingham"), 39.50m));
            routes.AddRoute(new Route(_stations.GetStationByLocation("Birmingham"), _stations.GetStationByLocation("London"), 39.50m));
            routes.AddRoute(new Route(_stations.GetStationByLocation("Edinburgh"), _stations.GetStationByLocation("Glasgow"), 10.00m));
            routes.AddRoute(new Route(_stations.GetStationByLocation("Edinburgh"), _stations.GetStationByLocation("London"), 70.00m));
            routes.AddRoute(new Route(_stations.GetStationByLocation("Plymouth"), _stations.GetStationByLocation("Ipswich"), 26.00m));
        }

        private void button2_Click(object sender, EventArgs e) {
            var gui = new AddLanguageGUI();
            gui.ShowDialog();
        }
    }
}
