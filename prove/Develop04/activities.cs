using System;
using System.Threading;

public class Activities
{
    protected int duration;
    protected string activityName;
    protected string activityDescription;

    public Activities(string name, string description)
    {
        activityName = name;
        activityDescription = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        ShowMessage($"Starting the {activityName}...\n{activityDescription}");
        duration = GetDurationFromUser();
        ShowMessage("Get ready...");

        ShowAnimation(3);
    }

    public void EndActivity()
    {
        ShowMessage("Good job!");
        ShowMessage($"{duration} second {activityName} Complete.");
        ShowAnimation(3);
    }

    private int GetDurationFromUser()
    {
        Console.Write("How Long Would You Like?: ");
        return int.Parse(Console.ReadLine());
    }

    private void ShowMessage(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
        Thread.Sleep(2500); 
    }

    public void ShowAnimation(int seconds)
    {
        char[] spinner = new char[] { '[', '|', ']', '|', };
        int spinnerIndex = 0;

        for (int i = 0; i < seconds; i++)
        {
            Console.Clear();
            Console.WriteLine(spinner[spinnerIndex]);
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            Thread.Sleep(75);
        }

        Console.Clear();
    }
    public void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}
