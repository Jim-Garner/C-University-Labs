using System;
using System.IO;

namespace Lab7._1___Methods_and_Structs
{
    class Program
    {
        struct Student
        {
            public string name;
            public int[] marks;
        }

        static void Main(string[] args)
        {
            //Array to hold the students
            Student[] arrayOfPersons;

            //Read in all lines of the text file containing the students names and marks
            string[] lineInFile = File.ReadAllLines("students.txt");

            //Initialise the array with however many lines are in the text file.
            arrayOfPersons = new Student[lineInFile.Length];


            //Loop over however many studetns we have
            for (int i = 0; i < arrayOfPersons.Length; i++)
            {
                //Split the line according to the comma, so the names and marks will be seperated
                string[] lineSplit = lineInFile[i].Split(';');

                //Create a new student
                Student p = new Student();

                //Assign the name of that student to the first element of the array which has been split into names and marks
                p.name = lineSplit[0];

                //Then split the marks side of the array according to the comma to get individual marks
                string[] marks = lineSplit[1].Split(',');

                //Assign these marks to that student
                //Some students only have 3 marks, some 2.
                //Hence, this method will add the marks to the array no matter how many there are.
                int[] m = new int[marks.Length];

                for (int x = 0; x < marks.Length; x++)
                {
                    m[x] = int.Parse(marks[x]);
                }
                p.marks = m;
                //Add that student to the array of students.
                arrayOfPersons[i] = p;


            }
            //loop over all the students
            for (int i = 0; i < arrayOfPersons.Length; i++)
            {
                //Total for that students total mark
                int total = 0;
                //Add the marks to the total
                for (int x = 0; x < arrayOfPersons[i].marks.Length; x++)
                {
                    total = total + arrayOfPersons[i].marks[x];
                }
                //If the average is less than 40, write their name
                if (total / arrayOfPersons[i].marks.Length < 40)
                {
                    Console.WriteLine(arrayOfPersons[i].name);
                }
            }
        }
    }
}
