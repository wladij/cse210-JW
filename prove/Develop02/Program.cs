using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Please select one of the following choice:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string[] questions = new string[]
                    {
                        "Who was the most interesting person I interacted with today?",
                        "What was the best part of my day?",
                        "How did I see the hand of the Lord in my life today?",
                        "What was the strongest emotion I felt today?",
                        "If I had one thing I could do over today, what would it be?"
                    };
                    Random random = new Random();
                    string randomQuestion = questions[random.Next(questions.Length)];
                    Console.WriteLine(randomQuestion);
                    Console.WriteLine("Write your answer:");
                    string answer = Console.ReadLine();

                    Entry newEntry = new Entry
                    {
                        Question = randomQuestion,
                        Answer = answer,
                        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    };
                    journal.AddEntry(newEntry);

                    Console.WriteLine("Entry successfully added.\n");
                    break;
                case 2:
                    Console.Write("the file is csv? y/n: ");
                    string answer2 = Console.ReadLine();
                    if (answer2 == "y")
                    {
                        Console.WriteLine("Enter the name of the CSV file you want to display:");
                        string csvFileName = Console.ReadLine();
                        try
                        {
                            journal.DisplayCSVContent(csvFileName);
                            Console.WriteLine("\nContents of the CSV file displayed correctly.\n");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error displaying the contents of the CSV file: {ex.Message}\n");
                        }
                        break;
                    }else
                    {
                        journal.ShowEntries();
                    }
                    
                    break;
                case 3:
                    Console.Write("the file is CSV? y/n: ");
                    string answer1 = Console.ReadLine();
                    if (answer1 == "y")
                    {
                        Console.WriteLine("Enter the file name to import the journal from CSV:");  
                        string importFileName = Console.ReadLine();
                        try
                        {
                            journal.ImportFromCSV(importFileName);
                            Console.WriteLine("Journal imported from CSV correctly.\n");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error when importing the journal from CSV: {ex.Message}\n");
                        }
                        break;
                    }else
                    {
                        Console.WriteLine("Introduzca el nombre del archivo para cargar el diario:");
                        string loadFileName = Console.ReadLine();

                        try
                        {
                            journal.LoadFromFile(loadFileName);
                            Console.WriteLine("Journal loaded correctly.\n");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error while loading the journal: {ex.Message}\n");
                        }
                        break;
                    }
                    
                    
                case 4:
                    Console.WriteLine("Enter the name of the file to save the journal:");
                    string fileName = Console.ReadLine();

                    try
                    {
                        journal.SaveToFile(fileName);
                        Console.WriteLine("Journal saved correctly.\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error when saving the journal: {ex.Message}\n");
                    }
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("It is not correct, Try again.");
                    break;
            }

        
        }


    }
}