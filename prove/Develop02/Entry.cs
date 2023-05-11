// This is the template for the class Entry
// This class holds the data

public class Entry {
    public string _userResponse = "";
    public string _dateWritten = "";
    public string _promptUsed = "";

    public Entry()
    {

    }
    
    // Method for getting the date as a string
    public void GetDate() {
        DateTime currentDate = DateTime.Now;
        string _dateWritten = currentDate.ToShortDateString();
        Console.WriteLine($"{_dateWritten}");
    }

    // Method for getting the randomly generated prompt
    public void GetPrompt() {
        JournalIdeas entryPrompt = new JournalIdeas();
        entryPrompt.DisplayDailyPrompt();
        Console.Write("> ");
    }

    // Method for getting user reponse
    public void GetResponse() {
        string _userResponse = Console.ReadLine();
    }

    // Method for how the entries will be displayed
    public void DisplayEntry() {
        Console.WriteLine($"{_dateWritten} - {_promptUsed}");
        Console.WriteLine($"{_userResponse}");
    }

    
}

        