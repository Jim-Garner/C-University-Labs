using System;

namespace Lab3___Encapsulation
{

    class Account
    {
        //Class attributes;

        public string AccountName;
        private int AccountNumber;
        private decimal AccountBalance;

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

        public void depositFunds(int amount)
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


        //Accessor - An accessor is a public level method which can read a private variable;

        public string getAccountName()
        {
            return AccountName;
        }

        //Mutator - A mutator is a public level method which can modify a private variable;

        public void setAccountName(string AccountName)
        {
            this.AccountName = AccountName;
        }

        //Get and Set statements - combines an accessor and mutator in one; Eg:

        public string Name
        {
            get //Accessor
            {
                return AccountName;
            }
            set //Mutator
            {
                if (value.Trim() != "")
                {
                    AccountName = value; //Value equates to whatever is passed to it, in this case a new name;
                }

                else
                {
                    Console.WriteLine("Change to name was an empty string \r\n");
                }
            }
        }



        public int AccountNo
        {
            get
            {
                return AccountNumber;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Account number cannot be less than zero.\r\n");
                }

                else
                {
                    AccountNumber = value;
                }
            }
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Account A = new Account("James Garner", 1000, 5);
            //Since account balance is now Private instead of Public, it can;t be directly edited outside the class;
            //A.AccountBalance = 100000;


            Console.WriteLine(A.AccountNo);

            A.AccountNo = -5;
            Console.WriteLine(A.AccountNo);

        }



    }
}
