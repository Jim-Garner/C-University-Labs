using System;
using System.Collections.Generic;

namespace Lab1._2___Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lists

            //Declare the list name and type;
            List<string> names = new List<string>();

            names.Add("James");
            names.Add("Timothy");
            names.Add("Joe");
            names.Add("Dawn");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            //Dictionarys
            //Here we declare a dictionary called garage;
            Dictionary<string, int> garage = new Dictionary<string, int>();

            //Dictionary's need a key and a value, like an ordinary one needs a word and a definition.

            garage.Add("Ferrari Sport", 2);
            garage.Add("Bugatti Vehron", 1);
            garage.Add("Aston Martin DBS", 2);

            if (garage.ContainsKey("Ferrari Sport"))
            {
                int value = garage["Ferrari Sport"];
                Console.WriteLine(value);
            }

            if (garage.ContainsKey("Bugatti Vehron"))
            {
                Console.WriteLine("True.");
            }
            else
            {
                Console.WriteLine("False.");
            }
        }
    }
}
