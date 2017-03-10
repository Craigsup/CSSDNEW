using System.ComponentModel;
using System.Windows.Forms;

namespace ModifiedTicketingSystem {
    partial class ScannerCreatorGUI
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.cbStation = new System.Windows.Forms.ComboBox();
            this.radEntry = new System.Windows.Forms.RadioButton();
            this.radExit = new System.Windows.Forms.RadioButton();
            this.lblScannerType = new System.Windows.Forms.Label();
            this.btnCreateScanner = new System.Windows.Forms.Button();
            this.scannerCreatorGUIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scannerCreatorGUIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(103, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Scanner Creator";
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.Location = new System.Drawing.Point(48, 55);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(76, 24);
            this.lblStation.TabIndex = 1;
            this.lblStation.Text = "Station: ";
            // 
            // cbStation
            // 
            this.cbStation.FormattingEnabled = true;
            this.cbStation.Location = new System.Drawing.Point(130, 55);
            this.cbStation.Name = "cbStation";
            this.cbStation.Size = new System.Drawing.Size(182, 21);
            this.cbStation.TabIndex = 2;
            this.cbStation.SelectedIndexChanged += new System.EventHandler(this.cbStation_SelectedIndexChanged);
            // 
            // radEntry
            // 
            this.radEntry.AutoSize = true;
            this.radEntry.Checked = true;
            this.radEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEntry.Location = new System.Drawing.Point(52, 138);
            this.radEntry.Name = "radEntry";
            this.radEntry.Size = new System.Drawing.Size(116, 21);
            this.radEntry.TabIndex = 3;
            this.radEntry.TabStop = true;
            this.radEntry.Text = "Entry Scanner";
            this.radEntry.UseVisualStyleBackColor = true;
            // 
            // radExit
            // 
            this.radExit.AutoSize = true;
            this.radExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radExit.Location = new System.Drawing.Point(207, 138);
            this.radExit.Name = "radExit";
            this.radExit.Size = new System.Drawing.Size(105, 21);
            this.radExit.TabIndex = 4;
            this.radExit.TabStop = true;
            this.radExit.Text = "Exit Scanner";
            this.radExit.UseVisualStyleBackColor = true;
            // 
            // lblScannerType
            // 
            this.lblScannerType.AutoSize = true;
            this.lblScannerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScannerType.Location = new System.Drawing.Point(107, 102);
            this.lblScannerType.Name = "lblScannerType";
            this.lblScannerType.Size = new System.Drawing.Size(129, 24);
            this.lblScannerType.TabIndex = 5;
            this.lblScannerType.Text = "Scanner Type";
            // 
            // btnCreateScanner
            // 
            this.btnCreateScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateScanner.Location = new System.Drawing.Point(107, 180);
            this.btnCreateScanner.Name = "btnCreateScanner";
            this.btnCreateScanner.Size = new System.Drawing.Size(158, 44);
            this.btnCreateScanner.TabIndex = 6;
            this.btnCreateScanner.Text = "Create Scanner";
            this.btnCreateScanner.UseVisualStyleBackColor = true;
            this.btnCreateScanner.Click += new System.EventHandler(this.btnCreateScanner_Click);
            // 
            // scannerCreatorGUIBindingSource
            // 
            this.scannerCreatorGUIBindingSource.DataSource = typeof(ModifiedTicketingSystem.ScannerCreatorGUI);
            // 
            // ScannerCreatorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 308);
            this.Controls.Add(this.btnCreateScanner);
            this.Controls.Add(this.lblScannerType);
            this.Controls.Add(this.radExit);
            this.Controls.Add(this.radEntry);
            this.Controls.Add(this.cbStation);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.lblTitle);
            this.Name = "ScannerCreatorGUI";
            this.Text = "BarrierGUI";
            ((System.ComponentModel.ISupportInitialize)(this.scannerCreatorGUIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblStation;
        private ComboBox cbStation;
        private RadioButton radEntry;
        private RadioButton radExit;
        private Label lblScannerType;
        private Button btnCreateScanner;
        private BindingSource scannerCreatorGUIBindingSource;
    }
}

