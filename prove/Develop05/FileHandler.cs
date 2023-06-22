using System;
using System.IO;

public class FileHandler
{
    // Private Member Variables
    protected string _fileName;
    protected int _pointsEarned;
    protected List<Goal> _goalList;

    // Constructors
    public FileHandler()
    {
        
        
    }

    // Methods
    public void SaveToFile(string filename)
    {
        _fileName = filename;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_pointsEarned}");
        }
    }

    public void LoadFile()
    {

    }

    // public string GetStringRepresentation()
    // {
    //     string goalType = GetType().Name;
    //     string goalEntry = Console.WriteLine($"{goalType}:{_goalName},{_goalDescription},")

    //     return ;
    // }
}