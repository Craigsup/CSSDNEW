using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ModifiedTicketingSystem {
    public partial class MobileAppGUI : Form {
        private MobileApp _app;
        private int _account;
        
        public MobileAppGUI() {
            InitializeComponent();

            lblLogin.Visible = true;
            tbPassword.Visible = true;
            tbUsername.Visible = true;
            lblPassword.Visible = true;
            lblUsername.Visible = true;
            btnLogin.Visible = true;
            btnOpenMenu.Visible = false;
            tbPassword.Text = "password";
            tbUsername.Text = "Bob";


            //ShowLogin();
        }

        private void ShowLogin() {
            // Show login screen
            ToggleLoginScreen();

        }


        private void ShowHome() {
            btnOpenMenu.Visible = true;
            lblHome.Visible = true;
            lblWelcome.Visible = true;
            lblUser.Visible = true;
        }
        private void ShowBalance()
        {
            lblBalance.Visible = true;
            btnOpenMenu.Visible = true;
            lblBalanceValue.Visible = true;
            lblBalanceValue.Text = "£"+new CustomerAccount().GetXByAccountId<float>(_account, "balance");

        }
        private void ShowTopUp()
        {
            lblTopUp.Visible = true;
            btnOpenMenu.Visible = true;
            lblCurrencySymbol.Visible = true;

            btnTopUp.Visible = true;
            tbTopUp.Visible = true;
        }

        private void ShowPaymentOptions()
        {
            lblCurrencySymbol.Visible = false;
            lblTopUp.Visible = false;
            btnOpenMenu.Visible = false;
            btnTopUp.Visible = false;
            tbTopUp.Visible = false;

            lblPaymentTitle.Visible = true;
            lbPaymentOptions.Visible = true;
            btnPaymentOptions.Visible = true;

            lbPaymentOptions.Items.Clear();
            foreach (var option in new CustomerAccount().GetXByAccountId<List<string>>(_account, "paymentoptions")) {
                lbPaymentOptions.Items.Add(option);
            }
            lbPaymentOptions.Items.Add("New Payment Method");
            lbPaymentOptions.SelectedIndex = 0;

        }

        private void ShowCvvScreen() {
            lblPayment.Visible = false;
            lblPaymentTitle.Visible = false;
            lbPaymentOptions.Visible = false;
            btnPaymentOptions.Visible = false;

            if (lbPaymentOptions.SelectedIndex == lbPaymentOptions.Items.Count - 1) {
                lblCvvText.Text = "Enter your CVV for the card ending in: \n" + tbCardNumber.Text.Substring(tbCardNumber.Text.Length-4);
            } else {
                lblCvvText.Text = "Enter your CVV for the card ending in: \n" + lbPaymentOptions.SelectedItem.ToString().Substring(lbPaymentOptions.SelectedItem.ToString().Length-4);
            }
            

            lblCvvText.Visible = true;
            lblCvvTitle.Visible = true;
            tbCvvNumber.Visible = true;
            btnCvvScreen.Visible = true;
            tbCvvNumber.Text = "";
        }

        private void ShowAddPaymentOptionScreen()
        {
            lblPaymentTitle.Visible = false;
            lbPaymentOptions.Visible = false;
            btnPaymentOptions.Visible = false;

            lblCardNumber.Visible = true;
            lblExpDate.Visible = true;
            lblAccHolderName.Visible = true;
            tbAccHolderName.Visible = true;
            tbCardNumber.Visible = true;
            tbExpiryDate.Visible = true;
            lblAddPaymentDetails.Visible = true;
            btnAddCard.Visible = true;

        }

        private void ShowCvvConfirmedScreen()
        {
            lblCvvText.Visible = false;
            lblCvvTitle.Visible = false;
            tbCvvNumber.Visible = false;
            btnCvvScreen.Visible = false;

            lblCvvConfirmed.Visible = true;
            btnCvvConfirmed.Visible = true;

        }

        /*
        * Custom Toggle Functions to simplify screens
        */

        private void ToggleLoginScreen() {
            lblLogin.Visible = !lblLogin.Visible;
            tbPassword.Visible = !tbPassword.Visible;
            tbUsername.Visible = !tbUsername.Visible;
            lblPassword.Visible = !lblPassword.Visible;
            lblUsername.Visible = !lblUsername.Visible;
            btnLogin.Visible = !btnLogin.Visible;
            btnOpenMenu.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginToAccount(tbUsername.Text, tbPassword.Text);
        }

        private void HideAll()
        {
            foreach (var x in Controls.OfType<Button>())
            {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<Label>())
            {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<PictureBox>())
            {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<TextBox>())
            {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<ListBox>())
            {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<NumericUpDown>())
            {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<ComboBox>())
            {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<Panel>())
            {
                x.Visible = false;
            }

            pnlMenu.Width = 0;
        }

        private void LoginToAccount(string username, string password)
        {
            _account = new CustomerAccount().VerifyLogin(username, password);
            lblUser.Text = username;
            if (_account > -1) {
                _app = new MobileApp(_account);
                // Hide login screen
                ToggleLoginScreen();

                //Show Home Screen
                ShowHome();


                // Log in successful. Do something.
            }
        }

        private void btnOpenMenu_Click(object sender, EventArgs e)
        {
            btnOpenMenu.Visible = false;
            for (int i = 0; i < 100;i++) {
                pnlMenu.Width = pnlMenu.Width + 1;
                //await Task.Delay(10);
            }
            if (_account > -1) {
                lblNavHome.Visible = true;
                lblNavBalance.Visible = true;
                lblNavTopUp.Visible = true;
                lblLogOut.Visible = true;
                pnlMenu.Visible = true;
            }
            btnCloseMenu.Visible = true;
        }

        private void btnCloseMenu_Click(object sender, EventArgs e)
        {
            btnCloseMenu.Visible = false;
            for (int i = 0; i < 100; i++) {
                pnlMenu.Width = pnlMenu.Width - 1;
                //await Task.Delay(10);
            }
            lblNavHome.Visible = false;
            lblNavBalance.Visible = false;
            lblNavTopUp.Visible = false;
            lblLogOut.Visible = false;
            pnlMenu.Visible = false;
            btnOpenMenu.Visible = true;
        }

        private void lblNavHome_Click(object sender, EventArgs e)
        {
            HideAll();
            ShowHome();
        }

        private void lblNavBalance_Click(object sender, EventArgs e)
        {
            HideAll();
            ShowBalance();
        }

        private void lblNavTopUp_Click(object sender, EventArgs e)
        {
            HideAll();
            ShowTopUp();
        }

        private void tbTopUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblPayment.Visible = false;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbTopUp_KeyUp(object sender, KeyEventArgs e)
        {
            var indexOfDecimal = ((sender as TextBox).Text.IndexOf('.'));

            if (indexOfDecimal > 0 && (sender as TextBox).Text.Length > indexOfDecimal + 3)
            {
                tbTopUp.Text = tbTopUp.Text.Substring(0, tbTopUp.Text.Length - 1);
                tbTopUp.SelectionStart = tbTopUp.Text.Length;
            }

        }

        private void btnTopUp_Click(object sender, EventArgs e)
        {
            ShowPaymentOptions();
        }

        private void btnPaymentOptions_Click(object sender, EventArgs e) {
            if(lbPaymentOptions.SelectedIndex == lbPaymentOptions.Items.Count - 1) {
                ShowAddPaymentOptionScreen();
                // ShowCvvScreen();
                // add payment stuff
            }
            else
            {
                ShowCvvScreen();

            }
        }

        private void btnCvvScreen_Click(object sender, EventArgs e)
        {
            ShowCvvConfirmedScreen();
            //do cvv check stuff
            if (_app.MakePayment(decimal.Parse(tbTopUp.Text)))
            {
                tbTopUp.Text = "";
                lblPayment.Text = "Payment Successful";
                lblPayment.Location = new Point((Width - lblPayment.Width) / 2, lblPayment.Location.Y);
                lblPayment.Visible = true;
            }
            else
            {
                lblPayment.Text = "Payment Failed";
                lblPayment.Location = new Point((Width - lblPayment.Width) / 2, lblPayment.Location.Y);
                lblPayment.Visible = true;
            }
        }

        private void btnCvvConfirmed_Click(object sender, EventArgs e)
        {
            HideAll();
            ShowHome();
        }

        private void btnAddCard_Click(object sender, EventArgs e) {
            new CustomerAccount(_account).AddPaymentCard(_account, tbCardNumber.Text, tbExpiryDate.Text, tbAccHolderName.Text);
            HideAll();
            lblPayment.Text = "Added.";
            lblPayment.Visible = true;
            ShowCvvScreen();
        }

        private void MobileAppGUI_FormClosing(object sender, FormClosingEventArgs e) {
            _account = new Account().Logout(_account);
        }

        private void MobileAppGUI_Load(object sender, EventArgs e) {

        }

        private void btnLogOut_Click(object sender, EventArgs e) {
            _account = new Account().Logout(_account);
            HideAll();
            ToggleLoginScreen();
        }
    }
}
