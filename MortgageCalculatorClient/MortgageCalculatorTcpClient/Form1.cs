using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MortgageCalculatorServiceLibrary;

namespace MortgageCalculatorTcpClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateMortgage_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                MortgageCalculatorServiceReference.MortgageCalculatorClient client = new MortgageCalculatorServiceReference.MortgageCalculatorClient("NetTcpBinding_IMortgageCalculator");
                Mortgage objMortgage = new Mortgage();
                objMortgage = client.ComputeMortgage(Convert.ToDouble(txtPurchasePrice.Text), Convert.ToDouble(txtInterestRate.Text), Convert.ToInt16(ddlAmortization.SelectedItem.ToString()), Convert.ToDouble(txtTaxes.Text), Convert.ToDouble(ddlPercentDown.SelectedItem.ToString()));
                txtDownPayment.Text = objMortgage.Down_Payment.ToString("c2");
                txtRemainingMortgage.Text = objMortgage.Remaining_Mortgage.ToString("c2");
                txtGePremium.Text = objMortgage.GE_Premium.ToString("c2");
                txtTotalFinancing.Text = objMortgage.Total_Financing.ToString("c2");
                txtMonthlyPayment.Text = objMortgage.Monthly_Mortgage_Payment.ToString("c2");
                txtFees.Text = objMortgage.Fees.ToString("c2");
                txtTotalPayment.Text = objMortgage.Total_Payment.ToString("c2");
            }
        }

        public Boolean valid()
        {
            return check_Textbox(txtPurchasePrice, "Purchase Price is a required field.")
                && check_Textbox(txtInterestRate, "Interest Rate is a required field.")
                && check_ComboBox(ddlAmortization, "Select Amortization.")
                && check_ComboBox(ddlPercentDown, "Select Percent Down.")
                && check_Textbox(txtTaxes,"Taxes is a required field");
        }

        public Boolean check_Textbox(TextBox txtControl, string errMessage)
        {
            if (txtControl.Text == string.Empty)
            {
                DisplayMessage(errMessage, "Required Field", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                txtControl.Focus();
                return false;
            }
            else return true;
        }

        public Boolean check_ComboBox(ComboBox cbControl, string errMessage)
        {
            if (cbControl.SelectedIndex == -1)
            {
                DisplayMessage(errMessage, "Required Field", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                cbControl.Focus();
                return false;
            }
            else return true;
        }

        public void DisplayMessage(string message, string caption, MessageBoxButtons msgBoxButton, MessageBoxIcon msgBoxIcon, MessageBoxDefaultButton msgBoxDefaultButton)
        {
            MessageBox.Show(message, caption, msgBoxButton, msgBoxIcon, msgBoxDefaultButton);
        }
    }
}
