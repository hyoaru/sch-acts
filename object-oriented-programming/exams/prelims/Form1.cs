using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrelimCabrera{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        private Dictionary<string, int> ticketTypeAndCostMap = new Dictionary<string, int>(){
            {"Premiere", 250}, {"Normal", 200}, {"Discount", 100}
        };

        private void Form1_Load(object sender, EventArgs e){
            foreach(KeyValuePair<string, int> dictionary in ticketTypeAndCostMap) {
                cmbTicketType.Items.Add(dictionary.Key);
            }
        }

        private void btnCompute_Click(object sender, EventArgs e) {
            int ticketQuantity = 0;
            try {
                ticketQuantity = int.Parse(txtTicketQuantity.Text);
            } catch (FormatException) {
                txtTicketQuantity.Text = "Invalid Input";
                cmbTicketType.ResetText();
                txtSummaryTicketQuantity.Clear();
                txtSummaryTicketType.Clear();
                txtSummaryTotalAmount.Clear();
                txtSummaryTypeCost.Clear();
            }

            if (!txtTicketQuantity.Text.Equals("Invalid Input")) {
                txtSummaryTicketQuantity.Text = $"{ticketQuantity}";
                txtSummaryTicketType.Text = cmbTicketType.Text;
                txtSummaryTypeCost.Text = $"{ticketTypeAndCostMap[cmbTicketType.Text]}";

                int totalAmount = (
                    cmbTicketType.Text.Equals("") ? 0 
                    : ticketQuantity * ticketTypeAndCostMap[cmbTicketType.Text]);

                txtSummaryTotalAmount.Text = $"{totalAmount}";
            }
        }
    }
}
