using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Day01_BankApp
{
    internal class CurrentAccount: BankAccount
    {
        public double InterestRate { get; } = 0.08;
        public double AnnualCharges { get; } = 1000.0;
        public double MinimumBalance { get; } = 1000.0;

        public CurrentAccount(int accountNumber, string accountHolder, double balance, string accountType) : base(accountNumber, accountHolder, balance, accountType)
        {
            /*Console.WriteLine("Current Account");*/
        }

        public override string ToString()
        {
            return base.ToString() + "; Minimum Balance: " + MinimumBalance + "; Interest Rate: " + InterestRate + " Annual Charges: " + AnnualCharges;
        }
    }
}
