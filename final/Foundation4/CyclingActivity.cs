namespace Foundation4
{
    ///<summary>
    /// Holds the info and methods for Cycling.
    ///<summary>

    public class Cycling : Activity
    {
        private int _speed;

        public Cycling(int speed, string activity, string date, int length, double distance) : base(activity, date, length, distance)
        {
            _speed = speed;
        }

        public override void GetSummary()
        {
            Console.WriteLine($"{_date} {_activity} ({_length} min) - Distance {_distance} miles, Speed {_speed} mph, Pace {TruePace()} min per mile");
        }
        public override double TruePace()
        {
            return 60 / _speed;
        }
    }   
}