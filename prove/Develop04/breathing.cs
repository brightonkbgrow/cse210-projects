using System;
using System.Threading;

public class Breathing : Activities
{
    public Breathing() : base("Breathing", "This activity will help you pace your breathing in and out slowly.") { }

    public void StartBreathing()
    {
        StartActivity();

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine("Breathe in...");         
            Thread.Sleep(3000); 
            ShowAnimation(3);

            Console.Clear();
            Console.WriteLine("Hold...");
            Thread.Sleep(5000); 

            Console.Clear();
            Console.WriteLine("Breathe out...");
            Thread.Sleep(8000); 
            ShowAnimation(3);
        }

        EndActivity();
    }
}
