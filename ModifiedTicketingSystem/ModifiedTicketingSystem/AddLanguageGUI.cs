using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModifiedTicketingSystem {
    public partial class AddLanguageGUI : Form {
        int count = 0;
        string[] languageTemp = new string[20];
        string path = Path.Combine(Environment.CurrentDirectory, @"Languages\");
        string[] newLang = new string[20];

        public AddLanguageGUI() {
            InitializeComponent();

            string[] files = Directory.GetFiles(path, "1english.language");

            languageTemp = File.ReadAllLines(files[0]);
            lblTranslateText.Text = "Name of Language";
        }

        private void tbTranslateText_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                newLang[count] = tbTranslateText.Text;
                count++;
                if (languageTemp.Length == count) {
                    File.WriteAllLines(path + newLang[0] + ".language", newLang);
                    Close();
                } else {
                    lblTranslateText.Text = languageTemp[count];
                    tbTranslateText.Clear();
                }
            }
        }
    }
}
