/**3.Write a program in C# Sharp to count the frequency of each element of an array.**/

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
                    Console.Write("{0} occurs {1} times", a[i], dup[i]);
                    Console.Write("\n");
                }
            }    
        }

    }
}

/**
Input & Output :
-------------------
Enter the number of elements to be stored in the array : 6
Enter 6 elements in the array :
element - 0 : 31
element - 1 : 22
element - 2 : 67
element - 3 : 22
element - 4 : 31
element - 5 : 22

Frequency of all elements of the array :
31 occurs 2 times
22 occurs 3 times
67 occurs 1 times
**/
