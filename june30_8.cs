using System;

namespace july
{
    class june30_8
    {
        static void Main(string[] args)
        {
            string str = "c# Exercises";
            Console.WriteLine("Original string:\n" + str);
            Console.WriteLine("\nAfter alternating the case of each letter of the given string:\n" + test(str));

            str = "C# is used to develop web apps, desktop apps, mobile apps, games and much more.";
            Console.WriteLine("\nOriginal string:\n" + str);
            Console.WriteLine("\nAfter alternating the case of each letter of the given string:\n" + test(str));
            Console.Write("\n");
        }
        public static string test(string str)
        {
            int i;
            string text = str.Replace(" ", "  ");
            string result_str = "";
            result_str += Char.ToUpper(str[0]);
            for (i = 1; i < text.Length; i++)
            {
                if (i % 2 == 0) 
                result_str += Char.ToUpper(text[i]);
                else if (i % 2 != 0 && Char.IsUpper(text[i])) result_str += Char.ToLower(text[i]);
                else 
                result_str += text[i];
            }
            result_str = result_str.Replace("  ", " ");
            return result_str;
        }

    }
    
}