using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Day01_BankApp
{
    class FixedDeposit : InvestmentInstruments
    {
        public double InterestRate { get; set; } = 0.05;
        public int MinimumTenor { get; set; } = 12;
        public int MaximumTenor { get; set; } = 60;

        public FixedDeposit(int investmentId, string investmentName, double investedAmount, string investmentType) : base(investmentId, investmentName, investedAmount, investmentType)
        { }

        public override string ToString()
        {
            return base.ToString() + "; Interest Rate: " + InterestRate + "; Minimum Tenor: " + MinimumTenor + "; Maximum Tenor: " + MaximumTenor;
        }
    }
}
