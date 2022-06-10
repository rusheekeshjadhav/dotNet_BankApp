using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Day01_BankApp
{
    public delegate void DepositMoney(double amount);
    public delegate string WithDrawMoney(double amount);
    public delegate double CheckBalance();

    class TransactionEvent
    {
        public event DepositMoney depositMoney;
        public event WithDrawMoney withdrawMoney;
        public event CheckBalance checkBalance;

        public void onDepositMoney(double amount)
        {
            if (depositMoney != null)
                depositMoney(amount);
        }

        public string onWithdrawMoney(double amount)
        {
            if(withdrawMoney != null)
                return withdrawMoney(amount);
            return null;
        }

        public double onCheckBalance()
        {
            if(checkBalance != null)
                return checkBalance();
            return 0;
        }
    }
}
