using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video
        {
            Title = "Gamer time on Destiny 2",
            Author = "Brighton Grow",
            Length = 550
        };
        video1.AddComment("Cami", "Sick vid, bro");
        video1.AddComment("Jence", "so thats where the easter eggs are!");
        video1.AddComment("lameguy3000", "Boring vid if you ask me.");

        videos.Add(video1);

        Video video2 = new Video
        {
            Title = "Star Wars Review",
            Author = "StarWarsGuy",
            Length = 1000
        };
        video2.AddComment("Jabba", "Me wombo be teenee chaga, ho ho ho");
        video2.AddComment("Obi-Wan", "Hello there");
        video2.AddComment("Vader", "I find this video... disturbing");

        videos.Add(video2);

        Video video3 = new Video
        {
            Title = "Fishing Guide",
            Author = "IDontKnowHowToFish",
            Length = 1300
        };
        video3.AddComment("joe", "you killed a fish. cool");
        video3.AddComment("james", "Maybe use bait.");
        video3.AddComment("jameater100", "Can you put jam on the fish?");

        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
