using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModifiedTicketingSystem.Properties;

namespace ModifiedTicketingSystem {
    public partial class AdminGUI : Form, IObserver {
        private int _account;
        private StationList _stations;
        //private Station _station;

        public AdminGUI() {
            InitializeComponent();

            lblLoginDetails.Visible = true;
            tbPassword.Visible = true;
            tbUsername.Visible = true;
            lblPassword.Visible = true;
            lblUsername.Visible = true;
            btnLogin.Visible = true;
            tbPassword.Text = "password";
            tbUsername.Text = "admin-pete-w";

            LoadStations();

            foreach (var station in _stations.GetStations()) {
                cbStations.Items.Add(station);
                cbSelectStation.Items.Add(station);
            }
            cbStations.SelectedIndex = 0;
            cbSelectStation.SelectedIndex = 0;

        }



        private void LoadStations() {
            List<Station> stationsTemp = ReadFromBinaryFile<List<Station>>(@"Stations.txt");
            _stations = new StationList(stationsTemp);
        }

        public static T ReadFromBinaryFile<T>(string filePath) {
            using (Stream stream = File.Open(filePath, FileMode.Open)) {
                var binaryFormatter = new BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }

        private void ShowLogin() {
            // Show login screen
            ToggleLoginScreen();
            tbUsername.Focus();
        }

        private void ShowHome() {
            HideAll();
            ToggleHomeScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            LoginToAccount(tbUsername.Text, tbPassword.Text);
        }

        private void ToggleLoginScreen() {
            lblLoginDetails.Visible = !lblLoginDetails.Visible;
            tbPassword.Visible = !tbPassword.Visible;
            tbUsername.Visible = !tbUsername.Visible;
            lblPassword.Visible = !lblPassword.Visible;
            lblUsername.Visible = !lblUsername.Visible;
            btnLogin.Visible = !btnLogin.Visible;
        }

        private void ToggleHomeScreen() {
            tcAdminViews.Visible = !tcAdminViews.Visible;
        }

        private void LoginToAccount(string username, string password) {
            _account = new AdminAccount().VerifyLogin(username, password);
            lblUsername.Text = username;
            if (_account > -1) {
                // Hide login screen
                ToggleLoginScreen();

                //Show Home Screen
                ShowHome();


                // Log in successful. Do something.
            }
        }

        private void ConfigureGuiForLogin() {
            PictureBox userPicture = new PictureBox {
                Location = new Point(Width - 150, 15),
                Image = (Image)Resources.ResourceManager.GetObject("_" + _account),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(38, 38),
                Visible = true,
                Name = "account"
            };
            Controls.Add(userPicture);
            Label userName = new Label {
                Name = "lblAccountUsername",
                Text =
                    new CustomerAccount().GetXByAccountId<string>(_account, "username") + "\n£" +
                    string.Format("{0:0000000.00}", new CustomerAccount().GetXByAccountId<string>(_account, "balance")),
                Location = new Point(Width - 150 + userPicture.Width + 3, 15),
                AutoSize = true
            };
            Controls.Add(userName);
        }

        private void HideAll() {
            foreach (var x in Controls.OfType<Button>()) {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<Label>()) {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<PictureBox>()) {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<TextBox>()) {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<ListBox>()) {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<NumericUpDown>()) {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<ComboBox>()) {
                x.Visible = false;
            }
        }

        private void AdminGUI_Load(object sender, EventArgs e) {

        }

        public void Update(int count) {
            lblTicketCount.Text = count.ToString();
        }

        private void cbSelectStation_SelectedIndexChanged(object sender, EventArgs e) {
            lblStartStationEntry.Text = cbSelectStation.SelectedItem.ToString();
            cbStations.SelectedIndex = cbSelectStation.SelectedIndex;
            cbEndStationEntry.Items.Clear();
            foreach (var station in _stations.GetStations()) {
                if (station != cbSelectStation.SelectedItem) {
                    cbEndStationEntry.Items.Add(station);
                }
            }

            var test = new AdminAccount().GetXByAccountId<RouteList>(_account, "routes");
            foreach (var route in test.GetAllRoutes()) {
                lbRoutes.Items.Add(route);
            }
        }

        private void cbStations_SelectedIndexChanged(object sender, EventArgs e) {
            cbSelectStation.SelectedIndex = cbStations.SelectedIndex;
        }
    }
}
