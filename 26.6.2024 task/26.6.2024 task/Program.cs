using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _26._6._2024_task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //task 01:
            Console.WriteLine("Plz enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Plz enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine()); ;

            int minNumber = Math.Min(num1, num2);
            Console.WriteLine("The min number between {0} and {1} is {2} ", num1, num2, minNumber);



            //task 01 method 02:



            //int X = -5;
            //int Y = 0;


            //Console.WriteLine(X > Y ? $"{Y} is smaller than {X}" : $"{X} is smaller than {Y}");



            //task 02: Display the sign of a number:

            //Console.WriteLine("Plz enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(number >= 0 ? $"The sign of {number} is +" : $"The sign of {number} is -");



            Console.WriteLine("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

           
            int sign = Math.Sign(number); //returns -1 if the num is minus, 0 if 0 and 1 if positive.
            string signString = new[] { "-", "0", "+" }[sign + 1]; //to return the correct index

            Console.WriteLine($"The sign of {number} is {signString}");



            //task 03: sorting 3 numbers ascendingly
            Console.WriteLine("Please enter three numbers separated by spaces: ");
            string userInput = Console.ReadLine();


            string[] arr01 = userInput.Split();

            int[] numbersAsArray = Array.ConvertAll(arr01, Convert.ToInt32);
            Array.Sort(numbersAsArray);


            Console.WriteLine($"Your inputted numbers sorted ascendingly are: {numbersAsArray[0]} {numbersAsArray[1]} {numbersAsArray[2]}");


            //task 04: finding the max of five numbers

            Console.WriteLine("Please enter 5 numbers separated by spaces: ");
            string userInput01 = Console.ReadLine();
            string[] arrInput01 = userInput01.Split();
            int[] numbersAsArray01 = Array.ConvertAll(arrInput01, Convert.ToInt32);
            Array.Sort(numbersAsArray01); //optional
            int maxNum = numbersAsArray01.Max();
            Console.WriteLine("The maximum number is: " + maxNum);


            //task 04: method 02: using OrderByDescending(x => x).First()

            Console.WriteLine("Please enter 5 numbers separated by spaces: ");
            string userInput02 = Console.ReadLine();
            string[] arr02 = userInput02.Split();
            int[] numbersAsArray02 = Array.ConvertAll(arr02, Convert.ToInt32);

            int maxNum1 = numbersAsArray02.OrderByDescending(x => x).First();
            Console.WriteLine("The maximum number is: " + maxNum1);



            //task 05: converting km to miles:

            Console.WriteLine("Plz enter the km per hour: ");
            double kiloMeterPerHour = Convert.ToDouble(Console.ReadLine());
            double milePerHour = 0.621371 * kiloMeterPerHour;
            Console.WriteLine($"{kiloMeterPerHour} km is {milePerHour} miles");




            //task 06: hours and minutes as input and calculates the total number of minutes:

            Console.Write("Plz enter a number of hours: ");
            int userHoursInput = Convert.ToInt32(Console.ReadLine());

            int minutesFromHours = userHoursInput * 60;

            Console.Write("Plz enter a number of minutes: ");
            int userMinutesInput = Convert.ToInt32(Console.ReadLine());

            int totalMinutes = minutesFromHours + userMinutesInput;
            Console.WriteLine($"{userHoursInput} hour(s) and {minutesFromHours} minute(s) are {totalMinutes} minutes total.");




            //task 07: minutes converted to hours and minutes:
            Console.WriteLine("Plz enter any number of minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            int remainingMinutes = minutes % 60;
            int hours = minutes / 60;


            Console.WriteLine($"{minutes} minute(s) are {hours} hour(s) and {remainingMinutes} minute(s)");



            // task 08: printing elements of an array along with their length.

            string[] arr = new string[5];
            arr = new string[] { "Hello people", "Let's go out", "I'm hungry", "Would you like some cheese?", "I hate winter" };

            string arrFirstElement = arr[0];
            int arrFirstElementLength = arr[0].Length;

            Console.WriteLine(arrFirstElement + " " + arrFirstElementLength);

            string arrSecondElement = arr[1];
            int arrSecondElementLength = arr[1].Length;
            Console.WriteLine(arrSecondElement + " " + arrSecondElementLength);


            string arrThirdElement = arr[2];
            int arrThirdElementLength = arr[2].Length;
            Console.WriteLine(arrThirdElement + " " + arrThirdElementLength);

            string arrFourthElement = arr[3];
            int arrFourthElementLength = arr[3].Length;
            Console.WriteLine(arrFourthElement + " " + arrFourthElementLength);

            string arrFifthElement = arr[4];
            int arrFifthElementLength = arr[4].Length;
            Console.WriteLine(arrFifthElement + " " + arrFifthElementLength);


            //string[] arr2 = new string[5];
            //arr2 = new string[] { "Hello people", "Let's go out", "I'm hungry", "Would you like some cheese?", "I hate winter" };

            //Array.ForEach(arr2, item =>
            //{
            //    Console.WriteLine(item + " " + item.Length);
            //});



        }
    
    }
}
