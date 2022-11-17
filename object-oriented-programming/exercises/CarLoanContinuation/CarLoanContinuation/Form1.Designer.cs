namespace CarLoanContinuation {
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
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtMonthlyAmortization = new System.Windows.Forms.TextBox();
            this.txtGrossAmount = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.cmbLoanTerm = new System.Windows.Forms.ComboBox();
            this.cmbCarModel = new System.Windows.Forms.ComboBox();
            this.lblMonthlyAmortization = new System.Windows.Forms.Label();
            this.lblCarBrand = new System.Windows.Forms.Label();
            this.tpnlBody = new System.Windows.Forms.TableLayoutPanel();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblCarPrice = new System.Windows.Forms.Label();
            this.lblLoanTerm = new System.Windows.Forms.Label();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblGrossAmount = new System.Windows.Forms.Label();
            this.cmbCarBrand = new System.Windows.Forms.ComboBox();
            this.txtCarPrice = new System.Windows.Forms.TextBox();
            this.fpnlFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.tpnlBody.SuspendLayout();
            this.fpnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompute
            // 
            this.btnCompute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(3, 3);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(106, 41);
            this.btnCompute.TabIndex = 2;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(115, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 41);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtMonthlyAmortization
            // 
            this.txtMonthlyAmortization.Enabled = false;
            this.txtMonthlyAmortization.Location = new System.Drawing.Point(145, 178);
            this.txtMonthlyAmortization.Name = "txtMonthlyAmortization";
            this.txtMonthlyAmortization.ReadOnly = true;
            this.txtMonthlyAmortization.Size = new System.Drawing.Size(165, 20);
            this.txtMonthlyAmortization.TabIndex = 15;
            // 
            // txtGrossAmount
            // 
            this.txtGrossAmount.Enabled = false;
            this.txtGrossAmount.Location = new System.Drawing.Point(145, 153);
            this.txtGrossAmount.Name = "txtGrossAmount";
            this.txtGrossAmount.ReadOnly = true;
            this.txtGrossAmount.Size = new System.Drawing.Size(165, 20);
            this.txtGrossAmount.TabIndex = 14;
            // 
            // txtInterest
            // 
            this.txtInterest.Enabled = false;
            this.txtInterest.Location = new System.Drawing.Point(145, 128);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.ReadOnly = true;
            this.txtInterest.Size = new System.Drawing.Size(165, 20);
            this.txtInterest.TabIndex = 13;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(145, 103);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(165, 20);
            this.txtDownPayment.TabIndex = 12;
            // 
            // cmbLoanTerm
            // 
            this.cmbLoanTerm.FormattingEnabled = true;
            this.cmbLoanTerm.Location = new System.Drawing.Point(145, 78);
            this.cmbLoanTerm.Name = "cmbLoanTerm";
            this.cmbLoanTerm.Size = new System.Drawing.Size(165, 21);
            this.cmbLoanTerm.TabIndex = 11;
            this.cmbLoanTerm.SelectedIndexChanged += new System.EventHandler(this.cmbLoanTerm_SelectedIndexChanged);
            // 
            // cmbCarModel
            // 
            this.cmbCarModel.FormattingEnabled = true;
            this.cmbCarModel.Location = new System.Drawing.Point(145, 28);
            this.cmbCarModel.Name = "cmbCarModel";
            this.cmbCarModel.Size = new System.Drawing.Size(165, 21);
            this.cmbCarModel.TabIndex = 9;
            this.cmbCarModel.SelectedIndexChanged += new System.EventHandler(this.cmbCarModel_SelectedIndexChanged);
            // 
            // lblMonthlyAmortization
            // 
            this.lblMonthlyAmortization.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyAmortization.Location = new System.Drawing.Point(3, 175);
            this.lblMonthlyAmortization.Name = "lblMonthlyAmortization";
            this.lblMonthlyAmortization.Size = new System.Drawing.Size(132, 30);
            this.lblMonthlyAmortization.TabIndex = 7;
            this.lblMonthlyAmortization.Text = "Monthly Amortization";
            this.lblMonthlyAmortization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCarBrand
            // 
            this.lblCarBrand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarBrand.Location = new System.Drawing.Point(3, 0);
            this.lblCarBrand.Name = "lblCarBrand";
            this.lblCarBrand.Size = new System.Drawing.Size(81, 25);
            this.lblCarBrand.TabIndex = 0;
            this.lblCarBrand.Text = "Car Brand";
            this.lblCarBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpnlBody
            // 
            this.tpnlBody.ColumnCount = 2;
            this.tpnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.48286F));
            this.tpnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.51714F));
            this.tpnlBody.Controls.Add(this.txtMonthlyAmortization, 1, 7);
            this.tpnlBody.Controls.Add(this.txtGrossAmount, 1, 6);
            this.tpnlBody.Controls.Add(this.txtInterest, 1, 5);
            this.tpnlBody.Controls.Add(this.txtDownPayment, 1, 4);
            this.tpnlBody.Controls.Add(this.cmbLoanTerm, 1, 3);
            this.tpnlBody.Controls.Add(this.cmbCarModel, 1, 1);
            this.tpnlBody.Controls.Add(this.lblMonthlyAmortization, 0, 7);
            this.tpnlBody.Controls.Add(this.lblCarBrand, 0, 0);
            this.tpnlBody.Controls.Add(this.lblCarModel, 0, 1);
            this.tpnlBody.Controls.Add(this.lblCarPrice, 0, 2);
            this.tpnlBody.Controls.Add(this.lblLoanTerm, 0, 3);
            this.tpnlBody.Controls.Add(this.lblDownPayment, 0, 4);
            this.tpnlBody.Controls.Add(this.lblInterest, 0, 5);
            this.tpnlBody.Controls.Add(this.lblGrossAmount, 0, 6);
            this.tpnlBody.Controls.Add(this.cmbCarBrand, 1, 0);
            this.tpnlBody.Controls.Add(this.txtCarPrice, 1, 2);
            this.tpnlBody.Location = new System.Drawing.Point(114, 94);
            this.tpnlBody.Name = "tpnlBody";
            this.tpnlBody.RowCount = 8;
            this.tpnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tpnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tpnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tpnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tpnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tpnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tpnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tpnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tpnlBody.Size = new System.Drawing.Size(313, 205);
            this.tpnlBody.TabIndex = 5;
            // 
            // lblCarModel
            // 
            this.lblCarModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarModel.Location = new System.Drawing.Point(3, 25);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(81, 25);
            this.lblCarModel.TabIndex = 1;
            this.lblCarModel.Text = "Car Model";
            this.lblCarModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCarPrice
            // 
            this.lblCarPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarPrice.Location = new System.Drawing.Point(3, 50);
            this.lblCarPrice.Name = "lblCarPrice";
            this.lblCarPrice.Size = new System.Drawing.Size(81, 25);
            this.lblCarPrice.TabIndex = 2;
            this.lblCarPrice.Text = "Car Price";
            this.lblCarPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoanTerm
            // 
            this.lblLoanTerm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanTerm.Location = new System.Drawing.Point(3, 75);
            this.lblLoanTerm.Name = "lblLoanTerm";
            this.lblLoanTerm.Size = new System.Drawing.Size(81, 25);
            this.lblLoanTerm.TabIndex = 3;
            this.lblLoanTerm.Text = "Loan Term";
            this.lblLoanTerm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownPayment.Location = new System.Drawing.Point(3, 100);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(117, 25);
            this.lblDownPayment.TabIndex = 4;
            this.lblDownPayment.Text = "Down Payment";
            this.lblDownPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInterest
            // 
            this.lblInterest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(3, 125);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(96, 25);
            this.lblInterest.TabIndex = 5;
            this.lblInterest.Text = "Interest";
            this.lblInterest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGrossAmount
            // 
            this.lblGrossAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossAmount.Location = new System.Drawing.Point(3, 150);
            this.lblGrossAmount.Name = "lblGrossAmount";
            this.lblGrossAmount.Size = new System.Drawing.Size(96, 25);
            this.lblGrossAmount.TabIndex = 6;
            this.lblGrossAmount.Text = "Gross Amount";
            this.lblGrossAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCarBrand
            // 
            this.cmbCarBrand.FormattingEnabled = true;
            this.cmbCarBrand.Location = new System.Drawing.Point(145, 3);
            this.cmbCarBrand.Name = "cmbCarBrand";
            this.cmbCarBrand.Size = new System.Drawing.Size(165, 21);
            this.cmbCarBrand.TabIndex = 8;
            this.cmbCarBrand.SelectedIndexChanged += new System.EventHandler(this.cmbCarBrand_SelectedIndexChanged);
            // 
            // txtCarPrice
            // 
            this.txtCarPrice.Enabled = false;
            this.txtCarPrice.Location = new System.Drawing.Point(145, 53);
            this.txtCarPrice.Name = "txtCarPrice";
            this.txtCarPrice.ReadOnly = true;
            this.txtCarPrice.Size = new System.Drawing.Size(165, 20);
            this.txtCarPrice.TabIndex = 10;
            // 
            // fpnlFooter
            // 
            this.fpnlFooter.Controls.Add(this.btnCompute);
            this.fpnlFooter.Controls.Add(this.btnClear);
            this.fpnlFooter.Location = new System.Drawing.Point(155, 319);
            this.fpnlFooter.Name = "fpnlFooter";
            this.fpnlFooter.Size = new System.Drawing.Size(224, 48);
            this.fpnlFooter.TabIndex = 6;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(27, 38);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(489, 42);
            this.lblFormTitle.TabIndex = 4;
            this.lblFormTitle.Text = "Car Loan System";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(552, 427);
            this.Controls.Add(this.tpnlBody);
            this.Controls.Add(this.fpnlFooter);
            this.Controls.Add(this.lblFormTitle);
            this.MaximumSize = new System.Drawing.Size(568, 466);
            this.MinimumSize = new System.Drawing.Size(568, 466);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_load);
            this.tpnlBody.ResumeLayout(false);
            this.tpnlBody.PerformLayout();
            this.fpnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtMonthlyAmortization;
        private System.Windows.Forms.TextBox txtGrossAmount;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.ComboBox cmbLoanTerm;
        private System.Windows.Forms.ComboBox cmbCarModel;
        private System.Windows.Forms.Label lblMonthlyAmortization;
        private System.Windows.Forms.Label lblCarBrand;
        private System.Windows.Forms.TableLayoutPanel tpnlBody;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label lblCarPrice;
        private System.Windows.Forms.Label lblLoanTerm;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblGrossAmount;
        private System.Windows.Forms.ComboBox cmbCarBrand;
        private System.Windows.Forms.TextBox txtCarPrice;
        private System.Windows.Forms.FlowLayoutPanel fpnlFooter;
        private System.Windows.Forms.Label lblFormTitle;
    }
}

