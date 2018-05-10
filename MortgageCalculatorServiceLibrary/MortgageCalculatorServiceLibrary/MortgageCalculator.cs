using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MortgageCalculatorServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MortgageCalculator" in both code and config file together.
    public class MortgageCalculator : IMortgageCalculator
    {
        public Mortgage ComputeMortgage(double purchasePrice, double interestRate, int amortization, double taxes, double percentDown)
        {
            Mortgage objMortgageData = new Mortgage();
            if (purchasePrice != 0.0 && interestRate != 0.0 && amortization != 0 && taxes != 0.0)
            {
                objMortgageData.Pruchase_Price = purchasePrice;
                objMortgageData.Interest_Rate = interestRate;
                objMortgageData.Amortization = amortization;
                objMortgageData.Taxes = taxes;
                objMortgageData.Percent_Down = percentDown;

                objMortgageData.Down_Payment = ComputeDownPayment(objMortgageData.Pruchase_Price, objMortgageData.Percent_Down);
                objMortgageData.Remaining_Mortgage = objMortgageData.Pruchase_Price - objMortgageData.Down_Payment;
                objMortgageData.GE_Premium = ComputeGEPremium(objMortgageData.Pruchase_Price, objMortgageData.Down_Payment, objMortgageData.Remaining_Mortgage);
                objMortgageData.Total_Financing = objMortgageData.Remaining_Mortgage + objMortgageData.GE_Premium;
                objMortgageData.Monthly_Mortgage_Payment = ComputeMonthlyMortgagePayment(objMortgageData.Total_Financing, objMortgageData.Interest_Rate, objMortgageData.Amortization);
                objMortgageData.Fees = objMortgageData.Taxes / 12;
                objMortgageData.Total_Payment = objMortgageData.Monthly_Mortgage_Payment + objMortgageData.Fees;
            }
            return objMortgageData;
        }

        private double ComputeDownPayment(double purchasePrice, double percentDown)
        {
            double downpayment = 0.0;
            downpayment = (percentDown / 100) * purchasePrice;
            return downpayment;
        }

        private double ComputeGEPremium(double purchasePrice, double downPayment, double remainingMortgage)
        {
            double gepremium = 0.0;
            double loan_to_value_ratio = (1 - (downPayment / purchasePrice)) * 100;
            double premiumROI = 0.0;

            if (loan_to_value_ratio > 90 && loan_to_value_ratio <= 95)
            {
                premiumROI = 4.00;
            }
            else if (loan_to_value_ratio > 85 && loan_to_value_ratio <= 90)
            {
                premiumROI = 3.10;
            }
            else if (loan_to_value_ratio > 80 && loan_to_value_ratio <= 85)
            {
                premiumROI = 2.80;
            }
            else if (loan_to_value_ratio > 75 && loan_to_value_ratio <= 80)
            {
                premiumROI = 2.40;
            }
            else if (loan_to_value_ratio > 65 && loan_to_value_ratio <= 70)
            {
                premiumROI = 1.70;
            }
            else
            {
                premiumROI = 0.60;
            }

            gepremium = (premiumROI / 100) * remainingMortgage;
            return gepremium;
        }

        private double ComputeMonthlyMortgagePayment(double totalFinancing, double annualROI, int amortization)
        {
            double monthlyMortgagePayment = 0.0;
            int numberOfPayments = amortization * 12;
            double monthlyROI = annualROI / 100 / 12;
            double numerator = monthlyROI * Math.Pow((1 + monthlyROI), numberOfPayments);
            double denominator = Math.Pow((1 + monthlyROI), numberOfPayments) - 1;
            monthlyMortgagePayment = (numerator / denominator) * totalFinancing;
            return monthlyMortgagePayment;
        }
    }
}
