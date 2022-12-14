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
    public partial class TeacherForm : Form {
        ClassTeacher teacher = new ClassTeacher();

        public TeacherForm () {
            InitializeComponent();
        }

        private void btnPreview_Click (object sender, EventArgs e) {
            teacher.SetEmployeeID(int.Parse(txtEmployeeID.Text));
            teacher.SetLastName(txtLastName.Text);
            teacher.SetFirstName(txtFirstName.Text);
            teacher.SetMiddleName(txtMiddleName.Text);
            teacher.SetAge(int.Parse(txtAge.Text));
            teacher.SetPosition(txtPosition.Text);
            teacher.SetTaxID(txtTaxID.Text);

            string message = String.Concat(
                "Employee ID : ", teacher.GetEmployeeID().ToString(), "\n",
                "Last Name: ", teacher.GetLastName(), "\n",
                "First Name: ", teacher.GetFirstName(), "\n",
                "Middle Name: ", teacher.GetMiddleName(), "\n",
                "Age : ", teacher.GetAge().ToString(), "\n",
                "Position : ", teacher.GetPosition(), "\n",
                "Tax ID : ", teacher.GetTaxID(), "\n"
            );

            MessageBox.Show(message);
        }

        private void btnClose_Click (object sender, EventArgs e) {
            this.Close();
        }
    }
}
