using System;

namespace SimpleCalculator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private enum Operations { Addition, Subtraction, Multiplication, Division };
        private void Compute(Operations operation) {
            double firstNumber = 0;
            double secondNumber = 0;
            string result = "";

            try {
                firstNumber = Double.Parse(txtFirstNumber.Text);
                secondNumber = Double.Parse(txtSecondNumber.Text);
                switch (operation) {
                    case Operations.Addition:
                        result = $"{firstNumber + secondNumber}";
                        break;
                    case Operations.Subtraction:
                        result = $"{firstNumber - secondNumber}";
                        break;
                    case Operations.Multiplication:
                        result = $"{firstNumber * secondNumber}";
                        break;
                    case Operations.Division:
                        result = $"{firstNumber / secondNumber}";
                        break;
                }
            }

            catch (FormatException) {
                result = "Invalid input";
            }

            txtResult.Text = result;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            Compute(Operations.Addition);
        }

        private void btnSubtract_Click(object sender, EventArgs e) {
            Compute(Operations.Subtraction);
        }

        private void btnMultiply_Click(object sender, EventArgs e) {
            Compute(Operations.Multiplication);
        }

        private void btnDivide_Click(object sender, EventArgs e) {
            Compute(Operations.Division);
        }
    }
}