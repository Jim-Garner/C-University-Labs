using System;
using System.IO;


namespace ConsoleApplication49
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";

            //This opens up the stream reader which we will use to access the file
            // The name of the file to be read is inputter here “namesAndMarks.txt”
            StreamReader file = new StreamReader("namesAndMarks.txt");


            Console.WriteLine("Which students exam mark would you like to know?");
            string name = Console.ReadLine();
            //For every line which isn’t the last one
            while ((line = file.ReadLine()) != null)
            {
                //Split the line from the text file
                string[] namesMarks = line.Split(';');
                
                //if it matches the user input
                if (namesMarks[0].ToUpper() == name.ToUpper())
                {
                    string[] marks = namesMarks[1].Split(',');



                    try
                    {
                        int marksOne = int.Parse(marks[0]);
                        int marksTwo = int.Parse(marks[1]);
                        int marksThree = int.Parse(marks[2]);

                        int average = ((marksOne + marksTwo + marksThree) / marks.Length);

                        Console.WriteLine(average);
                    }
                    catch
                    {
                        int marksOne = int.Parse(marks[0]);
                        int marksTwo = int.Parse(marks[1]);

                        int average = ((marksOne + marksTwo) / marks.Length);

                        Console.WriteLine(average);
                    }

                    
                    
                }
            }
            //wait for user input so results can be seen
            Console.ReadLine();
        }
    }
}
