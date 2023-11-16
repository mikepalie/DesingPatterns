using System;

namespace Facade
{

    public class Program
    {
        public static void Main(string[] args)
        {
            BankSystemFacade bank = new BankSystemFacade();

            bank.WithdrawLogic();
            Console.WriteLine("=============");
            bank.DepositLogic();
        }
    }
    class BankSystemFacade
    {
        private DatabaseSystem db;
        private UserInterfaceSystem ui;
        private AuthenticationSystem auth;

        public BankSystemFacade()
        {
            db = new DatabaseSystem();
            ui = new UserInterfaceSystem();
            auth = new AuthenticationSystem();
        }

        public void WithdrawLogic()
        {
            db.ConnectToDatabase();
            auth.GetCredentials();
            db.LoadUser();
            ui.WithdrawView();
            db.WithdrawMoney();
        }

        public  void DepositLogic()
        {
            db.ConnectToDatabase();
            auth.GetCredentials();
            db.LoadUser();
            ui.WithdrawView();
            db.DepositMoney();
        }

        public void AccountLogic()
        {
            db.ConnectToDatabase();
            auth.GetCredentials();
            db.LoadUser();
        }



    }   
}
