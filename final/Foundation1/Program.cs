using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Program 1: Abstraction with YouTube Videos");
        Console.WriteLine("A program written by Geri Rusk\n");
        
        Comment comment1 = new Comment();
        comment1._userName = "brenwren1";
        comment1._commentText = "A great video showing how to find light in the dark world.  Will use his 3-step approach.";

        Comment comment2 = new Comment();
        comment2._userName = "johnjones";
        comment2._commentText = "Tom Brown is a genius and helps us to find light.";

        Comment comment3 = new Comment();
        comment3._userName = "gilgally43";
        comment3._commentText = "Powerful resource for those who are struggling, like me.  I will use his suggestions.";

        Comment comment4 = new Comment(); 
        comment4._userName = "sawyerAdam";
        comment4._commentText = "This is one of the better videos I have seen which reinforces spiritual awareness.";       

        Video video1 = new Video();
        video1._videoTitle = "Finding Light in a Dark World";
        video1._videoAuthor = "Tom Brown";
        video1._videoLength = 188;
        video1._videoComments.Add(comment1);
        video1._videoComments.Add(comment2);
        video1._videoComments.Add(comment3);
        video1._videoComments.Add(comment4);

        video1.DisplayVideo();
        string breakSet = new String('X', 100);
        Console.WriteLine();
        Console.WriteLine(breakSet);
        Console.WriteLine();

        Comment comment5 = new Comment();
        comment5._userName = "hyrumyoung";
        comment5._commentText = "This video helped me to remember where I have come from and where I can go.  All things through Christ.";

        Comment comment6 = new Comment();
        comment6._userName = "billwright45";
        comment6._commentText = "With relatives who came across on the plains, I remember their courage in the face of adversity.  I can endure all things, too.";

        Comment comment7 = new Comment();
        comment7._userName = "honeyHazel34";
        comment7._commentText = "I am a convert, but I can look at those around me and how they face their trials.  It strengthens my faith.";

        Comment comment8 = new Comment(); 
        comment8._userName = "SnowEliza";
        comment8._commentText = "I am proud of my heritage and I look to my namesake often for inspiration to overcome my trials.";       

        Video video2 = new Video();
        video2._videoTitle = "Overcoming Trials as We Look to Our Ancestors";
        video2._videoAuthor = "Robert Goodman";
        video2._videoLength = 358;
        video2._videoComments.Add(comment5);
        video2._videoComments.Add(comment6);
        video2._videoComments.Add(comment7);
        video2._videoComments.Add(comment8);

        video2.DisplayVideo();
        Console.WriteLine();
        Console.WriteLine(breakSet);
        Console.WriteLine();

        Comment comment9 = new Comment();
        comment9._userName = "bunnyBonnie83";
        comment9._commentText = "I love to see animals so happy!  This makes my heart smile!";

        Comment comment10 = new Comment();
        comment10._userName = "CaptainTedWhite";
        comment10._commentText = "A feel-good video to put me in a better mood.";

        Comment comment11 = new Comment();
        comment11._userName = "JJRogers";
        comment11._commentText = "Aw, this makes me miss my first pet, but I know that Georgie is in a better place!";

        Video video3 = new Video();
        video3._videoTitle = "Happy Animal Compilation";
        video3._videoAuthor = "Claire Seeler";
        video3._videoLength = 98;
        video3._videoComments.Add(comment9);
        video3._videoComments.Add(comment10);
        video3._videoComments.Add(comment11);
        

        video3.DisplayVideo();
        Console.WriteLine();

    }
}