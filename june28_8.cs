using System;

namespace june
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[50];
            int i,n;
 
            
            Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} numbers of elements in the array :\n",n);

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
        
            Console.Write("\n\nThe values store into the array in reverse are :\n");
            for(i = n-1; i >= 0; i--)
            {
                Console.Write("{0}  ",a[i]);
            }
            Console.Write("\n\n");
        }
    }
}


















