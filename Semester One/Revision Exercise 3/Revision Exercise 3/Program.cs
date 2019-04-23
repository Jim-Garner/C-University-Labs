using System;

namespace Revision_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] shoeSizes = new int[20];

            for (int i = 0; i < shoeSizes.Length; i++)
            {
                Console.WriteLine("Please enter a shoe size:");

                shoeSizes[i] = int.Parse(Console.ReadLine());

            }

            


        }
    }
}
