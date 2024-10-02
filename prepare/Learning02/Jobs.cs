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
        string result = @"";
        result += $"Company: {_company}\n";
        result += $"Job Title: {_jobTitle}\n";
        result += $"Start Year: {_startYear}\n";
        result += $"End Year: {_endYear}\n";
        Console.WriteLine(result);
    }
}