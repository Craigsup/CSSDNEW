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

            //var hold = Persister.ReadFromBinaryFile<List<Station>>(@"Stations.txt");
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
            List<Station> stationsTemp = Persister.ReadFromBinaryFile<List<Station>>(@"Stations.txt");
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
    }
}
