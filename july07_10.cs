/**10.Create a class named "Table". It must have a constructor, indicating the width and height of the board. It will have a method "ShowData" which will write on the screen 
the width and that height of the table.Create an array containing 10 tables, with random sizes between 50 and 200 cm, and display all the data.**/

using System;

namespace july
{
    class july07_10
    {
        //Main Method
        static void Main(string[] args)
        {
            Table[] arr = new Table[10];
            //Generate the random values
            Random value = new Random();
            for(int i = 0; i<10; i++)
            arr[i] = new Table(value.Next(50, 200), value.Next(50,200));
            foreach (var i in arr)
            i.ShowData();
        }
        // created a class Table
        public  class Table  
        {
            private int width = 0; 
            private int height = 0; 
            //Created a parameterized constructor
            public Table(int width, int height)
            {
                if (width >= 0) this.width = width;
                if (height >= 0) this.height = height;
            }
            public void ShowData()
            {
                Console.WriteLine("Height - {0} cm, width - {1} cm", height, width);
            }
        }
    }   
   
}				
/**
Output : 
----------------
Height - 111 cm, width - 102 cm
Height - 128 cm, width - 82 cm
Height - 154 cm, width - 112 cm
Height - 98 cm, width - 122 cm
Height - 92 cm, width - 187 cm
Height - 176 cm, width - 75 cm
Height - 95 cm, width - 197 cm
Height - 68 cm, width - 192 cm
Height - 188 cm, width - 66 cm
Height - 63 cm, width - 162 cm
**/