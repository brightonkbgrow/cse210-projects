using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Adventure Guide";
        job1._company = "Maverik";
        job1._startYear = 2023;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Support Tech Rep";
        job2._company = "LinkTrust";
        job2._startYear = 2014;
        job2._endYear = 2015;

        Resume myResume = new Resume();
        myResume._name = "Brighton Grow";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.ShowResume();
    }
}