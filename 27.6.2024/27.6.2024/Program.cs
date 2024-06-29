using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._6._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //problem solving: https://www.w3resource.com/csharp-exercises/string/index.php

            //PS 01: I want you to display whatever the user inputs alone. If they enter a word
            //then show it alone, and if they enter a phrase, show it alone.


            //Console.Write("Plz enter a word or phrase: ");
            //string userInput = Console.ReadLine();

            //if (string.IsNullOrEmpty(userInput)) {
            //    Console.WriteLine("You didn't enter anything!");
            //} else {

            //    string[] userPhrases = userInput.Split(); //splits at the space.


            //    if (userPhrases.Length == 1) {

            //        Console.WriteLine($"The word you entered is: {userPhrases[0]}");

            //    } else {

            //        Console.Write($"The phrase you entered is: ");
            //        for (int i = 0; i < userPhrases.Length; i++) {
            //            Console.Write(userPhrases[i] + " ");

            //        }

            //        Console.WriteLine();

            //    }
            //}


            //PS 02: Find the string of a string using the library (length)

            //Console.WriteLine("Enter any word or phrase: ");
            //string phraseEntered = Console.ReadLine();

            //int phraseLength = phraseEntered.Length;
            //Console.WriteLine("The length of the phrase/word you entered is: " + phraseLength);


            //PS 02: Find the string of a string ////wihtout//// using the library (length)

            //Console.WriteLine("Plz enter a word or a phrase: ");

            //string str;
            //int l = 0;  

            //str = Console.ReadLine();

            //foreach(char c in str)
            //{
            //    l++;
            //}
            //Console.WriteLine("The length of the phrase/word you entered is: " + l);




            ////////////////// NEW PROBLEM SOLVING //////////////////////
            //PS 03: Write a C# Sharp program to separate individual characters from a phrase.

            //Console.WriteLine("Plz enter a word or a phrase separated by a comma: ");

            //string str = Console.ReadLine();

            //string [] stringSeparated = str.Split(new string[] {","}, StringSplitOptions.RemoveEmptyEntries);

            //foreach (string s in stringSeparated) {
            //    Console.WriteLine(s);
            //}


            //PS 04: Write a C# Sharp program to separate individual characters from a word.

            //Console.WriteLine("Plz enter a word: ");

            //string str = Console.ReadLine();

            //foreach (char ch in str) {
            //    Console.Write(ch + " ");

            //}

            //PS 05: Write a program in C# Sharp to print individual characters of the string in ///reverse order///.



            //Console.WriteLine("Plz enter a word: ");

            //string str = Console.ReadLine();

            //int l;

            //for (l = str.Length - 1; l>=0; l--)
            //{
            //    Console.Write(str[l] + " ");

            //}

            //Console.WriteLine();


            //PS 06: Write a program in C# Sharp to count the total number of words in a string.


            //Console.WriteLine("Plz enter a word or phrase : ");

            //string str = Console.ReadLine();

            //string [] strSeperated = str.Split(' ');

            //int l = strSeperated.Length;
            //Console.WriteLine("The number of words you entered is: {0}", l);


            //PS 07: Write a program in C# Sharp to compare two strings without using a string library functions.

            ///////////////come back to it later //////////////

            Console.WriteLine("Plz enter a word or phrase : ");

            string str01 = Console.ReadLine();
            string[] str01Splited = str01.Split();

            int str01Length = str01Splited.Length;

            Console.WriteLine("Plz enter a word or phrase : ");

            string str02 = Console.ReadLine();
            string[] str02Splited = str02.Split();

            int str02Length = str02Splited.Length;

            if (str01Length == str02Length)
            {
                Console.WriteLine("The two strings are equal in length");

                for (int i = 0; i < str01Length; i++)
                {
                    if (str02Splited[i] != str01Splited[i])
                    {
                        Console.WriteLine("The two strings are equal in words too");
                    }

                    else
                    {
                        Console.WriteLine("The two strings are NOT equal in length");
                    }
                }
            }

            else
            {
                Console.WriteLine("The two strings are NOT equal in length");

                for (int i = 0; i < str01Length; i++)
                {
                    if (str02Splited[i] == str01Splited[i])
                    {
                        Console.WriteLine("The two strings are equal in words too");
                    }

                    else
                    {
                        Console.WriteLine("The two strings are NOT equal in length");
                    }
                }






            }
        }
    }
}
