// This is my code template for the category of things known as Job.
// The responsibility of Job is to keep track of the company, job title, start year and end year. 

public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    // Constructor
    public Job()
    {
    }

    // A method to show how this information will be displayed.
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

