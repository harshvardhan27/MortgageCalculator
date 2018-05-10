namespace MortgageCalculatorTcpClient
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblAmortization = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.ddlAmortization = new System.Windows.Forms.ComboBox();
            this.lblPercentDown = new System.Windows.Forms.Label();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.txtTaxes = new System.Windows.Forms.TextBox();
            this.ddlPercentDown = new System.Windows.Forms.ComboBox();
            this.btnCalculateMortgage = new System.Windows.Forms.Button();
            this.panelMortgageDetails = new System.Windows.Forms.Panel();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.lblFees = new System.Windows.Forms.Label();
            this.txtMonthlyPayment = new System.Windows.Forms.TextBox();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.txtTotalFinancing = new System.Windows.Forms.TextBox();
            this.lblTotalFinancing = new System.Windows.Forms.Label();
            this.txtGePremium = new System.Windows.Forms.TextBox();
            this.lblGEPremium = new System.Windows.Forms.Label();
            this.txtRemainingMortgage = new System.Windows.Forms.TextBox();
            this.lblRemainingMortgage = new System.Windows.Forms.Label();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.lblMortgageDetail = new System.Windows.Forms.Label();
            this.panelMortgageDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(347, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mortgage Calculator";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(63, 106);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(104, 17);
            this.lblPurchasePrice.TabIndex = 1;
            this.lblPurchasePrice.Text = "Purchase Price";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(78, 151);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(89, 17);
            this.lblInterestRate.TabIndex = 2;
            this.lblInterestRate.Text = "Interest Rate";
            // 
            // lblAmortization
            // 
            this.lblAmortization.AutoSize = true;
            this.lblAmortization.Location = new System.Drawing.Point(81, 199);
            this.lblAmortization.Name = "lblAmortization";
            this.lblAmortization.Size = new System.Drawing.Size(86, 17);
            this.lblAmortization.TabIndex = 3;
            this.lblAmortization.Text = "Amortization";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(174, 106);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(307, 22);
            this.txtPurchasePrice.TabIndex = 4;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(174, 146);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(307, 22);
            this.txtInterestRate.TabIndex = 5;
            // 
            // ddlAmortization
            // 
            this.ddlAmortization.FormattingEnabled = true;
            this.ddlAmortization.Items.AddRange(new object[] {
            "10",
            "15",
            "25",
            "30"});
            this.ddlAmortization.Location = new System.Drawing.Point(174, 190);
            this.ddlAmortization.Name = "ddlAmortization";
            this.ddlAmortization.Size = new System.Drawing.Size(307, 24);
            this.ddlAmortization.TabIndex = 6;
            // 
            // lblPercentDown
            // 
            this.lblPercentDown.AutoSize = true;
            this.lblPercentDown.Location = new System.Drawing.Point(529, 106);
            this.lblPercentDown.Name = "lblPercentDown";
            this.lblPercentDown.Size = new System.Drawing.Size(96, 17);
            this.lblPercentDown.TabIndex = 7;
            this.lblPercentDown.Text = "Percent Down";
            // 
            // lblTaxes
            // 
            this.lblTaxes.AutoSize = true;
            this.lblTaxes.Location = new System.Drawing.Point(579, 151);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(46, 17);
            this.lblTaxes.TabIndex = 8;
            this.lblTaxes.Text = "Taxes";
            // 
            // txtTaxes
            // 
            this.txtTaxes.Location = new System.Drawing.Point(631, 148);
            this.txtTaxes.Name = "txtTaxes";
            this.txtTaxes.Size = new System.Drawing.Size(283, 22);
            this.txtTaxes.TabIndex = 9;
            // 
            // ddlPercentDown
            // 
            this.ddlPercentDown.FormattingEnabled = true;
            this.ddlPercentDown.Items.AddRange(new object[] {
            "5",
            "10"});
            this.ddlPercentDown.Location = new System.Drawing.Point(631, 102);
            this.ddlPercentDown.Name = "ddlPercentDown";
            this.ddlPercentDown.Size = new System.Drawing.Size(283, 24);
            this.ddlPercentDown.TabIndex = 10;
            // 
            // btnCalculateMortgage
            // 
            this.btnCalculateMortgage.Location = new System.Drawing.Point(174, 253);
            this.btnCalculateMortgage.Name = "btnCalculateMortgage";
            this.btnCalculateMortgage.Size = new System.Drawing.Size(197, 31);
            this.btnCalculateMortgage.TabIndex = 11;
            this.btnCalculateMortgage.Text = "CalculateMortgage";
            this.btnCalculateMortgage.UseVisualStyleBackColor = true;
            this.btnCalculateMortgage.Click += new System.EventHandler(this.btnCalculateMortgage_Click);
            // 
            // panelMortgageDetails
            // 
            this.panelMortgageDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMortgageDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMortgageDetails.Controls.Add(this.txtTotalPayment);
            this.panelMortgageDetails.Controls.Add(this.lblTotalPayment);
            this.panelMortgageDetails.Controls.Add(this.txtFees);
            this.panelMortgageDetails.Controls.Add(this.lblFees);
            this.panelMortgageDetails.Controls.Add(this.txtMonthlyPayment);
            this.panelMortgageDetails.Controls.Add(this.lblMonthlyPayment);
            this.panelMortgageDetails.Controls.Add(this.txtTotalFinancing);
            this.panelMortgageDetails.Controls.Add(this.lblTotalFinancing);
            this.panelMortgageDetails.Controls.Add(this.txtGePremium);
            this.panelMortgageDetails.Controls.Add(this.lblGEPremium);
            this.panelMortgageDetails.Controls.Add(this.txtRemainingMortgage);
            this.panelMortgageDetails.Controls.Add(this.lblRemainingMortgage);
            this.panelMortgageDetails.Controls.Add(this.txtDownPayment);
            this.panelMortgageDetails.Controls.Add(this.lblDownPayment);
            this.panelMortgageDetails.Controls.Add(this.lblMortgageDetail);
            this.panelMortgageDetails.Location = new System.Drawing.Point(66, 304);
            this.panelMortgageDetails.Name = "panelMortgageDetails";
            this.panelMortgageDetails.Size = new System.Drawing.Size(860, 345);
            this.panelMortgageDetails.TabIndex = 12;
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Location = new System.Drawing.Point(586, 158);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Size = new System.Drawing.Size(189, 22);
            this.txtTotalPayment.TabIndex = 14;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Location = new System.Drawing.Point(480, 164);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(99, 17);
            this.lblTotalPayment.TabIndex = 13;
            this.lblTotalPayment.Text = "Total Payment";
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(586, 114);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(189, 22);
            this.txtFees.TabIndex = 12;
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Location = new System.Drawing.Point(498, 120);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(81, 17);
            this.lblFees.TabIndex = 11;
            this.lblFees.Text = "Taxes/Fees";
            // 
            // txtMonthlyPayment
            // 
            this.txtMonthlyPayment.Location = new System.Drawing.Point(586, 77);
            this.txtMonthlyPayment.Name = "txtMonthlyPayment";
            this.txtMonthlyPayment.Size = new System.Drawing.Size(189, 22);
            this.txtMonthlyPayment.TabIndex = 10;
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(463, 77);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(116, 17);
            this.lblMonthlyPayment.TabIndex = 9;
            this.lblMonthlyPayment.Text = "Monthly Payment";
            // 
            // txtTotalFinancing
            // 
            this.txtTotalFinancing.Location = new System.Drawing.Point(166, 203);
            this.txtTotalFinancing.Name = "txtTotalFinancing";
            this.txtTotalFinancing.Size = new System.Drawing.Size(163, 22);
            this.txtTotalFinancing.TabIndex = 8;
            // 
            // lblTotalFinancing
            // 
            this.lblTotalFinancing.AutoSize = true;
            this.lblTotalFinancing.Location = new System.Drawing.Point(52, 203);
            this.lblTotalFinancing.Name = "lblTotalFinancing";
            this.lblTotalFinancing.Size = new System.Drawing.Size(105, 17);
            this.lblTotalFinancing.TabIndex = 7;
            this.lblTotalFinancing.Text = "Total Financing";
            // 
            // txtGePremium
            // 
            this.txtGePremium.Location = new System.Drawing.Point(166, 164);
            this.txtGePremium.Name = "txtGePremium";
            this.txtGePremium.Size = new System.Drawing.Size(163, 22);
            this.txtGePremium.TabIndex = 6;
            // 
            // lblGEPremium
            // 
            this.lblGEPremium.AutoSize = true;
            this.lblGEPremium.Location = new System.Drawing.Point(70, 164);
            this.lblGEPremium.Name = "lblGEPremium";
            this.lblGEPremium.Size = new System.Drawing.Size(87, 17);
            this.lblGEPremium.TabIndex = 5;
            this.lblGEPremium.Text = "GE Premium";
            // 
            // txtRemainingMortgage
            // 
            this.txtRemainingMortgage.Location = new System.Drawing.Point(166, 120);
            this.txtRemainingMortgage.Name = "txtRemainingMortgage";
            this.txtRemainingMortgage.Size = new System.Drawing.Size(163, 22);
            this.txtRemainingMortgage.TabIndex = 4;
            // 
            // lblRemainingMortgage
            // 
            this.lblRemainingMortgage.AutoSize = true;
            this.lblRemainingMortgage.Location = new System.Drawing.Point(18, 120);
            this.lblRemainingMortgage.Name = "lblRemainingMortgage";
            this.lblRemainingMortgage.Size = new System.Drawing.Size(139, 17);
            this.lblRemainingMortgage.TabIndex = 3;
            this.lblRemainingMortgage.Text = "Remaining Mortgage";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(166, 77);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(163, 22);
            this.txtDownPayment.TabIndex = 2;
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.AutoSize = true;
            this.lblDownPayment.Location = new System.Drawing.Point(59, 77);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(98, 17);
            this.lblDownPayment.TabIndex = 1;
            this.lblDownPayment.Text = "DownPayment";
            // 
            // lblMortgageDetail
            // 
            this.lblMortgageDetail.AutoSize = true;
            this.lblMortgageDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMortgageDetail.Location = new System.Drawing.Point(300, 17);
            this.lblMortgageDetail.Name = "lblMortgageDetail";
            this.lblMortgageDetail.Size = new System.Drawing.Size(212, 29);
            this.lblMortgageDetail.TabIndex = 0;
            this.lblMortgageDetail.Text = "Mortgage Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(996, 681);
            this.Controls.Add(this.panelMortgageDetails);
            this.Controls.Add(this.btnCalculateMortgage);
            this.Controls.Add(this.ddlPercentDown);
            this.Controls.Add(this.txtTaxes);
            this.Controls.Add(this.lblTaxes);
            this.Controls.Add(this.lblPercentDown);
            this.Controls.Add(this.ddlAmortization);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.lblAmortization);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblPurchasePrice);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMortgageDetails.ResumeLayout(false);
            this.panelMortgageDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblAmortization;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.ComboBox ddlAmortization;
        private System.Windows.Forms.Label lblPercentDown;
        private System.Windows.Forms.Label lblTaxes;
        private System.Windows.Forms.TextBox txtTaxes;
        private System.Windows.Forms.ComboBox ddlPercentDown;
        private System.Windows.Forms.Button btnCalculateMortgage;
        private System.Windows.Forms.Panel panelMortgageDetails;
        private System.Windows.Forms.Label lblMortgageDetail;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.TextBox txtRemainingMortgage;
        private System.Windows.Forms.Label lblRemainingMortgage;
        private System.Windows.Forms.TextBox txtGePremium;
        private System.Windows.Forms.Label lblGEPremium;
        private System.Windows.Forms.TextBox txtTotalFinancing;
        private System.Windows.Forms.Label lblTotalFinancing;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.TextBox txtMonthlyPayment;
        private System.Windows.Forms.TextBox txtTotalPayment;
        private System.Windows.Forms.Label lblTotalPayment;
    }
}

