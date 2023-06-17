using System;
using System.Collections.Generic;
namespace Develop04
{
    ///<summary>
    /// The responsibility of Listing is to hold and run the listing activity
    ///<summary>

    public class Listing : Activity
    {
        private DateTime _currentTime;
        private DateTime _endTime;
        private List<string> _promptsList = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
        private List<string> _answersList;
        static Random _rnd = new Random();
        public Listing()
        {
            SetName("Listing Activity");
            SetDesc("This activity will help you reflect on the good things in your life by having you list as many things you can in a certain area.");
            _answersList = new List<string>();
        }

        public void List()
        {
            _currentTime = DateTime.Now;
            _endTime = _currentTime.AddSeconds(Duration);
            Console.WriteLine(GetRandomPrompt(_promptsList));
            Pause();
            Pause();
            Console.WriteLine("You may begin listing items:");
            while (DateTime.Now < _endTime)
            {
                string listItem = Console.ReadLine();
                _answersList.Add(listItem);
            }
            Pause();
            int itemCount = _answersList.Count;
            Console.WriteLine($"You entered {itemCount} items.");
        }
        public string GetRandomPrompt(List<string> listName)
        {
            int r = _rnd.Next(listName.Count);
            return listName[r];
        }

    }
}