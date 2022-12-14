namespace MyCInheritance {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tpnlNavigation = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStudentForm = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.tpnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpnlNavigation
            // 
            this.tpnlNavigation.ColumnCount = 1;
            this.tpnlNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlNavigation.Controls.Add(this.button2, 0, 1);
            this.tpnlNavigation.Controls.Add(this.btnStudentForm, 0, 0);
            this.tpnlNavigation.Location = new System.Drawing.Point(13, 13);
            this.tpnlNavigation.Name = "tpnlNavigation";
            this.tpnlNavigation.RowCount = 3;
            this.tpnlNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tpnlNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tpnlNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tpnlNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlNavigation.Size = new System.Drawing.Size(138, 329);
            this.tpnlNavigation.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Teacher Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStudentForm
            // 
            this.btnStudentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStudentForm.Location = new System.Drawing.Point(3, 3);
            this.btnStudentForm.Name = "btnStudentForm";
            this.btnStudentForm.Size = new System.Drawing.Size(132, 43);
            this.btnStudentForm.TabIndex = 0;
            this.btnStudentForm.Text = "Student Form";
            this.btnStudentForm.UseVisualStyleBackColor = true;
            this.btnStudentForm.Click += new System.EventHandler(this.btnStudentForm_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Location = new System.Drawing.Point(175, 13);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(263, 329);
            this.pnlBody.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(453, 354);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.tpnlNavigation);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tpnlNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlNavigation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStudentForm;
        private System.Windows.Forms.Panel pnlBody;
    }
}

