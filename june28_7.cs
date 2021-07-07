/**7. Write a program in C# Sharp to find maximum and minimum element in an array.**/

using System;

namespace June
{
    class june28_7
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int i, max, min, n;

            Console.Write("\nEnter the array elements are : ");
            n = Convert.ToInt32(Console.ReadLine());
            for(i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = a[0];
            min = a[0];
            
            for(i = 1; i < n; i++)
            {
                if(a[i] > max)
                {
                    max = a[i];
                }

                if(a[i] < min)
                {
                    min = a[i];
                }
            }
            
            Console.WriteLine("Maximum element in the array is : " + max);
            Console.WriteLine("Minimum element in the array is : " + min);
            Console.Write("\n");
        }
    }
}

/**
Input & Output :
--------------------
Enter the array elements are : 3
element - 0 : 21
element - 1 : 55
element - 2 : 77
Maximum element in the array is : 77
Minimum element in the array is : 21
**/
