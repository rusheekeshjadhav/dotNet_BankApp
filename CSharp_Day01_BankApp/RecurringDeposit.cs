using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Day01_BankApp
{
    class RecurringDeposit : InvestmentInstruments
    {
        public double InterestRate { get; set; } = 0.06;
        public int MinimumTenor { get; set; } = 15;
        public int MaximumTenor { get; set; } = 72;

        public RecurringDeposit(int investmentId, string investmentName, double investedAmount, string investmentType) : base(investmentId, investmentName, investedAmount, investmentType)
        { }

        public override string ToString()
        {
            return base.ToString() + "; Interest Rate: " + InterestRate + "; Minimum Tenor: " + MinimumTenor + "; Maximum Tenor: " + MaximumTenor;
        }
    }
}
