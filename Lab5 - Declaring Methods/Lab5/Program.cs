using System;

namespace Lab5
{
    class Program
    {

        /// <summary>
        /// This is how we declare a new method
        /// </summary>
        /// 



        //Instead of void we have written int. That tells the method that we are expecting an integer at the end of
        //the method.To send the integer out of the method we use return. 


        static int GetIntTwo(string prompter)
        {
            Console.WriteLine(prompter);
            int numbers = int.Parse(Console.ReadLine());
            return numbers;
        }

        static void SayHelloWorld()
        {
            //Changes made to these methods change ALL lines of the called method as well.
            Console.WriteLine("Hello world!");
        }
        static void SayHello(string name)
        {
            Console.WriteLine("Hello " + name + ", how are you doing today?");
        }

        static void GetInt(string prompt)
        {
            Console.WriteLine(prompt);
            int number = int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            ///To call the mothod SayHelloWorld
            SayHelloWorld();

            ///To call the method SayHello
            SayHello("Alex");

            //method Get Int; let's us enter some text to prompt the user into entering a number, parses it and saves it.
            GetInt("Please enter a number:");

            GetIntTwo("Please enter another number:");
            // This uses the getinttwo method, asks user for a number, parses it and stores the result into numberchoice;
            int numberChoice = GetIntTwo("What film would you like to see?");
            Console.WriteLine(numberChoice);
        }
       
    }
}
