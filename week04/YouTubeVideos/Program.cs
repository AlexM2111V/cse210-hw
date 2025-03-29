using System;

class Program
{
    static void Main(string[] args)
    {
        Video Video1 = new Video("Road Rage", "John Coleman", 7200);
        Video Video2 = new Video("Blue Bloods", "Ray Truman", 6940);
        Video Video3 = new Video("Fast and Furious", "Rob Cohen", 7350);
        Video Video4 = new Video("The Shepperds", "Lindon Terry", 6500);
        Comment comment1 = new Comment("Alex Mendoza", "This is the best video I have ever watched");
        Comment comment2 = new Comment("Nair Mendoza", "I loved the part 1 but this part 2 was much much better");
        Comment comment3 = new Comment("Josh Carter", "This movie is overrated");
        Comment comment4 = new Comment("Jorge Dennis", "First 30 minutes of the movie were kind of slow but great movie overall");
        Comment comment5 = new Comment("Marjorie Newman", "I couldn't stop crying. This film was very emotional.");
        Comment comment6 = new Comment("Eliza Thompson", "I read some negative comments about this movie but I definitely loved it");
        Comment comment7 = new Comment("Janel Williams", "I want a part 2, this was great!");
        Comment comment8 = new Comment("Chris Hemsworth", "An action-packed thrill ride that keeps you on the edge of your seat.");
        Comment comment9 = new Comment("Scarlett Johansson", "A breathtaking performance that combines depth and elegance.");
        Comment comment10 = new Comment("Ryan Reynolds", "A perfect mix of humor and action, making it an unforgettable film.");
        Comment comment11 = new Comment("Jennifer Lawrence", "Her portrayal of the character is both raw and powerful.");
        Comment comment12 = new Comment("Dwayne Johnson", "Pure adrenaline from start to finish, a must-watch for action fans.");
        Comment comment13 = new Comment("Emma Stone", "A heartwarming and charming film, with a stellar performance by Stone.");
        Comment comment14 = new Comment("Tom Hanks", "An emotional journey that showcases Hanks' unparalleled talent as an actor.");

        Video1.AddComment(comment1);
        Video1.AddComment(comment2);
        Video2.AddComment(comment3);
        Video2.AddComment(comment4);
        Video3.AddComment(comment5);
        Video3.AddComment(comment6);
        Video4.AddComment(comment7);
        Video4.AddComment(comment8);
        Video2.AddComment(comment9);
        Video3.AddComment(comment10);
        Video1.AddComment(comment11);
        Video1.AddComment(comment12);
        Video4.AddComment(comment13);
        Video4.AddComment(comment14);

        List<Video> videos = new List<Video>();
        videos.Add(Video1);
        videos.Add(Video2);
        videos.Add(Video3);
        videos.Add(Video4);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}