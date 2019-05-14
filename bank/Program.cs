using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Name: Bank";
            string author= "Author: Mati Osa";
            Console.WriteLine(name);
            Console.WriteLine(author);
            Console.WriteLine();

            List<Account> accounts = new List<Account>();
            accounts.Add(new SavingAccount(1, "Jan", "Kalosz", 90092104856));
            accounts.Add(new SavingAccount(2, "Jan", "Nowak", 93022504566));
            accounts.Add(new SavingAccount(3, "Marcin", "Drab", 84031103456));
            accounts.Add(new SavingAccount(4, "Anna", "Zez", 75011135678));
            accounts.Add(new SavingAccount(5, "Kamila", "Raz", 95062666844));
            accounts.Add(new BillingAccount(6, "Jan", "Kalosz", 90092104856));
            accounts.Add(new BillingAccount(7, "Jan", "Nowak", 93022504556));


           
            Printer printer = new Printer();
            printer.Print(accounts[0]);
            printer.Print(accounts[1]);
            printer.Print(accounts[2]);
            
            Console.ReadKey();
        }
    }
}
