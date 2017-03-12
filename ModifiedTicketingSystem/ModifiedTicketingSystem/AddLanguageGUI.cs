using System;
using System.IO;
using System.Windows.Forms;

namespace ModifiedTicketingSystem {
    public partial class AddLanguageGUI : Form {
        int count = 0;
        string[] languageTemp = new string[20];
        string path = Path.Combine(Environment.CurrentDirectory, @"Languages\");
        string[] newLang = new string[20];

        public AddLanguageGUI() {
            InitializeComponent();
            //Get the location of the English .language file
            string[] files = Directory.GetFiles(path, "1english.language");

            //Load the English language into an array
            languageTemp = File.ReadAllLines(files[0]);
        }

        private void tbTranslateText_KeyDown(object sender, KeyEventArgs e) {
            //When user presses enter key
            if (e.KeyData == Keys.Enter) {
                //After language name has been entered, display text to translate and change to ask for translation.
                if (count == 0) {
                    lblAskForTranslation.Text = "Enter translations for the following text:";
                    lblTranslateText.Visible = true;
                }
                //Store translated text in new language array and then increment counter
                newLang[count] = tbTranslateText.Text;
                count++;
                //Check if this is the last piece of text to be translated
                if (languageTemp.Length == count) {
                    //Write the new language to a .language file
                    File.WriteAllLines(path + newLang[0] + ".language", newLang);
                    Close();
                } else {
                    //If not the last piece of text, display the next piece to be translated and clear the text box
                    lblTranslateText.Text = languageTemp[count];
                    tbTranslateText.Clear();
                }
            }
        }
    }
}
