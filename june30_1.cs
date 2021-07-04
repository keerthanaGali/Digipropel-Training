using System;

namespace july
{
    class Program
    {
        enum name
        {
        keerthi,
        bhavana,
        vasudha,
        sireesha,
        vineeth,
        harsha
        }
        static void Main(string[] args) 
        {
            //select the option to given below cases
            Console.Write("Choose the option value :  ");
            String str = Console.ReadLine();
            
            // name myVar=0;// =  name.parse(str);
            Enum.TryParse(str, out name myVar);
            
            switch(myVar)
            {
                case name.keerthi:
                Console.WriteLine("\nYou select the name keerthi");
                Console.WriteLine("Age is 21");
                break;

                case name.bhavana:
                Console.WriteLine("\nYou select the name bhavana");
                Console.WriteLine("Age is 22");
                break;

                case name.vasudha:
                Console.WriteLine("\nYou select the name vasudha");
                Console.WriteLine("Age is 20");
                break;

                case name.sireesha:
                Console.WriteLine("\nYou select the name sireesha");
                Console.WriteLine("Age is 23");
                break;

                case name.vineeth:
                Console.WriteLine("\nYou select the name vineeth");
                Console.WriteLine("Age is 24");
                break;

                case name.harsha:
                Console.WriteLine("\nYou select the name harsha");
                Console.WriteLine("Age is 22");
                break;

                default:
                Console.WriteLine("\nInvalid option");
                break;
            }
        }
    }    
}    