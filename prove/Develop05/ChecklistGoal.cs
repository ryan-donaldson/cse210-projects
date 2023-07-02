namespace Develop05
{
    ///<summary>
    /// The responsibility of a Checklist Goal is to hold the functionality of a checklist goal
    ///<summary>

    public class ChecklistGoal : Goal
    {
        private int _timesToComplete;
        private int _timesCompleted = 0; 

        public ChecklistGoal(string _goal, int _timesToComplete)
        {
            _goal = _goal += $" Completed: 0/{_timesToComplete} times";
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
            _timesCompleted += 1;
        }
    }
}