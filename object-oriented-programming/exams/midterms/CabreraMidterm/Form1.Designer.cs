namespace CabreraMidterm {
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.tpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblBookingType = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblNumberOfNightsToStay = new System.Windows.Forms.Label();
            this.lblRoomRatePerNight = new System.Windows.Forms.Label();
            this.lblReservationFee = new System.Windows.Forms.Label();
            this.cmbBookingType = new System.Windows.Forms.ComboBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.txtRoomRatePerNight = new System.Windows.Forms.TextBox();
            this.txtNumberOfNightsToStay = new System.Windows.Forms.TextBox();
            this.txtReservationFee = new System.Windows.Forms.TextBox();
            this.lblReservationPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtReservationPrice = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.tpnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(12, 46);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(536, 57);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Hotel Reservation";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 2;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.75641F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.24359F));
            this.tpnlMain.Controls.Add(this.txtTotalPrice, 1, 6);
            this.tpnlMain.Controls.Add(this.txtReservationPrice, 1, 5);
            this.tpnlMain.Controls.Add(this.lblTotalPrice, 0, 6);
            this.tpnlMain.Controls.Add(this.lblReservationPrice, 0, 5);
            this.tpnlMain.Controls.Add(this.txtReservationFee, 1, 4);
            this.tpnlMain.Controls.Add(this.txtNumberOfNightsToStay, 1, 3);
            this.tpnlMain.Controls.Add(this.lblBookingType, 0, 0);
            this.tpnlMain.Controls.Add(this.lblRoomType, 0, 1);
            this.tpnlMain.Controls.Add(this.lblNumberOfNightsToStay, 0, 3);
            this.tpnlMain.Controls.Add(this.lblRoomRatePerNight, 0, 2);
            this.tpnlMain.Controls.Add(this.lblReservationFee, 0, 4);
            this.tpnlMain.Controls.Add(this.cmbBookingType, 1, 0);
            this.tpnlMain.Controls.Add(this.cmbRoomType, 1, 1);
            this.tpnlMain.Controls.Add(this.txtRoomRatePerNight, 1, 2);
            this.tpnlMain.Location = new System.Drawing.Point(121, 118);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 7;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.89918F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.03679F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0602F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.06355F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.37124F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.04013F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.06355F));
            this.tpnlMain.Size = new System.Drawing.Size(312, 299);
            this.tpnlMain.TabIndex = 1;
            // 
            // lblBookingType
            // 
            this.lblBookingType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBookingType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingType.Location = new System.Drawing.Point(3, 0);
            this.lblBookingType.Name = "lblBookingType";
            this.lblBookingType.Size = new System.Drawing.Size(142, 32);
            this.lblBookingType.TabIndex = 0;
            this.lblBookingType.Text = "Booking Type";
            // 
            // lblRoomType
            // 
            this.lblRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(3, 32);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(142, 32);
            this.lblRoomType.TabIndex = 1;
            this.lblRoomType.Text = "Room Type";
            // 
            // lblNumberOfNightsToStay
            // 
            this.lblNumberOfNightsToStay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumberOfNightsToStay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfNightsToStay.Location = new System.Drawing.Point(3, 117);
            this.lblNumberOfNightsToStay.Name = "lblNumberOfNightsToStay";
            this.lblNumberOfNightsToStay.Size = new System.Drawing.Size(142, 56);
            this.lblNumberOfNightsToStay.TabIndex = 2;
            this.lblNumberOfNightsToStay.Text = "Number of Nights To Stay";
            // 
            // lblRoomRatePerNight
            // 
            this.lblRoomRatePerNight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomRatePerNight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomRatePerNight.Location = new System.Drawing.Point(3, 64);
            this.lblRoomRatePerNight.Name = "lblRoomRatePerNight";
            this.lblRoomRatePerNight.Size = new System.Drawing.Size(142, 53);
            this.lblRoomRatePerNight.TabIndex = 3;
            this.lblRoomRatePerNight.Text = "Room Rate Per Night";
            // 
            // lblReservationFee
            // 
            this.lblReservationFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReservationFee.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationFee.Location = new System.Drawing.Point(3, 173);
            this.lblReservationFee.Name = "lblReservationFee";
            this.lblReservationFee.Size = new System.Drawing.Size(142, 33);
            this.lblReservationFee.TabIndex = 4;
            this.lblReservationFee.Text = "Reservation Fee";
            // 
            // cmbBookingType
            // 
            this.cmbBookingType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBookingType.FormattingEnabled = true;
            this.cmbBookingType.Location = new System.Drawing.Point(151, 3);
            this.cmbBookingType.Name = "cmbBookingType";
            this.cmbBookingType.Size = new System.Drawing.Size(158, 21);
            this.cmbBookingType.TabIndex = 5;
            this.cmbBookingType.SelectedIndexChanged += new System.EventHandler(this.cmbBookingType_SelectedIndexChanged);
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(151, 35);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(158, 21);
            this.cmbRoomType.TabIndex = 6;
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);
            // 
            // txtRoomRatePerNight
            // 
            this.txtRoomRatePerNight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRoomRatePerNight.Location = new System.Drawing.Point(151, 67);
            this.txtRoomRatePerNight.Name = "txtRoomRatePerNight";
            this.txtRoomRatePerNight.ReadOnly = true;
            this.txtRoomRatePerNight.Size = new System.Drawing.Size(158, 22);
            this.txtRoomRatePerNight.TabIndex = 7;
            // 
            // txtNumberOfNightsToStay
            // 
            this.txtNumberOfNightsToStay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumberOfNightsToStay.Location = new System.Drawing.Point(151, 120);
            this.txtNumberOfNightsToStay.Name = "txtNumberOfNightsToStay";
            this.txtNumberOfNightsToStay.Size = new System.Drawing.Size(158, 22);
            this.txtNumberOfNightsToStay.TabIndex = 8;
            // 
            // txtReservationFee
            // 
            this.txtReservationFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReservationFee.Location = new System.Drawing.Point(151, 176);
            this.txtReservationFee.Name = "txtReservationFee";
            this.txtReservationFee.ReadOnly = true;
            this.txtReservationFee.Size = new System.Drawing.Size(158, 22);
            this.txtReservationFee.TabIndex = 9;
            // 
            // lblReservationPrice
            // 
            this.lblReservationPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReservationPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationPrice.Location = new System.Drawing.Point(3, 206);
            this.lblReservationPrice.Name = "lblReservationPrice";
            this.lblReservationPrice.Size = new System.Drawing.Size(142, 35);
            this.lblReservationPrice.TabIndex = 10;
            this.lblReservationPrice.Text = "Reservation Price";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(3, 241);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(142, 58);
            this.lblTotalPrice.TabIndex = 11;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // txtReservationPrice
            // 
            this.txtReservationPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReservationPrice.Location = new System.Drawing.Point(151, 209);
            this.txtReservationPrice.Name = "txtReservationPrice";
            this.txtReservationPrice.ReadOnly = true;
            this.txtReservationPrice.Size = new System.Drawing.Size(158, 22);
            this.txtReservationPrice.TabIndex = 12;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalPrice.Location = new System.Drawing.Point(151, 244);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(158, 22);
            this.txtTotalPrice.TabIndex = 13;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(207, 446);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(130, 35);
            this.btnCompute.TabIndex = 2;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(560, 563);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.tpnlMain);
            this.Controls.Add(this.lblFormTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(576, 602);
            this.MinimumSize = new System.Drawing.Size(576, 602);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tpnlMain.ResumeLayout(false);
            this.tpnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.Label lblBookingType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblNumberOfNightsToStay;
        private System.Windows.Forms.Label lblRoomRatePerNight;
        private System.Windows.Forms.Label lblReservationFee;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtReservationPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblReservationPrice;
        private System.Windows.Forms.TextBox txtReservationFee;
        private System.Windows.Forms.TextBox txtNumberOfNightsToStay;
        private System.Windows.Forms.ComboBox cmbBookingType;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.TextBox txtRoomRatePerNight;
        private System.Windows.Forms.Button btnCompute;
    }
}

