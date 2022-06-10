using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Day01_BankApp
{
    public class BankEnum : IEnumerator
    {
        public BankAccount[] _bank;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public BankEnum(BankAccount[] list)
        {
            _bank = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _bank.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public BankAccount Current
        {
            get
            {
                try
                {
                    return _bank[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}