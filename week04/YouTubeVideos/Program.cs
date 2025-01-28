using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = [];
        Video video1 = new Video("DIY - Tiling from Amateur to Pro", "Kayode", 20);
        video1.AddComment("Tosin", "This is getting interesting");
        video1.AddComment("Temilorun", "Hilarious");
        video1.AddComment("Temisan", "Super Excited");
        videos.Add(video1);

        Video video2 = new Video("Learn C# in One Hour", "John Doe", 60);
        video2.AddComment("Alice", "Very informative");
        video2.AddComment("Bob", "Great explanations");
        videos.Add(video2);

        Video video3 = new Video("Web Development Basics", "Jane Smith", 45);
        video3.AddComment("Eve", "This is exactly what I needed");
        video3.AddComment("Charlie", "Fantastic content");
        videos.Add(video3);

        Video video4 = new Video("Advanced JavaScript Techniques", "Daniel Lee", 30);
        video4.AddComment("Sophia", "Well explained");
        video4.AddComment("Michael", "Really helpful");
        videos.Add(video4);

        foreach (Video video in videos)
        {

            Console.WriteLine($"Title: {video.Title()} by {video.Author()} - {video.Length()} minutes ");
            video.ShowComments();
            Console.WriteLine("");
        }
    }
}