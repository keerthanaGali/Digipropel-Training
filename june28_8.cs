using System;

namespace June
{
    class june28_8
    {
        static void Main(string[] args)
        {
            int[] a = new int[50];
            int i,n;
 
            
            Console.Write("Enter the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter {0} numbers of elements in the array :\n",n);

            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());           
            }
 
            Console.Write("The values store into the array are : \n");
            for(i=0;i<n;i++)
            {
	            Console.Write("{0}  ",a[i]);
            }
        
            Console.Write("\nThe values store into the array in reverse are :\n");
            for(i = n-1; i >= 0; i--)
            {
                Console.Write("{0}  ",a[i]);
            }

        }
    }
}

/**
Input & Output : 
---------------------
Enter the number of elements to be stored in the array : 7
Enter 7 numbers of elements in the array :
element - 0 : 1
element - 1 : 2
element - 2 : 3
element - 3 : 4
element - 4 : 5
element - 5 : 6
element - 6 : 7
The values store into the array are :
1  2  3  4  5  6  7
The values store into the array in reverse are :
7  6  5  4  3  2  1
**/
