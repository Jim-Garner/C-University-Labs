using System;
namespace ConsoleApplication49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which studetns exam mark would you like to know ? ");
           
            string name = Console.ReadLine();
            name = name.ToUpper();

            string[] students = new string[]{"JON DOE,67", "JAMES SMITH,52", "EMILY TURNER,64", "BEN TURNER,27",
                "JANE EARL,55", "BEN LOUDEN,61", "ANDREW MANS,42", "AMY SANDERSON,52", "KATE COLES,34", "NATHAN MUIR,72"};


            //For ever index in the students array;
            for (int i = 0; i < students.Length; i++)
            {
                //Split that same index if it has a comma in it into another array called Namesandmarks
                string[] namesAndMarks = students[i].Split(",");
                
                //For every index in nameandmarks;
                for (int j = 0; j < namesAndMarks.Length; j++)
                {
                    //Check if the name matches an index;
                    if (namesAndMarks[j] == name)
                    {
                        //if a name matches an index, print the next one along, as that'll be that students mark.
                        Console.WriteLine(namesAndMarks[j + 1]);
                    }
                }
            }
        }
    }
}