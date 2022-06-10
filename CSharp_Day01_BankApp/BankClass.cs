using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Day01_BankApp
{
    class BankClass : IEnumerable
    {
        public static List<BankAccount> bankAccount = new List<BankAccount>();

        /*public static BankAccount[] bankAccount = new BankAccount[10];*/

        public static int index = 0;

        public BankAccount[] accounts;

        public BankClass(List<BankAccount> accounts)
        {
            this.accounts = accounts.ToArray();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public BankEnum GetEnumerator()
        {
            return new BankEnum(this.accounts);
        }


        /*  Instead of above to methods, we can use the enumerator of the array class directly by the method below.
         *  Just return the enumerator of the array class, so no need to write separate 'BankEnum' class.
         */

        /*IEnumerator IEnumerable.GetEnumerator()
        {
            return bankAccount.GetEnumerator();
        }*/

    }
}
