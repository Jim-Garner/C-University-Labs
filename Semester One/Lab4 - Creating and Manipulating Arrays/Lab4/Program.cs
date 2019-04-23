using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Here we are telling the console there will be a string array call filmNames with 5 pidgeon holes.
            string[] filmNames = new string[5];
            //.Here we are filling those five pidgeon holes.
            filmNames[0] = "1. Legend (18)";
            filmNames[1] = "2. Hotel Transylvania (U)";
            filmNames[2] = "3. Into The Storm (12A)";
            filmNames[3] = "4. Everest (15)";
            filmNames[4] = "5. Rocky (12)";
            string again;

            do
            {

                Console.WriteLine("Please select a movie:");
                ///Here is a loop; declaring that console should print the array contents whilst i is less than the length of the array.
                for (int i = 0; i < filmNames.Length; i++)
                {
                    ///This will print the index number the console is currently at.
                    Console.WriteLine(filmNames[i]);

                }

                Console.WriteLine("\nWhich film would you like to see?");
                int filmNo = int.Parse(Console.ReadLine());

                Console.WriteLine("\nHow old are you?");
                int age = int.Parse(Console.ReadLine());


                ///This variable gets the film number and takes away one, to account for us counting from one and the console counting from zero.
                filmNo = filmNo - 1;

                ///If user is less than 18, find out what they are allowed to see.
                if (age < 18)
                {   ///This finds the selected film and sees if it sends with 12A
                    if (filmNames[filmNo].EndsWith("(12A)"))
                    {
                        if (age > 12)
                        {
                            Console.WriteLine("Thank you. You may enter.");
                        }
                        if (age == 12)
                        {
                            Console.WriteLine("Are you with an Adult? Y or N?");
                            string adult = Console.ReadLine();
                            adult = adult.ToUpper();
                            if (adult == "Y")
                            {
                                Console.WriteLine("Thank you. You may enter.");
                            }
                            else if (adult == "N")
                            {
                                Console.WriteLine("Sorry! You're too young. Come back with an adult.");
                            }
                            else
                            {
                                Console.WriteLine("Input not recognised.");
                            }


                        }
                        else
                        {
                            Console.WriteLine("You're too young to see this film. Sorry.");
                        }

                    }
                    if (filmNames[filmNo].EndsWith("(12)"))
                    {
                        if (age >= 12)
                        {
                            Console.WriteLine("Thank you. You may enter.");
                        }
                        if (age < 12)
                        {
                            Console.WriteLine("You're too young to see this film. Sorry.");
                        }
                    }

                    if (filmNames[filmNo].EndsWith("(15)"))
                    {
                        if (age >= 15)
                        {
                            Console.WriteLine("Thank you. You may enter.");
                        }
                        if (age < 15)
                        {
                            Console.WriteLine("You're too young to see this film. Sorry.");
                        }
                    }
                    if (filmNames[filmNo].EndsWith("(18)"))
                    {
                        if (age >= 18)
                        {
                            Console.WriteLine("Thank you. You may enter.");
                        }
                        if (age < 18)
                        {
                            Console.WriteLine("You're too young to see this film. Sorry.");
                        }
                    }
                  

                }
                else
                {
                    Console.WriteLine("Thank you. You may enter.");
                }



                Console.WriteLine("Another customer Y or N?");
                again = Console.ReadLine();
                again = again.ToUpper();
            }
            while (again == "Y");
            





        }
    }
}
