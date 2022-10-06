using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonControls {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private Dictionary<string, string[]> optionsSelectedOptionsMap =
            new Dictionary<string, string[]>() {
                {"Months", new string[] {
                    "January", "February", "March", "April",
                    "May", "June", "July", "August",
                    "September", "October", "November", "December"}},
                {"Weeks", new string[] {
                    "Sunday", "Monday", "Tuesday", "Wednesday",
                    "Thursday", "Friday", "Saturday"}},
            };

        private string[] colorsSelectionArray = new string[] {"Red", "Green", "Blue"};


        private void Form1_Load(object sender, EventArgs e) {
            // Accessing each of the keys in the `optionsSelectedOptionsMap` and adding it to the combo box items
            foreach (KeyValuePair<string, string[]> dictionary in optionsSelectedOptionsMap) {
                cmbOption.Items.Add(dictionary.Key);
            }

            foreach (string option in colorsSelectionArray) {
                cblColorsSelection.Items.Add(option);
            }
        }

        private void cmbOption_SelectedIndexChanged(object sender, EventArgs e) {
            // Clearing items of the `cmbSelectedOption` as selected index is changed then resetting the text
            cmbSelectedOption.Items.Clear();
            cmbSelectedOption.ResetText();

            // Getting the array of strings of the selected index and assigning it to `selectedOptionArray`
            string[] selectedOptionArray = optionsSelectedOptionsMap[cmbOption.SelectedItem.ToString()];

            // Accessing each of the strings in the array of the selected index and adding it to the combo box
            foreach (string option in selectedOptionArray) {
                cmbSelectedOption.Items.Add(option);
            }
        }

        private void btnCblColorsSelectionSubmit_Click(object sender, EventArgs e) {
            string colors = " ";

            // Access and concatinate each checked items
            foreach (string color in cblColorsSelection.CheckedItems) {
                colors += $" {color}";
            }
            MessageBox.Show(colors);
        }

        private void btnRboColorsSelectionSubmit_Click(object sender, EventArgs e) {
            string color = "";
            if (rdoRed.Checked) {
                color = rdoRed.Text;
            } else if (rdoGreen.Checked) {
                color = rdoGreen.Text;
            } else if (rdoBlue.Checked) {
                color = rdoBlue.Text;
            }
            MessageBox.Show(color);
        }
    }
}
