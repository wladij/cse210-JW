class StationaryBiking : Activity
{
    public double Speed { get; private set; }

    public StationaryBiking(DateTime date, int durationInMinutes, double speed)
        : base(date, durationInMinutes)
    {
        Speed = speed;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed; 
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {Speed:F1} mph, Pace: {GetPace():F2} min per mile";
    }
}