using System;
using System.IO;

namespace Lab6._5___File_Input_and_Output_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //This opens up the stream reader which we will use to access the file
            // The name of the file to be read is inputter here “namesAndMarks.txt”
            StreamReader file = new StreamReader("namesAndMarks.txt");
            //This opens up the stream writer which can be used to write text to the file specified
            //"newFile.txt"
            StreamWriter writer = new StreamWriter("nameAndLowestScore.txt");
            string line = "";
            //For every line which isnt the last
            while ((line = file.ReadLine()) != null)
            {
                //Split the line from the text file - we should get the names in namesMarks[0], and the marks in namesMarks[1]
                string[] namesMarks = line.Split(';');
                //This splits the marks in the able array into individual marks
                string[] studentMarks = namesMarks[1].Split(',');
                //We want to convert these marks to ints so we can compare them to get the lowest mark.
                int[] marks = new int[studentMarks.Length];
                //parse the scores into the int array
                for (int i = 0; i < marks.Length; i++)
                {
                    marks[i] = int.Parse(studentMarks[i]);
                }
                //set the lowest possible mark as the maximum mark
                int lowestMark = 100;
                //For every mark
                for (int i = 0; i < marks.Length; i++)
                {
                    //If it is lower than the highest mark
                    if (marks[i] < lowestMark)
                    {
                        //assign lowest marks to that value.
                        lowestMark = marks[i];
                    }
                }
                //This writes line to the file containing the students name and their lowest mark
                writer.WriteLine(namesMarks[0] + ";" + lowestMark);
                //This flushes the streamwriter so the information is saved to the file
                writer.Flush();
            }
            //This closes the streamwriter.
            writer.Close();
            
        }
    }

}
