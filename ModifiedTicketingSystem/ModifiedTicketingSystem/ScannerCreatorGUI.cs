using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModifiedTicketingSystem.Properties;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ModifiedTicketingSystem {
    public partial class ScannerCreatorGUI : Form {
        private Scanner _scanner;
        protected string selectedStation;
        private StationList _stations;
        public ScannerCreatorGUI() {
            InitializeComponent();

            //var hold = ReadFromBinaryFile<List<Station>>(@"Stations.txt");
            //cbStation.DataSource = hold;
            LoadStations();

            foreach (var station in _stations.GetStations()) {
                cbStation.Items.Add(station);
            }
            cbStation.SelectedIndex = 0;

            //cbStation.DataSource = _stations;
            //selectedStation = "Abbey Wood";
        }

        private void LoadStations() {
            List<Station> stationsTemp = ReadFromBinaryFile<List<Station>>(@"Stations.txt");
            _stations = new StationList(stationsTemp);
        }

        private void btnCreateScanner_Click(object sender, EventArgs e) {
            bool radChosen;
            if (radEntry.Checked) {
                radChosen = true;
            } else {
                radChosen = false;
            }
            Station station = _stations.GetStationByLocation(selectedStation);
            _scanner = new Scanner(station, radChosen);
            ScannerFeedbackGUI gui = new ScannerFeedbackGUI(_scanner);
            gui.Show();
        }

        private void cbStation_SelectedIndexChanged(object sender, EventArgs e) {
            selectedStation = cbStation.SelectedItem.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns>(T)binaryFormatter.Deserialize(stream)</returns>
        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }

        /// <summary>
        /// This method takes the List of CustomerAccount object and binary serializes it, allowing the persistence of data.
        /// </summary>
        /// <param name="filePath">This is the file name/output directory.</param>
        /// <param name="objectToWrite">This is the object that gets serialized. Can be of any type.</param>
        /// <param name="append">This flags whether to append the object to the end of the file (if it exists already)</param>
        /// <typeparam name="T">This is the type of T</typeparam>
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }
    }
}
