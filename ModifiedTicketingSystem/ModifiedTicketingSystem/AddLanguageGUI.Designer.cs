namespace ModifiedTicketingSystem {
    partial class AddLanguageGUI {
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
            this.lblTranslateText = new System.Windows.Forms.Label();
            this.tbTranslateText = new System.Windows.Forms.TextBox();
            this.lblAskForTranslation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTranslateText
            // 
            this.lblTranslateText.AutoSize = true;
            this.lblTranslateText.Location = new System.Drawing.Point(63, 169);
            this.lblTranslateText.Name = "lblTranslateText";
            this.lblTranslateText.Size = new System.Drawing.Size(83, 13);
            this.lblTranslateText.TabIndex = 0;
            this.lblTranslateText.Text = "Text to translate";
            this.lblTranslateText.Visible = false;
            // 
            // tbTranslateText
            // 
            this.tbTranslateText.Location = new System.Drawing.Point(66, 195);
            this.tbTranslateText.Name = "tbTranslateText";
            this.tbTranslateText.Size = new System.Drawing.Size(281, 20);
            this.tbTranslateText.TabIndex = 1;
            this.tbTranslateText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTranslateText_KeyDown);
            // 
            // lblAskForTranslation
            // 
            this.lblAskForTranslation.AutoSize = true;
            this.lblAskForTranslation.Location = new System.Drawing.Point(63, 99);
            this.lblAskForTranslation.Name = "lblAskForTranslation";
            this.lblAskForTranslation.Size = new System.Drawing.Size(156, 13);
            this.lblAskForTranslation.TabIndex = 2;
            this.lblAskForTranslation.Text = "Enter the name of the language";
            // 
            // AddLanguageGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 449);
            this.Controls.Add(this.lblAskForTranslation);
            this.Controls.Add(this.tbTranslateText);
            this.Controls.Add(this.lblTranslateText);
            this.Name = "AddLanguageGUI";
            this.Text = "AddLanguageGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTranslateText;
        private System.Windows.Forms.TextBox tbTranslateText;
        private System.Windows.Forms.Label lblAskForTranslation;
    }
}