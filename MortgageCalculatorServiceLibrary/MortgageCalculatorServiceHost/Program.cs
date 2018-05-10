using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculatorServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost mortgageCalculatorServiceHost = new ServiceHost(typeof(MortgageCalculatorServiceLibrary.MortgageCalculator)))
            {
                mortgageCalculatorServiceHost.Open();
                Console.WriteLine("Host started press any key to stop");
                Console.ReadLine();
            }
        }
    }
}
