/**8. Write a c# program to generate a random number.**/

using System;

namespace july
{
    class july05_8
    {
        static void Main(string[] args)
        {
            Random random = new System.Random();
            //will generate randon numbers
            Console.WriteLine("First random number is :" +(random.Next(0,10)));
            Console.WriteLine("Second random number is : "+(random.Next(20,100)));
        }
    }
}



/**
Output : 
------------------
First random number is :6
Second random number is : 91
**/