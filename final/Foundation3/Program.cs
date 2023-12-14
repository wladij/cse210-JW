using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Address conferenceAddress = new Address("123 Conference St", "Cityville", "CA", "USA");
        Conference conference = new Conference("Tech Conference", "Annual technology conference", DateTime.Now, new TimeSpan(10, 0, 0), conferenceAddress, "John Doe", 500);

        Address receptionAddress = new Address("456 Reception Ave", "Townsville", "NY", "USA");
        Reception reception = new Reception("Networking Reception", "Casual networking event", DateTime.Now.AddDays(7), new TimeSpan(18, 30, 0), receptionAddress, "rsvp@example.com");

        Address outdoorMeetingAddress = new Address("789 Park", "Outdoor City", "TX", "USA");
        OutdoorMeeting outdoorMeeting = new OutdoorMeeting("Community Picnic", "Outdoor gathering for the community", DateTime.Now.AddDays(14), new TimeSpan(12, 0, 0), outdoorMeetingAddress, "Sunny day");

        Console.WriteLine("Conference Details:\n" + conference.GetDetails() + "\n");
        Console.WriteLine("Reception Details:\n" + reception.GetDetails() + "\n");
        Console.WriteLine("Outdoor Meeting Details:\n" + outdoorMeeting.GetDetails());
    }
}