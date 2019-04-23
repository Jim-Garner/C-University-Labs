using System;
using System.IO;

namespace Lab1_1___Resizeable_Arrays
{
    class ResizeableArray
    {
        //Create a blank array;
        public int[] Array = new int[0];


        //Add a method that will add ints to array;
        public void AddInt(int numberToAdd)
        {
            //Create a new array, making room for the new number;
            int[] newArray = new int[Array.Length + 1];


            //Loop through old array and copy into new array;
            for (int i = 0; i < Array.Length; i++)
            {
                //New array index is assigned Array index value, copying it over.
                newArray[i] = Array[i];
            }

            //This will add the numberToAdd to the VERY end of the array -1 index position, or it would be out of bounds.
            newArray[newArray.Length - 1] = numberToAdd;

            //NewArray now becomes current array;
            Array = newArray;
        }


        public void printArray()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }

        public void removeInt(int delInt) 
        {
            //Create new array removing an index position.
            int[] newArray = new int[Array.Length - 1];

            for (int i = 0; i < Array.Length; i++)
            {
                newArray[i] = Array[delInt];
            }

            
            
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            //Calling Class, new object my Array = new array;
            ResizeableArray myArray = new ResizeableArray();

            //Method AddInt to myArray
            myArray.AddInt(5);
            myArray.AddInt(12);
            myArray.AddInt(54);
            myArray.removeInt(12);

            //Print my Array
            myArray.printArray();
        }
    }


}
