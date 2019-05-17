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

            AccountsManager manager = new AccountsManager();
            manager.CreateBillingAccount("Jan", "Kalosz", 90092104856);
            manager.CreateBillingAccount("Kamila", "Raz", 95062666844);
            manager.CreateSavingAccount("Jan", "Kalosz", 90092104856);

            IEnumerable<string> users = manager.ListofCustomers();
        

           
            Printer printer = new Printer();
            
            foreach(string user in users)
            {
                Console.WriteLine(user);
            }
            
            Console.ReadKey();
        }
    }
}
