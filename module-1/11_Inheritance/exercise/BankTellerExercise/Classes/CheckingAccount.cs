namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {

        public CheckingAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber)
        {

        }



        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance):base(accountHolderName, accountNumber, balance)
        {

        }


       


        public override decimal Withdraw(decimal amountToWithdraw)
        {
            
           
            if (Balance > 0)
            {
                Balance = Balance - amountToWithdraw;
                return Balance;
            }
            else if (Balance < 0 && Balance > -100)
            {
                Balance = (Balance - amountToWithdraw) - 10;
                return Balance;
            }
            else
            {
                return Balance;
            }

            return Balance;


        }

        


    }




   
}
