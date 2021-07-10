/**4.  Write a program in C# Sharp to find the length of a string without using library function. **/

using System;

namespace july
{
    class june30_4
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter the string value :");
            str = Console.ReadLine();
            int strLength = str.Length;
            Console.WriteLine("Length of the string is : " + strLength);

        }

    }
    
}

/**
Input :
---------------
Enter the string value :
This is a C# Program.

Output :
--------------
Length of the string is : 21
**/
