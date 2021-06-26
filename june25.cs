using System;

namespace june25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Program june25 = new Program();
            june25.Multi();
            june25.AddSubMulDiv();
            june25.Average();
            june25.SumTripleIntegers();
            june25.checkintegers();
            june25.stringword();
        }

/**Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. **/        

        public void Multi()
        {
            int a = 1,b = 1,c = 1;
            Console.WriteLine("Enter the a,b,c Values:");

            Console.Write("Enter the value of a: ",a);
            a=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of b: ",b);
            b=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of c: ",c);
            c=Convert.ToInt32(Console.ReadLine());

            int d = a * b * c;
            Console.WriteLine("Multiplication of three numbers: " + d);
            Console.ReadLine();
        }

/**Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing 
   of two numbers which will be entered by the user.**/        

        public void AddSubMulDiv()
        {
            int i = 1,j = 1;

            //Addition of two numbers

            Console.WriteLine("Enter the Addition values of i,j:");

            Console.Write("Enter the value of i: ",i);
            i=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of j: ",j);
            j=Convert.ToInt32(Console.ReadLine());

            int add  = i + j;
            Console.WriteLine("Addition of two numbers: " + add);
            Console.ReadLine();

            //Subtraction of two numbers

            Console.WriteLine("Enter the Subtraction values of i,j:");

            Console.Write("Enter the value of i: ",i);
            i=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of j: ",j);
            j=Convert.ToInt32(Console.ReadLine());

            int sub = i - j;
            Console.WriteLine("Subtraction of two numbers: " + sub);
            Console.ReadLine();

            //Multiplication of two numbers

            Console.WriteLine("Enter the Multiplication values of i,j:");

            Console.Write("Enter the value of i: ",i);
            i=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of j: ",j);
            j=Convert.ToInt32(Console.ReadLine());

            int mul = i * j;
            Console.WriteLine("Multiplication of two numbers: " + mul);
            Console.ReadLine();

            //Division of two numbers

            Console.WriteLine("Enter the Division values of i,j:");

            Console.Write("Enter the value of i: ",i);
            i=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of j: ",j);
            j=Convert.ToInt32(Console.ReadLine());

            int div = i / j;
            Console.WriteLine("Division of two numbers: " + div);
            Console.ReadLine();

        }

/** Write a C# Sharp program that takes four numbers as input to calculate and print the average.**/

        public void Average()
        {
            int l = 1,m = 1,n = 1,o = 1,p = 1,q = 1,r = 1;
            Console.WriteLine("Enter the Calculate & Average values:");

            Console.Write("Enter the value of l: ",l);
            l=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of m: ",m);
            m=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of n: ",n);
            n=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of o: ",o);
            o=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of p: ",p);
            p=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of q: ",q);
            q=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of r: ",r);
            r=Convert.ToInt32(Console.ReadLine());

            int avg = (l + m + n + o + p + q + r) / 7;
            Console.WriteLine("Calculate & Average value is : " + avg);
            Console.ReadLine();
        }

/** Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.**/

        public void SumTripleIntegers()
        {
            int x = 1,y = 1;
            Console.WriteLine("Enter the sum of values:");

            Console.Write("Enter the value of x: ",x);
            x=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of y: ",y);
            y=Convert.ToInt32(Console.ReadLine());

            if(x == y)
            {
                int z = (x + y) * (x + y) * (x + y);
                Console.WriteLine("Sum of Triple integers: " + z);
                Console.ReadLine();
            }
            
        }

/** Write a C# program to check two given integers and return true if one is negative and one is positive. **/        

        bool checkintegers()
        {
            int m = 1,n = 1;
            Console.WriteLine("Enter the Positive sign and Negative sign values:");

            Console.Write("Enter the value of m: ",m);
            m=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of n: ",n);
            n=Convert.ToInt32(Console.ReadLine());

            if((m > 0 && n < 0) || (m < 0 && n > 0))
            {
                Console.WriteLine("True");
                Console.ReadLine();
                return true;
            }

            else
            {
                Console.WriteLine("False");
                Console.ReadLine();
                return false;
            }
                
        }

 /** Write a C# program to check if a string starts with a specified word. **/       

        public void stringword()
        {
            string k = "";
            Console.WriteLine("Enter the string:");
            k = Console.ReadLine();
            Console.WriteLine("Enter the word to check given the above string:");
            string g = "";
            g = Console.ReadLine();

            Console.WriteLine(" After check given the above string is: " + k.Contains(g));
            Console.ReadLine();
        } 
        
    }
}
