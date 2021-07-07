/**2. Write a program in C# Sharp to count a total number of duplicate elements in an array.**/
using System;

namespace June
{
    class june28_2
        {
        static void Main(string[] args)
        {
            int n, i, j;
            int dupl=1, count = 0;
            int[] a = new int[100];
            int[] b = new int[100];
            int[] c = new int[100];

            Console.Write("Enter the elements stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter {0} elements in the array : ",n);

            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                b[i] = a[i];
                c[i] = 0;
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (a[i] == b[j])
                    {
                        c[j] = dupl;

                        dupl++;
                    }
                }
                dupl = 1;

            }
                for (i = 0; i < n; i++)
                {
                    if (c[i] == 2) 
                    { 
                        count++; 
                    } 
                }
                Console.Write("The number of duplicate elements are : {0} \n", count);
                Console.Write("\n");
        }
    }
}   

/**
Input & Output :
---------------------
Enter the elements stored in the array : 5
Enter 5 elements in the array : 
element - 0 : 2
element - 1 : 1
element - 2 : 7
element - 3 : 2
element - 4 : 7
The number of duplicate elements are : 2 
**/
