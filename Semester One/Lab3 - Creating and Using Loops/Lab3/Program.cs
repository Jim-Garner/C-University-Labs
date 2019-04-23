using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        // Loops
        {
            //For Loops - this will loops until i = 9, printing the statement each time it loops.

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello World!");
            }

            //Do While - this is saying "loop while j is less than ten". Essentially "do this, while this"

            int j = 0;

            do
            {
                Console.WriteLine("Hello World!");
                j++;
            }
            //Termination criteria
            while (j < 10);



            Console.ReadLine();
        }
        
    }
}
