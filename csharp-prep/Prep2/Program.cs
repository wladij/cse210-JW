using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Give me your grade: ");
        string userImput = Console.ReadLine();
        int grade = int.Parse(userImput);
        string letter = "";
        int lastDigit = 0;
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }
        lastDigit = grade%10;
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit >= 3 && lastDigit < 7)
        {
            sign = "-";
        }
        
        
        Console.WriteLine($"Your letter is {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}