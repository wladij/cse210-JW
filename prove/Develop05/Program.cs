using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        List<Goal> goals = new List<Goal>();
        User user = new User();

        while (true)
        {
            ShowMenu(user, goals);

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    CreateNewGoal(goals);
                    break;
                case "2":
                    ShowGoalsList(goals);
                    break;
                case "3":
                    SaveUserData(user, goals);
                    break;
                case "4":
                    LoadUserData(user, goals);
                    break;
                case "5":
                    RecordEvent(user, goals);
                    break;
                case "6":
                    // Exit the program
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }

    static void ShowMenu(User user, List<Goal> goals)
    {
        Console.WriteLine($"\nUser Score: {user.Score}");
        Console.WriteLine("Menu Options");
        Console.WriteLine("1. Create new goal");
        Console.WriteLine("2. Goals list");
        Console.WriteLine("3. Save goals");
        Console.WriteLine("4. Load goals");
        Console.WriteLine("5. Record event");
        Console.WriteLine("6. Exit");
        Console.Write("Select an option: ");
    }

    static void CreateNewGoal(List<Goal> goals)
    {
        Console.WriteLine("\nCreate new goal:");

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter a brief description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the value of the goal: ");
        int value = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");

        string typeOption = Console.ReadLine();

        switch (typeOption)
        {
            case "1":
                goals.Add(new Goal(name, value) { Completed = false });
                break;
            case "2":
                goals.Add(new EternalGoal(name, value) { Completed = false });
                break;
            case "3":
                Console.Write("Enter the desired count for the checklist: ");
                int targetCount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the additional bonus: ");
                int bonus = Convert.ToInt32(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, value, targetCount, bonus) { Completed = false });
                break;
            default:
                Console.WriteLine("Invalid option. Goal not created.");
                break;
        }

        Console.WriteLine("Goal created successfully.");
    }

    static void ShowGoalsList(List<Goal> goals)
    {
        Console.WriteLine("\nGoals List:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i]}");
        }
    }

    static void SaveUserData(User user, List<Goal> goals)
{
    try
    {
        Console.Write("Enter a filename to save data (including extension, e.g., data.txt): ");
        string filename = Console.ReadLine();

        if (filename.EndsWith(".txt"))
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Goal goal in goals)
                {
                    string line = $"{goal.Name},{goal.Value},{GetGoalType(goal)}";

                    if (goal is ChecklistGoal checklistGoal)
                    {
                        line += $",{checklistGoal.TargetCount},{checklistGoal.Bonus}";
                    }

                    writer.WriteLine(line);
                }
            }

            Console.WriteLine("Data saved successfully.");
        }
        else
        {
            Console.WriteLine("Unsupported file format. Please use a .txt file.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error saving data: {ex.Message}");
    }
}

static string GetGoalType(Goal goal)
{
    if (goal is EternalGoal)
    {
        return "Eternal";
    }
    else if (goal is ChecklistGoal)
    {
        return "Checklist";
    }
    else
    {
        return "Simple";
    }
}

    static void LoadUserData(User user, List<Goal> goals)
{
    try
    {
        Console.Write("Enter a filename to load data (including extension, e.g., data.txt): ");
        string filename = Console.ReadLine();

        if (File.Exists(filename) && filename.EndsWith(".txt"))
        {
            string[] lines = File.ReadAllLines(filename);

            goals.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string name = parts[0];
                int value = int.Parse(parts[1]);
                string type = parts[2];

                if (type == "Simple")
                {
                    goals.Add(new Goal(name, value));
                }
                else if (type == "Eternal")
                {
                    goals.Add(new EternalGoal(name, value));
                }
                else if (type == "Checklist")
                {
                    int targetCount = int.Parse(parts[3]);
                    int bonus = int.Parse(parts[4]);
                    goals.Add(new ChecklistGoal(name, value, targetCount, bonus));
                }
                
            }

            Console.WriteLine("Data loaded successfully.");
        }
        else
        {
            Console.WriteLine("File does not exist or has an unsupported format. Please use a .txt file.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading data: {ex.Message}");
    }
}

    static void RecordEvent(User user, List<Goal> goals)
    {
        Console.WriteLine("\nRecord an event:");

        ShowGoalsList(goals);

        Console.Write("Enter the number of the goal to record: ");
        int goalNumber = Convert.ToInt32(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < goals.Count)
        {
            int points = goals[goalNumber].RecordEvent();
            user.AddPoints(points);

            Console.WriteLine($"Event recorded. Earned {points} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
}

class User
{
    public int Score { get; set; }

    public void AddPoints(int points)
    {
        Score += points;
    }
}

[Serializable]
class UserData
{
    public int Score { get; set; }
    public List<Goal> Goals { get; set; }
}
