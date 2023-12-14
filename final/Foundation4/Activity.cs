public class Activity
{
    public DateTime Date { get; private set; }
    public int DurationInMinutes { get; private set; }

    public Activity(DateTime date, int durationInMinutes)
    {
        Date = date;
        DurationInMinutes = durationInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; 
    }

    public virtual double GetSpeed()
    {
        return 0; 
        
    }

    public virtual double GetPace()
    {
        return 0; 
    }

    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} {GetType().Name} ({DurationInMinutes} min)";
    }
}
