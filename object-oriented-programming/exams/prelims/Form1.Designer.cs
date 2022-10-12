namespace PrelimCabrera
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.txtTicketQuantity = new System.Windows.Forms.TextBox();
            this.lblTicketQuantity = new System.Windows.Forms.Label();
            this.cmbTicketType = new System.Windows.Forms.ComboBox();
            this.lblTicketType = new System.Windows.Forms.Label();
            this.lblSummaryOfTransaction = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblSummaryTicketQuantity = new System.Windows.Forms.Label();
            this.txtSummaryTicketQuantity = new System.Windows.Forms.TextBox();
            this.lblSummaryTicketType = new System.Windows.Forms.Label();
            this.txtSummaryTicketType = new System.Windows.Forms.TextBox();
            this.lblSummaryTotalAmount = new System.Windows.Forms.Label();
            this.txtSummaryTotalAmount = new System.Windows.Forms.TextBox();
            this.lblSummaryTypeCost = new System.Windows.Forms.Label();
            this.txtSummaryTypeCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.Location = new System.Drawing.Point(12, 31);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(476, 49);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "Ticket Booth";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTicketQuantity
            // 
            this.txtTicketQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketQuantity.Location = new System.Drawing.Point(253, 93);
            this.txtTicketQuantity.Name = "txtTicketQuantity";
            this.txtTicketQuantity.Size = new System.Drawing.Size(127, 23);
            this.txtTicketQuantity.TabIndex = 0;
            // 
            // lblTicketQuantity
            // 
            this.lblTicketQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTicketQuantity.Location = new System.Drawing.Point(119, 93);
            this.lblTicketQuantity.Name = "lblTicketQuantity";
            this.lblTicketQuantity.Size = new System.Drawing.Size(114, 23);
            this.lblTicketQuantity.TabIndex = 2;
            this.lblTicketQuantity.Text = "Ticket Quantity";
            // 
            // cmbTicketType
            // 
            this.cmbTicketType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTicketType.FormattingEnabled = true;
            this.cmbTicketType.Location = new System.Drawing.Point(253, 122);
            this.cmbTicketType.Name = "cmbTicketType";
            this.cmbTicketType.Size = new System.Drawing.Size(127, 23);
            this.cmbTicketType.TabIndex = 1;
            // 
            // lblTicketType
            // 
            this.lblTicketType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketType.Location = new System.Drawing.Point(119, 122);
            this.lblTicketType.Name = "lblTicketType";
            this.lblTicketType.Size = new System.Drawing.Size(105, 21);
            this.lblTicketType.TabIndex = 2;
            this.lblTicketType.Text = "Ticket Type";
            this.lblTicketType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSummaryOfTransaction
            // 
            this.lblSummaryOfTransaction.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryOfTransaction.Location = new System.Drawing.Point(20, 218);
            this.lblSummaryOfTransaction.Name = "lblSummaryOfTransaction";
            this.lblSummaryOfTransaction.Size = new System.Drawing.Size(468, 34);
            this.lblSummaryOfTransaction.TabIndex = 2;
            this.lblSummaryOfTransaction.Text = "Summary Of Transaction";
            this.lblSummaryOfTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCompute.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(181, 165);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(140, 31);
            this.btnCompute.TabIndex = 2;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblSummaryTicketQuantity
            // 
            this.lblSummaryTicketQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryTicketQuantity.Location = new System.Drawing.Point(143, 263);
            this.lblSummaryTicketQuantity.Name = "lblSummaryTicketQuantity";
            this.lblSummaryTicketQuantity.Size = new System.Drawing.Size(80, 20);
            this.lblSummaryTicketQuantity.TabIndex = 2;
            this.lblSummaryTicketQuantity.Text = "Quantity";
            this.lblSummaryTicketQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSummaryTicketQuantity
            // 
            this.txtSummaryTicketQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSummaryTicketQuantity.Location = new System.Drawing.Point(240, 264);
            this.txtSummaryTicketQuantity.Name = "txtSummaryTicketQuantity";
            this.txtSummaryTicketQuantity.ReadOnly = true;
            this.txtSummaryTicketQuantity.Size = new System.Drawing.Size(118, 23);
            this.txtSummaryTicketQuantity.TabIndex = 3;
            // 
            // lblSummaryTicketType
            // 
            this.lblSummaryTicketType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryTicketType.Location = new System.Drawing.Point(143, 292);
            this.lblSummaryTicketType.Name = "lblSummaryTicketType";
            this.lblSummaryTicketType.Size = new System.Drawing.Size(80, 20);
            this.lblSummaryTicketType.TabIndex = 2;
            this.lblSummaryTicketType.Text = "Type";
            this.lblSummaryTicketType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSummaryTicketType
            // 
            this.txtSummaryTicketType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSummaryTicketType.Location = new System.Drawing.Point(240, 293);
            this.txtSummaryTicketType.Name = "txtSummaryTicketType";
            this.txtSummaryTicketType.ReadOnly = true;
            this.txtSummaryTicketType.Size = new System.Drawing.Size(118, 23);
            this.txtSummaryTicketType.TabIndex = 4;
            // 
            // lblSummaryTotalAmount
            // 
            this.lblSummaryTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryTotalAmount.Location = new System.Drawing.Point(143, 352);
            this.lblSummaryTotalAmount.Name = "lblSummaryTotalAmount";
            this.lblSummaryTotalAmount.Size = new System.Drawing.Size(80, 18);
            this.lblSummaryTotalAmount.TabIndex = 2;
            this.lblSummaryTotalAmount.Text = "Total";
            this.lblSummaryTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSummaryTotalAmount
            // 
            this.txtSummaryTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSummaryTotalAmount.Location = new System.Drawing.Point(240, 351);
            this.txtSummaryTotalAmount.Name = "txtSummaryTotalAmount";
            this.txtSummaryTotalAmount.ReadOnly = true;
            this.txtSummaryTotalAmount.Size = new System.Drawing.Size(118, 23);
            this.txtSummaryTotalAmount.TabIndex = 5;
            // 
            // lblSummaryTypeCost
            // 
            this.lblSummaryTypeCost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryTypeCost.Location = new System.Drawing.Point(143, 321);
            this.lblSummaryTypeCost.Name = "lblSummaryTypeCost";
            this.lblSummaryTypeCost.Size = new System.Drawing.Size(80, 20);
            this.lblSummaryTypeCost.TabIndex = 2;
            this.lblSummaryTypeCost.Text = "Type Cost";
            this.lblSummaryTypeCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSummaryTypeCost
            // 
            this.txtSummaryTypeCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSummaryTypeCost.Location = new System.Drawing.Point(240, 322);
            this.txtSummaryTypeCost.Name = "txtSummaryTypeCost";
            this.txtSummaryTypeCost.ReadOnly = true;
            this.txtSummaryTypeCost.Size = new System.Drawing.Size(118, 23);
            this.txtSummaryTypeCost.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(500, 441);
            this.Controls.Add(this.txtSummaryTotalAmount);
            this.Controls.Add(this.txtSummaryTypeCost);
            this.Controls.Add(this.txtSummaryTicketType);
            this.Controls.Add(this.txtSummaryTicketQuantity);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.cmbTicketType);
            this.Controls.Add(this.lblSummaryTotalAmount);
            this.Controls.Add(this.lblSummaryTypeCost);
            this.Controls.Add(this.lblSummaryOfTransaction);
            this.Controls.Add(this.lblSummaryTicketType);
            this.Controls.Add(this.lblSummaryTicketQuantity);
            this.Controls.Add(this.lblTicketType);
            this.Controls.Add(this.lblTicketQuantity);
            this.Controls.Add(this.txtTicketQuantity);
            this.Controls.Add(this.lblAppTitle);
            this.MaximumSize = new System.Drawing.Size(516, 480);
            this.MinimumSize = new System.Drawing.Size(516, 480);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.TextBox txtTicketQuantity;
        private System.Windows.Forms.Label lblTicketQuantity;
        private System.Windows.Forms.ComboBox cmbTicketType;
        private System.Windows.Forms.Label lblTicketType;
        private System.Windows.Forms.Label lblSummaryOfTransaction;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblSummaryTicketQuantity;
        private System.Windows.Forms.TextBox txtSummaryTicketQuantity;
        private System.Windows.Forms.Label lblSummaryTicketType;
        private System.Windows.Forms.TextBox txtSummaryTicketType;
        private System.Windows.Forms.Label lblSummaryTotalAmount;
        private System.Windows.Forms.TextBox txtSummaryTotalAmount;
        private System.Windows.Forms.Label lblSummaryTypeCost;
        private System.Windows.Forms.TextBox txtSummaryTypeCost;
    }
}

