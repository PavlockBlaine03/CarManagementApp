namespace CarPaymentApp
{
    partial class CarPaymentForm
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtCarPrice = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblCarPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.lblLoanTerm = new System.Windows.Forms.Label();
            this.listLoanTerm = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.listHistory = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(507, 192);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(179, 40);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate ";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtCarPrice
            // 
            this.txtCarPrice.Location = new System.Drawing.Point(97, 206);
            this.txtCarPrice.Name = "txtCarPrice";
            this.txtCarPrice.Size = new System.Drawing.Size(294, 20);
            this.txtCarPrice.TabIndex = 1;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(97, 446);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(294, 20);
            this.txtInterestRate.TabIndex = 3;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(97, 321);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(294, 20);
            this.txtDownPayment.TabIndex = 4;
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyPayment.Location = new System.Drawing.Point(95, 669);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(49, 33);
            this.lblMonthlyPayment.TabIndex = 5;
            this.lblMonthlyPayment.Text = "$0";
            // 
            // lblCarPrice
            // 
            this.lblCarPrice.AutoSize = true;
            this.lblCarPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarPrice.Location = new System.Drawing.Point(93, 166);
            this.lblCarPrice.Name = "lblCarPrice";
            this.lblCarPrice.Size = new System.Drawing.Size(131, 20);
            this.lblCarPrice.TabIndex = 6;
            this.lblCarPrice.Text = "Enter Car Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Interest Rate";
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.AutoSize = true;
            this.lblDownPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownPayment.Location = new System.Drawing.Point(94, 289);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(177, 20);
            this.lblDownPayment.TabIndex = 8;
            this.lblDownPayment.Text = "Enter Down Payment";
            // 
            // lblLoanTerm
            // 
            this.lblLoanTerm.AutoSize = true;
            this.lblLoanTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanTerm.Location = new System.Drawing.Point(97, 548);
            this.lblLoanTerm.Name = "lblLoanTerm";
            this.lblLoanTerm.Size = new System.Drawing.Size(150, 20);
            this.lblLoanTerm.TabIndex = 9;
            this.lblLoanTerm.Text = "Select Loan Term";
            // 
            // listLoanTerm
            // 
            this.listLoanTerm.FormattingEnabled = true;
            this.listLoanTerm.Items.AddRange(new object[] {
            "",
            "12 Months",
            "24 Months",
            "36 Months",
            "48 Months",
            "60 Months",
            "72 Months"});
            this.listLoanTerm.Location = new System.Drawing.Point(101, 582);
            this.listLoanTerm.Name = "listLoanTerm";
            this.listLoanTerm.Size = new System.Drawing.Size(291, 30);
            this.listLoanTerm.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(507, 426);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 40);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listHistory
            // 
            this.listHistory.FormattingEnabled = true;
            this.listHistory.Location = new System.Drawing.Point(97, 742);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(589, 121);
            this.listHistory.TabIndex = 13;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(507, 303);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(179, 38);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 910);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listHistory);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listLoanTerm);
            this.Controls.Add(this.lblLoanTerm);
            this.Controls.Add(this.lblDownPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCarPrice);
            this.Controls.Add(this.lblMonthlyPayment);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtCarPrice);
            this.Controls.Add(this.btnCalculate);
            this.Name = "CalculatorForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtCarPrice;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblCarPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.Label lblLoanTerm;
        private System.Windows.Forms.ListBox listLoanTerm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox listHistory;
        private System.Windows.Forms.Button btnClear;
    }
}