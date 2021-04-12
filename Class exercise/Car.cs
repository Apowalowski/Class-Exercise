using System;
using System.Collections.Generic;
using System.Text;

namespace Class_exercise
{
    public class Car
    {


        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        //Constructors
        public Car() //A special member method that has the same name as it's class
        {

        }
        //fields
        //properties
        //methods

        //Create a Make property of type string that is public
        public string Make { get; set; } //get = read set = write
        public string Model { get; set; }
        public int Year { get; set; }

    }
}