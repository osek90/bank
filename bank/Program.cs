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
            

            SavingAccount savingAccount = new SavingAccount("9000000000001", 0.0M, "Jan", "Kalosz", 90092104856);
            
           
            SavingAccount savingAccount2 = new SavingAccount("9000000000002", 0.0M, "Anna", "Jarosz", 92032305345);


            BillingAccount billingAccount = new BillingAccount("8000000000001", 100.00M, savingAccount.FirstName, savingAccount.LastName, savingAccount.Pesel);
           

            Printer printer = new Printer();
            printer.Print(savingAccount);
            printer.Print(savingAccount2);

            printer.Print(billingAccount);
            
            Console.ReadKey();
        }
    }
}
