using System;

namespace june
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int i,j,n,temp;
 
            
            Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n",n);

            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());           
            }
 
            for(i=0; i<n; i++)
            {
                
                for(j=i+1; j<n; j++)
                {
                    if(a[j] < a[i])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.Write("\nElements of array in sorted ascending order:\n");
            for(i=0; i<n; i++)
            {
                
                Console.Write("{0}  ", a[i]);
            }
		        Console.Write("\n\n");	
        }
    }
}


















