using System;

public class Job
{
    //Attrubutes
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;

    //Behaviors
    public void jobInfo()
    {
        string result = @"";
        result += $"Company: {_company}\n";
        result += $"Job Title: {_jobTitle}\n";
        result += $"Start Year: {_startYear}\n";
        result += $"End Year: {_endYear}\n";
        Console.WriteLine(result);
    }
}