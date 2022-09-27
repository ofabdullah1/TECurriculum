﻿namespace BankTellerExercise
{
    public class BankAccount : IAccountable
    {
        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountHolder, string accountNumber)
        {
            AccountHolderName = accountHolder;
            AccountNumber = accountNumber;
            Balance = 0;
        }

        public BankAccount(string accountHolder, string accountNumber, decimal balance)
        {
            AccountHolderName = accountHolder;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public BankAccount()
        {

        }

        public decimal Deposit(decimal amountToDeposit)
        {
            Balance += amountToDeposit;
            
            return Balance;
        }

        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            Balance -= amountToWithdraw;
            return Balance;
        }

        public virtual decimal TransferTo(BankAccount destinationAccount, decimal transferAmount)
        {
            if (Balance >= transferAmount)
            {
                destinationAccount.Balance += transferAmount;
                this.Balance = (Balance - transferAmount);
            } 
            return this.Balance;
        }

       


    }
}
