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
    public partial class Form_BankInit : Form
    {
        public Form_BankInit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form_AccountOpen form = new Form_AccountOpen();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Form_InvestOpen form = new Form_InvestOpen();
            form.Show();
        }

        private void Form_BankInit_Load(object sender, EventArgs e)
        {

        }
    }
}
