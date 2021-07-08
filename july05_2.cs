/**2. Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects.**/

using System;

namespace july
{
    class july05_2 
    {
        //Protected class instead of private
        static void Main(string[] args)
        {
            int a = 3;
            string Name;
            Person[] persons = new Person[a];
            for (int i = 0; i < a; i++)
            {
                persons[i] = new Person(Name = Console.ReadLine());
            }
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }
    }
    
    public class Person
    {
        public string Name { get; set;}
        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
           Console.WriteLine("Constructors are called : ");
            return "Name :" + Name;
        }
         ~Person()
         {
             Name = string.Empty;
         }
    }
    
}

/**
Input : 
-------------
keerthi
vineeth
prathyusha

Output :
--------------
Constructors are called : 
Name :keerthi
Constructors are called :
Name :vineeth
Constructors are called :
Name :prathyusha   
**/