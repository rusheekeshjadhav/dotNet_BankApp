using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Day01_BankApp
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; set; }
        public string AccountType { get; set; }

        public BankAccount() { }

        public BankAccount(int accountNumber, string accountHolder, double balance, string accountType)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
            AccountType = accountType;
        }

        public void deposit(double amount)
        {
            Balance = Balance + amount;
        }
        public string withdraw(double amount)
        {
            double minimumBalance;
            if (AccountType == "Saving")
                minimumBalance = ((SavingAccount)BankClass.bankAccount[BankClass.index - 1]).MinimumBalance;
            else
                minimumBalance = ((CurrentAccount)BankClass.bankAccount[BankClass.index - 1]).MinimumBalance;

            if (amount <= (Balance - minimumBalance))
            {
                Balance = Balance - amount;
                return "Money deducted successfully";
            }
            else return "Insufficient Funds ! Minimum required balance = " + minimumBalance;
        }

        public double checkBalance()
        {
            return Balance;
        }

        public override string ToString()
        {
            return "Account Number: " + AccountNumber + "; Account Holder: " + AccountHolder + "; Account Type: " + AccountType + "; Balance: " + Balance;
        }

    }
}
