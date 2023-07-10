using System;
using System.Collections.Generic;
namespace Develop04
{
    class Program
    {
        // I exceeded the requirements by keeping track of how many of each activity the user performs and then displaying those numbers to them at the end.
        static void Main(string[] args)
        {
            Activity activity = new Activity();
            Breathing breathing = new Breathing();
            Reflection reflection = new Reflection();
            Listing listing = new Listing();
            int breathActCnt = 0;
            int reflectActCnt = 0;
            int listActCnt = 0;

            Console.WriteLine("Welcome to the Mindfulness Activities Program!");
            string option = "0";
            while (option != "4")
            {
                Console.WriteLine("Choose from the menu below what you would like to do:");
                Console.WriteLine("1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity\n4. Quit");
                option = Console.ReadLine();

                if (option == "1")
                {
                    breathing.StartMsg();
                    breathing.Breathe();
                    breathing.EndMsg();
                    breathActCnt += 1;
                }
                else if (option == "2")
                {
                    reflection.StartMsg();
                    reflection.Reflect();
                    reflection.EndMsg();
                    reflectActCnt += 1;
                }
                else if (option == "3")
                {
                    listing.StartMsg();
                    listing.List();
                    listing.EndMsg();
                    listActCnt += 1;
                }
                else
                {
                }
            }
            Console.WriteLine($"You completed the following activites today:\nBreathing Activites: {breathActCnt}\nReflection Activities: {reflectActCnt}\nListing Activities: {listActCnt}");
        }
    }
}