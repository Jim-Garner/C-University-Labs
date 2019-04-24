using System;

namespace Lab2._3___Constructors_Final
{

    class Account
    {
        //Class attributes;

        public string AccountName;
        public int AccountNumber;
        public decimal AccountBalance;

        //Constructors;

        public Account(string AccountName, int AccountNumber, decimal AccountBalance)
        {
            this.AccountName = AccountName;
            this.AccountNumber = AccountNumber;
            this.AccountBalance = AccountBalance;

            string error = "";

            if (AccountBalance < 0)
            {
                error += "Account balance cannot be less that zero.";
            }

            if (AccountName.Trim() == "")
            {
                error += "Account name cannot be left blank.";
            }

            if (AccountNumber < 0)
            {
                error += "Account number cannot be less than zero.";
            }

            if (error != "")
            {
                throw new Exception(error);
            }
        }

        public Account(string AccountName, int AccountNumber) : this(AccountName, AccountNumber, 0)
        {

        }

        public Account(string AccountName) : this(AccountName, 0)
        {

        }

        //Methods;

        public void withdrawFunds(int amount)
        {
            int overdraft = 0;

            if ((AccountBalance - amount) >= (0 + overdraft))
            {
                AccountBalance = AccountBalance - amount;
                Console.WriteLine("Withdrawal successful, your remaining balance is " + AccountBalance + ".");

            }
            if (amount < 0)
            {
                Console.WriteLine("Withdrawal amount must be more than zero.");
            }
        }

        public void depositFunds (int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Deposit amount must be more than zero.");
            }
            else
            {
                AccountBalance = AccountBalance + amount;
                Console.WriteLine("Deposit successful. Your new balance is " + AccountBalance + ".");
            }
        }



    }


    class Program
    {
        static void Main(string[] args)
        {
            Account A = new Account("James", 0,5);
            Account B = new Account("",529508, 5);


        }
    }
}
