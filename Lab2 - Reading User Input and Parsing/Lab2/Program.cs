using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, what is your age?");
            string age = Console.ReadLine();

            //Int.Parse is used to convert strings to integers so the console can read it as an int.

            int toNumber = int.Parse(age);

            if (toNumber >= 18)
            {
                Console.WriteLine("Enjoy the movie!");
            }
            else
            {
                Console.WriteLine("It seems you're a tad too young for this film!");
            }
            Console.ReadLine();
        }
    }
}
