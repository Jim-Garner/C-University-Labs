using System;




namespace Lab5___Interfaces_and_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }



    public interface IAccountInterface
    {
        void withdrawFunds(decimal amount);
        void depositFunds(decimal amount);
    }
    public interface IArtimaticInterface
    {
        void addTwoNumbers(int a, int b);
        void multiplyTwoNumbers(int a, int b);
        void subtractTwoNumbers(int a, int b);
        void divideTwoNumbers(decimal a, decimal b);
    }


    class Account : IAccountInterface
    {
        public void withdrawFunds(decimal amount)
        {

        }
        public void depositFunds(decimal amount)
        {

        }
    }

    
    class Arithmetic : IArtimaticInterface
    {
        public void addTwoNumbers(int a, int b)
        {

        }
        public void multiplyTwoNumbers(int a, int b)
        {

        }
        public void subtractTwoNumbers(int a, int b)
        {

        }
        public void divideTwoNumbers(decimal a, decimal b)
        {

        }
    }

}
