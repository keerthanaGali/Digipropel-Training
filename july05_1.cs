/**1.Create a C# program that requests three names of people from the user and stores them in an array of objects 
of type Person.**/

using System;

namespace july
{
    
    class july05_1
    {
        static void Main(string[] args)
        {
            int i, total = 3;
            Person[] persons = new Person[total];
    
            for (i = 0; i < total; i++)
            {
                persons[i] = new Person() 
                {
                    Name = Console.ReadLine()
                };
            }
    
            for (i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
    
            Console.ReadLine();
        }
    
        public class Person
        {
            public string Name { get; set; }
    
            public override string ToString()
            {
                return "Hello! My name is " + Name;
            }
        }
    }
}

/**
Input : 
------------
Keerthi
Prathyusha
Vineeth

Output :
-------------
Hello! My name is Keerthi
Hello! My name is Prathyusha
Hello! My name is Vineeth
**/