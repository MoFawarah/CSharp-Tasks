using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _30._6._24.Program;

namespace _30._6._24
{
    internal class Program
    {

        //for task 05
        public class Person
        {
            public int Age;
            public string Gender;
            public string Name;
            public string Email;
            public int ID;
            public string Phone;

            public Person()
            {
                Age = 18;
                Name = "Tim";
                Email = "tim123@gmail.com";
                ID = 553;
                Phone = "0790896111";
            }

            public Person(int age, string gender, string name, string email, int id, string phone)
            {
                if (age >= 18 && age <= 60)
                {
                    Age = age;
                }
                Gender = gender;
                Email = email;
                ID = id;
                if (IsValidPhoneNumber(phone))
                {
                    Phone = phone;
                }
            }

            public bool IsValidPhoneNumber(string phoneNumber)
            {

                return phoneNumber.StartsWith("077") || phoneNumber.StartsWith("078") || phoneNumber.StartsWith("079");
            }

            public void display()
            {
                Console.WriteLine($"Age: {Age}, Gender: {Gender}, Email: {Email}, ID: {ID}, Phone:{Phone}");
            }

        }




        //for task 04

        static int ReturnAge(int age)
        {

            int ageInDays = age * 365;

            return ageInDays;

        }

        //for task 03
        static int[] ReturnYears(int[] years)
        {
            List<int> otherYears = new List<int>();
            for (int i = 0; i < years.Length; i++)
            {

                if (years[i] >= 1950)
                {

                    otherYears.Add(years[i]);

                }
            }

            return otherYears.ToArray();


        }


        //for task 02
        static void Cube(int x)
        {

            for (int i = 0; i <= x; i++)
            {

                Console.WriteLine($"num is " + i + " and the cube of " + i + " is: " + i * i * i);

            }
        }


        //for task 01
        static (int sum, double average) SumAndAverage(int[] numbers)
        {
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Length;

            return (sum, average);
        }

        static void Main(string[] args)
        {


            ////////        task 01         ////////////////


            //int[] numbers = new int[10];
            //Console.WriteLine("Enter 10 numbers: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Number-{i + 1}: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //var (sum, average) = SumAndAverage(numbers);

            //Console.WriteLine($"Sum: {sum}, Average: {average}");



            ////////        task 02          ////////////////


            //Console.Write("Plz enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Cube(number);






            ////////          task 03         ////////////////


            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };

            int[] filteredYears = ReturnYears(years);

            Console.WriteLine("Years greater than 1950:");
            foreach (int year in filteredYears)
            {
                Console.WriteLine(year);
            }


            ///////// task 04 ////////////


            Console.Write("enter your age in years: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            int ageInDays = ReturnAge(userAge);

            Console.WriteLine($"Your age '{userAge}' years in days is {ageInDays}");



            ///////////////// task 05 //////////////


            Console.WriteLine("The default ");
            Person mera = new Person();
            mera.display();
            Console.WriteLine();
            Person person = new Person(24, "Male", "Mohammad", "mfawareh1@gmail.com", 778, "1537857");
            Console.WriteLine("Another Person: ");
            person.display();


        }
    }
}
