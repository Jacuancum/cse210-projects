using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine("<Job and Resume>");
        */
        public class Job
        {
            public string _company;
            public string _jobtitle;
            public int _startyear;
            public int _endyear;

            Job job = new Job();
            job._company = "Microsoft";
            job._jobtitle = "software Engineer";
            job._startyear = 2019;
            job._endyear = 2022;

            public void displayJobDetails()
            {
                Console.WriteLine($"{_jobtitle} ({_company}) {_startyear}-{_endyear}");
            }
        }
    }
    
}