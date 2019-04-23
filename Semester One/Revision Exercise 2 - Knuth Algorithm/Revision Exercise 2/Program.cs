using System;

namespace Revision_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[53];

            //This populates the array with numbers from 0-52;
            for (int i = 0; i < 53; i++)
            {
                numbers[i] = i;
                
            }

            //Knuth Algorithm


            //For each index position, iterate through.
            for (int index = 0; index < numbers.Length; index++)
            {
                //Save number index.
                int tmp = numbers[index];

                //Assign a random number between index and array length;
                int r = rnd.Next(index, numbers.Length);

                //Number index assgined random number.
                numbers[index] = numbers[r];

                //Random number assigned to numbers[i]
                numbers[r] = tmp;

                Console.WriteLine(numbers[index]);
            }
           
        }
    }
}
