using System;

public class Resume
{
    //Attrubutes
    string _name;
    List<Jobs> _jobs;


    //Behaviors
    public void ShowResume()
    {
        string result = @"";
        result = $"{_name} \n{_jobTitle} ({_company}) {_startYear}-{endYear}";

        Console.WriteLine(result);
    }
}