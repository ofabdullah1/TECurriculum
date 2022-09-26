namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber)
        {

        }



        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {

        }



        public override decimal Withdraw(decimal amountToWithdraw)
        {
            
            if(amountToWithdraw + 2> Balance)
            {
                return Balance;
            }
            else if (Balance - amountToWithdraw < 150)
            {
                Balance = (Balance - amountToWithdraw) - 2;
                return Balance;
            }
            else
            {
                Balance = Balance - amountToWithdraw;
                return Balance;
            }
            return Balance;
            
          




        }


    }





}
