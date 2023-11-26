public class MindfulnessActivity
{
    protected int Duration { get; private set; }
    protected string Name { get; }
    protected string Description { get; }

    public MindfulnessActivity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void StartActivity()
    {
        ShowStartingMessage();
        SpinWaitForSeconds(3); 
        PerformActivity();
        ShowEndingMessage();
    }

    protected virtual void ShowStartingMessage()
    {
        Console.WriteLine($"Starting the activity {Name}:");
        Console.WriteLine(Description);
        Console.WriteLine("Please be ready to begin.");
        SetDuration();
    }

    private void SetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Duration = duration;
        }
        else
        {
            Console.WriteLine("Invalid input. A default duration of 60 seconds will be used.");
            Duration = 60; 
        }
    }

    protected virtual void PerformActivity()
    {

    }

    protected virtual void ShowEndingMessage()
    {
        Console.WriteLine($"Good job! You have completed the activity {Name}.");
        Console.WriteLine($"Duration: {Duration} seconds.");
        SpinWaitForSeconds(3);  
    }

    private static void SpinWaitForSeconds(int seconds)
    {
        var spinner = new char[] { '|', '/', '-', '\\' };
        var waitDuration = TimeSpan.FromSeconds(1);

        for (int i = 0; i < seconds; i++)
        {
            foreach (var spinChar in spinner)
            {
                Console.Write($"\rWait a Moment... {spinChar}");
                Thread.Sleep(waitDuration);
            }
        }

        Console.WriteLine();  
    }
}