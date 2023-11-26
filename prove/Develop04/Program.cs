
using System;
using System.Threading;

public class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        StartActivity(new BreathingActivity());
                        break;
                    case 2:
                        StartActivity(new ReflectionActivity());
                        break;
                    case 3:
                        StartActivity(new ListingActivity());
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    static void StartActivity(MindfulnessActivity activity)
    {
        activity.StartActivity();
    }
}