using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);

        DisplayResult(name, square);


    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string answer = Console.ReadLine();
        int number = int.Parse(answer);

        return number;
    }

    static int SquareNumber(int number)
    {
        double answer = Math.Pow(number, 2);
        int square = (int)answer;

        return square;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }

}