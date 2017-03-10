using System.ComponentModel;
using System.Windows.Forms;

namespace ModifiedTicketingSystem {
    partial class Form1 {
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
            this.btnAddNewGUI = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnScannerCreator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewGUI
            // 
            this.btnAddNewGUI.Location = new System.Drawing.Point(81, 63);
            this.btnAddNewGUI.Name = "btnAddNewGUI";
            this.btnAddNewGUI.Size = new System.Drawing.Size(157, 67);
            this.btnAddNewGUI.TabIndex = 0;
            this.btnAddNewGUI.Text = "New Token Machine GUI";
            this.btnAddNewGUI.UseVisualStyleBackColor = true;
            this.btnAddNewGUI.Click += new System.EventHandler(this.btnAddNewGUI_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Mobile App GUI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnScannerCreator
            // 
            this.btnScannerCreator.Location = new System.Drawing.Point(383, 174);
            this.btnScannerCreator.Name = "btnScannerCreator";
            this.btnScannerCreator.Size = new System.Drawing.Size(131, 65);
            this.btnScannerCreator.TabIndex = 2;
            this.btnScannerCreator.Text = "Open Scanner Creator";
            this.btnScannerCreator.UseVisualStyleBackColor = true;
            this.btnScannerCreator.Click += new System.EventHandler(this.btnScannerCreator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 312);
            this.Controls.Add(this.btnScannerCreator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddNewGUI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddNewGUI;
        private Button button1;
        private Button btnScannerCreator;
    }
}

