using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Day01_BankApp
{
    internal class Employee<T> where T : GenericBase
    {
        public string GetName(T empVariable)
        {
            return empVariable.Name;
        }
    }
}
