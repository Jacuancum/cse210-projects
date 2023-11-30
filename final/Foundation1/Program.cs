using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Insterstellar", "Christopher Nolan", 145);
        video1.AddComment("Peter", "Great video!");
        video1.AddComment("Tyler", "Interesting content");
        videos.Add(video1);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " minutes");
            Console.WriteLine("Number of Comments: " + video.GetNumComments());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment._commenterName}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}