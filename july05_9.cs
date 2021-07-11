/**9. Make D:\csharp\example.dat file using BinaryWriter class, store current date and time and read that text using BinaryReader class.**/

using System;
using System.IO;

namespace july
{
    class july05_9
    {
        // Define constant string
        const string filename = "july.date and time"; 
        static void Main(string[] args)
        {
            WriteDefaultValues();
            DisplayValues();
        }
        
        public static void WriteDefaultValues()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.Create)))
            {
                writer.Write("Current Date and Time : " + DateTime.Now.ToString());
            }
        }
        public static void DisplayValues()
        {
            if (File.Exists(filename))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.Open)))
                {
                    Console.WriteLine(reader.ReadString());
                }
            }
        }

    }
}



/**
Output : 
------------------
Current Date and Time : 11-07-2021 21:01:16
**/