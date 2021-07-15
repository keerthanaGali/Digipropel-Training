/**5. Explore the "File" class; Write a program to take the name of a file from user and read the file.Display the number of lines in the file on the screen. Use try - catch in code.**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace july
{
    class july05_5
    {
        //Main Method
        static void Main(string[] args)
        {
            String line;
            int count = 0;
            //Opens a file in read mode
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\digipropel\Desktop\july\keerthi.txt");
            //Gets each line till end of file is reached
            
            while ((line = file.ReadLine()) != null)
            {
                String[] words = line.Split(' ');
                //Count the each word
                count = count + words.Length;
            }
            
            Console.WriteLine("Number of words present in given file: {0}", count);
            file.Close();
        }
    }
}


/**
Output :
----------------
Number of words present in given file: 5
**/