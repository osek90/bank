using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Printer
    {
        public void Print(Account account)
        {
            Console.WriteLine("Dane Konta: ");
            Console.WriteLine("Typ: {0}", account.TypeName());
            Console.WriteLine("Saldo: {0}zł", account.Balance);
            Console.WriteLine("Imie właściciela: {0}", account.FirstName);
            Console.WriteLine("Nazwisko właściciela: {0}", account.LastName);
            Console.WriteLine("PESEL: {0}", account.Pesel);
            Console.WriteLine();
        }

       

    }
}
