using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        Resume _myResume = new()
        {
            _name = "Kayode Adetayo"
        };

        Job job1 = new()
        {
            _jobTitle = "Software Engineer",
            _company = "Microsoft",
            _endYear = 2024,
            _startYear = 2021
        };
        _myResume.jobs.Add(job1);

        Job job2 = new()
        {
            _jobTitle = "Software Engineer",
            _company = "LinkedIn",
            _endYear = 2024,
            _startYear = 2021
        };
        _myResume.jobs.Add(job2);

        _myResume.Display();
    }
}