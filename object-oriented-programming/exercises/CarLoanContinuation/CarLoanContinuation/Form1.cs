using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLoanContinuation {
    public partial class MainForm : Form {
        static string[] CarBrands = { "Toyota", "Nissan" };

        static string[] ToyotaModels = { "Raize", "Veloz", "Wigo", "Vios",};
        static double[] ToyotaModelPrices = { 1000000, 1250000, 700000, 1035000 };
        static string[] NissanModels = { "Kicks", "NV350", "Livina", "Z" };
        static double[] NissanModelPrices = { 1500000, 2000000, 1200000, 2500000 };
        static string[][] CarModels = { ToyotaModels, NissanModels };
        static double[][] CarModelsPrices = { NissanModelPrices, ToyotaModelPrices };

        static int[] Terms = { 24, 36, 48, 60 };
        static double[] InterestRates = { 0.15, 0.10, 0.05, 0.03 };

        Car loanClient = new Car();


        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_load(object sender, EventArgs e) {
            LoadCarBrands();
            LoadTerms();
        }

        private void cmbCarBrand_SelectedIndexChanged(object sender, EventArgs e) {
            cmbCarModel.ResetText();
            cmbCarModel.Items.Clear();
            LoadCarModels();
            loanClient.SetBrand(cmbCarBrand.Text);
        }

        private void cmbCarModel_SelectedIndexChanged(object sender, EventArgs e) {
            txtCarPrice.ResetText();
            LoadPrice();
            loanClient.SetModel(cmbCarModel.Text);
            loanClient.SetPrice(double.Parse(txtCarPrice.Text));
        }

        private void cmbLoanTerm_SelectedIndexChanged(object sender, EventArgs e) {
            loanClient.SetTerms(int.Parse(cmbLoanTerm.Text));
            loanClient.SetInterestRate();
        }

        private void btnCompute_Click(object sender, EventArgs e) {
            loanClient.SetDownpayment(double.Parse(txtDownPayment.Text));
            loanClient.ComputeNetPrice();
            loanClient.ComputeInterest();
            loanClient.ComputeGrossAmount();
            loanClient.ComputeMonthlyAmortization();

            txtInterest.Text = loanClient.GetInterest().ToString();
            txtGrossAmount.Text = loanClient.GetGrossAmount().ToString();
            txtMonthlyAmortization.Text = loanClient.GetMontlyAmortization().ToString();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            cmbCarBrand.ResetText();
            cmbCarModel.ResetText();
            txtCarPrice.ResetText();
            cmbLoanTerm.ResetText();
            txtDownPayment.ResetText();
            txtInterest.ResetText();
            txtGrossAmount.ResetText();
            txtMonthlyAmortization.ResetText();
        }


        // Form loading methods

        private void LoadCarBrands() {
            for (int i = 0; i < CarBrands.Length; i++) {
                cmbCarBrand.Items.Add(CarBrands[i]);
            }
        }

        private void LoadCarModels() {
            int brandIndex = cmbCarBrand.SelectedIndex;
            string[] modelArrayToUse = CarModels[brandIndex];
            for (int i = 0; i < modelArrayToUse.Length; i++) {
                cmbCarModel.Items.Add(modelArrayToUse[i]);
            }
        }

        private void LoadPrice() {
            int brandIndex = cmbCarBrand.SelectedIndex;
            int modelIndex = cmbCarModel.SelectedIndex;
            double[] modelPriceArrayToUse = CarModelsPrices[brandIndex];
            txtCarPrice.Text = modelPriceArrayToUse[modelIndex].ToString();
        }

        private void LoadTerms() {
            for (int i = 0; i < Terms.Length; i++) {
                cmbLoanTerm.Items.Add(Terms[i]);
            }
        }


    }
}
