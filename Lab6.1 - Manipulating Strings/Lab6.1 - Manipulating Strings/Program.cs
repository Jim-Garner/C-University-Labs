using System;

namespace Lab6._1___Manipulating_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string numberList = "2,4,5,6,7,8,5,4,3,4,5,65,6,5,4,3,4,4,3,32,2,4,5,6,67,5,4,4,5,6,7,";

            //.Split splits a string into an array accoring to the criteria provided. In this case, whenever it finds a comma.

            string[] numbers = numberList.Split(",");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
