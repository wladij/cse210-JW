using System;
using System.Collections.Generic;

namespace ScriptureMemorization
{
    class Program
    {
        static void Main()
        {
            
            List<Scripture> scriptures = new List<Scripture>
            {
                new Scripture(new Reference("John 3:16"), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
                new Scripture(new Reference("Proverbs 3:5-6"), "Trust in the Lord with all thine heart; and lean not unto thine cown understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
                new Scripture(new Reference("2Nephi 31:11"), "And the Father said: Repent ye, repent ye, and be baptized in the name of my Beloved Son."),
                
            };

            
            Random random = new Random();
            Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

            
            selectedScripture.Display();

            
            while (!selectedScripture.AllWordsHidden)
            {
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                {
                    break;
                }

                selectedScripture.HideRandomWord();
                selectedScripture.Display();
            }

            Console.WriteLine("Program ended.");
        }
    }
}