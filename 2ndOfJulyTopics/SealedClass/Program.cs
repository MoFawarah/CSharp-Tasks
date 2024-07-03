using System;
using System.Collections.Generic;
namespace ConsoleApp7
{
    internal class Program
    {

        sealed class Car
        {
            protected int Make { get; set; }
            public Car(int make)
            {
                Make = make;

            }

            
            public int Year { get; set; }
            public string Type { get; set; }

            // Method Start
            void Start()
            {
                Console.WriteLine("the car is starting");
            }
            public void Stop()
            {
                Console.WriteLine("the car is stopping");
                Console.WriteLine(Make);   // Parent
            }



        }


        class BMW : Car //can't be inherited (Car is a sealed class)
        {
            BMW(int make) : base(make)
            {
                Make = make; // Child
            }

            public double Speed { get; set; }


        }
        static void Main(string[] args)
        {
            Car car = new Car(1234);
            // Console.WriteLine();
            //  car.Stop();

            //selead Class
            // ما بورث  : Car


        }
    }
}
//Selead Class
