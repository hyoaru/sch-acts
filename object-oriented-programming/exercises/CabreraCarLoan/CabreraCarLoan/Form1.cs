using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabreraCarLoan {
    public partial class MainForm : Form {
        LoanClient loanClient = new LoanClient();
        private double _carPrice;
        private double _downPayment;
        private double _interest;
        private double _grossAmount;
        private double _monthlyAmortization;

        public MainForm() {
            InitializeComponent();
        }

        private void LoadItemsInCarBrand() {
            foreach (KeyValuePair<string, string[]> dictionary in LoanClient.BrandModelMap) {
                cmbCarBrand.Items.Add(dictionary.Key);
            }
        }

        private void LoadItemsInCarModel() {
            foreach (string model in LoanClient.BrandModelMap[loanClient.CarBrand]) {
                cmbCarModel.Items.Add(model);
            }
        }

        private void LoadItemsInLoanTerm() {
            foreach (int loanTerm in LoanClient.TermInterestMap.Keys) {
                cmbLoanTerm.Items.Add(loanTerm.ToString());
            }
        }

        private void ComputeOutputFields() {
            _carPrice = loanClient.GetCarPrice();
            _interest = loanClient.GetInterest();
            _grossAmount = loanClient.GetGrossAmount();
            _monthlyAmortization = loanClient.GetMonthlyAmortization();
        }

        private void ClearOutputFields() {
            txtCarPrice.Clear();
            txtInterest.Clear();
            txtGrossAmount.Clear();
            txtMonthlyAmortization.Clear();
        }

        private void ClearInputFields() {
            cmbCarBrand.ResetText();
            cmbCarModel.ResetText();
            cmbLoanTerm.ResetText();
            txtDownPayment.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            LoadItemsInCarBrand();
            LoadItemsInLoanTerm();
        }

        private void cmbCarBrand_SelectedIndexChanged(object sender, EventArgs e) {
            ClearOutputFields();
            cmbCarModel.Items.Clear();
            cmbCarModel.ResetText();

            loanClient.CarBrand = cmbCarBrand.Text;
            LoadItemsInCarModel();
        }

        private void cmbCarModel_SelectedIndexChanged(object sender, EventArgs e) {
            loanClient.CarModel = cmbCarModel.Text;
            ClearOutputFields();
            txtCarPrice.Text = loanClient.GetCarPrice().ToString();
        }

        private void cmbLoanTerm_SelectedIndexChanged(object sender, EventArgs e) {
            loanClient.LoanTerm = int.Parse(cmbLoanTerm.Text);
        }

        private void btnCompute_Click(object sender, EventArgs e) {
            try {
                _downPayment = double.Parse(txtDownPayment.Text);
                loanClient.DownPayment = _downPayment;

                ComputeOutputFields();
                txtInterest.Text = _interest.ToString();
                txtGrossAmount.Text = _grossAmount.ToString();
                txtMonthlyAmortization.Text = _monthlyAmortization.ToString();
            } catch (Exception) {
                ClearInputFields();
                ClearOutputFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            ClearInputFields();
            ClearOutputFields();
        }
    }
}
