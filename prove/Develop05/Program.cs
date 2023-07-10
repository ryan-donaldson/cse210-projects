using System;
namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {
            Goal goalgroup = new Goal();
            SimpleGoal simple1 = new SimpleGoal("simple1","Run a marathon []");
            EternalGoal eternalgoal1 = new EternalGoal("eternalgoal1","Read your scriptures []");
            ChecklistGoal checklistgoal1 = new ChecklistGoal("checklistgoal1","Attend the temple", 10);
            goalgroup.GoalListAdd(simple1);
            goalgroup.GoalListAdd(eternalgoal1);
            goalgroup.GoalListAdd(checklistgoal1);
            Dictionary<string, Goal> goalInstances = new Dictionary<string, Goal>
            {
                {"simple1", simple1},
                {"eternalgoal1", eternalgoal1},
                {"checklistgoal1", checklistgoal1}
            };
            int simplePoints = simple1.GetPoints();
            int eternalPoints = eternalgoal1.GetPoints();
            int checklistPoints = checklistgoal1.GetPoints();
            goalgroup.SetPoints((simplePoints + eternalPoints + checklistPoints));

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
                    Console.WriteLine($"You have {goalgroup.GetPoints()} points.");
                }

                else if (i == 3)
                {
                    Console.WriteLine("What kind of goal would you like to create?\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                    int newGoal;
                    newGoal = int.Parse(Console.ReadLine());
                    string goalName;
                    int goalTimes;
                    if (newGoal == 1)
                    {
                        Console.WriteLine("Enter the name of the simple goal you want to add.");
                        string simpleName = Console.ReadLine();
                        Console.WriteLine("What is the goal you want to add? Don't forget the empty brackets at the end.");
                        goalName = Console.ReadLine();
                        SimpleGoal newSimple = new SimpleGoal($"{simpleName}",$"{goalName}");
                        goalgroup.GoalListAdd(newSimple);
                        goalInstances.Add($"{simpleName}", newSimple);
                    }
                    else if (newGoal == 2)
                    {
                        Console.WriteLine("Enter the name of the eternal goal you want to add.");
                        string eternalName = Console.ReadLine();
                        Console.WriteLine("What is the goal you want to add? Don't forget the empty brackets at the end.");
                        goalName = Console.ReadLine();
                        EternalGoal newEternal = new EternalGoal($"{eternalName}",$"{goalName}");
                        goalgroup.GoalListAdd(newEternal);
                        goalInstances.Add($"{eternalName}", newEternal);
                    }
                    else if (newGoal == 3)
                    {
                        Console.WriteLine("Enter the name of the checklist goal you want to add.");
                        string checkName = Console.ReadLine();
                        Console.WriteLine("What is the goal you want to add? ");
                        goalName = Console.ReadLine();
                        Console.WriteLine("How many times should this goal be completed? ");
                        goalTimes = int.Parse(Console.ReadLine());
                        ChecklistGoal newCheck = new ChecklistGoal($"{checkName}",$"{goalName}", goalTimes);
                        goalgroup.GoalListAdd(newCheck);
                        goalInstances.Add($"{checkName}", newCheck);
                    }
                }
                else if (i == 4)
                {
                    goalgroup.ShowGoals();
                    Console.WriteLine("Which goal would you like to mark as completed? (type the name of the goal, not the goal itself)");
                    string markGoal = Console.ReadLine();
                    
                    List<Goal> goalList = goalgroup.GetGoalObjects();
                    bool goalFound = false;
                        foreach (Goal goal in goalList)
                        {
                            if (goal.GetName().Equals(markGoal))
                            {
                                goal.MarkComplete();
                                goal.AddPoints();
                                goalFound = true;
                            }
                        }
                        if (!goalFound)
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