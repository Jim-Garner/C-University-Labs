using System;

namespace Lab6___Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
        int number;

            //Try to do this;
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            //If you can't do that, do this;
            catch
            {
                Console.WriteLine("Invalid format. Number required.");
            }
            //Regardless of the above, do this;
            finally
            {
                Console.WriteLine("Program executed correctly.");
            }
        }
    }
}
