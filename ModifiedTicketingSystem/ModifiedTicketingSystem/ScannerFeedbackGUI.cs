using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModifiedTicketingSystem {
    public partial class ScannerFeedbackGUI : Form {
        private Scanner _scanner;
        public ScannerFeedbackGUI(Scanner scanner) {
            InitializeComponent();
            _scanner = scanner;
            lblError.ForeColor = Color.Red;
            lblError.Text = "Barrier Closed";
            lblStation.Text = scanner.GetStation().GetLocation();
            string scannerType;
            if (scanner.GetScannerType() == true) {
                lblScannerType.Text = "Entry";
            } else {
                lblScannerType.Text = "Exit";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_scanner.GetScannerType() == true && tbTicketId.Text != "" ) {
                Ticket _ticket = _scanner.GetStation().GetTicketByTicketId(Convert.ToInt32(tbTicketId.Text));
                if (_ticket.GetTicketId() == 0) {
                    FinalMessage(false);
                } else {
                    _scanner.AddScannedTicket(_ticket);
                    if (_scanner.ValidateTicket()) {
                        FinalMessage(true);
                    } else {
                        FinalMessage(false);
                    }
                }
            } else if(_scanner.GetScannerType() == false && tbTicketId.Text != "") {
                Ticket _ticket = _scanner.GetStation().GetTicketByTicketId(Convert.ToInt32(tbTicketId.Text));
                if(_ticket.GetTicketId() == 0) {
                    FinalMessage(false);
                } else {
                    _scanner.AddScannedTicket(_ticket);
                    if(_scanner.ValidateTicket()) {
                        FinalMessage(true);
                    } else {
                        FinalMessage(false);
                    }
                }
            } else {
                lblError.Text = "Please enter your ticket Id";
            }
        }

        private async void FinalMessage(bool success) {
            if(success) {
                lblError.ForeColor = Color.Green;
                lblError.Text = "Barrier Open";
                await Task.Delay(3000);
                _scanner.GetBarrier().CloseBarrier();
                lblError.ForeColor = Color.Red;
                lblError.Text = "Barrier Closed";
            } else {
                lblError.ForeColor = Color.Red;
                lblError.Text = "Your ticket was rejected";
                await Task.Delay(1000);
                lblError.Text = "Barrier Closed";
            }
        }
    }
}
