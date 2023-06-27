public class Comment
{
    // Member Variables
    public string _userName;
    public string _commentText;

    // Constructors
    public Comment()
    {
    }

    // Methods
    public void commentDisplay()
    {
        Console.WriteLine();
        Console.WriteLine($"@{_userName} commented:");
        Console.WriteLine($"{_commentText}");
    }
}