using System.Collections.Generic;
namespace Develop05
{
    ///<summary>
    /// The responsibility of Goal is to hold the base info and methods for the other goals
    ///<summary>

    public class Goal
    {
        protected string _goal;
        private List<Goal> _goals = new List<Goal>();
        protected int _points = 0;
        private string _filename;

        public virtual void MarkComplete()
        {}
        public virtual void AddPoints()
        {}
        public string DisplayPoints()
        {
            return $"Points: {_points}";
        }
        public void SaveToFile()
        {
            string filename;
            Console.WriteLine("What is the filename?");
            filename = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(filename))
            foreach (Goal goal in _goals)
            {
                string output = $"{goal}\n";
                outputFile.WriteLine(output);
            }
        }
        public void LoadFromFile()
        {
            Console.WriteLine("What is the filename?");
            string filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        public void ShowGoals()
        {
            foreach ((Goal goal, int index) in _goals.Select((g, i) => (g, i + 1)))
            {
                Console.WriteLine($"{index}. {goal}");
            }
        }
        public void SetFilename(string filename)
        {
            _filename = filename;
        }
        public string GetFilename()
        {
            return _filename;
        }
        public string GetGoal()
        {
            return _goal;
        }
        public void GoalListAdd(Goal goal)
        {
            _goals.Add(goal);
        }
        public List<Goal> GetGoalsList()
        {
            return _goals;
        }
    }
}