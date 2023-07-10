namespace Develop05
{
    ///<summary>
    /// The responsibility of a Simple Goal is to hold the functionality of a simple goal
    ///<summary>
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string goal)
        {
            _name = name;
            _goal = goal;
        }
        public override void AddPoints()
        {
            _points += 1000;
        }
        public override void MarkComplete()
        {
           _goal = _goal.Replace("[]", "[X]");
        }
    }
}