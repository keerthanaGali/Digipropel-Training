
using System;

namespace June
{
    class june28_9
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int n, i, j, temp;
            
            Console.Write("Enter the elements in the array : ");
            n = Convert.ToInt32(Console.ReadLine()); 
            
            Console.Write("Enter {0} elements in the array :\n",n);
            for(i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(i = 0; i < n; i++)
            {
                for(j = i + 1; j < n; j++)
                {
                    if(a[j] < a[i])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.Write("\nThe elements of array in sorted ascending order:\n");
            for(i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }
            Console.Write("\n");	
        }
    }
}

