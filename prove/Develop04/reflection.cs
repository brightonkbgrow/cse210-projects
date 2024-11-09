public class Reflection : Activities
{
    private static readonly string[] prompts =
    {
        "Think of a time when you picked yourself up.",
        "Think of a time when you succeeded despite the odds.",
        "Think of a time when you did an act of service.",
        "Think of a time when you didn't mess everything up."
    };

    private static readonly string[] questions =
    {
        "Why was this experience important?",
        "Have you ever done anything like this before?",
        "How did you feel afterwards?",
        "What made this time different than other times when you wern't successful?",
        "What is your favorite thing about this?",
        "What could you learn from this experience that you could use elsewhere?",
        "What did you learn about yourself?"
    };

    public Reflection() : base("Reflection", "This activity will help you reflect.") { }

    public void StartReflection()
    {
        StartActivity();

        Console.WriteLine("Get ready to reflect...");
        ShowAnimation(3);
        Console.Clear();

        Random rand = new Random();
        string currentPrompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine($"--- {currentPrompt} ---\n");
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow reflect on the following question.");
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        HashSet<int> usedQuestions = new HashSet<int>();

        while (DateTime.Now < endTime)
        {
            int questionIndex;
            do
            {
                questionIndex = rand.Next(questions.Length);
            } while (usedQuestions.Count < questions.Length && usedQuestions.Contains(questionIndex));

            if (usedQuestions.Count >= questions.Length)
            {
                usedQuestions.Clear();
            }

            usedQuestions.Add(questionIndex);
            string currentQuestion = questions[questionIndex];

            Console.Write($"> {currentQuestion} ");
            ShowAnimation(10);
            Console.WriteLine();
        }

        Console.WriteLine("\nReflection complete!");
        Thread.Sleep(2000);

        EndActivity();
    }



   
}