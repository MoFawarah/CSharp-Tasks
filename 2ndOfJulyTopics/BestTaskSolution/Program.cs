using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BestTaskSolution
{
    internal class Program
    {

        class Car
        {
            protected string Make { get; set; }
            protected int Year { get; set; }
            protected string Type { get; set; }
            protected int PalletNo { get; set; }
            protected double Price { get; set; }
            protected string Model { get; set; }
            protected string Color { get; set; }
            protected string OwnerName { get; set; }



            public Car(string make, int year, string type, int palletNo, double price, string model, string color, string ownerName)
            {
                this.Make = make;
                this.Year = year;
                this.Type = type;
                this.PalletNo = palletNo;
                this.Price = price;
                this.Model = model;
                this.Color = color;
                this.OwnerName = ownerName;
            }

            private void DisplayOwnerName(string OwnerName)
            {
                Console.WriteLine($"The owner of {Type} is {OwnerName}");
            }

            protected void ShowOwnerName ()
            {
                DisplayOwnerName(OwnerName);
            }

            protected void Stop()
            {
                Console.WriteLine("The car is stopping");
            }

            protected void Start()
            {
                Console.WriteLine("The car is starting");
            }

            protected void DisplayInfo()
            {
                Console.WriteLine($"The car info is {Year}, {Make}, {Type}, {PalletNo}, {Price}, {Model}, and {Color}");
            }
        }

        class BMW : Car
        {

            double Speed { get; set; }

            public BMW(string make, int year, string type, int palletNo, double price, string model, string color, string ownerName, double speed) : base(make, year, type, palletNo, price, model, color, ownerName)
            {
                Speed = speed;
            }

            public void Info()
            {
                Console.WriteLine($"The information of car are {Speed}, {Year}, {Make}, {Type}, {PalletNo}, {Price}, {Model}, and {Color}");
            }


            public void GetStop()
            {
                Start();
            }

            public void GetStart()
            {
                Stop();
            }

            public void GetInfo()
            {
                DisplayInfo();
            }

            public void GetOwnerName ()
            {
                ShowOwnerName();
            }
        }


        static void Main(string[] args)
        {


            Car myCar = new Car("Toyota", 1998, "Toyota", 22314, 153800.2, "PPY", "Black", "Rami");


            BMW bmwCar = new BMW("Honda", 1950, "BMW", 111110, 222.24, "mmt", "Red", "Mohammad Fawareh", 1000);

            bmwCar.GetStart();
            bmwCar.GetStop();
            bmwCar.GetInfo();
            bmwCar.GetOwnerName();
            bmwCar.Info();
        }
    }
}

