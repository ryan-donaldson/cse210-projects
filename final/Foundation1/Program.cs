using System;

namespace Foundation1
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video1 = new Video("How to Make Spaghetti", "Mr. Spaghetti", 300);
            Comment vidcom1 = new Comment("Spaghetti Lover", "Love this recipe!");
            Comment vidcom2 = new Comment("Spaghetti Hater", "This is disgusting.");
            Comment vidcom3 = new Comment("Food Enjoyer", "I'm too lazy to make this but it looks good!");
            video1.AddComment(vidcom1);
            video1.AddComment(vidcom2);
            video1.AddComment(vidcom3);

            Video video2 = new Video("Best Places to Go Skydiving", "Mr. Skydiver", 600);
            Comment vid2com1 = new Comment("Skydiving Lover", "Love this video!");
            Comment vid2com2 = new Comment("Skydiving Hater", "I don't get why people do this.");
            Comment vid2com3 = new Comment("Adrenaline Junky", "Take me with you!!!");
            video2.AddComment(vid2com1);
            video2.AddComment(vid2com2);
            video2.AddComment(vid2com3);

            Video video3 = new Video("Moonlight Sonata Played on the Kazoo", "KazooTunes", 360);
            Comment vid3com1 = new Comment("Kazoo Lover", "This is my favorite song!");
            Comment vid3com2 = new Comment("Kazoo Hater", "You're trash at kazoo.");
            Comment vid3com3 = new Comment("Classical Music Enjoyer", "Almost fell asleep but good job!");
            video3.AddComment(vid3com1);
            video3.AddComment(vid3com2);
            video3.AddComment(vid3com3);

            List<Video> videos = new List<Video>();
            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            foreach(Video video in videos)
            {
                video.GetInfo();
            }
        }
    }
}
