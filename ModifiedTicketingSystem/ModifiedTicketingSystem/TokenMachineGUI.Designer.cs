using System.ComponentModel;
using System.Windows.Forms;

namespace ModifiedTicketingSystem {
    partial class TokenMachineGUI {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TokenMachineGUI));
            this.lbLanguages = new System.Windows.Forms.ListBox();
            this.lblLanguageTitle = new System.Windows.Forms.Label();
            this.lblAccountTitle = new System.Windows.Forms.Label();
            this.lbAccountTypes = new System.Windows.Forms.ListBox();
            this.lblJourneyTitle = new System.Windows.Forms.Label();
            this.lbJourneyType = new System.Windows.Forms.ListBox();
            this.nudTimedPass = new System.Windows.Forms.NumericUpDown();
            this.lblTimedPassTitle = new System.Windows.Forms.Label();
            this.nudTicketQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblNudQuantity = new System.Windows.Forms.Label();
            this.lblPaymentMethods = new System.Windows.Forms.Label();
            this.lbPaymentMethods = new System.Windows.Forms.ListBox();
            this.lblFinalMessage = new System.Windows.Forms.Label();
            this.lblStartStation = new System.Windows.Forms.Label();
            this.lblEndStation = new System.Windows.Forms.Label();
            this.cbEndStation = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLoginScreen = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.cbStartStation = new System.Windows.Forms.ComboBox();
            this.tbSingleJourneyPrice = new System.Windows.Forms.TextBox();
            this.lblSingleJourneyPrice = new System.Windows.Forms.Label();
            this.lblTimedPassPrice = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.lblCashTitle = new System.Windows.Forms.Label();
            this.lblTotalRemaining = new System.Windows.Forms.Label();
            this.lblAmountDueTitle = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimedPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTicketQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLanguages
            // 
            this.lbLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanguages.FormattingEnabled = true;
            this.lbLanguages.ItemHeight = 24;
            this.lbLanguages.Location = new System.Drawing.Point(117, 97);
            this.lbLanguages.Name = "lbLanguages";
            this.lbLanguages.Size = new System.Drawing.Size(256, 196);
            this.lbLanguages.TabIndex = 0;
            this.lbLanguages.SelectedIndexChanged += new System.EventHandler(this.SelectLanguage);
            this.lbLanguages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbLanguages_KeyDown);
            // 
            // lblLanguageTitle
            // 
            this.lblLanguageTitle.AutoSize = true;
            this.lblLanguageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblLanguageTitle.Location = new System.Drawing.Point(117, 68);
            this.lblLanguageTitle.Name = "lblLanguageTitle";
            this.lblLanguageTitle.Size = new System.Drawing.Size(149, 24);
            this.lblLanguageTitle.TabIndex = 1;
            this.lblLanguageTitle.Text = "lblLanguageTitle";
            // 
            // lblAccountTitle
            // 
            this.lblAccountTitle.AutoSize = true;
            this.lblAccountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAccountTitle.Location = new System.Drawing.Point(117, 68);
            this.lblAccountTitle.Name = "lblAccountTitle";
            this.lblAccountTitle.Size = new System.Drawing.Size(134, 24);
            this.lblAccountTitle.TabIndex = 2;
            this.lblAccountTitle.Text = "lblAccountTitle";
            this.lblAccountTitle.Visible = false;
            // 
            // lbAccountTypes
            // 
            this.lbAccountTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbAccountTypes.FormattingEnabled = true;
            this.lbAccountTypes.ItemHeight = 24;
            this.lbAccountTypes.Location = new System.Drawing.Point(117, 97);
            this.lbAccountTypes.Name = "lbAccountTypes";
            this.lbAccountTypes.Size = new System.Drawing.Size(256, 196);
            this.lbAccountTypes.TabIndex = 3;
            this.lbAccountTypes.Visible = false;
            this.lbAccountTypes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbAccountTypes_KeyDown);
            // 
            // lblJourneyTitle
            // 
            this.lblJourneyTitle.AutoSize = true;
            this.lblJourneyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblJourneyTitle.Location = new System.Drawing.Point(117, 68);
            this.lblJourneyTitle.Name = "lblJourneyTitle";
            this.lblJourneyTitle.Size = new System.Drawing.Size(132, 24);
            this.lblJourneyTitle.TabIndex = 4;
            this.lblJourneyTitle.Text = "lblJourneyTitle";
            this.lblJourneyTitle.Visible = false;
            // 
            // lbJourneyType
            // 
            this.lbJourneyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbJourneyType.FormattingEnabled = true;
            this.lbJourneyType.ItemHeight = 24;
            this.lbJourneyType.Location = new System.Drawing.Point(117, 97);
            this.lbJourneyType.Name = "lbJourneyType";
            this.lbJourneyType.Size = new System.Drawing.Size(256, 196);
            this.lbJourneyType.TabIndex = 5;
            this.lbJourneyType.Visible = false;
            this.lbJourneyType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbJourneyType_KeyDown);
            // 
            // nudTimedPass
            // 
            this.nudTimedPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimedPass.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTimedPass.Location = new System.Drawing.Point(119, 207);
            this.nudTimedPass.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimedPass.Name = "nudTimedPass";
            this.nudTimedPass.Size = new System.Drawing.Size(81, 29);
            this.nudTimedPass.TabIndex = 6;
            this.nudTimedPass.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimedPass.Visible = false;
            this.nudTimedPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudTimedPass_KeyDown);
            this.nudTimedPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudTimedPass_KeyUp);
            this.nudTimedPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nudTimedPass_MouseDown);
            // 
            // lblTimedPassTitle
            // 
            this.lblTimedPassTitle.AutoSize = true;
            this.lblTimedPassTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTimedPassTitle.Location = new System.Drawing.Point(117, 180);
            this.lblTimedPassTitle.Name = "lblTimedPassTitle";
            this.lblTimedPassTitle.Size = new System.Drawing.Size(101, 24);
            this.lblTimedPassTitle.TabIndex = 7;
            this.lblTimedPassTitle.Text = "Pass Days:";
            this.lblTimedPassTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimedPassTitle.Visible = false;
            // 
            // nudTicketQuantity
            // 
            this.nudTicketQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTicketQuantity.Location = new System.Drawing.Point(243, 208);
            this.nudTicketQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTicketQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTicketQuantity.Name = "nudTicketQuantity";
            this.nudTicketQuantity.Size = new System.Drawing.Size(79, 29);
            this.nudTicketQuantity.TabIndex = 8;
            this.nudTicketQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTicketQuantity.Visible = false;
            this.nudTicketQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudTicketQuantity_KeyDown);
            this.nudTicketQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudTicketQuantity_KeyUp);
            // 
            // lblNudQuantity
            // 
            this.lblNudQuantity.AutoSize = true;
            this.lblNudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNudQuantity.Location = new System.Drawing.Point(239, 181);
            this.lblNudQuantity.Name = "lblNudQuantity";
            this.lblNudQuantity.Size = new System.Drawing.Size(88, 24);
            this.lblNudQuantity.TabIndex = 9;
            this.lblNudQuantity.Text = "Quantity: ";
            this.lblNudQuantity.Visible = false;
            // 
            // lblPaymentMethods
            // 
            this.lblPaymentMethods.AutoSize = true;
            this.lblPaymentMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPaymentMethods.Location = new System.Drawing.Point(121, 68);
            this.lblPaymentMethods.Name = "lblPaymentMethods";
            this.lblPaymentMethods.Size = new System.Drawing.Size(208, 24);
            this.lblPaymentMethods.TabIndex = 10;
            this.lblPaymentMethods.Text = "Select payment method";
            this.lblPaymentMethods.Visible = false;
            // 
            // lbPaymentMethods
            // 
            this.lbPaymentMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbPaymentMethods.FormattingEnabled = true;
            this.lbPaymentMethods.ItemHeight = 24;
            this.lbPaymentMethods.Location = new System.Drawing.Point(117, 97);
            this.lbPaymentMethods.Name = "lbPaymentMethods";
            this.lbPaymentMethods.Size = new System.Drawing.Size(256, 196);
            this.lbPaymentMethods.TabIndex = 11;
            this.lbPaymentMethods.Visible = false;
            this.lbPaymentMethods.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbPaymentMethods_KeyDown);
            // 
            // lblFinalMessage
            // 
            this.lblFinalMessage.AutoSize = true;
            this.lblFinalMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblFinalMessage.Location = new System.Drawing.Point(109, 247);
            this.lblFinalMessage.Name = "lblFinalMessage";
            this.lblFinalMessage.Size = new System.Drawing.Size(307, 46);
            this.lblFinalMessage.TabIndex = 12;
            this.lblFinalMessage.Text = "lblFinalMessage";
            this.lblFinalMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinalMessage.Visible = false;
            // 
            // lblStartStation
            // 
            this.lblStartStation.AutoSize = true;
            this.lblStartStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblStartStation.Location = new System.Drawing.Point(119, 126);
            this.lblStartStation.Name = "lblStartStation";
            this.lblStartStation.Size = new System.Drawing.Size(107, 24);
            this.lblStartStation.TabIndex = 14;
            this.lblStartStation.Text = "Start Station";
            this.lblStartStation.Visible = false;
            // 
            // lblEndStation
            // 
            this.lblEndStation.AutoSize = true;
            this.lblEndStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEndStation.Location = new System.Drawing.Point(119, 197);
            this.lblEndStation.Name = "lblEndStation";
            this.lblEndStation.Size = new System.Drawing.Size(106, 24);
            this.lblEndStation.TabIndex = 15;
            this.lblEndStation.Text = "End Station";
            this.lblEndStation.Visible = false;
            // 
            // cbEndStation
            // 
            this.cbEndStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEndStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEndStation.FormattingEnabled = true;
            this.cbEndStation.Location = new System.Drawing.Point(117, 224);
            this.cbEndStation.Name = "cbEndStation";
            this.cbEndStation.Size = new System.Drawing.Size(121, 21);
            this.cbEndStation.TabIndex = 17;
            this.cbEndStation.Visible = false;
            this.cbEndStation.SelectedIndexChanged += new System.EventHandler(this.cbEndStation_SelectedIndexChanged);
            this.cbEndStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbEndStation_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPassword.Location = new System.Drawing.Point(117, 188);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 24);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "Password";
            this.lblPassword.Visible = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbPassword.Location = new System.Drawing.Point(121, 215);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 29);
            this.tbPassword.TabIndex = 21;
            this.tbPassword.Visible = false;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbUsername.Location = new System.Drawing.Point(121, 156);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 29);
            this.tbUsername.TabIndex = 20;
            this.tbUsername.Visible = false;
            this.tbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUsername_KeyDown);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUsername.Location = new System.Drawing.Point(117, 129);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 24);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "Username";
            this.lblUsername.Visible = false;
            // 
            // lblLoginScreen
            // 
            this.lblLoginScreen.AutoSize = true;
            this.lblLoginScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblLoginScreen.Location = new System.Drawing.Point(117, 70);
            this.lblLoginScreen.Name = "lblLoginScreen";
            this.lblLoginScreen.Size = new System.Drawing.Size(159, 24);
            this.lblLoginScreen.TabIndex = 18;
            this.lblLoginScreen.Text = "Enter login details";
            this.lblLoginScreen.Visible = false;
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(12, 314);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(56, 56);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 23;
            this.pbBack.TabStop = false;
            this.pbBack.Visible = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbHome
            // 
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(12, 13);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(56, 56);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHome.TabIndex = 24;
            this.pbHome.TabStop = false;
            this.pbHome.Visible = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // cbStartStation
            // 
            this.cbStartStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStartStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStartStation.FormattingEnabled = true;
            this.cbStartStation.Location = new System.Drawing.Point(117, 153);
            this.cbStartStation.Name = "cbStartStation";
            this.cbStartStation.Size = new System.Drawing.Size(121, 21);
            this.cbStartStation.TabIndex = 25;
            this.cbStartStation.Visible = false;
            this.cbStartStation.SelectedIndexChanged += new System.EventHandler(this.cbStartStation_SelectedIndexChanged);
            // 
            // tbSingleJourneyPrice
            // 
            this.tbSingleJourneyPrice.Enabled = false;
            this.tbSingleJourneyPrice.Location = new System.Drawing.Point(332, 223);
            this.tbSingleJourneyPrice.Name = "tbSingleJourneyPrice";
            this.tbSingleJourneyPrice.ReadOnly = true;
            this.tbSingleJourneyPrice.Size = new System.Drawing.Size(100, 20);
            this.tbSingleJourneyPrice.TabIndex = 26;
            this.tbSingleJourneyPrice.Visible = false;
            // 
            // lblSingleJourneyPrice
            // 
            this.lblSingleJourneyPrice.AutoSize = true;
            this.lblSingleJourneyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblSingleJourneyPrice.Location = new System.Drawing.Point(328, 197);
            this.lblSingleJourneyPrice.Name = "lblSingleJourneyPrice";
            this.lblSingleJourneyPrice.Size = new System.Drawing.Size(108, 24);
            this.lblSingleJourneyPrice.TabIndex = 27;
            this.lblSingleJourneyPrice.Text = "Ticket Price";
            this.lblSingleJourneyPrice.Visible = false;
            // 
            // lblTimedPassPrice
            // 
            this.lblTimedPassPrice.AutoSize = true;
            this.lblTimedPassPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTimedPassPrice.Location = new System.Drawing.Point(346, 181);
            this.lblTimedPassPrice.Name = "lblTimedPassPrice";
            this.lblTimedPassPrice.Size = new System.Drawing.Size(93, 24);
            this.lblTimedPassPrice.TabIndex = 29;
            this.lblTimedPassPrice.Text = "Total Cost";
            this.lblTimedPassPrice.Visible = false;
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Enabled = false;
            this.tbTotalPrice.Location = new System.Drawing.Point(349, 211);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.tbTotalPrice.TabIndex = 28;
            this.tbTotalPrice.Visible = false;
            // 
            // lblCashTitle
            // 
            this.lblCashTitle.AutoSize = true;
            this.lblCashTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCashTitle.Location = new System.Drawing.Point(192, 68);
            this.lblCashTitle.Name = "lblCashTitle";
            this.lblCashTitle.Size = new System.Drawing.Size(100, 24);
            this.lblCashTitle.TabIndex = 30;
            this.lblCashTitle.Text = "Enter cash";
            this.lblCashTitle.Visible = false;
            // 
            // lblTotalRemaining
            // 
            this.lblTotalRemaining.AutoSize = true;
            this.lblTotalRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTotalRemaining.Location = new System.Drawing.Point(216, 156);
            this.lblTotalRemaining.Name = "lblTotalRemaining";
            this.lblTotalRemaining.Size = new System.Drawing.Size(0, 24);
            this.lblTotalRemaining.TabIndex = 31;
            // 
            // lblAmountDueTitle
            // 
            this.lblAmountDueTitle.AutoSize = true;
            this.lblAmountDueTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDueTitle.Location = new System.Drawing.Point(117, 117);
            this.lblAmountDueTitle.Name = "lblAmountDueTitle";
            this.lblAmountDueTitle.Size = new System.Drawing.Size(121, 24);
            this.lblAmountDueTitle.TabIndex = 32;
            this.lblAmountDueTitle.Text = "Amount Due:";
            this.lblAmountDueTitle.Visible = false;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.Location = new System.Drawing.Point(246, 117);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(20, 24);
            this.lblAmountDue.TabIndex = 33;
            this.lblAmountDue.Text = "0";
            this.lblAmountDue.Visible = false;
            // 
            // TokenMachineGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 404);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.lblAmountDueTitle);
            this.Controls.Add(this.lblTotalRemaining);
            this.Controls.Add(this.lblCashTitle);
            this.Controls.Add(this.lblTimedPassPrice);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.lblSingleJourneyPrice);
            this.Controls.Add(this.tbSingleJourneyPrice);
            this.Controls.Add(this.lblStartStation);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLoginScreen);
            this.Controls.Add(this.lblFinalMessage);
            this.Controls.Add(this.lblNudQuantity);
            this.Controls.Add(this.nudTicketQuantity);
            this.Controls.Add(this.lblTimedPassTitle);
            this.Controls.Add(this.nudTimedPass);
            this.Controls.Add(this.lblJourneyTitle);
            this.Controls.Add(this.lblAccountTitle);
            this.Controls.Add(this.lblLanguageTitle);
            this.Controls.Add(this.lblPaymentMethods);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblEndStation);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.cbEndStation);
            this.Controls.Add(this.lbPaymentMethods);
            this.Controls.Add(this.cbStartStation);
            this.Controls.Add(this.lbJourneyType);
            this.Controls.Add(this.lbAccountTypes);
            this.Controls.Add(this.lbLanguages);
            this.DoubleBuffered = true;
            this.Name = "TokenMachineGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TokenMachineGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TokenMachineGUI_FormClosing);
            this.Load += new System.EventHandler(this.TokenMachineGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimedPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTicketQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbLanguages;
        public Label lblLanguageTitle;
        private Label lblAccountTitle;
        private ListBox lbAccountTypes;
        private Label lblJourneyTitle;
        private ListBox lbJourneyType;
        private NumericUpDown nudTimedPass;
        private Label lblTimedPassTitle;
        private NumericUpDown nudTicketQuantity;
        private Label lblNudQuantity;
        private Label lblPaymentMethods;
        private ListBox lbPaymentMethods;
        private Label lblFinalMessage;
        private Label lblStartStation;
        private Label lblEndStation;
        private ComboBox cbEndStation;
        private Label lblPassword;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Label lblUsername;
        private Label lblLoginScreen;
        private PictureBox pbBack;
        private PictureBox pbHome;
        private ComboBox cbStartStation;
        private TextBox tbSingleJourneyPrice;
        private Label lblSingleJourneyPrice;
        private Label lblTimedPassPrice;
        private TextBox tbTotalPrice;
        private Label lblCashTitle;
        private Label lblTotalRemaining;
        private Label lblAmountDueTitle;
        private Label lblAmountDue;
    }
}