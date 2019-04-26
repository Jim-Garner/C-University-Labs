using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    //Base class;

    public class Account
    {
        public decimal balance;

        public Account (decimal balance)
        {
            this.balance = balance;
        }

        public void depositFunds(decimal amount)
        {
            balance = balance + amount;
        }

        public virtual void withdrawFunds(decimal amount)
        {
            balance = balance - amount;
        }

        public decimal getBalance()
        {
            return balance;
        }

        public override string ToString()
        {
            return "Account type: " + this.GetType().Name + " ---  Current balance: £" +  balance ;
        }
    }

    //Derived class

    public class ChildAccount : Account
    {
        public ChildAccount(decimal balance) : base(balance)
        {
            this.balance = balance;

        }

        //If the same method is used but requirements are different, override can be used in the derived class;
        public override void withdrawFunds(decimal amount)
        {
            if (amount < 200)
            {
                balance = balance - amount;
            }

            else if(amount > 200)
            {
                Console.WriteLine("The withdrawal limit on this account is £200. Withdrawal failed.");
            }
        }
    }

    public class SavingsAccount : Account
    {
        public SavingsAccount (decimal balance) : base(balance)
        {
            this.balance = balance;
        }

        public override void withdrawFunds(decimal amount)
        {

            Console.WriteLine("Withdrawal of £" + amount + " failed. Withdrawals aren't allowed with this type of account.");

        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Account A = new Account(500);

            A.withdrawFunds(300);
            A.depositFunds(100);

            SavingsAccount B = new SavingsAccount(500);

            B.depositFunds(600);
            B.withdrawFunds(200);

            ChildAccount C = new ChildAccount(500);

            C.withdrawFunds(300);
            C.depositFunds(100);


            Console.WriteLine(A.ToString());
            Console.WriteLine(B.ToString());
            Console.WriteLine(C.ToString());





        }
    }
}

