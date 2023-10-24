using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Python Tutorial for Beginners", "FreeCodeCamp", 504.30);
        v1.AddComment("@rosariomcallen6938", "I am really enjoying this course, thank you for all your work on it!");
        v1.AddComment("@mohbcn", "I apreciated every minute of that course thank you alot, I will always follow your courses thank you");
        v1.AddComment("@theallcodes2309", "Thank you for keeping great efforts towards teaching us");

        Video v2 = new Video("C# Tutorial for Beginners", "Derek Banas", 657.72);
        v2.AddComment("@borninthedark7915", "Thank you for everything you've done!");
        v2.AddComment("@alexandershubert573", "Finally a comprehensive course at the right pace for the programmers");
        v2.AddComment("@florinji96", "Great video! I'm not new to programming, but definitely new to C#, great overview of the language, thank you!");

        Video v3 = new Video("JavaScript Full Course for Beginners", "Dave Gray", 178.19);
        v3.AddComment("@kcgr8chief627", "Thanks Dave. This is one of the best JS courses on youtube");
        v3.AddComment("@moments-to-share", "Hi Dave, I totally love your teaching style. Straight to the point and absolutely NO BS");
        v3.AddComment("@MarkoKovacina", "Great course! Your channel is an amazing source of knowledge for a web developer, regardless of years of experience");
        v3.AddComment("@robin_c24", "I just got here after finished your html,css course. I'm really appreciated for all the passion and hardwork you put into your course");
        v3.AddComment("@tunjigeorge5666", "Wow! Great content. You really take your time to explain things");

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video video in videos)
        {
             Console.WriteLine($"Video title: {video.GetTitle()}, Author: {video.GetAuthor()}, Length: {video.GetLength()} seconds, Number of Comments: {video.GetLengthComments()}");
             video.ShowComments();
             Console.WriteLine();
        }
    }
}