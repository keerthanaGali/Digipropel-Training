/**5.Write a program in C# Sharp to accept two matrices and check whether they are equal.**/

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

/**
Input & Output : (one example)
-----------------------------------
Enter the number of rows in first matrix : 3

Enter the number of columns in first matrix : 3

Enter the number of rows in second matrix : 4

Enter the number of columns in second matrix : 4
Enter the first matrix :
element - [0],[0] : 1 
element - [0],[1] : 2
element - [0],[2] : 3
element - [1],[0] : 4
element - [1],[1] : 5
element - [1],[2] : 6
element - [2],[0] : 7
element - [2],[1] : 8
element - [2],[2] : 9
Enter the second matrix :
element - [0],[0] : 11
element - [0],[1] : 12
element - [0],[2] : 13
element - [0],[3] : 14
element - [1],[0] : 15
element - [1],[1] : 16
element - [1],[2] : 17
element - [1],[3] : 18
element - [2],[0] : 19
element - [2],[1] : 20
element - [2],[2] : 21
element - [2],[3] : 22
element - [3],[0] : 23
element - [3],[1] : 24
element - [3],[2] : 25
element - [3],[3] : 26
The first matrix is :
1  2  3
4  5  6
7  8  9
The second matrix is :
11  12  13  14
15  16  17  18
19  20  21  22
23  24  25  26
The Matrices can't be compared

Input & Output : (another example)
---------------------------------------
Enter the number of rows in first matrix : 3

Enter the number of columns in first matrix : 3

Enter the number of rows in second matrix : 3

Enter the number of columns in second matrix : 3
Enter the first matrix :
element - [0],[0] : 1
element - [0],[1] : 2
element - [0],[2] : 3
element - [1],[0] : 4
element - [1],[1] : 5
element - [1],[2] : 6
element - [2],[0] : 7
element - [2],[1] : 8
element - [2],[2] : 9
Enter the second matrix :
element - [0],[0] : 1
element - [0],[1] : 2
element - [0],[2] : 3
element - [1],[0] : 4
element - [1],[1] : 5
element - [1],[2] : 6
element - [2],[0] : 7
element - [2],[1] : 8
element - [2],[2] : 9
The first matrix is :
1  2  3
4  5  6
7  8  9
The second matrix is :
1  2  3
4  5  6
7  8  9
The Matrices can be compared
Two Matrices are equal
**/
