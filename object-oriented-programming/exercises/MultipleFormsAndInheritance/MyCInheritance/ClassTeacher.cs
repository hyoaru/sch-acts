using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCInheritance {
    class ClassTeacher : ClassPerson {
        private int _employeeID;
        private string _position;
        private string _taxID;

        public ClassTeacher () {
            _employeeID = 0;
            _position = "";
            _taxID = "";
        }

        // Setters

        public void SetEmployeeID (int employeeID) {
            _employeeID = employeeID;
        }

        public void SetPosition (string position) {
            _position = position;
        }

        public void SetTaxID (string taxID) {
            _taxID = taxID;
        }

        // Getters

        public int GetEmployeeID () {
            return _employeeID;
        }

        public string GetPosition () {
            return _position;
        }

        public string GetTaxID () {
            return _taxID;
        }
    }
}
