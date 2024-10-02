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

        Job job3 = new Job();
        job3._jobTitle = "Lot Technician";
        job3._company = "Larry H Miller";
        job3._startYear = 2019;
        job3._endYear = 2021;

        Job job4 = new Job();
        job4._jobTitle = "Hardware Specialist";
        job4._company = "Ace Hardware";
        job4._startYear = 2022;
        job4._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Brighton Grow";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        myResume._jobs.Add(job4);

        myResume.ShowResume();
    }
}