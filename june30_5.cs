using System;

namespace july
{
    class june30_5
    {
        static void Main(string[] args)
        {
            string str;
            int i, word;
            
            //Input the string
            Console.WriteLine("Enter the string : ");
            str = Console.ReadLine();
            word = 1;
            
            //Count the total number of words in a given string
            for (i = 0; i < str.Length; i++ )
            {
                if(str[i] == ' ' || str[i] == '\t')
                {
                    word++;
                }
            }
            Console.Write("Total number of words in the string is : " + word);

        }

    }
    
}