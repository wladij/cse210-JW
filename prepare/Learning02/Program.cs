using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle="Software Engineer";
        job1._company="Apple";
        job1._startYear=2020;
        job1._endYear=2022;

        Job job2 = new Job();
        job2._company="Microsoft";
        job2._jobTitle="Developer";
        job2._startYear=2020;
        job2._endYear=2021;

        

        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._member = "Maria Jacome";

        myResume.Display();
       


    }
    
}