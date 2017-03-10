using System.ComponentModel;
using System.Windows.Forms;

namespace ModifiedTicketingSystem {
    partial class MobileAppGUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblTopUp = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCloseMenu = new System.Windows.Forms.Button();
            this.btnOpenMenu = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblNavHome = new System.Windows.Forms.Label();
            this.lblNavBalance = new System.Windows.Forms.Label();
            this.lblNavTopUp = new System.Windows.Forms.Label();
            this.lblBalanceValue = new System.Windows.Forms.Label();
            this.btnTopUp = new System.Windows.Forms.Button();
            this.tbTopUp = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPaymentTitle = new System.Windows.Forms.Label();
            this.lbPaymentOptions = new System.Windows.Forms.ListBox();
            this.btnPaymentOptions = new System.Windows.Forms.Button();
            this.lblCvvTitle = new System.Windows.Forms.Label();
            this.lblCvvText = new System.Windows.Forms.Label();
            this.tbCvvNumber = new System.Windows.Forms.TextBox();
            this.btnCvvScreen = new System.Windows.Forms.Button();
            this.lblCvvConfirmed = new System.Windows.Forms.Label();
            this.btnCvvConfirmed = new System.Windows.Forms.Button();
            this.lblAddPaymentDetails = new System.Windows.Forms.Label();
            this.tbAccHolderName = new System.Windows.Forms.TextBox();
            this.lblAccHolderName = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.tbExpiryDate = new System.Windows.Forms.TextBox();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.lblCurrencySymbol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUsername.Location = new System.Drawing.Point(37, 182);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 29);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsername.Visible = false;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbUsername.Location = new System.Drawing.Point(175, 182);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 29);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.Visible = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbPassword.Location = new System.Drawing.Point(175, 245);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 29);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPassword.Location = new System.Drawing.Point(36, 246);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 29);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPassword.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.GreenYellow;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnLogin.Location = new System.Drawing.Point(98, 295);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(117, 49);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHome.Location = new System.Drawing.Point(109, 32);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(78, 29);
            this.lblHome.TabIndex = 5;
            this.lblHome.Text = "Home";
            this.lblHome.Visible = false;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblBalance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBalance.Location = new System.Drawing.Point(109, 32);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(100, 29);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.Text = "Balance";
            this.lblBalance.Visible = false;
            // 
            // lblTopUp
            // 
            this.lblTopUp.AutoSize = true;
            this.lblTopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTopUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTopUp.Location = new System.Drawing.Point(114, 32);
            this.lblTopUp.Name = "lblTopUp";
            this.lblTopUp.Size = new System.Drawing.Size(94, 29);
            this.lblTopUp.TabIndex = 7;
            this.lblTopUp.Text = "Top Up";
            this.lblTopUp.Visible = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DarkGray;
            this.pnlMenu.Location = new System.Drawing.Point(-1, 82);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(0, 168);
            this.pnlMenu.TabIndex = 10;
            // 
            // btnCloseMenu
            // 
            this.btnCloseMenu.BackColor = System.Drawing.Color.White;
            this.btnCloseMenu.FlatAppearance.BorderSize = 0;
            this.btnCloseMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseMenu.Location = new System.Drawing.Point(99, 82);
            this.btnCloseMenu.Name = "btnCloseMenu";
            this.btnCloseMenu.Size = new System.Drawing.Size(13, 69);
            this.btnCloseMenu.TabIndex = 11;
            this.btnCloseMenu.Text = "<";
            this.btnCloseMenu.UseVisualStyleBackColor = false;
            this.btnCloseMenu.Visible = false;
            this.btnCloseMenu.Click += new System.EventHandler(this.btnCloseMenu_Click);
            // 
            // btnOpenMenu
            // 
            this.btnOpenMenu.BackColor = System.Drawing.Color.White;
            this.btnOpenMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenMenu.Location = new System.Drawing.Point(0, 82);
            this.btnOpenMenu.Name = "btnOpenMenu";
            this.btnOpenMenu.Size = new System.Drawing.Size(15, 69);
            this.btnOpenMenu.TabIndex = 12;
            this.btnOpenMenu.Text = ">";
            this.btnOpenMenu.UseVisualStyleBackColor = false;
            this.btnOpenMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOpenMenu_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLogin.Location = new System.Drawing.Point(114, 32);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(73, 29);
            this.lblLogin.TabIndex = 13;
            this.lblLogin.Text = "Login";
            this.lblLogin.Visible = false;
            // 
            // lblNavHome
            // 
            this.lblNavHome.AutoSize = true;
            this.lblNavHome.BackColor = System.Drawing.Color.DarkGray;
            this.lblNavHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNavHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNavHome.Location = new System.Drawing.Point(13, 108);
            this.lblNavHome.Name = "lblNavHome";
            this.lblNavHome.Size = new System.Drawing.Size(62, 24);
            this.lblNavHome.TabIndex = 14;
            this.lblNavHome.Text = "Home";
            this.lblNavHome.Visible = false;
            this.lblNavHome.Click += new System.EventHandler(this.lblNavHome_Click);
            // 
            // lblNavBalance
            // 
            this.lblNavBalance.AutoSize = true;
            this.lblNavBalance.BackColor = System.Drawing.Color.DarkGray;
            this.lblNavBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNavBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNavBalance.Location = new System.Drawing.Point(13, 145);
            this.lblNavBalance.Name = "lblNavBalance";
            this.lblNavBalance.Size = new System.Drawing.Size(78, 24);
            this.lblNavBalance.TabIndex = 15;
            this.lblNavBalance.Text = "Balance";
            this.lblNavBalance.Visible = false;
            this.lblNavBalance.Click += new System.EventHandler(this.lblNavBalance_Click);
            // 
            // lblNavTopUp
            // 
            this.lblNavTopUp.AutoSize = true;
            this.lblNavTopUp.BackColor = System.Drawing.Color.DarkGray;
            this.lblNavTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNavTopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNavTopUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNavTopUp.Location = new System.Drawing.Point(13, 182);
            this.lblNavTopUp.Name = "lblNavTopUp";
            this.lblNavTopUp.Size = new System.Drawing.Size(73, 24);
            this.lblNavTopUp.TabIndex = 16;
            this.lblNavTopUp.Text = "Top Up";
            this.lblNavTopUp.Visible = false;
            this.lblNavTopUp.Click += new System.EventHandler(this.lblNavTopUp_Click);
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.lblBalanceValue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBalanceValue.Location = new System.Drawing.Point(93, 211);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(125, 44);
            this.lblBalanceValue.TabIndex = 17;
            this.lblBalanceValue.Text = "£ 0.00";
            this.lblBalanceValue.Visible = false;
            // 
            // btnTopUp
            // 
            this.btnTopUp.BackColor = System.Drawing.Color.GreenYellow;
            this.btnTopUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTopUp.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTopUp.Location = new System.Drawing.Point(98, 295);
            this.btnTopUp.Name = "btnTopUp";
            this.btnTopUp.Size = new System.Drawing.Size(117, 49);
            this.btnTopUp.TabIndex = 18;
            this.btnTopUp.Text = "Top Up";
            this.btnTopUp.UseVisualStyleBackColor = false;
            this.btnTopUp.Visible = false;
            this.btnTopUp.Click += new System.EventHandler(this.btnTopUp_Click);
            // 
            // tbTopUp
            // 
            this.tbTopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbTopUp.Location = new System.Drawing.Point(98, 214);
            this.tbTopUp.Name = "tbTopUp";
            this.tbTopUp.Size = new System.Drawing.Size(100, 29);
            this.tbTopUp.TabIndex = 19;
            this.tbTopUp.Visible = false;
            this.tbTopUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTopUp_KeyPress);
            this.tbTopUp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbTopUp_KeyUp);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblPayment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPayment.Location = new System.Drawing.Point(41, 151);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(180, 29);
            this.lblPayment.TabIndex = 20;
            this.lblPayment.Text = "Payment Failed";
            this.lblPayment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPayment.Visible = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcome.Location = new System.Drawing.Point(94, 122);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(115, 29);
            this.lblWelcome.TabIndex = 21;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUser.Location = new System.Drawing.Point(109, 154);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 29);
            this.lblUser.TabIndex = 22;
            this.lblUser.Visible = false;
            // 
            // lblPaymentTitle
            // 
            this.lblPaymentTitle.AutoSize = true;
            this.lblPaymentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPaymentTitle.ForeColor = System.Drawing.Color.White;
            this.lblPaymentTitle.Location = new System.Drawing.Point(54, 37);
            this.lblPaymentTitle.Name = "lblPaymentTitle";
            this.lblPaymentTitle.Size = new System.Drawing.Size(209, 24);
            this.lblPaymentTitle.TabIndex = 23;
            this.lblPaymentTitle.Text = "Select Payment Method";
            this.lblPaymentTitle.Visible = false;
            // 
            // lbPaymentOptions
            // 
            this.lbPaymentOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbPaymentOptions.FormattingEnabled = true;
            this.lbPaymentOptions.ItemHeight = 20;
            this.lbPaymentOptions.Location = new System.Drawing.Point(55, 81);
            this.lbPaymentOptions.Name = "lbPaymentOptions";
            this.lbPaymentOptions.Size = new System.Drawing.Size(208, 84);
            this.lbPaymentOptions.TabIndex = 24;
            this.lbPaymentOptions.Visible = false;
            // 
            // btnPaymentOptions
            // 
            this.btnPaymentOptions.BackColor = System.Drawing.Color.GreenYellow;
            this.btnPaymentOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPaymentOptions.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnPaymentOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnPaymentOptions.Location = new System.Drawing.Point(98, 295);
            this.btnPaymentOptions.Name = "btnPaymentOptions";
            this.btnPaymentOptions.Size = new System.Drawing.Size(120, 49);
            this.btnPaymentOptions.TabIndex = 25;
            this.btnPaymentOptions.Text = "Continue";
            this.btnPaymentOptions.UseVisualStyleBackColor = false;
            this.btnPaymentOptions.Visible = false;
            this.btnPaymentOptions.Click += new System.EventHandler(this.btnPaymentOptions_Click);
            // 
            // lblCvvTitle
            // 
            this.lblCvvTitle.AutoSize = true;
            this.lblCvvTitle.BackColor = System.Drawing.Color.Black;
            this.lblCvvTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCvvTitle.ForeColor = System.Drawing.Color.White;
            this.lblCvvTitle.Location = new System.Drawing.Point(64, 36);
            this.lblCvvTitle.Name = "lblCvvTitle";
            this.lblCvvTitle.Size = new System.Drawing.Size(180, 24);
            this.lblCvvTitle.TabIndex = 26;
            this.lblCvvTitle.Text = "Confirm Your Details";
            this.lblCvvTitle.Visible = false;
            // 
            // lblCvvText
            // 
            this.lblCvvText.AutoSize = true;
            this.lblCvvText.BackColor = System.Drawing.Color.White;
            this.lblCvvText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCvvText.Location = new System.Drawing.Point(21, 82);
            this.lblCvvText.Name = "lblCvvText";
            this.lblCvvText.Size = new System.Drawing.Size(284, 20);
            this.lblCvvText.TabIndex = 27;
            this.lblCvvText.Text = "Enter your CVV for the card ending in : ";
            this.lblCvvText.Visible = false;
            // 
            // tbCvvNumber
            // 
            this.tbCvvNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbCvvNumber.Location = new System.Drawing.Point(98, 214);
            this.tbCvvNumber.Name = "tbCvvNumber";
            this.tbCvvNumber.Size = new System.Drawing.Size(100, 29);
            this.tbCvvNumber.TabIndex = 28;
            this.tbCvvNumber.Visible = false;
            // 
            // btnCvvScreen
            // 
            this.btnCvvScreen.BackColor = System.Drawing.Color.GreenYellow;
            this.btnCvvScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCvvScreen.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnCvvScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCvvScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCvvScreen.Location = new System.Drawing.Point(98, 295);
            this.btnCvvScreen.Name = "btnCvvScreen";
            this.btnCvvScreen.Size = new System.Drawing.Size(120, 49);
            this.btnCvvScreen.TabIndex = 29;
            this.btnCvvScreen.Text = "Confirm";
            this.btnCvvScreen.UseVisualStyleBackColor = false;
            this.btnCvvScreen.Visible = false;
            this.btnCvvScreen.Click += new System.EventHandler(this.btnCvvScreen_Click);
            // 
            // lblCvvConfirmed
            // 
            this.lblCvvConfirmed.AutoSize = true;
            this.lblCvvConfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCvvConfirmed.ForeColor = System.Drawing.Color.White;
            this.lblCvvConfirmed.Location = new System.Drawing.Point(42, 60);
            this.lblCvvConfirmed.Name = "lblCvvConfirmed";
            this.lblCvvConfirmed.Size = new System.Drawing.Size(229, 24);
            this.lblCvvConfirmed.TabIndex = 30;
            this.lblCvvConfirmed.Text = "Balance added to account";
            this.lblCvvConfirmed.Visible = false;
            // 
            // btnCvvConfirmed
            // 
            this.btnCvvConfirmed.BackColor = System.Drawing.Color.GreenYellow;
            this.btnCvvConfirmed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCvvConfirmed.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnCvvConfirmed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCvvConfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCvvConfirmed.Location = new System.Drawing.Point(98, 295);
            this.btnCvvConfirmed.Name = "btnCvvConfirmed";
            this.btnCvvConfirmed.Size = new System.Drawing.Size(120, 49);
            this.btnCvvConfirmed.TabIndex = 31;
            this.btnCvvConfirmed.Text = "Continue";
            this.btnCvvConfirmed.UseVisualStyleBackColor = false;
            this.btnCvvConfirmed.Visible = false;
            this.btnCvvConfirmed.Click += new System.EventHandler(this.btnCvvConfirmed_Click);
            // 
            // lblAddPaymentDetails
            // 
            this.lblAddPaymentDetails.AutoSize = true;
            this.lblAddPaymentDetails.BackColor = System.Drawing.Color.Black;
            this.lblAddPaymentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAddPaymentDetails.ForeColor = System.Drawing.Color.White;
            this.lblAddPaymentDetails.Location = new System.Drawing.Point(64, 37);
            this.lblAddPaymentDetails.Name = "lblAddPaymentDetails";
            this.lblAddPaymentDetails.Size = new System.Drawing.Size(160, 24);
            this.lblAddPaymentDetails.TabIndex = 32;
            this.lblAddPaymentDetails.Text = "Enter Card Details";
            this.lblAddPaymentDetails.Visible = false;
            // 
            // tbAccHolderName
            // 
            this.tbAccHolderName.Location = new System.Drawing.Point(68, 118);
            this.tbAccHolderName.Name = "tbAccHolderName";
            this.tbAccHolderName.Size = new System.Drawing.Size(156, 20);
            this.tbAccHolderName.TabIndex = 33;
            this.tbAccHolderName.Visible = false;
            // 
            // lblAccHolderName
            // 
            this.lblAccHolderName.AutoSize = true;
            this.lblAccHolderName.BackColor = System.Drawing.Color.White;
            this.lblAccHolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAccHolderName.Location = new System.Drawing.Point(64, 95);
            this.lblAccHolderName.Name = "lblAccHolderName";
            this.lblAccHolderName.Size = new System.Drawing.Size(169, 20);
            this.lblAccHolderName.TabIndex = 34;
            this.lblAccHolderName.Text = "Account Holder Name:";
            this.lblAccHolderName.Visible = false;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.BackColor = System.Drawing.Color.White;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCardNumber.Location = new System.Drawing.Point(64, 154);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(107, 20);
            this.lblCardNumber.TabIndex = 36;
            this.lblCardNumber.Text = "Card Number:";
            this.lblCardNumber.Visible = false;
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Location = new System.Drawing.Point(68, 177);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(156, 20);
            this.tbCardNumber.TabIndex = 35;
            this.tbCardNumber.Visible = false;
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.BackColor = System.Drawing.Color.White;
            this.lblExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblExpDate.Location = new System.Drawing.Point(64, 211);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(94, 20);
            this.lblExpDate.TabIndex = 38;
            this.lblExpDate.Text = "Expiry Date:";
            this.lblExpDate.Visible = false;
            // 
            // tbExpiryDate
            // 
            this.tbExpiryDate.Location = new System.Drawing.Point(68, 234);
            this.tbExpiryDate.Name = "tbExpiryDate";
            this.tbExpiryDate.Size = new System.Drawing.Size(156, 20);
            this.tbExpiryDate.TabIndex = 37;
            this.tbExpiryDate.Visible = false;
            // 
            // btnAddCard
            // 
            this.btnAddCard.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddCard.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnAddCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnAddCard.Location = new System.Drawing.Point(99, 295);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(120, 49);
            this.btnAddCard.TabIndex = 39;
            this.btnAddCard.Text = "Add Card";
            this.btnAddCard.UseVisualStyleBackColor = false;
            this.btnAddCard.Visible = false;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.BackColor = System.Drawing.Color.DarkGray;
            this.lblLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblLogOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLogOut.Location = new System.Drawing.Point(12, 217);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(77, 24);
            this.lblLogOut.TabIndex = 40;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.Visible = false;
            this.lblLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblCurrencySymbol
            // 
            this.lblCurrencySymbol.AutoSize = true;
            this.lblCurrencySymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCurrencySymbol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCurrencySymbol.Location = new System.Drawing.Point(67, 212);
            this.lblCurrencySymbol.Name = "lblCurrencySymbol";
            this.lblCurrencySymbol.Size = new System.Drawing.Size(29, 31);
            this.lblCurrencySymbol.TabIndex = 41;
            this.lblCurrencySymbol.Text = "£";
            this.lblCurrencySymbol.Visible = false;
            // 
            // MobileAppGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(309, 484);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.tbExpiryDate);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.tbCardNumber);
            this.Controls.Add(this.lblAccHolderName);
            this.Controls.Add(this.tbAccHolderName);
            this.Controls.Add(this.lblAddPaymentDetails);
            this.Controls.Add(this.lblCvvConfirmed);
            this.Controls.Add(this.lblCvvText);
            this.Controls.Add(this.lblCvvTitle);
            this.Controls.Add(this.lbPaymentOptions);
            this.Controls.Add(this.lblPaymentTitle);
            this.Controls.Add(this.lblNavTopUp);
            this.Controls.Add(this.lblNavBalance);
            this.Controls.Add(this.lblNavHome);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnOpenMenu);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.btnCloseMenu);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTopUp);
            this.Controls.Add(this.tbTopUp);
            this.Controls.Add(this.lblBalanceValue);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbCvvNumber);
            this.Controls.Add(this.lblCurrencySymbol);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.btnCvvConfirmed);
            this.Controls.Add(this.btnCvvScreen);
            this.Controls.Add(this.btnPaymentOptions);
            this.Controls.Add(this.btnTopUp);
            this.Name = "MobileAppGUI";
            this.Text = "MobileAppGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MobileAppGUI_FormClosing);
            this.Load += new System.EventHandler(this.MobileAppGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUsername;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label lblPassword;
        private Button btnLogin;
        private Label lblHome;
        private Label lblBalance;
        private Label lblTopUp;
        private Panel pnlMenu;
        private Button btnCloseMenu;
        private Button btnOpenMenu;
        private Label lblLogin;
        private Label lblNavHome;
        private Label lblNavBalance;
        private Label lblNavTopUp;
        private Label lblBalanceValue;
        private Button btnTopUp;
        private TextBox tbTopUp;
        private Label lblPayment;
        private Label lblWelcome;
        private Label lblUser;
        private Label lblPaymentTitle;
        private ListBox lbPaymentOptions;
        private Button btnPaymentOptions;
        private Label lblCvvTitle;
        private Label lblCvvText;
        private TextBox tbCvvNumber;
        private Button btnCvvScreen;
        private Label lblCvvConfirmed;
        private Button btnCvvConfirmed;
        private Label lblAddPaymentDetails;
        private TextBox tbAccHolderName;
        private Label lblAccHolderName;
        private Label lblCardNumber;
        private TextBox tbCardNumber;
        private Label lblExpDate;
        private TextBox tbExpiryDate;
        private Button btnAddCard;
        private Label lblLogOut;
        private Label lblCurrencySymbol;
    }
}