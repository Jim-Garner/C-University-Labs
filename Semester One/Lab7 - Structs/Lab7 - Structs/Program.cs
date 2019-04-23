using System;

namespace Lab7___Structs
{
    class Program
    {
        struct Student
        {
            //Structs need to be declared above the Main code.
            //Predefined parameters need to be set out and declared here.
            public string name;
            public int[] marks;
        }

        static void Main(string[] args)
        {
            //Student variable name = new Student;
            Student p = new Student();
            //Pupil name - predefined in struct
            p.name = "Jane";
            //Pupil marks - predefined in struct
            p.marks = new int[] { 58, 43, 92 };

            Console.WriteLine(p.name);

            for (int i = 0; i < p.marks.Length; i++)
            {
                //Resembling how we use arrays;
                Console.WriteLine(p.marks[i]);
            }

        }
    }
}
