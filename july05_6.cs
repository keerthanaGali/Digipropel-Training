/**6. Write a C# program to check if the entered year is a leap year or not**/

using System;

namespace july
{
    class july05_6
    {
        static void Main(string[] args)
        {
            // Check if the year is leap year or not
            int Year;
            Console.Write("\nEnter the Year : ");
            Year = Convert.ToInt32(Console.ReadLine());

            // If it is disvible by 100 or 400 then it is a Leap Year
            if((Year % 100 == 0) || (Year % 400 == 0) || (Year % 4 == 0))
            {
                Console.WriteLine("It is a Leap Year");
            }
            //If it is not disvible by 100 or 400 then it is not a Leap Year
            else
            {
                Console.WriteLine("It is not a Leap Year");
            }
            Console.Write("\n");
        }
    }
}

/**
Input & Output : 
------------------
Enter the Year : 2020
It is a Leap Year

Another Input & Output :
--------------------------
Enter the Year : 1998
It is not a Leap Year
**/