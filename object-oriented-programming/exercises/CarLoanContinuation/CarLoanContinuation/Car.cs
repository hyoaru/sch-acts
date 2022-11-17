using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLoanContinuation {
    class Car {
        string brand;
        string model;
        double price;
        int terms;
        double interestRate;
        double interest;
        double downpayment;
        double monthlyAmortization;
        double grossAmount;
        double netPrice;
        public Car() {
            brand = "";
            model = "";
            price = 0;
            terms = 0;
            interestRate = 0;
            interest = 0;
            downpayment = 0;
            monthlyAmortization = 0;
            grossAmount = 0;
            netPrice = 0;
        }

        public void SetBrand(string brd) {
            brand = brd;
        }
        public string GetBrand() {
            return brand;
        }
        public void SetModel(string mdl) {
            model = mdl;
        }
        public string GetModel() {
            return model;
        }
        public void SetPrice(double p) {
            price = p;
        }
        public double GetPrice() {
            return price;
        }
        public void SetTerms(int trms) {
            terms = trms;
        }
        public int GetTerms() {
            return terms;
        }
        public void SetInterestRate() {
            if (terms == 24)
                interestRate = 0.15;
            if (terms == 36)
                interestRate = 0.10;
            if (terms == 48)
                interestRate = 0.05;
            if (terms == 60)
                interestRate = 0.03;
        }
        public double GetInterestRate() {
            return interestRate;
        }
        public void SetDownpayment(double dp) {
            downpayment = dp;
        }
        public double GetDownpayment() {
            return downpayment;
        }
        public void ComputeNetPrice() {
            netPrice = price - downpayment;
        }
        public double GetNetPrice() {
            return netPrice;
        }
        public void ComputeInterest() {
            interest = netPrice * interestRate;
        }
        public double GetInterest() {
            return interest;
        }
        public void ComputeGrossAmount() {
            grossAmount = netPrice + interest;
        }
        public double GetGrossAmount() {
            return grossAmount;
        }
        public void ComputeMonthlyAmortization() {
            monthlyAmortization = grossAmount / terms;
        }
        public double GetMontlyAmortization() {
            return monthlyAmortization;
        }

    }
}
