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

            //All constructors chain off of this now;
        }

        //Just like methods, we can overload constructors; Which is used depends on the signature passed to it;

        public Account(string accountName, decimal accountBalance) : this(accountName, 0 , accountBalance)
        {
            //Chained to the three argument signature above;
        }

        public Account(string accountName) : this(accountName, 0)
        {
            //Chained to the two argument signature above;

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
            Account A = new Account("Jim Garner");
            Account B = new Account("Dawn Bates");
            Account C = new Account("Tim Goodfellow", 14969, 500);

            Console.WriteLine(A.accountName);
            Console.WriteLine(A.accountBalance);
            Console.WriteLine(A.accountNumber);

            Console.WriteLine(B.accountName);
            Console.WriteLine(B.accountBalance);
            Console.WriteLine(B.accountNumber);

            

        }
    }
}
