using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabreraCarLoan {
    class LoanClient {

        // Declaring as static as every such value of the instances doesn't have to be different
        public static Dictionary<string, string[]> BrandModelMap = new Dictionary<string, string[]> {
            {"Toyota", new string[] {"Raize", "Veloz", "Wigo", "Vios", "Rush", }},
            {"Nissan", new string[] {"Kicks", "NV350", "Livina", "Z", }},
        };

        public static Dictionary<string, double> ModelPriceMap = new Dictionary<string, double> {
            {"Raize", 1000000}, {"Veloz", 1250000}, {"Wigo", 700000},
            {"Vios", 1035000}, {"Rush", 1170000}, {"Kicks", 1500000},
            {"NV350", 2000000}, {"Livina", 1200000}, {"Z", 2500000},
        };

        public static Dictionary<int, double> TermInterestMap = new Dictionary<int, double> {
            {24, 0.15}, {36, 0.10}, {48, 0.05}, {60, 0.03},
        };

        // Properties
        public double DownPayment { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int LoanTerm { get; set; }

        // Fields
        private double _carPrice;
        private double _priceLessDownPayment;
        private double _interest;
        private double _interestRate;
        private double _grossAmount;
        private double _monthlyAmortization;

        // Constructor
        public LoanClient() { }

        // Methods
        private void ComputeCarPrice() {
            _carPrice = ModelPriceMap[CarModel];
        }

        private void ComputePriceLessDownPayment() {
            _priceLessDownPayment = _carPrice - DownPayment;
        }

        private void ComputeInterest() {
            _interestRate = TermInterestMap[LoanTerm];
            _interest = _priceLessDownPayment * _interestRate;
        }

        private void ComputeGrossAmount() {
            _grossAmount = _priceLessDownPayment + _interest;
        }

        private void ComputeMonthlyAmortization() {
            _monthlyAmortization = _grossAmount / LoanTerm;
        }

        public double GetCarPrice() {
            ComputeCarPrice();
            return _carPrice;
        }

        public double GetInterest() {
            ComputeCarPrice();
            ComputePriceLessDownPayment();
            ComputeInterest();
            return _interest;
        }

        public double GetGrossAmount() {
            ComputeCarPrice();
            ComputePriceLessDownPayment();
            ComputeInterest();
            ComputeGrossAmount();
            return _grossAmount;
        }

        public double GetMonthlyAmortization() {
            ComputeCarPrice();
            ComputePriceLessDownPayment();
            ComputeInterest();
            ComputeGrossAmount();
            ComputeMonthlyAmortization();
            return _monthlyAmortization;
        }
    }
}
