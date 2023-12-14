using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        List<Video> videos = new List<Video>
        {
            new Video
            {
                Title = "Video 1",
                Author = "Author 1",
                Duration = 120,
                Comments = new List<Comment>
                {
                    new Comment { CommenterName = "User1", CommentText = "Great video!" },
                    new Comment { CommenterName = "User2", CommentText = "I learned a lot." },
                    
                }
            },
            new Video
            {
                Title = "Video 2",
                Author = "Author 2",
                Duration = 180,
                Comments = new List<Comment>
                {
                    new Comment { CommenterName = "User3", CommentText = "Amazing content!" },
                    new Comment { CommenterName = "User4", CommentText = "Very informative." },
                    
                }
            },
            new Video
            {
                Title = "Video 3",
                Author = "Author 3",
                Duration = 150,
                Comments = new List<Comment>
                {
                    new Comment { CommenterName = "User5", CommentText = "Liked and subscribed!" },
                    new Comment { CommenterName = "User6", CommentText = "Looking forward to more." },
            
                }
            },
        };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Duration: {video.Duration} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}
