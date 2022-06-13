using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Day01_BankApp
{
    public partial class Form_InvestDetails : Form
    {
        public Form_InvestDetails()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label9.Text = "Investment ID : " + BankClass.instruments.ElementAt(BankClass.invIndex - 1).InvestmentId;
            label10.Text = "Investor Name : " + BankClass.instruments.ElementAt(BankClass.invIndex - 1).InvestorName;
            label12.Text = "Investment Type : " + BankClass.instruments.ElementAt(BankClass.invIndex - 1).InvestmentType;
            label1.Text = "Invested Amount : " + BankClass.instruments.ElementAt(BankClass.invIndex - 1).InvestedAmount;

            if (BankClass.instruments.ElementAt(BankClass.invIndex - 1).InvestmentType == "FD")
            {
                label3.Text = "Interest Rate : " + ((FixedDeposit)BankClass.instruments.ElementAt(BankClass.invIndex - 1)).InterestRate;
                label4.Text = "Minimum Tenor : " + ((FixedDeposit)BankClass.instruments.ElementAt(BankClass.invIndex - 1)).MinimumTenor + " months";
                label5.Text = "Maximum Tenor : " + ((FixedDeposit)BankClass.instruments.ElementAt(BankClass.invIndex - 1)).MaximumTenor + " months";
            }
            else
            {
                label3.Text = "Interest Rate : " + ((RecurringDeposit)BankClass.instruments.ElementAt(BankClass.invIndex - 1)).InterestRate;
                label4.Text = "Minimum Tenor : " + ((RecurringDeposit)BankClass.instruments.ElementAt(BankClass.invIndex - 1)).MinimumTenor + " months";
                label5.Text = "Maximum Tenor : " + ((RecurringDeposit)BankClass.instruments.ElementAt(BankClass.invIndex - 1)).MaximumTenor + " months";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_InvestOpen form = new Form_InvestOpen();
            form.Show();
            this.FindForm().Hide();
        }
    }
}
