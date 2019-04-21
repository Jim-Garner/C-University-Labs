using System;
//This let's us input and output files.
using System.IO;

namespace Lab6._3___File_Input_and_Output
{
    class Program
    {
        static void Main(string[] args)
        {            
            string line = "";
            //This opens up the stream reader which we will use to access the file

            // The name of the file to be read is inputter here “namesAndMarks.txt”
            StreamReader file = new StreamReader("namesAndMarks.txt");

            //For every line which isnt the last one
            while ((line = file.ReadLine()) != null)
            {
                //Print that line to the screen
                Console.WriteLine(line);
            }
            //wait for user input so results can be seen
            Console.ReadLine();
        }
    }
}
