public class Program
{
    public static void Main()
    {
        bool continueRunning = true;
        while (continueRunning)
        {
            Console.Clear();
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Listing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Breathing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new Listing().StartListing();
                    break;
                case "2":
                    new Reflection().StartReflection();
                    break;
                case "3":
                    new Breathing().StartBreathing();
                    break;
                case "4":
                    continueRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}
