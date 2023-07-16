namespace Foundation4
{
    ///<summary>
    /// Holds the base info and methods for Activities.
    ///<summary>

    public class Activity
    {
        protected string _activity;
        protected string _date;
        protected int _length;
        protected double _distance;
        

        public Activity(string activity, string date, int length, double distance)
        {
            _activity = activity;
            _date = date;
            _length = length;
            _distance = distance;
        }

        public double GetSpeed()
        {
            return (_distance / _length) * 60;
        }
        public virtual double TrueSpeed()
        {
            return 0;
        }
        public double GetPace()
        {
            return _length / _distance;
        }
        public virtual double TruePace()
        {
            return 0;
        }
        public virtual void GetSummary()
        {

        }
    }
}