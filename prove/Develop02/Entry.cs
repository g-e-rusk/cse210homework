// This is the template for the class Entry
// This class holds the data

public class Entry {
    public string _userResponse = "";
    public string _dateWritten = "";

    //public List<JournalIdeas> _dailyPrompt = new List<JournalIdeas>();

    
    public void DisplayEntry() {
        JournalIdeas entryPrompt = new JournalIdeas();
        entryPrompt.DisplayDailyPrompt();
    }
}

        