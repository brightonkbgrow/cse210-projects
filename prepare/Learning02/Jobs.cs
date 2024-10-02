using System;

public class Job
{
    //Attrubutes
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //Behaviors
    public void ShowResume()
    {
         Console.WriteLine($"{_jobTitle} ({_company})\n {_startYear}-{_endYear}");

       
    }
}