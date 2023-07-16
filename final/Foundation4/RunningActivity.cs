namespace Foundation4
{
    ///<summary>
    /// Holds the info and methods for Running.
    ///<summary>

    public class Running : Activity
    {

        public Running(string activity, string date, int length, double distance) : base(activity, date, length, distance)
        {
        }

        public override void GetSummary()
        {
            Console.WriteLine($"{_date} {_activity} ({_length} min) - Distance {_distance} miles, Speed {TrueSpeed()} mph, Pace {TruePace()} min per mile");
        }
        public override double TrueSpeed()
        {
            return 60 / GetPace();
        }
        public override double TruePace()
        {
            return 60 / GetSpeed();
        }

    }
}
