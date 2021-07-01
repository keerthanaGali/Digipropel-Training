
using System;

namespace June
{
    class june28_3
    {
        static void Main(string[] args)
        {
            int [] a = new int[100];
            int [] dup = new int[100];
            int n, i, j, count;
            Console.Write("Enter the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter {0} elements in the array :",n);
            for(i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());
                dup[i] = -1;
            }
            for(i = 0; i < n; i++)
            {
                count = 1;
                for(j = i + 1; j < n; j++)
                {
                    if(a[i]==a[j])
                    {
                        count++;
                        dup[j] = 0;
                    }
                }
                if(dup[i] != 0)
                {
                    dup[i] = count;
                }
            }
            Console.WriteLine("\nFrequency of all elements of the array : ");
            for(i = 0; i < n; i++)
            {
                if(dup[i]!=0)
                {
                    Console.WriteLine("{0} occurs {1} times", a[i], dup[i]);
                    Console.Write("\n");
                }
            }    
        }

    }
}