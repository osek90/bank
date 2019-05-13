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
            

            SavingAccount savingAccount = new SavingAccount(1, "Jan", "Kalosz", 90092104856);
            
           
            SavingAccount savingAccount2 = new SavingAccount(2, "Anna", "Jarosz", 92032305345);


            BillingAccount billingAccount = new BillingAccount(1, savingAccount.FirstName, savingAccount.LastName, savingAccount.Pesel);


            IPrinter printer = new SmallerPrinter();
            printer.Print(savingAccount);
            printer.Print(savingAccount2);

            printer.Print(billingAccount);
            
            Console.ReadKey();
        }
    }
}
