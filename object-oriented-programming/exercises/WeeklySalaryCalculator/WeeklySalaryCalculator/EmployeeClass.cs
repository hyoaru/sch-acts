using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklySalaryCalculator {
    class EmployeeClass {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int HoursWorked { get; set; }
        public double RatePerHour { get; set; }
        public double Deduction { get; set; }
        public string Position { get; set; }
        private double _allowance;
        private double _grossPay;
        private double _netPay;

        public static Dictionary<string, int> PositionAllowanceMap =
            new Dictionary<string, int> {
                {"Regular", 1000}, { "Probationary", 500}, {"Part-time", 100}
            };

        public double ComputeAllowance() {
            _allowance = PositionAllowanceMap[Position];
            return _allowance;
        }

        public double ComputeGrossPay() {
            _grossPay = (RatePerHour * HoursWorked) + _allowance;
            return _grossPay;
        }

        public double ComputeNetPay() {
            _netPay = ComputeGrossPay() - Deduction;
            return _netPay;
        }
    }
}
