using System;
namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {
            Goal goalgroup = new Goal();
            SimpleGoal simple1 = new SimpleGoal("Run a marathon");
            EternalGoal eternalgoal1 = new EternalGoal("Read your scriptures");
            ChecklistGoal checklistgoal1 = new ChecklistGoal("Attend the temple", 10);
            goalgroup.GoalListAdd(simple1);
            goalgroup.GoalListAdd(eternalgoal1);
            goalgroup.GoalListAdd(checklistgoal1);
            Dictionary<string, Goal> goalInstances = new Dictionary<string, Goal>
            {
                {"simple1", simple1},
                {"eternalgoal1", eternalgoal1},
                {"checklistgoal1", checklistgoal1}
            };

            Console.WriteLine("Welcome from the Goal Program! Here you can complete goals to get points!");
            int i = -1;
            while (i != 7)
            {
                Console.WriteLine("Please select one of the following choices:\n1. Show Goals\n2. Display Points\n3. Create New Goal\n" +
                "4. Mark Goal Complete\n5. Save Goals\n6. Load Goals\n7. Quit\nWhat would you like to do?");
                i = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    goalgroup.ShowGoals();
                }
                
                else if (i == 2)
                {
                    goalgroup.DisplayPoints();
                }

                else if (i == 3)
                {
                    Console.WriteLine("What kind of goal would you like to create?\n 1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                    int newGoal;
                    newGoal = int.Parse(Console.ReadLine());
                    string goalName;
                    int goalTimes;
                    if (newGoal == 1)
                    {
                        Console.WriteLine("What is the goal you want to add? ");
                        goalName = Console.ReadLine();
                        SimpleGoal simple2 = new SimpleGoal($"{goalName}");
                        goalgroup.GoalListAdd(simple2);
                        goalInstances.Add("simple2", simple2);
                    }
                    else if (newGoal == 2)
                    {
                        Console.WriteLine("What is the goal you want to add? ");
                        goalName = Console.ReadLine();
                        EternalGoal eternal2 = new EternalGoal($"{goalName}");
                        goalgroup.GoalListAdd(eternal2);
                        goalInstances.Add("eternal2", eternal2);
                    }
                    else if (newGoal == 3)
                    {
                        Console.WriteLine("What is the goal you want to add? ");
                        goalName = Console.ReadLine();
                        Console.WriteLine("How many times should this goal be completed? ");
                        goalTimes = int.Parse(Console.ReadLine());
                        ChecklistGoal check2 = new ChecklistGoal($"{goalName}", goalTimes);
                        goalgroup.GoalListAdd(check2);
                        goalInstances.Add("check2", check2);
                    }
                }
                else if (i == 4)
                {
                    string markGoal;
                    goalgroup.ShowGoals();
                    Console.WriteLine("Which goal would you like to mark as completed? (type the name of the goal, not the goal itself)");
                    markGoal = Console.ReadLine();
                    if (goalInstances.TryGetValue(markGoal, out Goal goalInstance))
                    {
                        goalInstance.MarkComplete();
                        goalInstance.AddPoints();
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal name!");
                    }
                }
                else if (i == 5)
                {
                    goalgroup.SaveToFile();
                }
                else if (i == 6)
                {
                    goalgroup.LoadFromFile();
                }
            }
        }
    }
}