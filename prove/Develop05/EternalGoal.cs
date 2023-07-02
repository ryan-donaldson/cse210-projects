namespace Develop05
{
    ///<summary>
    /// The responsibility of Eternal Goal is to hold the funcitonality of an eternal goal
    ///<summary>
    
    public class EternalGoal : Goal
    {

        public EternalGoal(string _goal)
        {
            _goal = _goal += " []";
        }
        public override void AddPoints()
        {
            _points += 100;
        }
        public override void MarkComplete()
        {
            _goal = _goal.Replace("[]","[X]");
        }
    }
}