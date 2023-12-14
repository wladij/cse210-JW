public class Reception : Event
{
    public string RsvpEmail { get; private set; }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RsvpEmail = rsvpEmail;
    }

    public override string GetDetails()
    {
        return $"{base.GetDetails()}\nRSVP Email: {RsvpEmail}";
    }
}