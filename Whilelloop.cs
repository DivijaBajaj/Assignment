using System;

namespace MO2033_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string constructedWord = "";
            Console.WriteLine("Let's build a word! Enter characters one by one.");
            Console.WriteLine("Enter '!' to stop and see the constructed word.");

            while (true)
            {
                Console.WriteLine("Enter a character:");
                char userInput = Console.ReadKey().KeyChar; // Read a single character from user input
                
                if (userInput == '!')
                {
                    Console.WriteLine("\nStopping word construction.");
                    break;
                }
                
                constructedWord += userInput; // Add the character to our word

                Console.WriteLine($"\nCurrent word: {constructedWord}");
            }

            if (constructedWord.Length > 0)
            {
                Console.WriteLine($"Your constructed word is: {constructedWord}");
            }
            else
            {
                Console.WriteLine("You didn't add any characters to the word.");
            }
        }
    }
}
