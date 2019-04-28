using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class SavingAccount :Account
    {
        public SavingAccount(string accountNumber, decimal balance, string firstName, string lastName, long pesel)
            : base (accountNumber, balance, firstName, lastName, pesel)
        {
        }
        
    }
}
