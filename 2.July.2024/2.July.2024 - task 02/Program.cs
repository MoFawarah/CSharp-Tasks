using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace task_2_July___try_01
{

    class Car
    {
        string make;
        int year;
        string type;
        double price;
        string model;
        int palletNo;
        string color;

        public string Make { get { return make; } set { make = value; } }
        public int Year { get { return year; } set { year = value; } }


        public void DisplayInfo(string make, int year)
        {
            Console.WriteLine($"The car make is: {make} and year is: {year}.");
        }

        public void DisplayInfo(string make)
        {
            Console.WriteLine($"The car make is: {make}");
        }

        public virtual void Display()
        {
            Console.WriteLine("Welcome Car!");
        }

    }

    class BMW : Car
    {
        public override void Display()
        {
            Console.WriteLine("Welcome BMW!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.DisplayInfo("Honda", 2022);
            car.DisplayInfo("Honda");


            Car bmwCar = new BMW();
            bmwCar.Display();


            BMW bmw = new BMW();
            bmw.Display();
        }
    }
}
