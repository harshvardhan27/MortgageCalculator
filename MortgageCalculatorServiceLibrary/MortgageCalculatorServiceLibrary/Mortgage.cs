using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculatorServiceLibrary
{
    [DataContract]
    public class Mortgage
    {
        [DataMember]
        public double Pruchase_Price { get; set; }

        [DataMember]
        public double Interest_Rate { get; set; }

        [DataMember]
        public int Amortization { get; set; }

        [DataMember]
        public double Taxes { get; set; }

        [DataMember]
        public double Percent_Down { get; set; }

        [DataMember]
        public double Down_Payment { get; set; }

        [DataMember]
        public double Remaining_Mortgage { get; set; }

        [DataMember]
        public double GE_Premium { get; set; }

        [DataMember]
        public double Total_Financing { get; set; }

        [DataMember]
        public double Monthly_Mortgage_Payment { get; set; }

        [DataMember]
        public double Fees { get; set; }

        [DataMember]
        public double Total_Payment { get; set; }
    }
}
