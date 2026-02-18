using System;

namespace Exam2_C_;

public class Posts
{
    public string Title{get; set;} = "";

    public string Description{get; set;} = "";

    public int LikeCount{get; set;}

    public List<string> Comments = new List<string>();

    public bool IsPublished {get; set;}


    public void Publish()
    {
        Console.WriteLine($"The post is published."); 
    }

    public void Like(string x)
    {
        Comments.Add(x);
    }

    public void GetInfo()
    {
        Console.WriteLine($"Title {Title} Description {Description} LikeCount {LikeCount}");
    }
}
