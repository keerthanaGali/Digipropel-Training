/**10.Write a program in C# to the add arrays in the following way.**/

using System;

namespace June
{
    class june28_10
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int i, j, s1 = 0, s2 = 0, sum;
            
            Console.WriteLine("Enter the first array elements : ");
            for (i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("Enter the second array elements : ");
            for (j = 0; j < b.Length; j++)
            {
                b[j] = Convert.ToInt32(Console.ReadLine());
            }

        
            // Adding the array elements
            for (i = 0; i < a.Length; i++)
            {
                s1 += a[i];
            }

            for (j = 0; j < b.Length; j++)
            {
                s2 += b[j];
            }
            sum = s1 + s2;

            Console.WriteLine("sum of the two array elements " + sum);
            Console.Write("\n");
        }
    }
}

/**
Input & output :
-----------------------
Enter the first array elements : 
3
5
1
7
8
Enter the second array elements :
2
4
1
9
4
sum of the two array elements : 44
**/
