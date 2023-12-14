public class Conference : Event
{
    public string SpeakerName { get; private set; }
    public int Capacity { get; private set; }

    public Conference(string title, string description, DateTime date, TimeSpan time, Address address, string speakerName, int capacity)
        : base(title, description, date, time, address)
    {
        SpeakerName = speakerName;
        Capacity = capacity;
    }

    public override string GetDetails()
    {
        return $"{base.GetDetails()}\nSpeaker: {SpeakerName}\nCapacity: {Capacity} attendees";
    }
}