using System;
using System.Collections.Generic;

public class Video
{
    public string Title {get; set;}
    public string Author {get; set;}
    public int Length {get; set;}

    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
    }
    
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }
    
    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        foreach (var comment in comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
        Console.WriteLine();
    }
}