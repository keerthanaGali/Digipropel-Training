/**9.Create a program to read a text file and ask the user for sentences to search in it.**/

using System;
using System.IO;

namespace july
{
    class july07_9
    {
        //Main Method
        static void Main(string[] args)
        {
            // Open a file in local drive  
            FileStream inFile = new FileStream(@"C:\Users\digipropel\Desktop\july\searchword.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string record;
            string input;
            Console.Write("\nEnter the word to search in the file :\n");
            input = Console.ReadLine();
            try
            {
                record = reader.ReadLine();
                while (record != null)
                {
                    // To check given string in the file
                    if (record.Contains(input))
                    {
                        Console.WriteLine(record);
                    }
                    record = reader.ReadLine();
                }
            }
            finally
            {
                // Close the file
                reader.Close();
                inFile.Close();
            }
            Console.Write("\n");
        }
    }
}


/**
Input :
----------------
Enter the word to search in the file :
visual studio
Output :
----------------
Hi, Welcome to the visual studio code, Write the C# sample code.
**/