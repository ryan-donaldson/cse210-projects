using System;

namespace Foundation3
{
    class Program
    {
        static void Main(string[] args)
        {
            Address lectureAddress = new Address("Cocoa Dino Bites Way, Boise, ID");
            Lecture lecture = new Lecture("John Doe", 3000, "Lecture", "Cocoa Dino Bites", "Come hear John speak on the wonders of Cocoa Dino Bites",
            "08/01/2090", "2:00pm", lectureAddress);
            Address receptionAddress = new Address("123 Reception Ave, St. George, UT");
            Reception reception = new Reception("rsvp@email.com", "Reception", "Anne's Baby Shower", "Join us to celebrate Anne's pregnancy!",
            "01/09/2042", "1:00pm", receptionAddress);
            Address outdoorAddress = new Address("Smoky Bear Campground, Island Park, WY");
            Outdoor outdoor = new Outdoor("Cloudy", "Outdoor", "Father and Sons Outing", "Spend the weekend camping and enjoy the outdoors!",
            "07/16/2088", "6:00pm", outdoorAddress);

            Console.WriteLine("The following are events on the schedule: ");
            Console.WriteLine();
            lecture.GetDetails();
            Console.WriteLine();
            lecture.FullDetails();
            Console.WriteLine();
            lecture.ShortDesc();

            Console.WriteLine();
            reception.GetDetails();
            Console.WriteLine();
            reception.FullDetails();
            Console.WriteLine();
            reception.ShortDesc();

            Console.WriteLine();
            outdoor.GetDetails();
            Console.WriteLine();
            outdoor.FullDetails();
            Console.WriteLine();
            outdoor.ShortDesc();
        }
    }
}
