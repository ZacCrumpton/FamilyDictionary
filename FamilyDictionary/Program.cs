using System;
using System.Linq;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           var myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("Mother", new Dictionary<string, string>() { { "name", "Tina" }, { "age", "50" } });
            myFamily.Add("Wife", new Dictionary<string, string>() { { "name", "Teresa" }, { "age", "28" } });
            myFamily.Add("Son", new Dictionary<string, string>(){ { "name", "Liam"}, { "age", "6"} } );
            myFamily.Add("Daughter", new Dictionary<string, string>() { { "name", "Liberty" }, { "age", "2" } });
            myFamily.Add("Daughter", new Dictionary<string, string>() { { "name", "Lilly" }, { "age", "1" } });

            foreach (var person in myFamily)
            {
                if (person.Value["age"] != "1")
                {
                Console.WriteLine($"{person.Value["name"]} is my {person.Key} and is {person.Value["age"]} years old");
                } else
                {
                    Console.WriteLine($"{person.Value["name"]} is my {person.Key} and is {person.Value["age"]}");
                }
            }
        }
    }
}
