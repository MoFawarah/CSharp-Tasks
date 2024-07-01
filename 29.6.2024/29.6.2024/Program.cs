using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._6._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //task 01: Correcting Syntax Errors:

            int[] ARR = { 1, 7, 9, 45 }; // old >>> string [ ] ARR= [ 1,7  9  45, ]

            int[] ARR2 = { 20, 50 };

            int[] newArray = ARR.Concat(ARR2).ToArray();

            string arrayString = "{" + string.Join(", ", newArray) + "}";

            Console.WriteLine(arrayString);


            //////Another Syntax Error/////////

            string [] arr2 = { "Str", "alex", "moh" }; // old >>> int arr2=["Str" "alex","moh"

            string array2Joined = "[" + string.Join(", ", arr2) + "]";
            Console.WriteLine(array2Joined);


            //////Another Syntax Error/////////
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

            string arr3Joined = "[" + string.Join(", ", arr3) + "]";
            Console.WriteLine(arr3Joined);


            //task 02: Finding the index of a certain item in an array

            string[] fruits = { "Tomato", "Banana", "Watermelon", "Burries", "Pears" };

            int tomatoIndex = Array.IndexOf(fruits, "Tomato");
            int bananaIndex = Array.IndexOf(fruits, "Banana");
            int burriesIndex = Array.IndexOf(fruits, "Burries");
            Console.WriteLine("The index of Tomato is: " + tomatoIndex);
            Console.WriteLine("The index of Banana is: " + bananaIndex);
            Console.WriteLine("The index of Burries is: " + burriesIndex);


            //task 03: Creating arrays that represent personal stuff
            string[] favFood = { "Mansaf", "Shawarma", "Fish", "Hummus", "Salad" };
            string[] favSports = { "Soccer", "Basketball", "Taekwondo", "Rope Jumping", "Tennis" };
            string[] favMovies = { "Last Christmas", "Luka", "The Pursuit of Happyness", "Friends" };

            Console.WriteLine("My favorite food is: ");
            foreach (var fav in favFood)
            {
                Console.Write(fav + " ");
            }
            Console.WriteLine(); 

            Console.WriteLine("My favorite sports are: ");
            foreach (var fav in favSports)
            {
                Console.Write(fav + " ");
            }
            Console.WriteLine();

            Console.WriteLine("My favorite movies are: ");
            foreach (var fav in favMovies)
            {
                if (fav == "Friends")
                {
                    Console.Write(fav + ".");
                }

                else {

                    Console.Write(fav + ", ");
                }
               
            }
            Console.WriteLine();


            //task 04:

            Console.Write("Plz input three numbers seperated by a comma: ");

            string[] userInput = Console.ReadLine().Split(',');

            int[] userInputArray = Array.ConvertAll(userInput, int.Parse);

            double sum = 0;

            foreach (int y in userInputArray)
            {
                sum += y;
            }

            Console.WriteLine("The total sum of your inputted numbers is: " + sum);


            //another method:


            //Console.Write("Plz input three numbers seperated by a comma: ");

            //int [] userInputArray = Console.ReadLine().Split(',').Select(int.Parse).ToArray();


            //double sum = 0;

            //foreach (int y in userInputArray)
            //{
            //    sum += y;
            //}

            //Console.WriteLine("The total sum of your inputted numbers is: " + sum);


            //task 05: Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]

            int sum001 = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                    sum001 += i;

                }
            }

            Console.WriteLine("\nThe Sum of odd Numbers is: " + sum001);


            //Task 06: 

            //int numberOfRows = 4;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

        

            

           
            int currentNumber = 1;

            for (int i = 1; i <= 4; i++)
            {
                // for spaces
                for (int j = 4; j > i; j--)
                {
                    Console.Write(" ");
                }

                // for numbers
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                }

                // Move to the next line
                Console.WriteLine();
            }
        }
    }
}
