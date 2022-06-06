using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosClases
{
    internal class CuentaAhorro
    {

        // Instance-level data.
        public double currBalance;
        // A static point of data.
        public static double currInterestRate = 0.04;
        public CuentaAhorro(double balance)
        {
            currBalance = balance;
        }
        // Static members to get/set interest rate.
        public static void SetInterestRate(double newRate)
        => currInterestRate = newRate;
        public static double GetInterestRate()
        => currInterestRate;
    }
}
