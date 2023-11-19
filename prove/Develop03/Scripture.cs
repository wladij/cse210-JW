using System;
using System.Collections.Generic;

namespace ScriptureMemorization
{
    class Scripture
    {
        private readonly Reference reference;
        private string text;
        private List<Word> words;

        public bool AllWordsHidden => words.All(word => word.IsHidden);

        public Scripture(Reference reference, string text)
        {
            this.reference = reference;
            this.text = text;
            InitializeWords();
        }

        private void InitializeWords()
        {
            string[] splitWords = text.Split(' ');
            words = splitWords.Select(word => new Word(word)).ToList();
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine($"{reference}\n");

            foreach (var word in words)
            {
                Console.Write(word.IsHidden ? "***** " : $"{word.Text} ");
            }

            Console.WriteLine();
        }

        public void HideRandomWord()
        {
            Random random = new Random();
            
        
            List<Word> visibleWords = words.Where(word => !word.IsHidden).ToList();

        
            if (visibleWords.Count > 0)
            {
                Word randomWord = visibleWords[random.Next(visibleWords.Count)];
                randomWord.Hide();
            }
        }
    }
}

