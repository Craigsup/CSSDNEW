using System.ComponentModel;
using System.Windows.Forms;

namespace ModifiedTicketingSystem {
    partial class MoneyForm {
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
            this.btn1p = new System.Windows.Forms.Button();
            this.btn2p = new System.Windows.Forms.Button();
            this.btn5p = new System.Windows.Forms.Button();
            this.btn10p = new System.Windows.Forms.Button();
            this.btn20p = new System.Windows.Forms.Button();
            this.btn50p = new System.Windows.Forms.Button();
            this.btn1pound = new System.Windows.Forms.Button();
            this.btn2pound = new System.Windows.Forms.Button();
            this.btn5pound = new System.Windows.Forms.Button();
            this.btn10pound = new System.Windows.Forms.Button();
            this.btn20pound = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1p
            // 
            this.btn1p.Location = new System.Drawing.Point(13, 24);
            this.btn1p.Name = "btn1p";
            this.btn1p.Size = new System.Drawing.Size(75, 23);
            this.btn1p.TabIndex = 0;
            this.btn1p.Text = "£0.01";
            this.btn1p.UseVisualStyleBackColor = true;
            this.btn1p.Click += new System.EventHandler(this.moneyButtonClick);
            // 
            // btn2p
            // 
            this.btn2p.Location = new System.Drawing.Point(94, 24);
            this.btn2p.Name = "btn2p";
            this.btn2p.Size = new System.Drawing.Size(75, 23);
            this.btn2p.TabIndex = 1;
            this.btn2p.Text = "£0.02";
            this.btn2p.UseVisualStyleBackColor = true;
            this.btn2p.Click += new System.EventHandler(this.moneyButtonClick);
            // 
            // btn5p
            // 
            this.btn5p.Location = new System.Drawing.Point(175, 24);
            this.btn5p.Name = "btn5p";
            this.btn5p.Size = new System.Drawing.Size(75, 23);
            this.btn5p.TabIndex = 2;
            this.btn5p.Text = "£0.05";
            this.btn5p.UseVisualStyleBackColor = true;
            this.btn5p.Click += new System.EventHandler(this.moneyButtonClick);
            // 
            // btn10p
            // 
            this.btn10p.Location = new System.Drawing.Point(256, 24);
            this.btn10p.Name = "btn10p";
            this.btn10p.Size = new System.Drawing.Size(75, 23);
            this.btn10p.TabIndex = 3;
            this.btn10p.Text = "£0.10";
            this.btn10p.UseVisualStyleBackColor = true;
            this.btn10p.Click += new System.EventHandler(this.moneyButtonClick);
            // 
            // btn20p
            // 
            this.btn20p.Location = new System.Drawing.Point(13, 53);
            this.btn20p.Name = "btn20p";
            this.btn20p.Size = new System.Drawing.Size(75, 23);
            this.btn20p.TabIndex = 4;
            this.btn20p.Text = "£0.20";
            this.btn20p.UseVisualStyleBackColor = true;
            this.btn20p.Click += new System.EventHandler(this.moneyButtonClick);
            // 
            // btn50p
            // 
            this.btn50p.Location = new System.Drawing.Point(94, 53);
            this.btn50p.Name = "btn50p";
            this.btn50p.Size = new System.Drawing.Size(75, 23);
            this.btn50p.TabIndex = 5;
            this.btn50p.Text = "£0.50";
            this.btn50p.UseVisualStyleBackColor = true;
            this.btn50p.Click += new System.EventHandler(this.moneyButtonClick);
            // 
            // btn1pound
            // 
            this.btn1pound.Location = new System.Drawing.Point(175, 53);
            this.btn1pound.Name = "btn1pound";
            this.btn1pound.Size = new System.Drawing.Size(75, 23);
            this.btn1pound.TabIndex = 6;
            this.btn1pound.Text = "£1.00";
            this.btn1pound.UseVisualStyleBackColor = true;
            this.btn1pound.Click += new System.EventHandler(this.moneyButtonClick);
            // 
            // btn2pound
            // 
            this.btn2pound.Location = new System.Drawing.Point(256, 53);
            this.btn2pound.Name = "btn2pound";
            this.btn2pound.Size = new System.Drawing.Size(75, 23);
            this.btn2pound.TabIndex = 7;
            this.btn2pound.Text = "£2.00";
            this.btn2pound.UseVisualStyleBackColor = true;
            this.btn2pound.Click += new System.EventHandler(this.moneyButtonClick);
            // 
            // btn5pound
            // 
            this.btn5pound.Location = new System.Drawing.Point(45, 90);
            this.btn5pound.Name = "btn5pound";
            this.btn5pound.Size = new System.Drawing.Size(120, 40);
            this.btn5pound.TabIndex = 8;
            this.btn5pound.Text = "£5.00";
            this.btn5pound.UseVisualStyleBackColor = true;
            this.btn5pound.Click += new System.EventHandler(this.moneyButtonClick);
            // 
            // btn10pound
            // 
            this.btn10pound.Location = new System.Drawing.Point(171, 90);
            this.btn10pound.Name = "btn10pound";
            this.btn10pound.Size = new System.Drawing.Size(120, 40);
            this.btn10pound.TabIndex = 9;
            this.btn10pound.Text = "£10.00";
            this.btn10pound.UseVisualStyleBackColor = true;
            this.btn10pound.Click += new System.EventHandler(this.moneyButtonClick);
            // 
            // btn20pound
            // 
            this.btn20pound.Location = new System.Drawing.Point(105, 136);
            this.btn20pound.Name = "btn20pound";
            this.btn20pound.Size = new System.Drawing.Size(120, 40);
            this.btn20pound.TabIndex = 10;
            this.btn20pound.Text = "£20.00";
            this.btn20pound.UseVisualStyleBackColor = true;
            this.btn20pound.Click += new System.EventHandler(this.moneyButtonClick);
            // 
            // MoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 195);
            this.Controls.Add(this.btn20pound);
            this.Controls.Add(this.btn10pound);
            this.Controls.Add(this.btn5pound);
            this.Controls.Add(this.btn2pound);
            this.Controls.Add(this.btn1pound);
            this.Controls.Add(this.btn50p);
            this.Controls.Add(this.btn20p);
            this.Controls.Add(this.btn10p);
            this.Controls.Add(this.btn5p);
            this.Controls.Add(this.btn2p);
            this.Controls.Add(this.btn1p);
            this.Name = "MoneyForm";
            this.Text = "Cash";
            this.Load += new System.EventHandler(this.MoneyForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn1p;
        private Button btn2p;
        private Button btn5p;
        private Button btn10p;
        private Button btn20p;
        private Button btn50p;
        private Button btn1pound;
        private Button btn2pound;
        private Button btn5pound;
        private Button btn10pound;
        private Button btn20pound;
    }
}