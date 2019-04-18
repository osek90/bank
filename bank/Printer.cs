using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Printer
    {
        public void Print(SavingAccount account)
        {
            Console.WriteLine("Dane Konta: ");
            Console.WriteLine("Numer konta: {0}", account.AccountNumber);
            Console.WriteLine("Saldo: {0}zł", account.Balane);
            Console.WriteLine("Imie właściciela: {0}", account.FirstName);
            Console.WriteLine("Nazwisko właściciela: {0}", account.LastName);
            Console.WriteLine("PESEL: {0}", account.Pesel);
            Console.WriteLine();
        }

        public void Print(BillingAccount account)
        {
            Console.WriteLine("Dane Konta: ");
            Console.WriteLine("Numer konta: {0}", account.AccountNumber);
            Console.WriteLine("Saldo: {0}zł", account.Balane);
            Console.WriteLine("Imie właściciela: {0}", account.FirstName);
            Console.WriteLine("Nazwisko właściciela: {0}", account.LastName);
            Console.WriteLine("PESEL: {0}", account.Pesel);
            Console.WriteLine();
        }

    }
}
