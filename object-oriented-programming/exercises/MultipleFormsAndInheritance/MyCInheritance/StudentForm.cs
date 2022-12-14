using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCInheritance {
    public partial class StudentForm : Form {
        ClassStudent student = new ClassStudent();

        public StudentForm () {
            InitializeComponent();
        }

        private void btnPreview_Click (object sender, EventArgs e) {
            student.SetStudentNumber(int.Parse(txtStudentNumber.Text));
            student.SetLastName(txtLastName.Text);
            student.SetFirstName(txtFirstName.Text);
            student.SetMiddleName(txtMiddleName.Text);
            student.SetAge(int.Parse(txtAge.Text));
            student.SetCourse(txtCourse.Text);
            student.SetDepartment(txtDepartment.Text);

            string message = String.Concat(
                "Student Number: ", student.GetStudentNumber().ToString(), "\n",
                "Last Name: ", student.GetLastName(), "\n",
                "First Name: ", student.GetFirstName(), "\n",
                "Middle Name: ", student.GetMiddleName(), "\n",
                "Age : ", student.GetAge().ToString(), "\n",
                "Course : ", student.GetCourse(), "\n",
                "Department : ", student.GetDepartment(), "\n"
            );

            MessageBox.Show(message);
        }

        private void btnClose_Click (object sender, EventArgs e) {
            this.Close();
        }
    }
}
