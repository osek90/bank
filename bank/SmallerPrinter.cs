using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class SmallerPrinter : IPrinter
    {
        public void Print(Account account)
        {
            Console.WriteLine("Dane Konta: {0}", account.AccountNumber);
            Console.WriteLine("Imie i nazwisko właściciela: {0}", account.GetFullName());
            Console.WriteLine();
        }
    }
}
