using System;

namespace Breakin_and_Continuing_Loops
{
    class Program
    {
        static void Main(string[] args)

        {
            //This Program will check which numbers over 70 are divisible by 4 and 9.
            for (int i = 0; i <= 100; i++)
            {
                if (i < 70)
                {
                    continue;
                }
                //Modulo - divides by four and produces the remainder. If it's not zero, the code will run.
                if ((i % 4) != 0)
                {
                    //If the value is != 0, the code will skip the rest and restart the loop. 
                    //As if the code isn't divisible by four, there's no need to check if it's divisible by 9.
                    continue;
                }

                if ((i % 9) != 0)
                {
                    continue;
                }

                Console.WriteLine(i + " is divisible.");
                Console.ReadLine();
            }
        }
    }
}
