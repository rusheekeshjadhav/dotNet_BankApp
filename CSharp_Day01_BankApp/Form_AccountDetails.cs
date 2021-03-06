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
    public partial class Form_AccountDetails : Form
    {
        string messege;

        TransactionEvent transEvent = new TransactionEvent();

        public Form_AccountDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                label7.Text = "Enter the money to be deposited";
            else
            {
                label7.Text = "";

                transEvent.onDepositMoney(Convert.ToDouble(textBox1.Text));
                MessageBox.Show("Money deposited successfully");

                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                label8.Text = "Enter the money to be withdrawn";
            else
            {
                label8.Text = "";
                messege = transEvent.onWithdrawMoney(Convert.ToDouble(textBox2.Text));

                MessageBox.Show(messege);
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Current Balance = " + transEvent.onCheckBalance());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label9.Text = "Account No. : " + BankClass.bankAccount.ElementAt(BankClass.index - 1).AccountNumber;
            label10.Text = "Account Holder : " + BankClass.bankAccount.ElementAt(BankClass.index - 1).AccountHolder;
            label12.Text = "Account Type : " + BankClass.bankAccount.ElementAt(BankClass.index - 1).AccountType;

            transEvent.depositMoney += BankClass.bankAccount.ElementAt(BankClass.index - 1).deposit;
            transEvent.withdrawMoney += BankClass.bankAccount.ElementAt(BankClass.index - 1).withdraw;
            transEvent.checkBalance += BankClass.bankAccount.ElementAt(BankClass.index - 1).checkBalance;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_AccountOpen form = new Form_AccountOpen();
            form.Show();
            this.FindForm().Hide();
        }
    }
}