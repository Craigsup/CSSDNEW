using System.ComponentModel;
using System.Windows.Forms;

namespace ModifiedTicketingSystem {
    partial class ScannerFeedbackGUI
    {
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTicketId = new System.Windows.Forms.Label();
            this.tbTicketId = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.lblScannerType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(75, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Scanner GUI";
            // 
            // lblTicketId
            // 
            this.lblTicketId.AutoSize = true;
            this.lblTicketId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketId.Location = new System.Drawing.Point(12, 130);
            this.lblTicketId.Name = "lblTicketId";
            this.lblTicketId.Size = new System.Drawing.Size(92, 24);
            this.lblTicketId.TabIndex = 1;
            this.lblTicketId.Text = "Ticket ID: ";
            // 
            // tbTicketId
            // 
            this.tbTicketId.Location = new System.Drawing.Point(100, 130);
            this.tbTicketId.Name = "tbTicketId";
            this.tbTicketId.Size = new System.Drawing.Size(133, 20);
            this.tbTicketId.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(79, 167);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(97, 53);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(13, 237);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Station:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Scanner Type:";
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.Location = new System.Drawing.Point(126, 48);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(0, 17);
            this.lblStation.TabIndex = 7;
            // 
            // lblScannerType
            // 
            this.lblScannerType.AutoSize = true;
            this.lblScannerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScannerType.Location = new System.Drawing.Point(126, 85);
            this.lblScannerType.Name = "lblScannerType";
            this.lblScannerType.Size = new System.Drawing.Size(0, 17);
            this.lblScannerType.TabIndex = 8;
            // 
            // ScannerFeedbackGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 285);
            this.Controls.Add(this.lblScannerType);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbTicketId);
            this.Controls.Add(this.lblTicketId);
            this.Controls.Add(this.lblTitle);
            this.Name = "ScannerFeedbackGUI";
            this.Text = "Scanner Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblTicketId;
        private TextBox tbTicketId;
        private Button btnSubmit;
        private Label lblError;
        private Label label1;
        private Label label2;
        private Label lblStation;
        private Label lblScannerType;
    }
}

