using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        int sum = 0;
        
        while (number != 0)
        {
            Console.Write("Enter number ");
            string answer = Console.ReadLine();
            number = int.Parse(answer);  
            numbers.Add(number);
        }
        for (int i = 0; i < numbers.Count; i++)
        {
            sum = numbers[i] + sum;
        }

        Console.WriteLine($"The sum is: {sum}");
        
        double average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        int sort = 0;
        int mayor = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sort = numbers[i];
            if (sort > mayor)
            {
                mayor = sort;
            }
        }
        Console.WriteLine($"The largest number is: {mayor}");
    }
}