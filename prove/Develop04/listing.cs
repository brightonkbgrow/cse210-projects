public class Listing : Activities
{
    private readonly List<string> _items = new List<string>();
   
    public Listing() : base("Listing", "This activity will help you count through steps to keep your mind focused.") { }

    public void StartListing()
    {
        StartActivity();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("You may begin in:");
        CountDown(3);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
           
            if (!string.IsNullOrWhiteSpace(input))
            {
                _items.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {_items.Count} items!");
        Thread.Sleep(3000);

        EndActivity();
    }

    private string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who are people that you love?",
            "What are your favorite hobbies?",
            "Who are people that you seen?",
            "What are your bragging rights?"
        };

        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }

}