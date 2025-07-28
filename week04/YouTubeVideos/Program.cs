using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        VideosList _list = new VideosList();
        Video _video1 = new Video();
        _video1.SetVideoInformation("Gratitude", "Brandon Lake", "342");
        _video1.SetVideoComment("Rafael", "To, anybody who's reading this, I pray that whatever is hurting you or whatever you are constantly stressing about gets better. May the dark thoughts, the overthinking, and the doubt exit your mind right now. May clarity replaces confusion. May peace and calmness fill your life. God bless you ");
        _video1.SetVideoComment("Martha", "This song makes me cry, I got on my knees & worshipped. Cried like a baby but this song is true testimony of loving God.");
        _video1.SetVideoComment("Taylor", "Who else cried listening to this?");
        _list.AddVideoToList(_video1);

        Video _video2 = new Video();
        _video2.SetVideoInformation("Birds of a Feather", "Billie Eilish", "230");
        _video2.SetVideoComment("Andy", "This is a masterpiece");
        _video2.SetVideoComment("Jonas", "Billie Eilish being the first human to be flying in history for Birds of A Feather music video is iconic");
        _video2.SetVideoComment("Michelle", "This song puts me in the right frequency.");
        _video2.SetVideoComment("Raul", "'Til the day that I die' this line hit hard.");
        _list.AddVideoToList(_video2);

        Video _video3 = new Video();
        _video3.SetVideoInformation("What was I made for?", "Billie Eilish", "248");
        _video3.SetVideoComment("Mark", "This is a masterpiece. This girl is super talented.");
        _video3.SetVideoComment("Andrew", "How does Billie manage to exceed my expectations everytime. She never disappoints");
        _video3.SetVideoComment("Amy", "these lyrics are  applicable across so many emotions and situations. It truly is an amazing song");
        _video3.SetVideoComment("Jake", "This song is so sad. It really tugs at your heart and gets those tears flowing.");
        _list.AddVideoToList(_video3);

        foreach (Video video in _list._videos)
        {
            video.DisplayVideoInformation();
            video.CountNumberOfComments();
            video.DisplayComments();

        }
    }
}