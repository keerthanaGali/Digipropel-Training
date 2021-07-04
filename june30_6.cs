using System;

namespace july
{
    class june30_6
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine("\nOriginal string is : {0}",  str);
            Console.WriteLine("\nPosition of the word 'fox' in the said string : " + WordPosition(str, "fox"));
            Console.WriteLine("\nPosition of the word 'the' in the said string : " + WordPosition(str, "the"));
            Console.WriteLine("\nPosition of the word 'lazy' in the said string : " + WordPosition(str, "lazy"));
            Console.WriteLine("\n");
        }
        public static int WordPosition(string text, string word)
        {
            string[] arry = text.Split(' '); 
            return Array.IndexOf(arry, word) + 1;
        }

        

    }
    
}