using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Day01_BankApp
{
    class InvestmentInstruments
    {
        public int InvestmentId { get; set; }
        public string InvestorName { get; set; }
        public double InvestedAmount { get; set; }
        public string InvestmentType { get; set; }

        public InvestmentInstruments(int investmentId, string investorName, double investedAmount, string investmentType)
        {
            InvestmentId = investmentId;
            InvestorName = investorName;
            InvestedAmount = investedAmount;
            InvestmentType = investmentType;
        }

        public override string ToString()
        {
            return "Investment ID: " + InvestmentId + "; Investor Name: " + InvestorName + "; Invested Amount: " + InvestedAmount + "; Investment Type: " + InvestmentType;
        }
    }
}