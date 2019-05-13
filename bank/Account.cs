﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    abstract class Account
    {
        public int Id { get; }
        public string AccountNumber { get; }
        public decimal Balance { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public long Pesel { get; }

        public Account (int id, string firstName, string lastName, long pesel)
        {
            Id = id;
            AccountNumber = generateAccountNumber(id);
            Balance = 0.0M;
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
        }
        //Metoda abstrakcyjna
        public abstract string TypeName();

        public string GetFullName()
        {
            string fullName = string.Format("{0} {1}", FirstName, LastName);

            return fullName;
        }
        public string GetBalance()
        {

            return string.Format("{0} zł", Balance);
        }
        private string generateAccountNumber(int id)
        {
            var accountNumber = string.Format("94{0:D10}", id);

            return accountNumber;
        }
    }
}
