using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {

        class Car
        {
            public int Make { get; set; }
            public int Year { get; set; }
            public string Type { get; set; }

            public double Price { get; set; }
            public int Model { get; set; }
            public int Pallet_No { get; set; }
            public string Color { get; set; }

            public Car(int make, int year, string type, double price, int model, int pallet_No, string color) // parameters    اسناد قيم ل  properties
            {
                this.Make = make; // 1999
                Year = year; //1999
                Type = type; //BMW
                Price = price; //1500.45
                Model = model;//2024
                Pallet_No = pallet_No; //123456
                Color = color; //red
            }

            // Method Start
            void Start()
            {
                Console.WriteLine("the car is starting");
            }
            void Stop()
            {
                Console.WriteLine("the car is stopping");
            }

            public void FullInformation()
            {
                Console.WriteLine($"The information of car is: {Make} , {Year} , {Type} , {Price} , {Model} , {Pallet_No} , {Color}");
            }
        }


        class BMW : Car
        {
            double Speed { get; set; }

            public BMW(int make, int year, string type, double price, int model, int pallet_No, string color, double speed) : base(make, year, type, price, model, pallet_No, color)
            {
                this.Speed = speed;
            }

        }
        static void Main(string[] args)
        {
            Car car = new Car(1999, 2002, "BMW", 1500.45, 2024, 123456, "red");

            car.FullInformation();

            BMW bMW = new BMW(12, 1999, "ABC", 12, 1, 1234, "color", 1520);
            Console.WriteLine(bMW.Year);

            

        }
    }
}