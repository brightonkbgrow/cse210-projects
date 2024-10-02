using System;

public class Resume
{
    //Attrubutes
    public string _name;
    public List<Job> _jobs = new List<Job>();


    //Behaviors
    public void ShowResume()
    {
        Console.WriteLine($"{_name}'s Resume");
        Console.WriteLine("Work Expirence: ");

        foreach (Job job in _jobs)
        {
            job.ShowResume();
        }


    }
}