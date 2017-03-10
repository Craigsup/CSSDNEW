using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModifiedTicketingSystem.Properties;
using System.Collections;

namespace ModifiedTicketingSystem {
    public partial class TokenMachineGUI : Form, IObserver {
        private TokenMachine _machine;
        private Language _lang;
        private LanguageList _langList;
        private string[] stations = new string[2533];
        private int _account;
        private Stack<string> _actionStack = new Stack<string>();
        private List<int> nudAcceptedValues = new List<int> { 1, 3, 5, 7, 10, 28 };
        private decimal dayPassPrice;
        private int selection;
        private Counter counter;
        private Random rand = new Random();
        string selectedStartStation, selectedEndStation;


        /// <summary>
        /// 
        /// </summary>
        public TokenMachineGUI(Counter _counter) {
            InitializeComponent();

            //SetupFile();
            dayPassPrice = decimal.Round((decimal)rand.NextDouble(), 2) * 10;
            _machine = new TokenMachine(dayPassPrice);
            //var hold = ReadFromBinaryFile<List<Station>>(@"Stations.txt");
            //cbStartStation.DataSource = hold;
            //cbStartStation.Text = "location";
            stations = File.ReadAllLines(@"UK_TrainStations.txt");
            cbStartStation.DataSource = stations;
            cbEndStation.BindingContext = new BindingContext();
            cbEndStation.DataSource = stations;
            //cbEndStation.DataSource = cbStartStation.DataSource;

            SetupLanguages();
            DisplayLangList();
            counter = _counter;
        }



        public static T ReadFromBinaryFile<T>(string filePath) {
            using (Stream stream = File.Open(filePath, FileMode.Open)) {
                var binaryFormatter = new BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }

        private void DisplayLangList() {
            // Show Select Option Screen
            ToggleLanguageScreen(true);
        }

        private void SetActiveLanguage() {
            DisplayStartOptions();
            pbHome.Visible = true;
            pbBack.Visible = true;
        }

        private void DisplayStartOptions() {
            // Hide Select Option Screen
            ToggleLanguageScreen(false);

            // Show Select Account Screen
            ToggleAccountOptions(true);
        }

        private void GuestLogin() {
            // Hide Select Account Screen
            ToggleAccountOptions(false);

            // Call DisplayGuestOptions
            DisplayGuestOptions();
        }

        private void DisplayGuestOptions() {
            // Show Select Journey Type Screen
            ToggleJourneyOptions(true);
        }

        private void DisplaySingleJourney() {
            // Hide Joruney Options
            ToggleJourneyOptions(false);

            // Show Timed Pass Screen
            ToggleSingleJourney(true);
        }

        private void DisplayTimedPass() {
            // Hide Joruney Options
            ToggleJourneyOptions(false);

            // Show Timed Pass Screen
            ToggleTimedPass(true);
        }

        private void DisplayPaymentOptions() {
            // Hide Timed Pass Screen
            ToggleTimedPass(false);

            // Show Payment Screen
            TogglePaymentScreen(true);
        }

        private void DisplayPaymentOptions2() {
            // Hide Single Journey Screen
            ToggleSingleJourney(false);

            // Show Payment Screen
            TogglePaymentScreen(true);
        }

        private void DisplayFinalMessage() {
            // Hide Timed Pass Screen
            TogglePaymentScreen(false);

            // Show Payment Screen
            FinalMessage();
        }

        private void createTicket() {
            StationList stationList = new StationList();
            //for new build
            //Station startStation = stationList.GetStationByLocation(selectedStartStation.GetLocation());
            //Station endStation = stationList.GetStationByLocation(selectedEndStation.GetLocation());
            Station startStation = stationList.GetStationByLocation(selectedStartStation);
            Station endStation = stationList.GetStationByLocation(selectedEndStation);
            Route route = new Route(startStation, endStation, Convert.ToDecimal(tbSingleJourneyPrice.Text.Substring(1)));
            Ticket ticket = new Ticket(route, true, DateTime.Now, null, "single", _account);
            startStation.AddTicketToList(ticket);
            endStation.AddTicketToList(ticket);
            ticket.InitialiseTicketId();
        }

        private void createTimedTicket() {
            for (int i = 0; i <= (nudTicketQuantity.Value - 1); i++) {
                DateTime date = DateTime.Now.AddDays((int)nudTimedPass.Value);
                Ticket ticket = new Ticket(true, DateTime.Now, "timed", date, _account);
                ticket.SerialiseTickets();
            }
        }

        private void Login() {
            // Hide Select Account Screen
            ToggleAccountOptions(false);
            // Show Login Screen
            DisplayLoginScreen();
        }

        private void DisplayLoginScreen() {
            ToggleLoginScreen(true);
        }

        private void DisplayLoginOptions() {
            ToggleLoginScreen(false);
            ToggleJourneyOptions(true);
        }

        private void InsertMoney() {

        }

        private void SelectTicketType() {

        }

        private void SelectRoute() {

        }

        private void SelectDeparture() {

        }

        private void SelectPassDays() {

        }

        /*
         * Custom Toggle Functions to simplify screens
         */
        private void ToggleAccountOptions(bool show) {
            if (_actionStack.Count > 0 && _actionStack.Peek() != "AccountOptions") {
                _actionStack.Push("AccountOptions");
            }
            lblAccountTitle.Visible = !lblAccountTitle.Visible;
            lbAccountTypes.Visible = !lbAccountTypes.Visible;
            pbBack.Visible = !pbBack.Visible;
            pbHome.Visible = !pbHome.Visible;

            if (show) {
                lbAccountTypes.Focus();
                if (lbAccountTypes.Items.Count < 1) {
                    lblAccountTitle.Text = _lang.GetOptionText();
                    foreach (var option in _lang.GetGuestOptions()) {
                        lbAccountTypes.Items.Add(option);
                    }
                }
                if (lbAccountTypes.Items.Count > 0) {
                    lbAccountTypes.SelectedIndex = 0;
                }
            }
        }

        private void ToggleLanguageScreen(bool show) {
            if (_actionStack.Count == 0) {
                _actionStack.Push("LanguageScreen");
            }
            lbLanguages.Visible = !lbLanguages.Visible;
            lblLanguageTitle.Visible = !lblLanguageTitle.Visible;
            pbHome.Visible = false;
            pbBack.Visible = false;

            if (show) {
                pbHome.Visible = false;
                pbBack.Visible = false;
                lbLanguages.Focus();
                if (lbLanguages.Items.Count < 1) {
                    var tempString = "";
                    var gap = lbLanguages.Location.Y - lblLanguageTitle.Location.Y;
                    foreach (var language in _langList.GetAllLanguages()) {
                        lbLanguages.Items.Add(language);
                        //tempString += language.GetStarterOption() + "\n";
                        //lbLanguages.Location = new Point(lbLanguages.Location.X, lbLanguages.Location.Y + 19);
                    }

                    //lblLanguageTitle.Text = _lang.GetStarterOption();
                }
                if (lbLanguages.Items.Count > 0) {
                    lbLanguages.SelectedIndex = 0;
                }
            }
        }

        private void ToggleJourneyOptions(bool show) {
            if (_actionStack.Count > 0 && _actionStack.Peek() != "JourneyOptions") {
                _actionStack.Push("JourneyOptions");
            }
            lblJourneyTitle.Visible = !lblJourneyTitle.Visible;
            lbJourneyType.Visible = !lbJourneyType.Visible;
            pbBack.Visible = !pbBack.Visible;
            pbHome.Visible = !pbHome.Visible;

            if (show) {
                lbJourneyType.Focus();
                if (lbJourneyType.Items.Count < 1) {
                    lblJourneyTitle.Text = _lang.GetOptionText();
                    foreach (var option in _lang.GetTicketType()) {
                        lbJourneyType.Items.Add(option);
                    }
                }
                if (lbJourneyType.Items.Count > 0) {
                    lbJourneyType.SelectedIndex = 0;
                }
            }
        }

        private void ToggleSingleJourney(bool show) {
            if (_actionStack.Count > 0 && _actionStack.Peek() != "SingleJourney") {
                _actionStack.Push("SingleJourney");
            }
            lblStartStation.Visible = !lblStartStation.Visible;
            lblEndStation.Visible = !lblEndStation.Visible;
            lblSingleJourneyPrice.Visible = !lblSingleJourneyPrice.Visible;
            cbStartStation.Visible = !cbStartStation.Visible;
            cbEndStation.Visible = !cbEndStation.Visible;
            tbSingleJourneyPrice.Text = "£5.00";
            tbSingleJourneyPrice.Visible = !tbSingleJourneyPrice.Visible;
            pbBack.Visible = !pbBack.Visible;
            pbHome.Visible = !pbHome.Visible;

            if (show) {
                cbStartStation.Focus();

            }
        }

        private void ToggleTimedPass(bool show) {
            if (_actionStack.Count > 0 && _actionStack.Peek() != "TimedPass") {
                _actionStack.Push("TimedPass");
            }
            nudTimedPass.Visible = !nudTimedPass.Visible;
            lblTimedPassTitle.Visible = !lblTimedPassTitle.Visible;
            lblNudQuantity.Visible = !lblNudQuantity.Visible;
            nudTicketQuantity.Visible = !nudTicketQuantity.Visible;
            pbBack.Visible = !pbBack.Visible;
            pbHome.Visible = !pbHome.Visible;
            lblTimedPassPrice.Visible = !lblTimedPassPrice.Visible;
            tbTotalPrice.Visible = !tbTotalPrice.Visible;

            if (show) {
                nudTimedPass.Focus();
                nudTimedPass.Value = 1;
                nudTicketQuantity.Value = 1;
            }
        }

        private void TogglePaymentScreen(bool show) {
            if (_actionStack.Count > 0 && _actionStack.Peek() != "PaymentScreen") {
                _actionStack.Push("PaymentScreen");
            }

            lblPaymentMethods.Visible = !lblPaymentMethods.Visible;
            lbPaymentMethods.Visible = !lbPaymentMethods.Visible;
            pbBack.Visible = !pbBack.Visible;
            pbHome.Visible = !pbHome.Visible;

            if (show) {
                lbPaymentMethods.Focus();
                if (lbPaymentMethods.Items.Count < 1) {
                    lblPaymentMethods.Text = _lang.GetPaymentOptions()[0];
                    if (_account > 0) {
                        foreach (
                            var option in _lang.GetPaymentOptions().GetRange(1, _lang.GetPaymentOptions().Count - 1)) {
                            lbPaymentMethods.Items.Add(option);
                        }
                    } else {
                        foreach (var option in _lang.GetPaymentOptions().GetRange(1, _lang.GetPaymentOptions().Count - 2)) {
                            lbPaymentMethods.Items.Add(option);
                        }
                    }
                }
                if (lbPaymentMethods.Items.Count > 0) {
                    lbPaymentMethods.SelectedIndex = 0;
                }
            }
        }

        private void ToggleLoginScreen(bool show) {
            if (_actionStack.Count > 0 && _actionStack.Peek() != "LoginScreen") {
                _actionStack.Push("LoginScreen");
            }
            lblLoginScreen.Visible = !lblLoginScreen.Visible;
            lblUsername.Visible = !lblUsername.Visible;
            tbUsername.Visible = !tbUsername.Visible;
            lblPassword.Visible = !lblPassword.Visible;
            tbPassword.Visible = !tbPassword.Visible;
            pbBack.Visible = !pbBack.Visible;
            pbHome.Visible = !pbHome.Visible;

            if (show) {
                tbUsername.Focus();
                lblLoginScreen.Text = _lang.GetLoginText()[0];
                lblUsername.Text = _lang.GetLoginText()[1];
                lblPassword.Text = _lang.GetLoginText()[2];
            }
        }

        private async void FinalMessage(DialogResult result = DialogResult.OK) {
            if (_actionStack.Count > 0 && _actionStack.Peek() != "FinalMessage") {
                _actionStack.Push("FinalMessage");
            }

            lblFinalMessage.Visible = true;
            lblFinalMessage.Text = "";

            if (selection == 0) {
                createTicket();
            } else {
                createTimedTicket();
            }

            await Task.Delay(1000);
            if (result == DialogResult.Cancel) {
                decimal amtPaid = _machine.GetPaidAmount();
                if (amtPaid > 0) {
                    lblFinalMessage.Text = "Refunding £" + amtPaid;
                    await Task.Delay(3000);
                    lblFinalMessage.Visible = false;
                    ResetControls();
                    ToggleLanguageScreen(true);
                    return;
                }
                lblFinalMessage.Visible = false;
                ResetControls();
                ToggleLanguageScreen(true);
                return;
            }

            foreach (var message in _lang.GetFinalMessage()) {
                lblFinalMessage.Text = message;
                await Task.Delay(3000);
            }

            counter.Increment();

            lblFinalMessage.Visible = false;
            ResetControls();
            ToggleLanguageScreen(true);
        }


        /*
         * This is our own functions - not defined in the class diagram
         */
        private void SetupLanguages() {
            _langList = new LanguageList();

            string path = Path.Combine(Environment.CurrentDirectory, @"Languages\");
            string[] files = Directory.GetFiles(path, "*.language");
            for (int i = 0; i < files.Length; i++) {

                string[] languageTemp = new string[20];

                languageTemp = File.ReadAllLines(files[i]);

                _langList.AddLanguage(new Language(languageTemp[0],
                new List<string> { languageTemp[1], languageTemp[2] },
                new List<string>(),
                new List<string> { languageTemp[3], languageTemp[4] },
                new List<string>(),
                languageTemp[5],
                new List<string> { languageTemp[6], languageTemp[7], languageTemp[8], languageTemp[9] },
                new List<string> { languageTemp[10] },
                languageTemp[11],
                new List<string> { languageTemp[12], languageTemp[13], languageTemp[14] },
                new List<string> { languageTemp[15], languageTemp[16], languageTemp[17] },
                new List<string> { languageTemp[18], languageTemp[19] }));
            }
        }


        /*
         * Design Patterns
         * Listener for change of language.
         */
        private void SelectLanguage(object sender, EventArgs e) {
            _lang = (Language)lbLanguages.SelectedItem;
            lblLanguageTitle.Text = _lang.GetStarterOption();
        }

        private void lbLanguages_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                SetActiveLanguage();
            }
        }

        private void lbAccountTypes_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                if (lbAccountTypes.SelectedIndex == 0) {
                    GuestLogin();
                    _account = 0;
                } else if (lbAccountTypes.SelectedIndex == 1) {
                    Login();
                } else {
                    Login();
                }
            }
        }

        private void lbJourneyType_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                if (lbJourneyType.SelectedIndex == 0) {
                    DisplaySingleJourney();
                } else if (lbJourneyType.SelectedIndex == 1) {
                    DisplayTimedPass();
                } else {
                    throw new NotImplementedException();
                }
            }
        }


        private void nudTicketQuantity_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                DisplayPaymentOptions();
            }
        }

        private void lbPaymentMethods_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                if (string.Compare(lbPaymentMethods.SelectedItem.ToString(), _lang.GetPaymentOptions()[1], StringComparison.Ordinal) == 0) {
                    // CARD PAYMENT
                    ToggleCardPayment();
                    //CreateTicket();
                    DisplayFinalMessage();
                } else if (string.Compare(lbPaymentMethods.SelectedItem.ToString(), _lang.GetPaymentOptions()[2], StringComparison.Ordinal) == 0) {
                    // CASH
                    TogglePaymentScreen(false);
                    ToggleCashScreen(true);
                } else if (string.Compare(lbPaymentMethods.SelectedItem.ToString(), _lang.GetPaymentOptions()[3], StringComparison.Ordinal) == 0) {
                    // ACCOUNT BALANCE
                    ToggleBalancePayment();
                    DisplayFinalMessage();
                }
            }
        }

        private void ToggleBalancePayment() {
            _machine.MakeBalancePayment(selection == 0 ? decimal.Parse(tbSingleJourneyPrice.Text.Substring(1)) : decimal.Parse(tbTotalPrice.Text), selection == 0 ? decimal.Parse(tbSingleJourneyPrice.Text.Substring(1)) : decimal.Parse(tbTotalPrice.Text));
        }

        private void ToggleCardPayment() {
            _machine.MakeCardPayment(selection == 0 ? decimal.Parse(tbSingleJourneyPrice.Text.Substring(1)) : decimal.Parse(tbTotalPrice.Text), selection == 0 ? decimal.Parse(tbSingleJourneyPrice.Text.Substring(1)) : decimal.Parse(tbTotalPrice.Text));
        }

        private async void ToggleCashScreen(bool show) {
            if (_actionStack.Count > 0 && _actionStack.Peek() != "CashScreen") {
                _actionStack.Push("CashScreen");
            }

            pbBack.Visible = !pbBack.Visible;
            pbHome.Visible = !pbHome.Visible;
            lblAmountDue.Visible = !lblAmountDue.Visible;
            lblAmountDueTitle.Visible = !lblAmountDueTitle.Visible;
            lblAmountDue.Text = selection == 0 ? tbSingleJourneyPrice.Text : tbTotalPrice.Text;

            MoneyForm moneyForm = new MoneyForm(_machine, selection == 0 ? tbSingleJourneyPrice.Text : tbTotalPrice.Text, lblAmountDue);
            var result = moneyForm.ShowDialog();

            if (decimal.Parse(lblAmountDue.Text.Substring(1)) < 0) {
                var amount = decimal.Parse(lblAmountDue.Text.Substring(1)) * -1;
                lblAmountDueTitle.Visible = !lblAmountDueTitle.Visible;
                lblAmountDue.Text = "Refunding £" + amount;
                await Task.Delay(3000);
                lblAmountDueTitle.Visible = !lblAmountDueTitle.Visible;
            }

            pbBack.Visible = !pbBack.Visible;
            pbHome.Visible = !pbHome.Visible;
            lblAmountDue.Visible = !lblAmountDue.Visible;
            lblAmountDueTitle.Visible = !lblAmountDueTitle.Visible;
            FinalMessage(result);
        }

        private void cbEndStation_KeyDown(object sender, KeyEventArgs e) {
            // Maybe change how to advance to payment screen - pressing enter is also how you pick the station in this combo box.
            if (e.KeyData == Keys.Enter) {
                selection = 0;
                DisplayPaymentOptions2();
            }
        }

        private void cbStartStation_SelectedIndexChanged(object sender, EventArgs e) {
            //Update price of ticket
            if (cbEndStation.SelectedItem != null) {
                tbSingleJourneyPrice.Text = "£4.00";
            }
            //for new combobox implementation
            //selectedStartStation = (Station)cbStartStation.SelectedItem;
            selectedStartStation = cbStartStation.SelectedItem.ToString();
        }

        private void cbEndStation_SelectedIndexChanged(object sender, EventArgs e) {
            //Update price of ticket
            if (cbStartStation.SelectedItem != null) {
                tbSingleJourneyPrice.Text = "£5.00";
            }
            //for new combobox implementation
            //selectedEndStation = (Station)cbEndStation.SelectedItem;
            selectedEndStation = cbEndStation.SelectedItem.ToString();
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                if (tbUsername.Text != "" && tbPassword.Text != "") {
                    LoginToAccount(tbUsername.Text, tbPassword.Text);
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                }
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                if (tbUsername.Text != "" && tbPassword.Text != "") {
                    LoginToAccount(tbUsername.Text, tbPassword.Text);
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                }
            }
        }

        private void LoginToAccount(string username, string password) {
            _account = new CustomerAccount().VerifyLogin(username, password);
            if (_account > -1) {
                // Log in successful. Do something.
                ConfigureGuiForLogin();
                ToggleLoginScreen(false);
                ToggleJourneyOptions(true);
            } else if (_account == -2) {
                // User is already logged in.
                MessageBox.Show(this, "Error: account already logged in.");
            } else {
                // Log in is unsuccessful - show error.
                MessageBox.Show(this, "Error");
            }

        }

        /// <summary>
        /// This method takes the List of CustomerAccount object and binary serializes it, allowing the persistence of data.
        /// </summary>
        /// <param name="filePath">This is the file name/output directory.</param>
        /// <param name="objectToWrite">This is the object that gets serialized. Can be of any type.</param>
        /// <param name="append">This flags whether to append the object to the end of the file (if it exists already)</param>
        /// <typeparam name="T">This is the type of T</typeparam>
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false) {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create)) {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        public void Update(int count) {
            throw new NotImplementedException();
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
            _machine.SetAccount(_account);
        }

        private void pbHome_Click(object sender, EventArgs e) {
            _actionStack.Clear();
            HideAll();

            ResetControls();
            ToggleLanguageScreen(true);
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

        private void ResetControls() {
            foreach (var x in Controls.OfType<Button>()) {
                x.Text = "";
            }

            foreach (var x in Controls.OfType<Label>()) {
                if (x.Name == "lblAccountUsername") {
                    Controls.Remove(x);
                }
                //x.Text = "";
            }

            foreach (var x in Controls.OfType<TextBox>()) {
                x.Text = "";
            }

            foreach (var x in Controls.OfType<ListBox>()) {
                x.Items.Clear();
            }

            foreach (var x in Controls.OfType<NumericUpDown>()) {
                x.Value = 1;
            }

            foreach (var x in Controls.OfType<ComboBox>()) {
                // x.Items.Clear();
                // Cannot do this as it's bound by a datasource. Need to change the datasource to change the items in the combobox. 
                // So when changing language, set the new datasource.
            }

            foreach (var x in Controls.OfType<PictureBox>()) {
                if (x.Name.Contains("account")) {
                    Controls.Remove(x);
                    x.Dispose();
                }
            }

            _actionStack.Clear();
            _account = new Account().Logout(_account);
            _machine = new TokenMachine(dayPassPrice);
        }

        private void pbBack_Click(object sender, EventArgs e) {
            // Pop first to remove the page we are currently on. Then the next Pop is the actual page we want to return to.
            _actionStack.Pop();
            switch (_actionStack.Pop()) {
                case "LanguageScreen":
                    HideAll();
                    ResetControls();
                    ToggleLanguageScreen(true);
                    lbLanguages.Focus();
                    break;
                case "AccountOptions":
                    HideAll();
                    ToggleAccountOptions(false);
                    lbAccountTypes.Focus();
                    break;
                case "LoginScreen":
                    HideAll();
                    ToggleLoginScreen(false);
                    _account = new Account().Logout(_account);
                    tbUsername.Focus();
                    break;
                case "JourneyOptions":
                    HideAll();
                    ToggleJourneyOptions(false);
                    lbJourneyType.Focus();
                    break;
                case "TimedPass":
                    HideAll();
                    ToggleTimedPass(false);
                    nudTimedPass.Focus();
                    break;
            }
        }

        private void nudTimedPass_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                selection = 1;
                DisplayPaymentOptions();
            }

            if (e.KeyData == Keys.Down) {
                int number = (int)nudTimedPass.Value;
                if (nudAcceptedValues.Contains(number)) {
                    var currentIndex = nudAcceptedValues.IndexOf(number) - 1;
                    nudTimedPass.Value =
                        nudAcceptedValues[currentIndex < 0 ? nudAcceptedValues.Count - 1 : currentIndex];
                }
            }

            //UpdateTimedPassPrice();
        }

        private void nudTimedPass_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Up) {
                int number = (int)nudTimedPass.Value;
                if (nudAcceptedValues.Contains(number)) {
                    var currentIndex = nudAcceptedValues.IndexOf(number) + 1;
                    nudTimedPass.Value =
                        nudAcceptedValues[currentIndex >= nudAcceptedValues.Count ? 0 : currentIndex];
                }
            }

            UpdateTimedPassPrice();
        }

        private void nudTimedPass_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                int number = (int)nudTimedPass.Value;
                if (nudAcceptedValues.Contains(number)) {
                    var currentIndex = nudAcceptedValues.IndexOf(number) + 1;
                    nudTimedPass.Value =
                        nudAcceptedValues[currentIndex >= nudAcceptedValues.Count ? 0 : currentIndex];
                }
            }

            UpdateTimedPassPrice();
        }

        private void UpdateTimedPassPrice() {
            tbTotalPrice.Text = "";
            var singleCost = _machine.NumberOfDaysPrice(int.Parse(nudTimedPass.Value.ToString(CultureInfo.InvariantCulture)));
            tbTotalPrice.Text = (singleCost * int.Parse(nudTicketQuantity.Value.ToString(CultureInfo.InvariantCulture))).ToString(CultureInfo.InvariantCulture);
        }

        private void nudTicketQuantity_KeyUp(object sender, KeyEventArgs e) {
            UpdateTimedPassPrice();
        }

        private void TokenMachineGUI_FormClosing(object sender, FormClosingEventArgs e) {
            _account = new Account().Logout(_account);
        }

        private void TokenMachineGUI_Load(object sender, EventArgs e) {

        }

        //public Counter ISubject {
        //    get { return counter; }
        //    set { counter.Increment(); }
        //}
    }
}

