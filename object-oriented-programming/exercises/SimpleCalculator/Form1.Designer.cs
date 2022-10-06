namespace SimpleCalculator {
    partial class Form1 {
        private System.ComponentModel.IContainer components = null;
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.applicationTitle = new System.Windows.Forms.Label();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // applicationTitle
            // 
            this.applicationTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applicationTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.applicationTitle.Location = new System.Drawing.Point(12, 19);
            this.applicationTitle.Name = "applicationTitle";
            this.applicationTitle.Size = new System.Drawing.Size(386, 76);
            this.applicationTitle.TabIndex = 0;
            this.applicationTitle.Text = "Simple Calculator";
            this.applicationTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstNumber.Location = new System.Drawing.Point(12, 72);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(171, 23);
            this.lblFirstNumber.TabIndex = 1;
            this.lblFirstNumber.Text = "First Number";
            this.lblFirstNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecondNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecondNumber.Location = new System.Drawing.Point(12, 101);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(171, 23);
            this.lblSecondNumber.TabIndex = 1;
            this.lblSecondNumber.Text = "Second Number";
            this.lblSecondNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstNumber.Location = new System.Drawing.Point(200, 72);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(121, 23);
            this.txtFirstNumber.TabIndex = 0;
            this.txtFirstNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecondNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecondNumber.Location = new System.Drawing.Point(200, 101);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(121, 23);
            this.txtSecondNumber.TabIndex = 1;
            this.txtSecondNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.Cursor = System.Windows.Forms.Cursors.No;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(12, 130);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(171, 23);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(200, 130);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(121, 23);
            this.txtResult.TabIndex = 2;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(89, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubtract.Location = new System.Drawing.Point(211, 170);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(110, 23);
            this.btnSubtract.TabIndex = 3;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMultiply.Location = new System.Drawing.Point(89, 199);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(110, 23);
            this.btnMultiply.TabIndex = 4;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDivide.Location = new System.Drawing.Point(211, 199);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(110, 23);
            this.btnDivide.TabIndex = 5;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(410, 258);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.txtFirstNumber);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.Controls.Add(this.applicationTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(426, 297);
            this.MinimumSize = new System.Drawing.Size(426, 297);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label applicationTitle;
        private Label lblFirstNumber;
        private Label lblSecondNumber;
        private TextBox txtFirstNumber;
        private TextBox txtSecondNumber;
        private Label lblResult;
        private TextBox txtResult;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
    }
}