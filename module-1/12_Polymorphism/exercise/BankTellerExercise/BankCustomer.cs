using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class BankCustomer : IAccountable
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public decimal Balance { get; }

        public bool IsVip
        {
            get
            {
                decimal sum = 0;
                
                foreach(IAccountable account in newCustomers)
                {
                    sum = sum + account.Balance;
                }

                if (sum >= 25000)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private List<IAccountable> newCustomers = new List<IAccountable>();



        public void AddAccount(IAccountable newAccount)
        {
            newCustomers.Add(newAccount);

        }

        public IAccountable[] GetAccounts()
        {
            IAccountable[] newArray = newCustomers.ToArray();
            return newArray;

        }


    }






}
