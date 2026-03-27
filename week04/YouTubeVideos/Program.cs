using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("I PLAYED SUPER BATTLE GOLF FOR THE FIRST TIME!", "MM7 Games", 1231);
        video1.AddComment(new Comment("darkhonor13", "LOL, JJ and Harry in the thumbnail is mad. Get your views Simon!"));
        video1.AddComment(new Comment("ethanquakenbush2477", "jj in the thumbnail is crazy"));
        video1.AddComment(new Comment("alpheano", "Y'all should play it with rdc boys"));

        Video video2 = new Video("This is what $1000 gets you in 2026!", "TechSource", 1502);
        video2.AddComment(new Comment("Joeker8171", "I would love to see a build off $1,500 vs $1,500. Great idea"));
        video2.AddComment(new Comment("christopherlegg5469", "A build off between you two would be cool I really wish micro center would open here in the UK"));
        video2.AddComment(new Comment("DariansIncompeTech", "man, I wish I lived near a Micro Center"));

        Video video3 = new Video("SIDEMEN BRUTALLY RANK UK FAST FOOD CHAINS", "SidemenReacts", 1507);
        video3.AddComment(new Comment("arin9953", "These four carrying this channel"));
        video3.AddComment(new Comment("Tom-Nr1", "WEE NEED A SIDEMEN VIDEO WHERE U GO TO THE FOOD CHAINS U HAVENT BEEN TO!!!!"));
        video3.AddComment(new Comment("juiced9432", "Simon putting Greggs in the highest tier sums up his food tastes"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments: ");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}