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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = null; textBox2.Text = null; comboBox1.SelectedItem = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "";

            if (comboBox1.SelectedItem == null || textBox1.Text == null || textBox2.Text == null)
                label4.Text = "Enter the required data";
            else
            {
                if (comboBox1.SelectedItem.ToString() == "FD")
                    BankClass.instruments.Add(new FixedDeposit(++BankClass.invIndex, textBox1.Text, Convert.ToDouble(textBox2.Text), comboBox1.SelectedItem.ToString()));
                else
                    BankClass.instruments.Add(new RecurringDeposit(++BankClass.invIndex, textBox1.Text, Convert.ToDouble(textBox2.Text), comboBox1.SelectedItem.ToString()));

                this.FindForm().Hide();
                Form5 form5 = new Form5();
                form5.Show();

                //  foreach directly on the list
                foreach (InvestmentInstruments p in BankClass.instruments)
                    Console.WriteLine(p);

                //  foreach directly on the class object containing the list
                /*BankClass b = new BankClass(BankClass.bankAccount);
                foreach (BankAccount x in b)
                {
                    Console.WriteLine(x.ToString());
                }*/
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
