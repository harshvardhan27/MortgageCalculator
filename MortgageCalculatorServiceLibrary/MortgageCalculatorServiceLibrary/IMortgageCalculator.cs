using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MortgageCalculatorServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMortgageCalculator" in both code and config file together.
    [ServiceContract]
    public interface IMortgageCalculator
    {
        [OperationContract]
        Mortgage ComputeMortgage(double purchasePrice, double interestRate, int amortization, double taxes, double percentDown);
    }
}
