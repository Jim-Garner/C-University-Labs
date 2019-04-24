using System;

namespace Lab2._2___Exceptns_and_Constrctrs
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
    
                    
            //Blank strings, ready to be appended in if else statements;
            string error = "";
            string error2 = "";


            bool errorNum = accountBalance < 0;
            //Trim removes all whitespace characters to see if there are characters there aside from spaces;
            if(accountName.Trim() == "")
            {
                //This will add the text to blank string error
                error += "First name cannot be empty\r\n";
            }

                //If error has text in it, this will run;
            if (error != "")
            {
                throw new Exception(error);
            }

            if (errorNum == true) 
            {
               error2 += "Account balance cannot be below zero\r\n";
            }
            if(error2 != "")
            {
                throw new Exception(error2);
            }        



        }

        //Just like methods, we can overload constructors; Which is used depends on the signature passed to it;

        public Account(string accountName)
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
            Account C = new Account("Tim Goodfellow", 14969, -1);
            Account D = new Account("Joe Grummet", 148289, 500);
            Account E = new Account("James",456789,-10);

            Console.WriteLine(A.accountName);
            Console.WriteLine(B.accountName);
            Console.WriteLine(C.accountBalance);
        }
    }
}
