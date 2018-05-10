using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MortgageCalculatorServiceLibrary;

namespace MortgageCalculatorWebClient
{
    public partial class mortgage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculateMortgage_Click(object sender, EventArgs e)
        { 
            MortgageCalculatorServiceReference.MortgageCalculatorClient client = new MortgageCalculatorServiceReference.MortgageCalculatorClient("BasicHttpBinding_IMortgageCalculator");
            Mortgage objMortgage = new Mortgage();
            objMortgage = client.ComputeMortgage(Convert.ToDouble(txtPurchasePrice.Text), Convert.ToDouble(txtInterestRate.Text), Convert.ToInt16(ddlAmortization.SelectedItem.Value), Convert.ToDouble(txtTaxes.Text), Convert.ToDouble(ddlPercentDown.SelectedItem.Value));
            txtDownPaymnet.Text = objMortgage.Down_Payment.ToString("c2");
            txtRemainingMortgage.Text = objMortgage.Remaining_Mortgage.ToString("c2");
            txtGePremium.Text = objMortgage.GE_Premium.ToString("c2");
            txtTotalFinancing.Text = objMortgage.Total_Financing.ToString("c2");
            txtMonthlyMortgagePayment.Text = objMortgage.Monthly_Mortgage_Payment.ToString("c2");
            txtFees.Text = objMortgage.Fees.ToString("c2");
            txtTotalPayment.Text = objMortgage.Total_Payment.ToString("c2");
        }
    }
}