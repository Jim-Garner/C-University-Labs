using System;

namespace Lab4___Polymorphism
{


    public class Account // #1
    {
        protected decimal balance; // #2

        public Account(decimal balance) // #3
        {
            this.balance = balance;
        }

        public virtual void depositFunds(decimal amount) // #4
        {
            balance = balance + amount;
        }

        public virtual void withdrawFunds(decimal amount) // #5
        {
            balance = balance - amount;
        }

        public decimal getBalance()
        {
            return balance;
        }
    }

    public class ChildAccount : Account // #6
    {
        public ChildAccount(decimal balance) // #7
            : base(balance)
        {
            this.balance = balance;
        }

        public override void withdrawFunds(decimal amount) // #8
        {
            if (amount < 200)
            {
                balance = balance - amount;
            }
            else
            {
                Console.WriteLine("Tried to withdraw too much");
            }
        }

    }

    public class SavingsAccount : Account // #9
    {
        public SavingsAccount(decimal balance) // #10
            : base(balance)
        {
            this.balance = balance;
        }

        public override void withdrawFunds(decimal amount) //#11
        {
            Console.WriteLine("Unable to withdraw funds using a savings account");
        }

        public override void depositFunds(decimal amount) //#12
        {
            if (amount > 10)
            {
                balance = balance + amount;
            }
            else
            {
                Console.WriteLine("Unable to deposit such a small amount (what an awful bank account)");
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            Account baseAccount = new Account(50);
            ChildAccount child = new ChildAccount(20);
            SavingsAccount savings = new SavingsAccount(1000);

            //This will use the Account deposit funds method
            child.depositFunds(20);

            //This will use the ChildAccount withdrawFunds method, as we have
            //overridden the Account withdrawFunds method.  
            child.withdrawFunds(20);

            //This method will use the Savings withdrawfunds method as we have
            //overridden the Account withdrawFunds method. You cannot withdraw
            //from a savings account - a message will be produced 
            savings.withdrawFunds(20);

            //This method will use the Savings depositfunds method as we have
            //overridden the Account depositFunds method.
            savings.depositFunds(20);
        }
    }

}