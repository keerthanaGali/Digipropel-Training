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
            Console.WriteLine("Missing number is :  ");
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