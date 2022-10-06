namespace CommonControls {
    partial class Form1 {
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.lblSelectedOption = new System.Windows.Forms.Label();
            this.cmbSelectedOption = new System.Windows.Forms.ComboBox();
            this.gboxColorsSelection0 = new System.Windows.Forms.GroupBox();
            this.cblColorsSelection = new System.Windows.Forms.CheckedListBox();
            this.btnCblColorsSelectionSubmit = new System.Windows.Forms.Button();
            this.gboxColorsSelection1 = new System.Windows.Forms.GroupBox();
            this.pnlRadioGroup = new System.Windows.Forms.Panel();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.btnRboColorsSelectionSubmit = new System.Windows.Forms.Button();
            this.gboxColorsSelection0.SuspendLayout();
            this.gboxColorsSelection1.SuspendLayout();
            this.pnlRadioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(353, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Common Controls Demo";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOptions
            // 
            this.lblOptions.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOptions.Location = new System.Drawing.Point(63, 86);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(57, 21);
            this.lblOptions.TabIndex = 1;
            this.lblOptions.Text = "Options";
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbOption
            // 
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.Location = new System.Drawing.Point(194, 86);
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.Size = new System.Drawing.Size(121, 21);
            this.cmbOption.TabIndex = 0;
            this.cmbOption.SelectedIndexChanged += new System.EventHandler(this.cmbOption_SelectedIndexChanged);
            // 
            // lblSelectedOption
            // 
            this.lblSelectedOption.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSelectedOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSelectedOption.Location = new System.Drawing.Point(63, 118);
            this.lblSelectedOption.Name = "lblSelectedOption";
            this.lblSelectedOption.Size = new System.Drawing.Size(113, 21);
            this.lblSelectedOption.TabIndex = 1;
            this.lblSelectedOption.Text = "Selected Option";
            this.lblSelectedOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSelectedOption
            // 
            this.cmbSelectedOption.FormattingEnabled = true;
            this.cmbSelectedOption.Location = new System.Drawing.Point(194, 118);
            this.cmbSelectedOption.Name = "cmbSelectedOption";
            this.cmbSelectedOption.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectedOption.TabIndex = 1;
            // 
            // gboxColorsSelection0
            // 
            this.gboxColorsSelection0.Controls.Add(this.btnCblColorsSelectionSubmit);
            this.gboxColorsSelection0.Controls.Add(this.cblColorsSelection);
            this.gboxColorsSelection0.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxColorsSelection0.Location = new System.Drawing.Point(66, 157);
            this.gboxColorsSelection0.Name = "gboxColorsSelection0";
            this.gboxColorsSelection0.Size = new System.Drawing.Size(249, 122);
            this.gboxColorsSelection0.TabIndex = 2;
            this.gboxColorsSelection0.TabStop = false;
            this.gboxColorsSelection0.Text = "Colors Selection";
            // 
            // cblColorsSelection
            // 
            this.cblColorsSelection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblColorsSelection.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblColorsSelection.FormattingEnabled = true;
            this.cblColorsSelection.Location = new System.Drawing.Point(20, 25);
            this.cblColorsSelection.Name = "cblColorsSelection";
            this.cblColorsSelection.Size = new System.Drawing.Size(210, 64);
            this.cblColorsSelection.TabIndex = 0;
            // 
            // btnCblColorsSelectionSubmit
            // 
            this.btnCblColorsSelectionSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCblColorsSelectionSubmit.Location = new System.Drawing.Point(187, 92);
            this.btnCblColorsSelectionSubmit.Name = "btnCblColorsSelectionSubmit";
            this.btnCblColorsSelectionSubmit.Size = new System.Drawing.Size(56, 24);
            this.btnCblColorsSelectionSubmit.TabIndex = 0;
            this.btnCblColorsSelectionSubmit.Text = "OK";
            this.btnCblColorsSelectionSubmit.UseVisualStyleBackColor = true;
            this.btnCblColorsSelectionSubmit.Click += new System.EventHandler(this.btnCblColorsSelectionSubmit_Click);
            // 
            // gboxColorsSelection1
            // 
            this.gboxColorsSelection1.Controls.Add(this.btnRboColorsSelectionSubmit);
            this.gboxColorsSelection1.Controls.Add(this.pnlRadioGroup);
            this.gboxColorsSelection1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxColorsSelection1.Location = new System.Drawing.Point(66, 296);
            this.gboxColorsSelection1.Name = "gboxColorsSelection1";
            this.gboxColorsSelection1.Size = new System.Drawing.Size(249, 122);
            this.gboxColorsSelection1.TabIndex = 3;
            this.gboxColorsSelection1.TabStop = false;
            this.gboxColorsSelection1.Text = "Colors Selection";
            // 
            // pnlRadioGroup
            // 
            this.pnlRadioGroup.Controls.Add(this.rdoBlue);
            this.pnlRadioGroup.Controls.Add(this.rdoGreen);
            this.pnlRadioGroup.Controls.Add(this.rdoRed);
            this.pnlRadioGroup.Location = new System.Drawing.Point(6, 22);
            this.pnlRadioGroup.Name = "pnlRadioGroup";
            this.pnlRadioGroup.Size = new System.Drawing.Size(237, 64);
            this.pnlRadioGroup.TabIndex = 2;
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRed.Location = new System.Drawing.Point(10, 3);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(45, 20);
            this.rdoRed.TabIndex = 0;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Red";
            this.rdoRed.UseVisualStyleBackColor = true;
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGreen.Location = new System.Drawing.Point(10, 22);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(56, 20);
            this.rdoGreen.TabIndex = 0;
            this.rdoGreen.TabStop = true;
            this.rdoGreen.Text = "Green";
            this.rdoGreen.UseVisualStyleBackColor = true;
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBlue.Location = new System.Drawing.Point(10, 41);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(48, 20);
            this.rdoBlue.TabIndex = 0;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "Blue";
            this.rdoBlue.UseVisualStyleBackColor = true;
            // 
            // btnRboColorsSelectionSubmit
            // 
            this.btnRboColorsSelectionSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRboColorsSelectionSubmit.Location = new System.Drawing.Point(187, 92);
            this.btnRboColorsSelectionSubmit.Name = "btnRboColorsSelectionSubmit";
            this.btnRboColorsSelectionSubmit.Size = new System.Drawing.Size(56, 23);
            this.btnRboColorsSelectionSubmit.TabIndex = 0;
            this.btnRboColorsSelectionSubmit.Text = "OK";
            this.btnRboColorsSelectionSubmit.UseVisualStyleBackColor = true;
            this.btnRboColorsSelectionSubmit.Click += new System.EventHandler(this.btnRboColorsSelectionSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(377, 491);
            this.Controls.Add(this.gboxColorsSelection1);
            this.Controls.Add(this.gboxColorsSelection0);
            this.Controls.Add(this.cmbSelectedOption);
            this.Controls.Add(this.cmbOption);
            this.Controls.Add(this.lblSelectedOption);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblTitle);
            this.MinimumSize = new System.Drawing.Size(393, 519);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxColorsSelection0.ResumeLayout(false);
            this.gboxColorsSelection1.ResumeLayout(false);
            this.pnlRadioGroup.ResumeLayout(false);
            this.pnlRadioGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.ComboBox cmbOption;
        private System.Windows.Forms.Label lblSelectedOption;
        private System.Windows.Forms.ComboBox cmbSelectedOption;
        private System.Windows.Forms.GroupBox gboxColorsSelection0;
        private System.Windows.Forms.CheckedListBox cblColorsSelection;
        private System.Windows.Forms.Button btnCblColorsSelectionSubmit;
        private System.Windows.Forms.GroupBox gboxColorsSelection1;
        private System.Windows.Forms.Panel pnlRadioGroup;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.Button btnRboColorsSelectionSubmit;
    }
}

