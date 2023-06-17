using System;
namespace Develop04
{
    ///<summary>
    /// The responsiblity of Breathing is to hold the info for and run the Breathing activity.
    ///<summary>
    
    public class Breathing : Activity
    {
        private DateTime _currentTime;
        private DateTime _endTime;
        public Breathing()
        {
            SetName("Breathing Activity");
            SetDesc("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        }
        public void Breathe()
        {
            _currentTime = DateTime.Now;
            _endTime = _currentTime.AddSeconds(Duration);

            while (DateTime.Now < _endTime)
            {
                Console.WriteLine("Breathe in...");
                Console.Write("3. . .");
                Thread.Sleep(2000);
                Console.Write("\b \b \b \b \b \b");
                Console.Write("2. . .");
                Thread.Sleep(2000);
                Console.Write("\b \b \b \b \b \b");
                Console.WriteLine("1. . . ");
                Thread.Sleep(2000);
                Console.WriteLine("Breathe out...");
                Thread.Sleep(2000);
            }
        }
    }
}