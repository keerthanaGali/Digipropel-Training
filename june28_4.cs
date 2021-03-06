/**4.Write a program in C# Sharp to separate odd and even integers in separate arrays.**/ 

using System;

namespace June
{
    class june28_4
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[] b = new int[10];
            int[] c = new int[10];
            int i,j = 0, k = 0, n;
            
            Console.Write("Enter the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter {0} elements in the array :\n",n);
            for(i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    b[j] = a[i];
                    j++;
                }
                else
                {
                    c[k] = a[i];
                    k++;
                }
            }
            Console.Write("\nThe Even elements are : \n");
            for(i = 0; i < j; i++)
            {
                Console.Write("{0} ",b[i]);
            }
            Console.Write("\nThe Odd elements are :\n");
            for(i = 0; i < k; i++)
            {
                Console.Write("{0} ", c[i]);
            }
            Console.Write("\n");	    
        }

    }
}

/**
Input & Output :
--------------------
Enter the number of elements to be stored in the array : 7
Enter 7 elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 1
element - 3 : 8
element - 4 : 3
element - 5 : 6
element - 6 : 1

The Even elements are :
2 8 6
The Odd elements are :
5 1 3 1
**/
