﻿using System;

namespace june
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] a= new int[5];
            int i, n, sum=0;	

            Console.Write("Input the number of elements to be stored in the array :");
	        n = Convert.ToInt32(Console.ReadLine()); 
   
            Console.Write("Input {0} elements in the array :\n",n);

        for(i=0;i<n;i++)
        {
	        Console.Write("element - {0} : ",i);
		    a[i] = Convert.ToInt32(Console.ReadLine()); 
	    }

        for(i=0; i<n; i++)
        {
            
            sum += a[i];
        }

            Console.Write("Sum of all elements stored in the array is :" + sum);
         
        }
    }
}
