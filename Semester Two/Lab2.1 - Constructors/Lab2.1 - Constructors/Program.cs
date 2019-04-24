using System;

namespace Lab2._1___Constructors
{

    class Account
    {
        public string accountName;
        public int accountNumber;
        public decimal accountBalance;

        //This is a constructor; Constructors MUST share the name of the class they're declared in;
        public Account(string accountName, int accountNumber, decimal accountBalance)
        {

            //We can use the word "This" to refer to the variable with the constructor signature;
            this.accountName = accountName;
            this.accountBalance = accountBalance;
            this.accountNumber = accountNumber;
        }

        //Just like methods, we can overload constructors; Which is used depends on the signature passed to it;

        public Account(string accountName) : this (accountName, 0)
        {
            this.accountName = accountName;
            accountBalance = 0;
            accountNumber = 0;
        }

        public Account(string accountName, decimal accountBalance)
        {
            this.accountName = accountName;
            this.accountBalance = accountBalance;
            accountNumber = 0;


        }






        public void withdrawFunds(decimal amount)
        {
            int overdraft = 200;

            if ((accountBalance - amount) >= (0 - overdraft))
            {
                accountBalance = accountBalance - amount;
                Console.WriteLine("Withdrawal successful.");
            }
            else
            {
                Console.WriteLine("Withdrawal was unsuccessful.");
            }


        }


    }



    class Program
    {

        static void Main(string[] args)
        {
            //The constructor allows us to build accounts like this now, saving on a lot of code;
            Account A = new Account("Jim Garner", 15246, 500);
            Account B = new Account("Dawn Bates", 15210, 650);
            Account C = new Account("Tim Goodfellow", 14969, 500);

            Console.WriteLine(A.accountName);
            Console.WriteLine(B.accountName);
            Console.WriteLine(C.accountName);
        }
    }
}
