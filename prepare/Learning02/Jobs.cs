using System;

public class Job
{
    //Attrubutes
    string _company;
    string _jobTitle;
    string _startYear;
    string _endYear;

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