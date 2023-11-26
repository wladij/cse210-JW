public class ListingActivity : MindfulnessActivity
{
    private readonly string[] listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void PerformActivity()
    {
        string prompt = listingPrompts[new Random().Next(listingPrompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(3000);  
        ListItems();
    }

    private void ListItems()
    {
        Console.WriteLine("Think about the prompt and start listing items...");
        Thread.Sleep(3000); 
        int itemCount = 0;
        while (true)
        {
            Console.Write("Enter an item (or 'done' to finish): ");
            string item = Console.ReadLine();
            if (item.ToLower() == "done")
            {
                break;
            }
            itemCount++;
        }

        Console.WriteLine($"You listed {itemCount} items.");
        Thread.Sleep(3000);  
    }
}
