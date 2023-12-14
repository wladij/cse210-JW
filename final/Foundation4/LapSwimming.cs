public class LapSwimming : Activity
{
    public int Laps { get; private set; }

    public LapSwimming(DateTime date, int durationInMinutes, int laps)
        : base(date, durationInMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000.0; 
    }

    public override double GetPace()
    {
        return DurationInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():F1} km, Pace: {GetPace():F2} min per km";
    }
}