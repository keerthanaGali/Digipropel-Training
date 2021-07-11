/**2. Create a C# program that implements an abstract class Animal that has a Name property of type text and three methods SetName (string name), GetName and Eat. The Eat method will be an abstract method of type void.**/

using System;

namespace july
{
    public abstract class Animal 
    {
        private string str;
        public void SetName(string name)
        {
            str = name;
        }
        public string GetName()
        {
            return str ;
        }
        public abstract void Eat();
    }
    public class AbstractClass
    {
        public class Dog : Animal
        {
            public override  void Eat()
            {
                Console.WriteLine("Lucy is Eating ");
            }
            public static void Main()
            {
                Dog dog = new Dog();
                dog.SetName(Console.ReadLine());
                Console.WriteLine (dog.GetName());
                dog.Eat();
            }
        }
    }

}


/**
Input : 
---------------
Lucy

Output : 
----------------
Lucy
Lucy is Eating
**/