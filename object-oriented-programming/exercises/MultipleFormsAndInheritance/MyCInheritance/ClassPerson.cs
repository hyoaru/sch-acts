using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCInheritance {
    class ClassPerson {
        private string _lastName;
        private string _firstName;
        private string _middleName;
        private int _age;

        public ClassPerson () {
            _lastName = "";
            _firstName = "";
            _middleName = "";
            _age = 0;
        }

        // Setters

        public void SetLastName (string lastName) {
            _lastName = lastName;
        }

        public void SetFirstName (string firstName) {
            _firstName = firstName;
        }

        public void SetMiddleName (string middleName) {
            _middleName = middleName;
        }

        public void SetAge (int age) {
            _age = age;
        }

        // Getters

        public string GetLastName () {
            return _lastName;
        }

        public string GetFirstName () {
            return _firstName;
        }

        public string GetMiddleName () {
            return _middleName;
        }

        public int GetAge () {
            return _age;
        }

    }
}
