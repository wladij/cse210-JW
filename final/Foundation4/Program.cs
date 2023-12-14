using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new StationaryBiking(new DateTime(2022, 11, 5), 45, 15.5),
            new LapSwimming(new DateTime(2022, 11, 7), 25, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}





