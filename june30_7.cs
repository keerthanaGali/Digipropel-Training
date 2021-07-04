using System;

namespace july
{
    class june30_7
    {
        static void Main(string[] args)
        {
            string str = "python exercises";
            Console.WriteLine("\nOriginal string is :\n{0}", str);
            Console.WriteLine("\nAfter converting the first character of each word of the given string :\n{0}", test(str));

            str = "The quick brown Fox jumps over the little lazy Dog";
            Console.WriteLine("\nOriginal string is :\n{0}", str);
            Console.WriteLine("\nAfter converting the first character of each word of the given string :\n{0}", test(str));
            Console.Write("\n");
        }
        public static string test(string str)
        {
            //split the string by space into string array
            int i;
            string[] strArry = str.Split(' ');
            for (i = 0; i < strArry.Length; i++)
            {
                //convert the first character of each word of a given string to uppercase
                strArry[i] =  strArry[i].Substring(0, 1).ToUpper() +  strArry[i].Substring(1);
            }
            return string.Join(" ",strArry);
        }

    }
    
}