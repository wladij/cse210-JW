public class OutdoorMeeting : Event
{
    public string WeatherForecast { get; private set; }

    public OutdoorMeeting(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        WeatherForecast = weatherForecast;
    }

    public override string GetDetails()
    {
        return $"{base.GetDetails()}\nWeather Forecast: {WeatherForecast}";
    }
}