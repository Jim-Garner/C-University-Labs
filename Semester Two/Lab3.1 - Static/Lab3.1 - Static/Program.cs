using System;

namespace Lab3_1___Static
{

    class Account
    {

        public string AccountName;
        private int AccountNumber;
        private decimal AccountBalance;

        //As this is declared static, this is now part of the Account class;
        static private int NextAccountNumber = 0; //Basically, what this does is create an integer that iterates with every use. Eg: first account will be 1, next will be 2 etc;

        public Account(string AccountName, decimal AccountBalance)
        {
            this.AccountName = AccountName;
            //NextAccountNumber needs to be set here;
            AccountNumber = NextAccountNumber;
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

            if (error != "")
            {
                throw new Exception(error);
            }

            //This is how the class knows how to iterate;
            NextAccountNumber++;

        }

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

        public string getAccountName()
        {
            return AccountName;
        }

        public void setAccountName(string AccountName)
        {
            this.AccountName = AccountName;
        }

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
                    AccountName = value; 
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
        //So static basically means the Method is part of the actual class, not an instance of it;

        static void Main(string[] args)
        {
            Account A = new Account("James Garner", 1000);
            Account B = new Account("Dawn Bates", 1000);

            Console.WriteLine(A.AccountNo);
            Console.WriteLine(B.AccountNo);

        }



    }
}
