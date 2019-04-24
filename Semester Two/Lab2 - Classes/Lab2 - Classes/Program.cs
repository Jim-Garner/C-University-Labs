using System;
using System.Collections.Generic;

namespace Lab2___Classes
{
    //Classes are blueprints of objects, specifying the parameters;
    class Account
    {
        public string AccountName;
        public int AccountNumber;
        public decimal AccountBalance;

        public void withdrawFunds (decimal amount)
        {

            int overdraft = 200;

            if ((AccountBalance - amount) >= (0 - overdraft))
            {
                //Account balance - withdrawal amount.
                AccountBalance = AccountBalance - amount;
                Console.WriteLine("You have successfully withdrawn " + amount + ".");
                Console.WriteLine("You now have " + AccountBalance + " remaining.");
            }
            else
            {
                Console.WriteLine("Withdrawal failed.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {   
            
            //This creates an instance of the account class; This is now an object;
            Account myAccount = new Account();
            myAccount.AccountName = "Jim Garner Account";
            myAccount.AccountBalance = 100;

            //This creates a random number;
            Random R = new Random();

            //Assigns random number as accountnumber;
            myAccount.AccountNumber = R.Next();

            //Calls the withdrawFunds method;
            myAccount.withdrawFunds(300);

            


        }
    }
}
