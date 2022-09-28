namespace BankTellerExercise.Classes
{
    public class BankAccount 
    {

        public string AccountHolderName { get; protected set; }
        public string AccountNumber { get;  set; }
        public decimal Balance { get; protected set; } = 0;

       





        public BankAccount(string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;


        }


        public BankAccount(string accountHolderName, string accountNumber, decimal balance)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            Balance = balance;

        }


        public decimal Deposit(decimal amountToDeposit)
        {
            
            
                Balance = Balance + amountToDeposit;

                return Balance;

        }

    
        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            
            
            Balance = Balance - amountToWithdraw;

            return Balance;
            
        }









    }
}
