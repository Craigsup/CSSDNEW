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
        private RouteList routes;

        /// <summary>
        /// The AdminGUI is initialized with the _routes paramater so that it can update the RouteList 
        /// when routes are added.
        /// </summary>
        /// <param name="_routes">The RouteList object that is created in form1</param>
        public AdminGUI(RouteList _routes) {
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
            routes = _routes;

            foreach (var station in _stations.GetStations()) {
                cbStations.Items.Add(station);
                cbSelectStation.Items.Add(station);
            }
            cbStations.SelectedIndex = 0;
            cbSelectStation.SelectedIndex = 0;

        }

        /// <summary>
        /// Load the stations from the Stations.txt file into a class variable.
        /// Only happens during initialization
        /// </summary>
        private void LoadStations() {
            List<Station> stationsTemp = ReadFromBinaryFile<List<Station>>(@"Stations.txt");
            _stations = new StationList(stationsTemp);
        }

        /// <summary>
        /// Reads in serialized data from a file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static T ReadFromBinaryFile<T>(string filePath) {
            using (Stream stream = File.Open(filePath, FileMode.Open)) {
                var binaryFormatter = new BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }

        /// <summary>
        /// changes the page to the homescreen layout.
        /// Only used to change from the login page.
        /// </summary>
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

        /// <summary>
        /// Creates a temporary AdminAccount to use AdminAccount functions (in this case verification of login details).
        /// if the username and password are accepted then _account is assigned as the account id. This will always be
        /// be higher than -1 so verify login returns -1 if the verification failed.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        private void LoginToAccount(string username, string password) {
            _account = new AdminAccount().VerifyLogin(username, password);
            if (_account > -1) {
                // Hide login screen
                ToggleLoginScreen();

                //Show Home Screen
                ShowHome();
            }
        }

        /// <summary>
        /// Hides all controls on the form
        /// </summary>
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


        /// <summary>
        /// Updates the ticket count label on the ticket tab with the new value passed through from the subject. 
        /// </summary>
        /// <param name="count">The amount of tickets that have been bought</param>
        public void Update(int count) {
            lblTicketCount.Text = count.ToString();
        }

        /// <summary>
        /// Empty because the class already has the RouteList object passed through to it.
        /// </summary>
        /// <param name="routes"></param>
        public void Update(List<Route> routes) {

        }

        /// <summary>
        /// When the station is changed in the combo box on the Routes panel it repopulates the list box with the
        /// stations which this station has routes to and updates combo box for selecting an end station when creating
        /// a route to not include the start station.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSelectStation_SelectedIndexChanged(object sender, EventArgs e) {
            lblStartStationEntry.Text = cbSelectStation.SelectedItem.ToString();
            cbStations.SelectedIndex = cbSelectStation.SelectedIndex;
            cbEndStationEntry.Items.Clear();
            foreach (var station in _stations.GetStations()) {
                if (station != cbSelectStation.SelectedItem) {
                    cbEndStationEntry.Items.Add(station);
                }
            }

            lbRoutes.Items.Clear();
            foreach (var route in routes.GetAllRoutes()) {
                if (route.GetStartPoint().ToString() == cbSelectStation.SelectedItem.ToString()) {
                    lbRoutes.Items.Add(route.GetEndPoint().ToString());
                }
            }
        }

        /// <summary>
        /// When the station is changed in the combo box on the Tickets tab it changes the selected station in the
        /// combo box on the Routes tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbStations_SelectedIndexChanged(object sender, EventArgs e) {
            cbSelectStation.SelectedIndex = cbStations.SelectedIndex;
        }

        /// <summary>
        /// Logs the Admin out then the form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminGUI_FormClosing(object sender, FormClosingEventArgs e) {
            _account = new Account().LogoutAdmin(_account);
        }

        /// <summary>
        /// Adds a route to the RouteList using the currently selected station, the selected end station and the
        /// price that has been entered. It then repopulates the list box to include the new route and notifies
        /// all the observers of the new route so that they can be used in the single journey ticket option on
        /// the TokenMachineGUI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateRoute_Click(object sender, EventArgs e) {
            routes.AddRoute(new Route((Station)cbSelectStation.SelectedItem, (Station)cbEndStationEntry.SelectedItem, decimal.Parse(tbPriceEntry.Text)));

            lbRoutes.Items.Clear();
            foreach (var route in routes.GetAllRoutes()) {
                if(route.GetStartPoint().ToString() == cbSelectStation.SelectedItem.ToString()) {
                    lbRoutes.Items.Add(route.GetEndPoint().ToString());
                }
            }
            routes.NotifyObservers();
        }
    }
}
