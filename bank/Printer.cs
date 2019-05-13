﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Printer : IPrinter
    {
        public void Print(Account account)
        {
            Console.WriteLine("Dane Konta: {0}", account.AccountNumber);
            Console.WriteLine("Typ: {0}", account.TypeName());
            Console.WriteLine("Saldo: {0}", account.GetBalance());
            Console.WriteLine("Imie i nazwisko właściciela: {0}", account.GetFullName());
            Console.WriteLine("PESEL: {0}", account.Pesel);
            Console.WriteLine();
        }

       

    }
}
