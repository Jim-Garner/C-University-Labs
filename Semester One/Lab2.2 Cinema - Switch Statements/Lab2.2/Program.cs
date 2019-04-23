using System;

namespace Lab2._2
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Garner Studios!");
            Console.WriteLine("We're currently showing:");
            Console.WriteLine("1. Legend  (18)");
            Console.WriteLine("2. Macbeth (15)");
            Console.WriteLine("3. Everest (12A)");
            Console.WriteLine("4. Fiction (18)");
            Console.WriteLine("5. Rocky I (12)");

            Console.WriteLine("Please enter the number of which film you'd like to see:");
            string number = Console.ReadLine();
            int i = int.Parse(number);
            switch(i)
            {
                case 0:
                case 1:
                    {
                        Console.WriteLine("You've selected Legend. What is your age?");
                        string age = Console.ReadLine();
                        int ageNum = int.Parse(age);
                        if (ageNum >= 18)
                        {
                            Console.WriteLine("Good choice! Enjoy the movie.");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you're not quite old enough.");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("You've selected Macbeth. What is your age?");
                        string age = Console.ReadLine();
                        int ageNum = int.Parse(age);
                        if (ageNum >= 15)
                        {
                            Console.WriteLine("Good choice! Enjoy the movie.");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you're not quite old enough.");
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("You've selected Everest. What is your age?");
                        string age = Console.ReadLine();
                        int ageNum = int.Parse(age);
                        if (ageNum >= 13)
                        {
                            Console.WriteLine("Good choice! Enjoy the movie.");
                        }
                        else if (ageNum == 12)
                        {
                            Console.WriteLine("Are you with an adult? Type 1 for Yes, or 2 for No:");
                            string adult = Console.ReadLine();
                            int adultCon = int.Parse(adult);
                            if (adultCon == 1) 
                            {
                                Console.WriteLine("Excellent, enjoy the movie.");
                            }
                            else
                            {
                                Console.WriteLine("Oh, sorry about that. You're too young for this film on your own.");
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you're not quite old enough.");
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("You've selected Fiction. What is your age?");
                        string age = Console.ReadLine();
                        int ageNum = int.Parse(age);
                        if (ageNum >= 18)
                        {
                            Console.WriteLine("Good choice! Enjoy the movie.");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you're not quite old enough.");
                        }
                        break;
                    }

                case 5:
                    {
                        Console.WriteLine("You've selected Rocky I. What is your age?");
                        string age = Console.ReadLine();
                        int ageNum = int.Parse(age);
                        if (ageNum >= 15)
                        {
                            Console.WriteLine("Good choice! Enjoy the movie.");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you're not quite old enough.");
                        }
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
