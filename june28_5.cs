
using System;

namespace June
{
    class june28_5
    {
        static void Main(string[] args)
        {
            int[,] a = new int[50,50];
            int[,] b = new int[50,50];
            int i, j, r1, c1, r2, c2, flag = 1;
            Console.Write("\nEnter the number of rows in first matrix :");
            r1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter the number of columns in first matrix :");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter the number of rows in second matrix : ");
            r2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter the number of columns in second matrix :");
            c2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the first matrix :\n");
            for(i = 0; i < r1; i++)
            {
                for(j = 0; j < c1; j++)
                {
	                Console.Write("element - [{0}],[{1}] : ",i,j);
	                a[i,j] = Convert.ToInt32(Console.ReadLine());  
                }
            } 

            Console.Write("Enter the second matrix :\n");

            for(i = 0; i < r2; i++)
            {
                for(j = 0; j < c2; j++)
                {
	                Console.Write("element - [{0}],[{1}] : ",i,j);
	                b[i,j] = Convert.ToInt32(Console.ReadLine()); 
                }
            } 

 	        Console.Write("The first matrix is :\n");
            
	        for(i = 0; i < r1; i++)
	        {
	            for(j = 0; j < c1; j++)
                Console.Write("{0}  ",a[i,j]);
	            Console.Write("\n");
	        }
            Console.Write("The second matrix is :\n");
            for(i = 0; i < r2; i++)
            {
                for(j = 0; j < c2; j++)
                Console.Write("{0}  ",b[i,j]);
                Console.Write("\n");
            }
            if (r1 != r2 && c1 != c2)
            {
                Console.WriteLine("The Matrices can't be compared");

            }
            else
            {
                {
                    Console.WriteLine("The Matrices can be compared");

                    for (i = 0; i < r1; i++)
                    {
                        for (j = 0; j < c2; j++)
                        {
                            if (a[i,j] != b[i,j])
                            {
                                flag = 0;
                                break;
                            }

                        }
                    
                        if(flag == 1)
                        Console.WriteLine("Two Matrices are equal");
                        else
                        Console.WriteLine("Two Matrices are not equal");
                    }
                }
            }
        }
    }
}

