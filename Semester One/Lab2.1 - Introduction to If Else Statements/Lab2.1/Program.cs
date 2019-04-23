using System;

namespace Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string number1Text = Console.ReadLine();
            int number1 = int.Parse(number1Text);

            if(number1 > 100)
            {
                Console.WriteLine("Number is bigger than 100.");
            }
            else
            {
                Console.WriteLine("Number is smaller or equal to 100.");
            }
            Console.ReadLine();
        }
    }
}
