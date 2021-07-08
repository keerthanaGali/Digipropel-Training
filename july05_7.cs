/**7.Write a C# Program to compare two dates**/

using System;

namespace july
{
    class july05_7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCompare the two dates");
            Console.WriteLine("--------------------------");

            //Compare two dates - date1 and date2
            DateTime date1 = new DateTime(2020, 07, 07);
            Console.WriteLine("Date 1 : {0}", date1);

            DateTime date2 = new DateTime(2020, 06, 08);
            Console.WriteLine("Date 2 : {0}", date2);

            if(date1 < date2)
            Console.WriteLine("{0} comes before {1}", date1, date2);
            else
            Console.WriteLine("{1} comes before {0}", date1, date2);
            Console.Write("\n");
        }
    }
}

/**
Output : 
------------------
Compare the two dates
Date 1 : 07-07-2020 00:00:00
Date 2 : 08-06-2020 00:00:00
08-06-2020 00:00:00 comes before 07-07-2020 00:00:00
**/