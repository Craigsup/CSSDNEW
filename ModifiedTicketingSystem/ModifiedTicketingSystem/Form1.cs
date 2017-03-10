using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ModifiedTicketingSystem {
    public partial class Form1 : Form {
        string selectedStartStation, selectedEndStation;

        private Counter counter;
        public Form1() {
            InitializeComponent();
            counter = new Counter();
            Setup();

        }

        private void btnAddNewGUI_Click(object sender, EventArgs e) {
            TokenMachineGUI gui = new TokenMachineGUI(counter);
            gui.Show();
            counter.RegisterObserver(gui);
        }

        private void button1_Click(object sender, EventArgs e) {
            MobileAppGUI gui = new MobileAppGUI();
            gui.Show();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }


        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false) {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create)) {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        private void Setup() {
            CustomerSetup();
            InitialStationLoad();
            TicketSetup();
            AdminSetup();
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
            WriteToBinaryFile<List<Station>>(@"Stations.txt", stationsj, false);
        }

        private StationList LoadStations(StationList _stations) {
            List<Station> stationsTemp = ReadFromBinaryFile<List<Station>>(@"Stations.txt");
            _stations = new StationList(stationsTemp);
            return _stations;
        }

        public void TicketSetup() {
            selectedStartStation = "Birmingham";
            selectedEndStation = "Birmingham";

            Ticket ticket = new Ticket();
            ticket.InitialiseTicketId();
            ticket.InitialiseTickets();

            List<Station> stationList = ReadFromBinaryFile<List<Station>>(@"Stations.txt");
            foreach (var station in stationList) {
                station.InitialiseTicketList(ticket);
            }
            //StationList _stations = new StationList();
            //_stations = new StationList(stationList);
        }

        private void AdminSetup() {
            StationList _stations = new StationList();
            _stations = LoadStations(_stations);
            var acc0 = new AdminAccount(0, "admin-pete-w", "password", "Pete Wilkinson", false);
            acc0.NewRoute(_stations.GetStationByLocation("Sheffield"), _stations.GetStationByLocation("London"), 25.00m);

            AccountList accList = new AccountList(true);
            accList.AddAdminAccount(acc0);
            accList.SaveAdminData();
        }


        public static T ReadFromBinaryFile<T>(string filePath) {
            using (Stream stream = File.Open(filePath, FileMode.Open)) {
                var binaryFormatter = new BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }


        private void btnScannerCreator_Click(object sender, EventArgs e) {
            ScannerCreatorGUI gui = new ScannerCreatorGUI();
            gui.Show();
        }

        private void btnAdminGUI_Click(object sender, EventArgs e) {
            AdminGUI gui = new AdminGUI();
            gui.Show();
            counter.RegisterObserver(gui);
            counter.NotifyObservers();
        }
    }
}
