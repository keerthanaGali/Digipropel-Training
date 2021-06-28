using System;

namespace june
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int i, j, n, count = 0;
 
            
            Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n",n);

            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());           
            }
 
            for (i = 0; i < n; i++)
            {
            for (j = i + 1; j < n; j++)
            {
                if (a[i] == a[j])
                {
                    count++;
                    break;
                }
            }
        }
 
            Console.Write("Total number of duplicate elements stored in the array : {0} \n\n ", count);
    

        }
    }
}


















