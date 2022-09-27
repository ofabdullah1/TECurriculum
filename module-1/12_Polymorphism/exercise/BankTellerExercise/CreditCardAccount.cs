using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class CreditCardAccount : IAccountable
    {
        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; }

        public decimal Debt { get; private set; } = 0m;

        public decimal Balance
        {
            get
            {
                return -Debt;
            }
        }



        public CreditCardAccount(string accountHolderName, string accountNumber)
        {

            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;

        }

        public decimal Pay(decimal amountToPay)
        {
            Debt = Debt - amountToPay;
            return Debt;
        }

        public decimal Charge(decimal amountToCharge)
        {
            Debt = Debt + amountToCharge;
            return Debt;
        }



    }
}
