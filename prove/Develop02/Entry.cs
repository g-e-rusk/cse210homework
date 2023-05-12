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
    public string GetDate() {
        DateTime currentDate = DateTime.Now;
        string date = currentDate.ToShortDateString();
        return date;

    }

    // Method for getting the randomly generated prompt
    public string GetPrompt() {
        JournalIdeas prompt = new JournalIdeas();
        string promptUsed = prompt.DisplayDailyPrompt();
        Console.WriteLine($"{promptUsed}");
        Console.Write("> ");
        return promptUsed;
    }

    // Method for getting user reponse
    public string GetResponse() {
        string response = Console.ReadLine();
        return response;
    }

    // Method for how the entries will be displayed
    public void DisplayEntry() {
        Console.WriteLine($"{_dateWritten} - {_promptUsed} \n{_userResponse}");
    }

    
}

        