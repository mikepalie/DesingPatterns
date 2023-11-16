using System;

namespace Facade
{
    public class DatabaseSystem
    {
        public void ConnectToDatabase()
        {
            Console.WriteLine("Connecting to Database....");
        }
        public void LoadUser()
        {
            Console.WriteLine("Loading user....");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("Withdrawing user money....");
        }
        public void DepositMoney()
        {
            Console.WriteLine("Depositing user money....");
        }
        public void BalanceMoney()
        {
            Console.WriteLine("Getting Acount Balance....");
        }
        public void TransferMoney()
        {
            Console.WriteLine("Transfering Acount Balance....");
        }

    }   
    
}
