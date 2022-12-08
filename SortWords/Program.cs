/* 
 * This program accepts any number of words from the user, 
 * sorts them in alphabetical order, and displays the sorted words separated by spaces
 * 
 * Program does not loop
 */

using System;
using static System.Console;

namespace SortWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for input and send it to the SortAndDisplayWords method
            WriteLine("Please enter words separated by spaces");
            SortAndDisplayWords(ReadLine());
        }

        static void SortAndDisplayWords(string userInput)
        {
            // Split the input string into individual words and store them in an array
            string[] words = userInput.Split();

            // Sort the array in alphabetical order
            Array.Sort(words);

            // Join the sorted words into a single string
            string sortedWords = string.Join(" ", words);

            // Display the sorted words
            WriteLine(sortedWords);
        }
    }
}
