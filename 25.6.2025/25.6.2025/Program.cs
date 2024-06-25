using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._6._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 01:
            Console.Write("Plz enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Welocme to the good stuff, {name}");

            //task 02:
            double valueDouble = 20.35;
            string nameString = "Mohammad";
            char letterChar = 'A';
            bool valueBool = true;
            int valueInt = 20;
            const float valueConst = 2.14f;

            Console.WriteLine($"{valueDouble} {nameString} {letterChar} {valueBool} {valueInt} {valueConst} ");

            //task 03:
            string[] car = { "BMW", "Toyota", "Jeeb" };
            for (int i = 0; i < car.Length; i++)
            {
                Console.Write(car[i] + " ");
            }
            Console.Write("\n");



            //task 04: 

            Console.Write("What's you first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's you surname? ");
            string surname = Console.ReadLine();

            Console.Write("When were you born? ");
            string bornYear = Console.ReadLine();

            Console.Write($"Welcome {firstName} {surname}, you were born in {bornYear}.");
            Console.WriteLine();



            //task 05:
            int[] bunchOfNumbers = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < bunchOfNumbers.Length; i++)
            {

                if (i == 0)
                {
                    Console.Write($"The elemnts in the array are: ");
                }
                Console.Write(bunchOfNumbers[i] + " ");
            }

            Console.WriteLine();



            //task 06:
            double sum = 0;
            double[] numbers = { 2, 10, -10};

            for (int i = 0; i < numbers.Length; i++) {

                sum += numbers[i];
                
            }

            Console.WriteLine(sum);


        }
    }
}
