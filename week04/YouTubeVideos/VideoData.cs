using System;

public class VideoData
{
    private List<Video> videos;
    
    public VideoData()
    {
        videos = new List<Video>();
        InitializeVideos();
    }
    
    private void InitializeVideos()
    {
        Video video1 = new Video("video name1","Creator1", 100);
        video1.AddComment(new Comment("commentor1.1","comment1.1 this is longer"));
        video1.AddComment(new Comment("copmmentor1.2","comment1.2 longer"));

        Video video2 = new Video("Video Name 2", "Creator 2", 200);
        video2.AddComment(new Comment("comment2.1", "comment2.1 longer"));
        video2.AddComment(new Comment("commentor2.2", "comment2.2 longer."));

        videos.Add(video1);
        videos.Add(video2);
    }
    
    public void DisplayAllVideos()
    {
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}