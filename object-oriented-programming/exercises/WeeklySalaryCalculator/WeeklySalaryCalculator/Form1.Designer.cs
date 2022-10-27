namespace WeeklySalaryCalculator {
    partial class WeeklySalaryCalculatorForm {
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
            this.lblWeeklySalaryCalculator = new System.Windows.Forms.Label();
            this.lblNameFirst = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblNameMiddle = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblNameLast = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRatePerHour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAllowance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeduction = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWeeklySalaryCalculator
            // 
            this.lblWeeklySalaryCalculator.Font = new System.Drawing.Font("Segoe UI Black", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklySalaryCalculator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWeeklySalaryCalculator.Location = new System.Drawing.Point(12, 33);
            this.lblWeeklySalaryCalculator.Name = "lblWeeklySalaryCalculator";
            this.lblWeeklySalaryCalculator.Size = new System.Drawing.Size(430, 33);
            this.lblWeeklySalaryCalculator.TabIndex = 0;
            this.lblWeeklySalaryCalculator.Text = "Weekly Salary Calculator";
            this.lblWeeklySalaryCalculator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNameFirst
            // 
            this.lblNameFirst.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFirst.Location = new System.Drawing.Point(87, 89);
            this.lblNameFirst.Margin = new System.Windows.Forms.Padding(0);
            this.lblNameFirst.Name = "lblNameFirst";
            this.lblNameFirst.Size = new System.Drawing.Size(112, 20);
            this.lblNameFirst.TabIndex = 1;
            this.lblNameFirst.Text = "First name";
            this.lblNameFirst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(215, 89);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(149, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblNameMiddle
            // 
            this.lblNameMiddle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMiddle.Location = new System.Drawing.Point(87, 115);
            this.lblNameMiddle.Margin = new System.Windows.Forms.Padding(0);
            this.lblNameMiddle.Name = "lblNameMiddle";
            this.lblNameMiddle.Size = new System.Drawing.Size(112, 20);
            this.lblNameMiddle.TabIndex = 1;
            this.lblNameMiddle.Text = "Middle name";
            this.lblNameMiddle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(215, 115);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(149, 20);
            this.txtMiddleName.TabIndex = 1;
            // 
            // lblNameLast
            // 
            this.lblNameLast.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLast.Location = new System.Drawing.Point(87, 141);
            this.lblNameLast.Margin = new System.Windows.Forms.Padding(0);
            this.lblNameLast.Name = "lblNameLast";
            this.lblNameLast.Size = new System.Drawing.Size(112, 20);
            this.lblNameLast.TabIndex = 1;
            this.lblNameLast.Text = "Last name";
            this.lblNameLast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(215, 141);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(149, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // lblPosition
            // 
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(87, 167);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(112, 20);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Position";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(215, 167);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(149, 21);
            this.cmbPosition.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hours worked";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(215, 194);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(149, 20);
            this.txtHoursWorked.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rate per hour";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRatePerHour
            // 
            this.txtRatePerHour.Location = new System.Drawing.Point(215, 220);
            this.txtRatePerHour.Name = "txtRatePerHour";
            this.txtRatePerHour.Size = new System.Drawing.Size(149, 20);
            this.txtRatePerHour.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Allowance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAllowance
            // 
            this.txtAllowance.Enabled = false;
            this.txtAllowance.Location = new System.Drawing.Point(215, 246);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(149, 20);
            this.txtAllowance.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gross pay";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Enabled = false;
            this.txtGrossPay.Location = new System.Drawing.Point(215, 281);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.Size = new System.Drawing.Size(149, 20);
            this.txtGrossPay.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 307);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Deduction";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDeduction
            // 
            this.txtDeduction.Location = new System.Drawing.Point(215, 307);
            this.txtDeduction.Name = "txtDeduction";
            this.txtDeduction.Size = new System.Drawing.Size(149, 20);
            this.txtDeduction.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 333);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Net pay";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNetPay
            // 
            this.txtNetPay.Enabled = false;
            this.txtNetPay.Location = new System.Drawing.Point(215, 333);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.Size = new System.Drawing.Size(149, 20);
            this.txtNetPay.TabIndex = 9;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(91, 381);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(79, 27);
            this.btnCompute.TabIndex = 10;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(188, 381);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(79, 27);
            this.btnPreview.TabIndex = 11;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(285, 381);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 27);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // WeeklySalaryCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(454, 473);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.txtNetPay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDeduction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGrossPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAllowance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRatePerHour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblNameLast);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.lblNameMiddle);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblNameFirst);
            this.Controls.Add(this.lblWeeklySalaryCalculator);
            this.MaximumSize = new System.Drawing.Size(470, 512);
            this.MinimumSize = new System.Drawing.Size(470, 512);
            this.Name = "WeeklySalaryCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeeklySalaryCalculator";
            this.Load += new System.EventHandler(this.WeeklySalaryCalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeeklySalaryCalculator;
        private System.Windows.Forms.Label lblNameFirst;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblNameMiddle;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblNameLast;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRatePerHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAllowance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeduction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnClose;
    }
}

