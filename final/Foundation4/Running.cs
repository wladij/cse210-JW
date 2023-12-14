public class Running : Activity
{
    public double Distance { get; private set; }

    public Running(DateTime date, int durationInMinutes, double distance)
        : base(date, durationInMinutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / (DurationInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return DurationInMinutes / Distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {Distance} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F2} min per mile";
    }
}
