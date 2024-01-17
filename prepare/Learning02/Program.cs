using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job _job1 = new Job();

        _job1._jobTitle = "Software Engineer";
        _job1._company = "Microsoft";
        _job1._startYear = 2019;
        _job1._endYear = 2022;


        Job _job2 = new Job();

        _job2._company = "Apple";
        _job2._jobTitle = "Manager";
        _job2._startYear = 2022;
        _job2._endYear = 2023;


        /* Console.WriteLine(_job1._company);
        Console.WriteLine(_job2._company); */

        /* _job1.Display();
        _job2.Display(); */

        Resume _resume = new Resume();

        _resume._jobss.Add(_job1);
        _resume._jobss.Add(_job2);


        _resume._name = "Allison Rose";
       
        _resume.DisplayResume();

    }
}