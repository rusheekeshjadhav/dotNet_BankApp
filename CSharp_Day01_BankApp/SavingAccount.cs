using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Day01_BankApp
{
    internal class SavingAccount : BankAccount
    {
        public double InterestRate { get; } = 0.07;
        public double AnnualCharges { get; } = 500.0;
        public double MinimumBalance { get; } = 500.0;

        public SavingAccount(int accountNumber, string accountHolder, double balance, string accountType) : base(accountNumber, accountHolder, balance, accountType)
        {
            Console.WriteLine("Saving Account");
        }

        public override string ToString()
        {
            return base.ToString() + "; Minimum Balance: " + MinimumBalance + "; Interest Rate: " + InterestRate + " Annual Charges: " + AnnualCharges;
        }
    }
}
