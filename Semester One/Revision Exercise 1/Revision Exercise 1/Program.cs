using System;

namespace Revision_Exercise_1
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please Enter a number:");
                int userNum = int.Parse(Console.ReadLine());

                numbers[i] = userNum;
            }

            for (int j = 9; j >= 0 ; j--)
            {
                Console.WriteLine(numbers[j]);
            }
        }
    }
}
