using System;
using System.Collections.Generic;

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
        Video video1 = new Video("Making a Titanium Chef's Knife","Alec Steele", 1375);
        video1.AddComment(new Comment("DavidGuyton","Now we need a titanium Jacket for Steele to wear."));
        video1.AddComment(new Comment("mackiefarrell","I have no idea why I'm so invested in your quest to forge weld steel and titanium, it objectively holds no importance to my life, yet I find it to be a question I need answers to and I'm glad you're out here finding them for me"));

        Video video2 = new Video("Find the FAKE PC Gamer", "Linus Tech Tips", 887);
        video2.AddComment(new Comment("Menirz", "2:05 Bro said the original Destiny, which is a console exclusive."));
        video2.AddComment(new Comment("Policepigeon", "ask them how many games in their library they have unplayed."));

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