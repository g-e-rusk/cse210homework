// This is my code template for the category of things known as Resume.
// The responsibility of Resume is to keep track of the person's name and a list of their jobs. 

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {
    }

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}
