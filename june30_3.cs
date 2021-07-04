using System;


namespace july
{
    class june30_3
    {
        static void Main(string[] args)
        {
            int row, column;
            Console.Write("\n\n");
            Console.WriteLine("Display the pattern like 'B' with an asterisk:");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");
            
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == 0 || row == 3 || row == 6) && (column < 5 && column > 1)) || (column == 5 && (row != 0 && row != 3 && row != 6)))
                    Console.Write("*");
                    else
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

    }
    
}