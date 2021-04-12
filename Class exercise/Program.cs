using System;
using System.Collections.Generic;

namespace Class_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2021;

            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "CX-5",
                Year = 2014, 

            };
            var chevy = new Car("Chevy", "Impala", 2000);
            var carList = new List<Car>() { myCar, mazda, chevy };

            Console.WriteLine(carList.Capacity); 
            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        }
    }
}
