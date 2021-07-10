/**2.Write a program to accepst two names and sort them in alphabetical order.**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace july
{
    class june30_2
    {
        static void Main(string[] args)
        {
            string a, b;
            List<string> names = new List<string>();

            //Input the names
            Console.WriteLine("Enter the first name:");
            a = Console.ReadLine();
            Console.WriteLine("Enter the second name:");
            b = Console.ReadLine();
            names.Add(a);
            names.Add(b);
            //Names to be sorted in alphabetical order
            names.Sort();
            Console.WriteLine("Sorted the list of two names : ");
            foreach (string s in names)
            {
                Console.WriteLine(s);
            }
        }

    }
    
}

/**
Input :
-------------
Enter the first name:
Keerthana
Enter the second name:
Gali

Output :
--------------
Sorted the list of two names : 
Gali
Keerthana
**/
