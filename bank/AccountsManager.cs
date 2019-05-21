using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class AccountsManager
    {
        private IList<Account> _accounts;

        public AccountsManager()
        {
            _accounts = new List<Account>();
        }
        public IEnumerable<Account> GetAllAccounts()
        {
            return _accounts;
        }
        private int generateId()
        {
            int id = 1;

            if (_accounts.Any())
            {
                id = _accounts.Max(x => x.Id) + 1;
            }
            return id;
        }
        public SavingAccount CreateSavingAccount(string firstName, string lastName, long pesel)
        {
            int id = generateId();

            SavingAccount account = new SavingAccount(id, firstName, lastName, pesel);
            _accounts.Add(account);

            return account;
        }
        public BillingAccount CreateBillingAccount(string firstName, string lastName, long pesel)
        {
            int id = generateId();

            BillingAccount account = new BillingAccount(id, firstName, lastName, pesel);
            _accounts.Add(account);

            return account;
        }
        public IEnumerable<Account> GetAllAccountsFor(string firstName, string lastName, long pesel)
        {
            /* List<Account> customerAccounts = new List<Account>();

             foreach (Account account in _accounts)
             {
                 if(account.FirstName == firstName && account.LastName== lastName && account.Pesel == pesel)
                 {
                     customerAccounts.Add(account);
                 }
             }
             return customerAccounts;
             */
            // metoda LINQ
            return _accounts.Where(x => x.FirstName == firstName && x.LastName == lastName && x.Pesel == pesel);
        }
        public Account GetAccount(string accountNo)
        {
            /* Account account;

             foreach(Account acc in _accounts)
             {
                 if(acc.AccountNumber == accountNo)
                 {
                     account = acc;
                     break;
                 }

             }

             return account;*/
            return _accounts.Single(x => x.AccountNumber == accountNo);
        }
        public IEnumerable<string> ListOfCustomers()
        {
            return _accounts.Select(a => string.Format("Imie : {0} | Nazwisko: {1} | PESEL: {2}", a.FirstName, a.LastName, a.Pesel)).Distinct();
            /*
            string users;
            List<string> us =new List<string>();
            foreach(Account acc in _accounts)
            {
                string imie = acc.FirstName;
                int flag = 0 ;
                string naz = acc.LastName;
                string PESEL = acc.Pesel.ToString();
                users = string.Format("Imie: {0} | Nazwisko: {1} | PESEL: {2}", imie, naz, PESEL);
                foreach(var user in us)
                {
                    if (user == users) flag = 1;
                }
                if(flag!=1) us.Add(users);

            }
            return us;
            */
        }
        public void CloseMonth()
        {
            foreach(SavingAccount account in _accounts.Where(x => x is SavingAccount))
            {
                account.AddInterest(0.04M);
            }
            foreach (BillingAccount account in _accounts.Where(x => x is BillingAccount))
            {
                account.TakeCharge(5.0M);
            }
        }
        public void AddMoney(string accountNo, decimal value)
        {
            Account account = GetAccount(accountNo);
            account.ChangeBalance(value);
        }

        public void TakeMoney(string accountNo, decimal value)
        {
            Account account = GetAccount(accountNo);
            account.ChangeBalance(-value);
        }

    }
}
