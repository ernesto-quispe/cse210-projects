using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2014";
        job1._endYear = "2017";

        //Console.WriteLine($"{job1._company} needs a {job1._jobTitle} in {job1._address}");
        //job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "DBA Seniors";
        job2._company = "Oracle";
        job2._startYear = "2017";
        job2._endYear = "2023";

       //Console.WriteLine($"{job2._company} needs a {job2._jobTitle} in {job2._address}");
        //job2.DisplayJobDetails();


        Resume myResume = new Resume();

        myResume._name = "Ernesto Quispe";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);


        //Console.WriteLine($"{myResume._jobs[0]._jobTitle}");
        
        myResume.DisplayResume();
    }
}