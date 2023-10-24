using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();
        Running running = new Running("16 Dec 2023", 45, 7.8);
        activities.Add(running);
        Swimming swimming = new Swimming("25 Oct 2023", 60, 18);
        activities.Add(swimming);
        Cycling cycling = new Cycling("23 Nov 2023", 90, 22);
        activities.Add(cycling);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}