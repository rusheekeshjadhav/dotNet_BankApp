﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "";

            if (comboBox1.SelectedItem == null || textBox1.Text == null || textBox2.Text == null)
                label4.Text = "Enter the required data";
            else
            {
                if (comboBox1.SelectedItem.ToString() == "Saving")
                {
                    BankClass.bankAccount.Add(new SavingAccount(++BankClass.index, textBox1.Text, Convert.ToDouble(textBox2.Text), comboBox1.SelectedItem.ToString()));
                    
                    /*BankClass.bankAccount[BankClass.index] = new SavingAccount(++BankClass.index, textBox1.Text, Convert.ToDouble(textBox2.Text), comboBox1.SelectedItem.ToString());*/
                }
                else
                {
                    BankClass.bankAccount.Add(new CurrentAccount(++BankClass.index, textBox1.Text, Convert.ToDouble(textBox2.Text), comboBox1.SelectedItem.ToString()));

                    /*BankClass.bankAccount[BankClass.index] = new CurrentAccount(++BankClass.index, textBox1.Text, Convert.ToDouble(textBox2.Text), comboBox1.SelectedItem.ToString());*/
                }

                this.FindForm().Hide();
                Form2 form2 = new Form2();
                form2.Show();

                //  foreach directly on the list
                /*foreach (BankAccount p in BankClass.bankAccount)
                    Console.WriteLine(p);*/

                //  foreach directly on the class object containing the list
                BankClass b = new BankClass(BankClass.bankAccount);
                foreach(BankAccount x in b)
                {
                    Console.WriteLine(x.ToString());
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = null; textBox2.Text = null; comboBox1.SelectedItem = null;
        }
    }
}
