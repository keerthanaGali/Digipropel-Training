/**9.Write a C# Sharp program reverse all the words of a given string which have even length.**/

using System;

namespace july
{
    class june30_9
    {
        static void Main(string[] args)
        {
            string str = "C# Exercises";
            Console.WriteLine("\nOriginal string: " + str);
            Console.WriteLine("\nReverse all the words of the said string which have even length:\n" + test(str));
            
            str = "C# is used to develop web apps , desktop apps , mobile apps , games and much more.";
            Console.WriteLine("\nOriginal string: " + str);
            Console.WriteLine("\nReverse all the words of the said string which have even length:\n" + test(str));
        
        }
        public static string test(string str)
        {
            int i;
            string[] strArry = str.Split(' ');
            for (i = 0; i < strArry.Length; i++)
            {
                if(strArry[i].Length % 2 == 0)
                {
                    char[] array = strArry[i].ToCharArray();
                    Array.Reverse(array);
                    strArry[i]= new string(array);
                }
            }
            return string.Join(" ",strArry);
        }

    }
    
}

/**
Output :
--------------
Original string: 
C# Exercises

Reverse all the words of the said string which have even length:
#C Exercises

Original string: 
C# is used to develop web apps , desktop apps , mobile apps , games and much more.

Reverse all the words of the said string which have even length:
#C si desu ot develop web sppa , desktop sppa , elibom sppa , games and hcum more.
**/
