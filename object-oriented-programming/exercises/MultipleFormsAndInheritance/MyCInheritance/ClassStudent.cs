using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCInheritance {
    class ClassStudent : ClassPerson {
        private int _studentNumber;
        private string _course;
        private string _department;

        public ClassStudent () {
            _studentNumber = 0;
            _course = "";
            _department = "";
        }

        // Setters

        public void SetStudentNumber (int studentNumber) {
            _studentNumber = studentNumber;
        }

        public void SetCourse (string course) {
            _course = course;
        }

        public void SetDepartment (string department) {
            _department = department;
        }

        // Getters

        public int GetStudentNumber () {
            return _studentNumber;
        }

        public string GetCourse () {
            return _course;
        }

        public string GetDepartment () {
            return _department;
        }

    }
}
