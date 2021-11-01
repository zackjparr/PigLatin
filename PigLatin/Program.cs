using System;
using System.Linq;

namespace PigLatin
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput = GetInput("Please input a word or sentence to translate to pig Latin");

            PigLatinApp phrase = new PigLatinApp(userInput);
            Console.WriteLine(phrase.ToPigLatin());
        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }
    }

}
