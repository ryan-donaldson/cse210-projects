using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
namespace Develop05
{
    ///<summary>
    /// The responsibility of Goal is to hold the base info and methods for the other goals
    ///<summary>

    public class Goal
    {
        protected string _name;
        protected string _goal;
        protected List<(string, string)> _goals = new List<(string, string)>();
        protected int _points = 0;

        public virtual void MarkComplete()
        {}
        public virtual void AddPoints()
        {}
        public void SetPoints(int points)
        {
            _points = points;
        }
        public int GetPoints()
        {
            return _points;
        }
        public void SaveToFile()
        {
            Console.WriteLine("What is the filename?");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach ((string name, string goal) in _goals)
                {
                    string output = $"{name} - {goal}";
                    outputFile.WriteLine(output);
                }
            }
        }
        public void LoadFromFile()
        {
            Console.WriteLine("What is the filename?");
            string filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);
            
            _goals.Clear();

            foreach(string line in lines)
            {
                string[] parts = line.Split(new string[] {" - "}, StringSplitOptions.None);

                if (parts.Length == 2)
                {
                    string name = parts[0];
                    string goal = parts[1];

                    _goals.Add((name, goal));
                }
            }
        }
        public void ShowGoals()
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                var (name, goal) = _goals[i];
                Console.WriteLine($"{i + 1}. {name} - {goal}");
            }
        }
        public string GetGoal()
        {
            return _goal;
        }
        public string GetName()
        {
            return _name;
        }
        public void GoalListAdd(Goal goal)
        {
            _goals.Add((goal._name, goal._goal));
        }
        public void GetGoalsList()
        {
            foreach (var (name, goal) in _goals)
            {
                Console.WriteLine($"Name: {name}, Goal: {goal}");
            }
        }
        public List<Goal> GetGoalObjects()
        {
            List<Goal> goalObjects = new List<Goal>();
            foreach ((string name, string goal) in _goals)
            {
            // Create a new Goal object using the name and goal values
            Goal goalObject = new Goal();
            goalObject._name = name;
            goalObject._goal = goal;

            // Add the Goal object to the list
            goalObjects.Add(goalObject);
            }
            return goalObjects;
        }
    }
}