public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("Get ready to breathe in and out...");
        Console.WriteLine(" ");
        for (int i = 0; i < Duration; i++)
        {
            Console.Write("Breathe in...");
            Thread.Sleep(1000);
            Console.Write("\r"); 
            Console.Write("Breathe out...");
            Thread.Sleep(1000);
            Console.Write("\r"); 
        }
    }
}