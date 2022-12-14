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
    public partial class MainForm : Form {
        public MainForm () {
            InitializeComponent();
        }

        private void ShowForm(Form form) {
            pnlBody.Controls.Clear();
            form.TopLevel = false;
            pnlBody.Controls.Add(form);
            form.Show();
        }

        private void btnStudentForm_Click (object sender, EventArgs e) {
            ShowForm(new StudentForm());
        }

        private void button2_Click (object sender, EventArgs e) {
            ShowForm(new TeacherForm());
        }
    }
}
