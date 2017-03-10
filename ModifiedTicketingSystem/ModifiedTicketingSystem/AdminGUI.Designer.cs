namespace ModifiedTicketingSystem {
    partial class AdminGUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.lblLoginDetails = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tcAdminViews = new System.Windows.Forms.TabControl();
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.lblSingleTicketsUsed = new System.Windows.Forms.Label();
            this.lblTimedPassesBought = new System.Windows.Forms.Label();
            this.lblTimedPassesUsed = new System.Windows.Forms.Label();
            this.lblStationSelect = new System.Windows.Forms.Label();
            this.lblTimedPasses = new System.Windows.Forms.Label();
            this.lblSingleTicketsBought = new System.Windows.Forms.Label();
            this.cbStations = new System.Windows.Forms.ComboBox();
            this.lblTicketCount = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            this.tabRoutes = new System.Windows.Forms.TabPage();
            this.lbRoutes = new System.Windows.Forms.ListBox();
            this.lblCreateRoute = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectStation = new System.Windows.Forms.ComboBox();
            this.lblRoutes = new System.Windows.Forms.Label();
            this.lblStartStation = new System.Windows.Forms.Label();
            this.lblEndStation = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCreateRoute = new System.Windows.Forms.Button();
            this.tbPriceEntry = new System.Windows.Forms.TextBox();
            this.lblStartStationEntry = new System.Windows.Forms.Label();
            this.cbEndStationEntry = new System.Windows.Forms.ComboBox();
            this.tcAdminViews.SuspendLayout();
            this.tabTickets.SuspendLayout();
            this.tabRoutes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoginDetails
            // 
            this.lblLoginDetails.AutoSize = true;
            this.lblLoginDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginDetails.Location = new System.Drawing.Point(183, 96);
            this.lblLoginDetails.Name = "lblLoginDetails";
            this.lblLoginDetails.Size = new System.Drawing.Size(261, 24);
            this.lblLoginDetails.TabIndex = 0;
            this.lblLoginDetails.Text = "Please enter your login details";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUsername.Location = new System.Drawing.Point(254, 153);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 24);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPassword.Location = new System.Drawing.Point(254, 225);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 24);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbUsername.Location = new System.Drawing.Point(214, 180);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(191, 29);
            this.tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbPassword.Location = new System.Drawing.Point(214, 252);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(191, 29);
            this.tbPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Turquoise;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLogin.Location = new System.Drawing.Point(258, 301);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tcAdminViews
            // 
            this.tcAdminViews.Controls.Add(this.tabTickets);
            this.tcAdminViews.Controls.Add(this.tabRoutes);
            this.tcAdminViews.Location = new System.Drawing.Point(30, 29);
            this.tcAdminViews.Name = "tcAdminViews";
            this.tcAdminViews.SelectedIndex = 0;
            this.tcAdminViews.Size = new System.Drawing.Size(557, 398);
            this.tcAdminViews.TabIndex = 6;
            this.tcAdminViews.Visible = false;
            // 
            // tabTickets
            // 
            this.tabTickets.Controls.Add(this.lblSingleTicketsUsed);
            this.tabTickets.Controls.Add(this.lblTimedPassesBought);
            this.tabTickets.Controls.Add(this.lblTimedPassesUsed);
            this.tabTickets.Controls.Add(this.lblStationSelect);
            this.tabTickets.Controls.Add(this.lblTimedPasses);
            this.tabTickets.Controls.Add(this.lblSingleTicketsBought);
            this.tabTickets.Controls.Add(this.cbStations);
            this.tabTickets.Controls.Add(this.lblTicketCount);
            this.tabTickets.Controls.Add(this.lblTickets);
            this.tabTickets.Location = new System.Drawing.Point(4, 22);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tabTickets.Size = new System.Drawing.Size(549, 372);
            this.tabTickets.TabIndex = 0;
            this.tabTickets.Text = "Tickets";
            this.tabTickets.UseVisualStyleBackColor = true;
            // 
            // lblSingleTicketsUsed
            // 
            this.lblSingleTicketsUsed.AutoSize = true;
            this.lblSingleTicketsUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSingleTicketsUsed.Location = new System.Drawing.Point(22, 174);
            this.lblSingleTicketsUsed.Name = "lblSingleTicketsUsed";
            this.lblSingleTicketsUsed.Size = new System.Drawing.Size(213, 20);
            this.lblSingleTicketsUsed.TabIndex = 8;
            this.lblSingleTicketsUsed.Text = "Single Journey Tickets Used:";
            // 
            // lblTimedPassesBought
            // 
            this.lblTimedPassesBought.AutoSize = true;
            this.lblTimedPassesBought.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTimedPassesBought.Location = new System.Drawing.Point(34, 329);
            this.lblTimedPassesBought.Name = "lblTimedPassesBought";
            this.lblTimedPassesBought.Size = new System.Drawing.Size(164, 20);
            this.lblTimedPassesBought.TabIndex = 7;
            this.lblTimedPassesBought.Text = "Bought at this station:";
            // 
            // lblTimedPassesUsed
            // 
            this.lblTimedPassesUsed.AutoSize = true;
            this.lblTimedPassesUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTimedPassesUsed.Location = new System.Drawing.Point(34, 296);
            this.lblTimedPassesUsed.Name = "lblTimedPassesUsed";
            this.lblTimedPassesUsed.Size = new System.Drawing.Size(150, 20);
            this.lblTimedPassesUsed.TabIndex = 6;
            this.lblTimedPassesUsed.Text = "Used at this station:";
            // 
            // lblStationSelect
            // 
            this.lblStationSelect.AutoSize = true;
            this.lblStationSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblStationSelect.Location = new System.Drawing.Point(15, 61);
            this.lblStationSelect.Name = "lblStationSelect";
            this.lblStationSelect.Size = new System.Drawing.Size(243, 24);
            this.lblStationSelect.TabIndex = 5;
            this.lblStationSelect.Text = "Select a station to view data:";
            // 
            // lblTimedPasses
            // 
            this.lblTimedPasses.AutoSize = true;
            this.lblTimedPasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTimedPasses.Location = new System.Drawing.Point(20, 261);
            this.lblTimedPasses.Name = "lblTimedPasses";
            this.lblTimedPasses.Size = new System.Drawing.Size(108, 20);
            this.lblTimedPasses.TabIndex = 4;
            this.lblTimedPasses.Text = "Timed Passes";
            // 
            // lblSingleTicketsBought
            // 
            this.lblSingleTicketsBought.AutoSize = true;
            this.lblSingleTicketsBought.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSingleTicketsBought.Location = new System.Drawing.Point(22, 135);
            this.lblSingleTicketsBought.Name = "lblSingleTicketsBought";
            this.lblSingleTicketsBought.Size = new System.Drawing.Size(227, 20);
            this.lblSingleTicketsBought.TabIndex = 3;
            this.lblSingleTicketsBought.Text = "Single Journey Tickets Bought:";
            // 
            // cbStations
            // 
            this.cbStations.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStations.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStations.FormattingEnabled = true;
            this.cbStations.Location = new System.Drawing.Point(19, 88);
            this.cbStations.Name = "cbStations";
            this.cbStations.Size = new System.Drawing.Size(178, 21);
            this.cbStations.TabIndex = 2;
            this.cbStations.SelectedIndexChanged += new System.EventHandler(this.cbStations_SelectedIndexChanged);
            // 
            // lblTicketCount
            // 
            this.lblTicketCount.AutoSize = true;
            this.lblTicketCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTicketCount.Location = new System.Drawing.Point(140, 14);
            this.lblTicketCount.Name = "lblTicketCount";
            this.lblTicketCount.Size = new System.Drawing.Size(20, 24);
            this.lblTicketCount.TabIndex = 1;
            this.lblTicketCount.Text = "0";
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTickets.Location = new System.Drawing.Point(15, 14);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(120, 24);
            this.lblTickets.TabIndex = 0;
            this.lblTickets.Text = "Total Tickets:";
            // 
            // tabRoutes
            // 
            this.tabRoutes.Controls.Add(this.cbEndStationEntry);
            this.tabRoutes.Controls.Add(this.lblStartStationEntry);
            this.tabRoutes.Controls.Add(this.tbPriceEntry);
            this.tabRoutes.Controls.Add(this.btnCreateRoute);
            this.tabRoutes.Controls.Add(this.lblPrice);
            this.tabRoutes.Controls.Add(this.lblEndStation);
            this.tabRoutes.Controls.Add(this.lblStartStation);
            this.tabRoutes.Controls.Add(this.lbRoutes);
            this.tabRoutes.Controls.Add(this.lblCreateRoute);
            this.tabRoutes.Controls.Add(this.label1);
            this.tabRoutes.Controls.Add(this.cbSelectStation);
            this.tabRoutes.Controls.Add(this.lblRoutes);
            this.tabRoutes.Location = new System.Drawing.Point(4, 22);
            this.tabRoutes.Name = "tabRoutes";
            this.tabRoutes.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoutes.Size = new System.Drawing.Size(549, 372);
            this.tabRoutes.TabIndex = 1;
            this.tabRoutes.Text = "Routes";
            this.tabRoutes.UseVisualStyleBackColor = true;
            // 
            // lbRoutes
            // 
            this.lbRoutes.FormattingEnabled = true;
            this.lbRoutes.Location = new System.Drawing.Point(16, 129);
            this.lbRoutes.Name = "lbRoutes";
            this.lbRoutes.Size = new System.Drawing.Size(231, 225);
            this.lbRoutes.TabIndex = 6;
            // 
            // lblCreateRoute
            // 
            this.lblCreateRoute.AutoSize = true;
            this.lblCreateRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCreateRoute.Location = new System.Drawing.Point(288, 105);
            this.lblCreateRoute.Name = "lblCreateRoute";
            this.lblCreateRoute.Size = new System.Drawing.Size(122, 20);
            this.lblCreateRoute.TabIndex = 5;
            this.lblCreateRoute.Text = "Create a Route:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Routes from this station";
            // 
            // cbSelectStation
            // 
            this.cbSelectStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSelectStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSelectStation.FormattingEnabled = true;
            this.cbSelectStation.Location = new System.Drawing.Point(345, 43);
            this.cbSelectStation.Name = "cbSelectStation";
            this.cbSelectStation.Size = new System.Drawing.Size(178, 21);
            this.cbSelectStation.TabIndex = 3;
            this.cbSelectStation.SelectedIndexChanged += new System.EventHandler(this.cbSelectStation_SelectedIndexChanged);
            // 
            // lblRoutes
            // 
            this.lblRoutes.AutoSize = true;
            this.lblRoutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblRoutes.Location = new System.Drawing.Point(12, 40);
            this.lblRoutes.Name = "lblRoutes";
            this.lblRoutes.Size = new System.Drawing.Size(327, 24);
            this.lblRoutes.TabIndex = 0;
            this.lblRoutes.Text = "Select a Station to show route options:";
            // 
            // lblStartStation
            // 
            this.lblStartStation.AutoSize = true;
            this.lblStartStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStartStation.Location = new System.Drawing.Point(292, 158);
            this.lblStartStation.Name = "lblStartStation";
            this.lblStartStation.Size = new System.Drawing.Size(103, 20);
            this.lblStartStation.TabIndex = 8;
            this.lblStartStation.Text = "Start Station:";
            // 
            // lblEndStation
            // 
            this.lblEndStation.AutoSize = true;
            this.lblEndStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEndStation.Location = new System.Drawing.Point(292, 198);
            this.lblEndStation.Name = "lblEndStation";
            this.lblEndStation.Size = new System.Drawing.Size(97, 20);
            this.lblEndStation.TabIndex = 9;
            this.lblEndStation.Text = "End Station:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrice.Location = new System.Drawing.Point(292, 250);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 20);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price:";
            // 
            // btnCreateRoute
            // 
            this.btnCreateRoute.Location = new System.Drawing.Point(448, 297);
            this.btnCreateRoute.Name = "btnCreateRoute";
            this.btnCreateRoute.Size = new System.Drawing.Size(75, 23);
            this.btnCreateRoute.TabIndex = 11;
            this.btnCreateRoute.Text = "Create";
            this.btnCreateRoute.UseVisualStyleBackColor = true;
            // 
            // tbPriceEntry
            // 
            this.tbPriceEntry.Location = new System.Drawing.Point(410, 250);
            this.tbPriceEntry.Name = "tbPriceEntry";
            this.tbPriceEntry.Size = new System.Drawing.Size(113, 20);
            this.tbPriceEntry.TabIndex = 12;
            // 
            // lblStartStationEntry
            // 
            this.lblStartStationEntry.AutoSize = true;
            this.lblStartStationEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStartStationEntry.Location = new System.Drawing.Point(410, 158);
            this.lblStartStationEntry.Name = "lblStartStationEntry";
            this.lblStartStationEntry.Size = new System.Drawing.Size(0, 20);
            this.lblStartStationEntry.TabIndex = 13;
            // 
            // cbEndStationEntry
            // 
            this.cbEndStationEntry.FormattingEnabled = true;
            this.cbEndStationEntry.Location = new System.Drawing.Point(410, 201);
            this.cbEndStationEntry.Name = "cbEndStationEntry";
            this.cbEndStationEntry.Size = new System.Drawing.Size(113, 21);
            this.cbEndStationEntry.TabIndex = 14;
            // 
            // AdminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 454);
            this.Controls.Add(this.tcAdminViews);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLoginDetails);
            this.Name = "AdminGUI";
            this.Text = "AdminGUI";
            this.Load += new System.EventHandler(this.AdminGUI_Load);
            this.tcAdminViews.ResumeLayout(false);
            this.tabTickets.ResumeLayout(false);
            this.tabTickets.PerformLayout();
            this.tabRoutes.ResumeLayout(false);
            this.tabRoutes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginDetails;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TabControl tcAdminViews;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.TabPage tabRoutes;
        private System.Windows.Forms.Label lblRoutes;
        private System.Windows.Forms.ComboBox cbStations;
        private System.Windows.Forms.Label lblTicketCount;
        private System.Windows.Forms.Label lblStationSelect;
        private System.Windows.Forms.Label lblTimedPasses;
        private System.Windows.Forms.Label lblSingleTicketsBought;
        private System.Windows.Forms.Label lblSingleTicketsUsed;
        private System.Windows.Forms.Label lblTimedPassesBought;
        private System.Windows.Forms.Label lblTimedPassesUsed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelectStation;
        private System.Windows.Forms.ListBox lbRoutes;
        private System.Windows.Forms.Label lblCreateRoute;
        private System.Windows.Forms.Label lblStartStationEntry;
        private System.Windows.Forms.TextBox tbPriceEntry;
        private System.Windows.Forms.Button btnCreateRoute;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblEndStation;
        private System.Windows.Forms.Label lblStartStation;
        private System.Windows.Forms.ComboBox cbEndStationEntry;
    }
}