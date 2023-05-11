// This is the template for the JournalIdeas class
// This stores the prompts and then returns a randomly selected one

public class JournalIdeas
{
    Random random = new Random();
    string[] prompts =  {
        "Who was the most interesting person I interacted with today? ",
        "Who is someone who inspires me, and what qualities do they possess that I admire? ",
        "What are three things I am grateful for today? ",
        "What was the best part of my day? ",
        "What are some goals that I've been afraid to pursue due to fear of failure or rejection? ",
        "What is a simple delight I have been enjoying lately? ",
        "When I am faced with challenges or obstacles, what is my usual response? ",
        "What was a moment of joy, delight, or contentment today? ",
        "How did I see the hand of the Lord in my life today? ",
        "What decisions am I facing right now? ",
        "What is one book that has inspired me and why? ",
        "What was the strongest emotion I felt today? ",
        "What is something I can do to make today amazing? ",
        "In general, how do I feel about how my life is going right now? ",
        "What is one thing I have always wanted to learn, and how can I make time to pursue this interest? ",
        "What are some new skills or knowledge areas that I want to develop? ",
        "What do I like about where I live right now? ",
        "If I had one thing I could do over today, what would it be? ",
        "What is something that inspired me today? ",
        "How can I make tomorrow even better? "
    };

        public void DisplayDailyPrompt() {
            int index = random.Next(prompts.Length);
            Console.WriteLine($"{prompts[index]}");            
        }


}