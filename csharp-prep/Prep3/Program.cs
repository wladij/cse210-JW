using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = " ";
        
        while (answer != "n")
        {
            Console.WriteLine("Gues the Number");
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guessNumber = -1; 
            int i = 0;
            while (guessNumber != magicNumber)  
            {
                Console.Write("What is guess? ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);

                if (magicNumber == guessNumber)
                {
                    Console.WriteLine("You guessed it!");
                    
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                    
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                i++;
            }
            Console.WriteLine($"attempts {i}");
            Console.Write("Do you want to play again?(y/n) ");
            answer = Console.ReadLine();
        }
    }
}