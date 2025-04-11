using Properties_Stone_Evan;
using System;

namespace MyApp
{
     class Program
    {
        static void Main(string[] args)
        {
            //program #
            Console.WriteLine("Program: 12");

            //sets car
            Car car = new Car();
            car.Make = "Mazda";
            car.Model = "CX-30";
            
            //prints first car & car
            Console.WriteLine("First Car");
            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            //sets car2
            Car car2 = new Car();
            car2.Make = "Honda";
            car2.Model = "CR-V";

            //prints second car & car2
            Console.WriteLine("Second Car");
            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

            //asks for user's input, sets yourcar
            Console.WriteLine("Please input a car's make.");
            string yourMake = Console.ReadLine();
            Console.WriteLine("Please input your car's model.");
            string yourModel = Console.ReadLine();
            Car yourCar = new Car();
            yourCar.Make = yourMake;
            yourCar.Model = yourModel;

            //prints your car & yourcar
            Console.WriteLine("Your Car");
            Console.WriteLine($"Make: {yourCar.Make}, Model: {yourCar.Model}");
            

        }
    }
}