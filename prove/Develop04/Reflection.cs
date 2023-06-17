using System;
using System.Collections.Generic;
namespace Develop04
{
    ///<summary>
    /// The responsibility of the Reflection class is to hold and run the reflection activity
    ///<summary>

    public class Reflection : Activity
    {
        private DateTime _currentTime;
        private DateTime _endTime;
        private List<string> _promptsList = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        private List<string> _questionsList = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?",
        "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
        private List<string> _waitAnimation = new List<string>{"<", "^", "v", ">"};
        static Random _rnd = new Random();

        public Reflection()
        {
            SetName("Reflection Activity");
            SetDesc("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");     
        }

        public void Reflect()
        {
            _currentTime = DateTime.Now;
            _endTime = _currentTime.AddSeconds(Duration);
            Console.WriteLine(GetRandomPrompt(_promptsList));
            Pause();
            Console.WriteLine("Reflect on the following questions:");
            while (DateTime.Now < _endTime)
            {
                Console.WriteLine(GetRandomPrompt(_questionsList));
                foreach (string s in _waitAnimation)
                {
                    Console.Write(s);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
            }
        }

        public string GetRandomPrompt(List<string> listName)
        {
            int r = _rnd.Next(listName.Count);
            return listName[r];
        }
    }


}