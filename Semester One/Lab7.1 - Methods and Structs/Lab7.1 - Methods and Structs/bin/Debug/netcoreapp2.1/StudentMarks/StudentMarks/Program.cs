using System;
using System.IO;

namespace ConsoleApplication51
{
    class Program
    {
        //The struct holding the student information
        public struct Student
        {
            //The string which holds the name of a student
            public string name;
            //The marks for each student
            public int[] marks;
        }

        public static int getAveageMarkOfAllStudents(Student[] arrayOfStudents)
        {
            //Total for the value to all the marks
            int total = 0;
            //Counter to count how many marks there are (some students have 2, some students have 3)
            int count = 0;

            //Loop over all studetns
            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                //Loop over each studetns marks
                for (int x = 0; x < arrayOfStudents[i].marks.Length; x++)
                {
                    //Add to the total and increment the counter 
                    //Some students will have 2 marks, some 3, so we need the counter
                    total = total + arrayOfStudents[i].marks[x];
                    count++;
                }
            }

            //Return the average
            return total / count;
        }

        //This method will write to the console all of the students names whose marks are less than 40
        public static void getNamesOfFailingStudents(Student[] arrayOfStudents)
        {
            //loop over all the students
            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                //Total for that students total mark
                int total = 0;

                //Add the marks to the total
                for (int x = 0; x < arrayOfStudents[i].marks.Length; x++)
                {
                    total = total + arrayOfStudents[i].marks[x];
                }

                //If the average is less than 40, write their name
                if (total / arrayOfStudents[i].marks.Length < 40)
                {
                    Console.WriteLine(arrayOfStudents[i].name);
                }
            }
        }

        //This gets the average 2nd mark for all students 
        public static int getAverageOfSecondMarkForAllStudents(Student[] arrayOfStudents)
        {
            //Total of all second marks
            int total = 0;

            //Loop over all the students 
            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                //Add thier 2nd mark to the total 
                total = total + arrayOfStudents[i].marks[1];
            }

            //return the average
            return total / arrayOfStudents.Length;
        }


        static void Main(string[] args)
        {


            //Array to hold the students
            Student[] arrayOfPersons;

            //Read in all lines of the text file containing the students names and marks 
            string[] lineInFile = File.ReadAllLines("Students.txt");

            //Initialise the array with however many lines are in the text file. 
            arrayOfPersons = new Student[lineInFile.Length];

            //Loop over however many students we have 
            for (int i = 0; i < arrayOfPersons.Length; i++)
            {
                //Split the line according to the comma, so the names and marks will be separated
                string[] lineSplit = lineInFile[i].Split(';');

                //Create a new student
                Student p = new Student();

                //Assign the name of that student to the first element of the array which has been split into //names and marks
                p.name = lineSplit[0];

                //Then split the marks side of the array according to the comma to get individual marks
                string[] marks = lineSplit[1].Split(',');

                //Assign these marks to that student
                // Some students only have 3 marks, some 2.
                //Hence, this method will add the marks to the array no matter how many there are. 

                int[] m = new int[marks.Length];

                for (int x = 0; x < marks.Length; x++)
                {
                    m[x] = int.Parse(marks[x]);
                }

                p.marks = m;

                //Add that studetn to the array of students. 
                arrayOfPersons[i] = p;

            }

            Console.WriteLine(getAveageMarkOfAllStudents(arrayOfPersons));

            Console.WriteLine(getAverageOfSecondMarkForAllStudents(arrayOfPersons));

            getNamesOfFailingStudents(arrayOfPersons);

        }
    }
}
