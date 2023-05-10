// This is the template for the class Entry
// This class holds the data

public class Entry {
    public string _userResponse = "";
    public string _dateWritten = "";

    public string _promptUsed = "";

    //public List<JournalIdeas> _dailyPrompt = new List<JournalIdeas>();

    
    public void entryDisplay() {
        JournalIdeas entryPrompt = new JournalIdeas();
        entryPrompt.DisplayDailyPrompt();
        Console.Write("> ");
    }

    public void addEntry() {
        Console.Write($"{_dateWritten}");
        Console.WriteLine($"{_promptUsed}");
        Console.WriteLine($"{_userResponse}");
    }
}

        