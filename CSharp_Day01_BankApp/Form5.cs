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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label9.Text = "Investment ID : " + BankClass.instruments.ElementAt(BankClass.invIndex - 1).InvestmentId;
            label10.Text = "Investor Name : " + BankClass.instruments.ElementAt(BankClass.invIndex - 1).InvestorName;
            label12.Text = "Investment Type : " + BankClass.instruments.ElementAt(BankClass.invIndex - 1).InvestmentType;
            label1.Text = "Invested Amount : " + BankClass.instruments.ElementAt(BankClass.invIndex - 1).InvestedAmount;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.FindForm().Hide();
        }
    }
}
