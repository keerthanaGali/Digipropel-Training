using System;

namespace june
{
    class Program
    {
        static void Main(string[] args)
        {
           int n, i, j;
            int dupl=1, occr = 0;
            int[] a = new int[100];
            int[] b = new int[100];
            int[] c = new int[100];

            Console.Write("\nEnter the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Input {0} elements in the array :  ", n);

            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            // copying entered array values to another array

            for (i = 0; i < n; i++)
            {
                b[i] = a[i];
                c[i] = 0;
            }

            // Identifying Duplicates

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
                    
                //displaying occurances

                for (i = 0; i < n; i++)
                {
                    if (c[i] == 2) 
                    { 
                        occr++; 
                    }
                    
                }
                Console.WriteLine("The number of duplicate elements are : {0} \n", occr);

        }
    }
}














