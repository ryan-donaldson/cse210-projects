namespace Develop05
{
    ///<summary>
    /// The responsibility of a Checklist Goal is to hold the functionality of a checklist goal
    ///<summary>

    public class ChecklistGoal : Goal
    {
        protected int _timesToComplete;
        protected int _timesCompleted = 0; 

        public ChecklistGoal(string name, string goal, int timesToComplete)
        {
            _name = name;
            _goal = goal += $" Completed: 0/{timesToComplete} times";
            _timesToComplete = timesToComplete;
        }
        public override void AddPoints()
        {
            _points += 50;
            if (_points == 50 * _timesToComplete)
            {
                _points += 500;
            }
        }
        public override void MarkComplete()
        {
            _timesCompleted++;
        }
    }
}