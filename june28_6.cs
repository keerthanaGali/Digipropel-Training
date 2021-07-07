/**6.Write a C# Sharp program to find the missing number in a given array of numbers between 10 and 20.**/

using System;

namespace June
{
    class june28_6
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
            
            Console.WriteLine("Enter the array elements : ");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int diff = arr[0] - 0;
            Console.WriteLine("Missing numbers is :  ");
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] - i != diff)
                {
                    while (diff < arr[i] - i)
                    {
                        Console.Write(i + diff + " ");
                        diff++;
                    }
                }
            }        
        }
    }
    
}

/**
Input & Output : (one example)
-------------------------------
Enter the array elements : 
10
11
13
14
15
16
17
18
19
20
Missing number is :  
12

Input & Output : (another example)
-------------------------------------
Enter the array elements : 
3
5
8
10
13
16
18
19
20
21
Missing numbers is :
4 6 7 9 11 12 14 15 17
**/
