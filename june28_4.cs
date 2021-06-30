using System;

namespace june
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[50];
            int[] b = new int[50];
            int[] c = new int[50];
            int i = 0,j = 0,k = 0,n;
 
            
            Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n",n);

            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());           
            }
 
            for(i = 0; i < n; i++)
            {
                if (a[i]%2 == 0)
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
            Console.Write("\nThe Even elements are stored in array : \n");
            for(i = 0; i < j; i++)
            {
                Console.Write("{0} ",b[i]);
            }
            Console.Write("\nThe Odd elements are stored in array :\n");
            for(i = 0; i < k; i++)
            {
                Console.Write("{0} ", c[i]);
            }
    	
        }
    }
}


















