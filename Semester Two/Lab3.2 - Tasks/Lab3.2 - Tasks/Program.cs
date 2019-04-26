using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    class Account
    {
        //Member variables
        private string AccountName;

        private int AccountNumber;

        private decimal AccountBalance;

        private decimal Overdraft = -200;

        private static int NextAccountNumber = 0;

        List<string> transactions;


        public Account(string AccountName, decimal AccountBalance)
        {

            this.AccountName = AccountName;
            this.AccountBalance = AccountBalance;
            AccountNumber = NextAccountNumber;
            transactions = new List<string>();
            NextAccountNumber++;

            string error = "";

            if (AccountName.Trim() == "")
            {
                error = error + "Empty name provided \r\n";
            }

            if (AccountBalance < 0)
            {
                error = error + "Initial balance cannot be negative \r\n";
            }

            if (error != "")
            {
                throw new Exception(error);
            }
        }

        //The second constructor fot his class. If this is uses, it takes the parameter AccountName, 
        //and sends it to the constructor above with the vales 0 and 0 for the account number and the
        //account balance

        //Here is the Name property we have written. What this allows us to do is both get and
        //set the account name, which is something we might need to do (people chabnge their names). 
        public string Name
        {
            get { return AccountName; }
            set
            {
                if (value.Trim() != "")
                {
                    AccountName = value;
                }
                else
                {
                    Console.WriteLine("Change to name was an empty string\r\n");
                }
            }
        }

        //The Balance property is different from the name property in that we don't event want to be able to set the accountBalance directly. 
        //Hence, we do not have a set function for it, so in order to change the value of accountBalance, it must be through withdrawFunds or
        //depositFunds.
        public decimal Balance
        {
            get { return AccountBalance; }

        }

        //With the Number property, we again dont want to be able to set the account number, as it could cause problems down the line. 
        //Hence, we only provide the get function. 
        public decimal Number
        {
            get { return AccountNumber; }

        }


        public void withdrawFunds(decimal amount)
        {
            if ((AccountBalance - amount > Overdraft) && (amount > 0))
            {
                AccountBalance = AccountBalance - amount;
                Console.WriteLine("Customer has withdrawn £" + amount + ".");
                transactions.Add("Customer withdrew £ " + amount + ". Remaining balance: £" + AccountBalance);
            }
            else
            {
                Console.WriteLine("Customer does not have enough money");
            }
        }

        public void depositFunds(decimal amount)
        {
            if (amount > 0)
            {
                AccountBalance = AccountBalance + amount;
                transactions.Add("£" + amount + " was deposited. New balance: £" + amount);
            }
        }


        //Prints out all transactions from transactionsList;
        public void Transactions()
        {
            Console.WriteLine("-----Transactions Start -----");
            for (int i = 0; i < transactions.Count; i++)
            {
                Console.WriteLine(transactions[i]);
            }
            Console.WriteLine("-----Transactions End -----");
        }

        public void FraudCheck()
        {
            for (int i = 0; i < transactions.Count; i++)
            {
                if(transactions[i] >300)
                {

                }
            }



        }

    }


    class Program
    {
        //So static basically means the Method is part of the actual class, not an instance of it;

        static void Main(string[] args)
        {


            Account A1 = new Account("Kim", 564654);
            Account A2 = new Account("Dawn Bates", 45872624);
            Account A3 = new Account("Mike", 45872624);
            Account A4 = new Account("James Garner", 65485621);
            Account A5 = new Account("Alan", 4557);
            Account A6 = new Account("15 Bates", 4587);
            Account A7 = new Account("46", 45877524);
            Account A8 = new Account("Dawn Bates", 27624);
            Account A9 = new Account("Dawn Bates", 45875);
            Account A10 = new Account("James Garner", 65485621);
            Account A11 = new Account("Account 111", 45754);
            Account A12 = new Account("Account 112", 45872624);
            Account A13 = new Account("Account 113", 45872624);
            Account A14 = new Account("Account 114", 4224);
            Account A15 = new Account("Account 115", 65485621);
            Account A16 = new Account("Account 116", 45872624);
            Account A17 = new Account("Account 117", 45872624);
            Account A18 = new Account("Account 118", 459624);
            Account A19 = new Account("Account 119", 45872624);
            Account A20 = new Account("Account 120", 45872624);
            Account A21 = new Account("Account 121", 65485621);
            Account A22 = new Account("Account 122", 45872624);
            Account A23 = new Account("Account 123", 45872624);
            Account A24 = new Account("Account 124", 945872624);
            Account A25 = new Account("Account 125", 45872624);
            Account A26 = new Account("Account 126", 45872624);
            Account A27 = new Account("Account 127", 65485621);
            Account A28 = new Account("Account 128", 45872624);
            Account A29 = new Account("Account 129", 45872624);
            Account A30 = new Account("Account 130", 45872624);
            Account A31 = new Account("Account 131", 45872624);
            Account A32 = new Account("Account 1320", 45872624);
            Account A33 = new Account("Account 1330", 65485621);
            Account A34 = new Account("Account 1340", 45872624);
            Account A35 = new Account("Account 1350", 45872624);
            Account A36 = new Account("Account 1360", 45872624);
            Account A37 = new Account("Account 1370", 45872624);
            Account A38 = new Account("Account 1380", 45872624);
            Account A39 = new Account("Account 1390", 65485621);
            Account A40 = new Account("Account 140", 45872624);
            Account A41 = new Account("Account 141", 45872624);
            Account A42 = new Account("Account 142", 45872624);
            Account A43 = new Account("Account 143", 45872624);
            Account A44 = new Account("Account 144", 45872624);
            Account A45 = new Account("Account 145", 65485621);
            Account A46 = new Account("Account 146", 45872624);
            Account A47 = new Account("Account 147", 45872624);
            Account A48 = new Account("Account 148", 45872624);
            Account A49 = new Account("Account 149", 45872624);
            Account A50 = new Account("Account 150", 5000);




            List<Account> customers = new List<Account>();

            customers.Add(A1);
            customers.Add(A2);
            customers.Add(A3);
            customers.Add(A4);
            customers.Add(A5);
            customers.Add(A6);
            customers.Add(A7);
            customers.Add(A8);
            customers.Add(A9);
            customers.Add(A10);
            customers.Add(A11);
            customers.Add(A12);
            customers.Add(A13);
            customers.Add(A14);
            customers.Add(A15);
            customers.Add(A16);
            customers.Add(A17);
            customers.Add(A18);
            customers.Add(A19);
            customers.Add(A20);
            customers.Add(A21);
            customers.Add(A22);
            customers.Add(A23);
            customers.Add(A24);
            customers.Add(A25);
            customers.Add(A26);
            customers.Add(A27);
            customers.Add(A28);
            customers.Add(A29);
            customers.Add(A30);
            customers.Add(A31);
            customers.Add(A32);
            customers.Add(A33);
            customers.Add(A34);
            customers.Add(A35);
            customers.Add(A36);
            customers.Add(A37);
            customers.Add(A38);
            customers.Add(A39);
            customers.Add(A40);
            customers.Add(A41);
            customers.Add(A42);
            customers.Add(A43);
            customers.Add(A44);
            customers.Add(A45);
            customers.Add(A46);
            customers.Add(A47);
            customers.Add(A48);
            customers.Add(A49);
            customers.Add(A50);

            A20.withdrawFunds(500);
            A10.depositFunds(4200);
            A16.withdrawFunds(200);
            A42.withdrawFunds(700);
            A36.withdrawFunds(100);
            A50.withdrawFunds(20);
            A25.withdrawFunds(100);
            A15.withdrawFunds(50);
            A20.withdrawFunds(500);
            A11.withdrawFunds(900);
            A1.withdrawFunds(10);

            /*
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Balance > 0)
                {
                    //Display current balance;
                    Console.WriteLine("Old balance £" + customers[i].Balance);
                    //Figure out 2% interest;
                    decimal interestCalc = customers[i].Balance * 1.02m;
                    //Take away customers original balance, leaving only interest;
                    decimal interest = interestCalc - customers[i].Balance;
                    //Deposit interest;
                    customers[i].depositFunds(interest);
                    //Display new balance;
                    Console.WriteLine("New balance £" + customers[i].Balance);
                }

                else if (customers[i].Balance < 0)
                {
                    Console.WriteLine("Old balance £" + customers[i].Balance);
                    customers[i].withdrawFunds(5);
                    Console.WriteLine("New balance £" + customers[i].Balance);
                }
            }
            */

            //Transactions




            





        }



    }
}
