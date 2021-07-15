/**10. Create a Directory D:\example and then create a file in it D:\example\test.txt and store "Hello File Handling" text in it.
 Then gather information of Directory and File and print them on console.**/

using System;
using System.IO;

namespace july
{
    class july05_10
    {
        //Main Method
        static void Main(string[] args)
        {
            CreateDirectory();
            CreateFile();
            Console.ReadKey();
        }
        
        //Creating Directory
        static void CreateDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo("C:/Users/digipropel/Desktop/july/keerthana");
            try
            {
                //Check Directory exists
                if (dir.Exists)
                {
                    Console.WriteLine("Directory Already Exists");
                    Console.WriteLine("Directory Name:" + dir.Name);
                    Console.WriteLine("Path" + dir.FullName);
                    Console.WriteLine("Created on" + dir.CreationTime);
                    Console.WriteLine("Last Accessed" + dir.LastAccessTime);
                }
                else 
                {
                    dir.Create();
                    Console.WriteLine("Directory Created Successfully.Information of Directory:");
                    Console.WriteLine("Directory Name:" + dir.Name);
                    Console.WriteLine("Path" + dir.FullName);
                    Console.WriteLine("Created on" + dir.CreationTime);
                    Console.WriteLine("Last Accessed" + dir.LastAccessTime);
                }
            }
            catch (DirectoryNotFoundException d)
            {
                Console.WriteLine(d.Message.ToString());
            }
        }
        //Creating File 
        static void CreateFile()
        {
            FileInfo file = new FileInfo("C://Users//digipropel//Desktop//july//keerthana\\keerthi.txt");
            using (StreamWriter sw = file.CreateText())
            {
                sw.WriteLine("Hello World!\nWelcome Keerthana!");
            }
            //Diplaying File Info
            Console.WriteLine("File Create on : " + file.CreationTime);
            Console.WriteLine("Directory Name : " + file.DirectoryName);
            Console.WriteLine("Full Name of File : " + file.FullName);
            Console.WriteLine("File is Last Accessed on : " + file.LastAccessTime);
        }
    }
}


/**
Output :
----------------
Directory Created Successfully.Information of Directory:
Directory Name:keerthana
PathC:\Users\digipropel\Desktop\july\keerthana
Created on01-01-1601 05:30:00
Last Accessed01-01-1601 05:30:00
File Create on : 15-07-2021 19:48:01
Directory Name : C:\Users\digipropel\Desktop\july\keerthana
Full Name of File : C:\Users\digipropel\Desktop\july\keerthana\keerthi.txt
File is Last Accessed on : 15-07-2021 19:48:01
**/