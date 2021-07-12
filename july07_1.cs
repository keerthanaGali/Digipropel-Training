/**1. Create a C# program that implements an IVehicle interface with two methods, 
one for Drive of type void and another for Refuel of type bool that has a parameter of type integer with the amount of gasoline to refuel."**/

using System;

namespace july
{
    class july07_1
    {
        //Main Method
        static void Main(string[] args)
        {
            Car car = new Car(0);
            Console.WriteLine("Enter the speed of the car:");
            int Fuel = int.Parse(Console.ReadLine());
            if (car.Refuel(Fuel))
            {
                car.Drive();
            }
        }
        
        //Declaring a interface called Ivehicle with two methods
        public interface Ivehicle
        {
            void Drive();
            bool Refuel(int amount);
        }
        
        //Declaring a class car with a builder
        public class Car : Ivehicle
        {
            public int fuel{ get; set;}
            public Car(int Fuel)
            {
                fuel = Fuel;
            }
            
            //Declaring a Drive method
            public void Drive()
            {
                if( fuel > 0 )
                {
                    Console.WriteLine("Car is driving");
                }
                else
                {
                    Console.WriteLine("No fuel in the car");
                }
            }
            
            //Declaring a bool called Refuel
            public bool Refuel(int amount)
            {
                fuel += amount;
                return true;
            }
        }
    }
}   
   
    				
/**
Input :
---------------
1)Enter the speed of the car:
60

2)Enter the speed of the car:
0

Output : 
----------------
1)Car is driving

2)No fuel in the car
**/