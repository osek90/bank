using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class SavingAccount :Account
    {
        public SavingAccount(int id, string firstName, string lastName, long pesel)
            : base (id, firstName, lastName, pesel)
        {
        }
        public override string TypeName()
        {
            return "Oszczędnościowe";

        }
    }
}
