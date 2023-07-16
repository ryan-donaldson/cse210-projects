using System;
using System.Collections.Generic;
namespace Foundation4
{
    class Program
    {
        static void Main(string[] args)
        {
            Running running = new Running("Running", "14 Jan 2026", 30, 4);
            Cycling cycling = new Cycling(12, "Cycling", "21 Aug 2026", 60, 12);
            Swimming swimming = new Swimming(6, "Swimming", "02 Oct 2026", 40);

            List<Activity> activities = new List<Activity>();
            activities.Add(running);
            activities.Add(cycling);
            activities.Add(swimming);

            Console.WriteLine("The following is a list of completed activites:");
            foreach(Activity activity in activities)
            {
                activity.GetSummary();
            }
        }
    }
}
