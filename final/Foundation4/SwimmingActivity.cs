namespace Foundation4
{
    ///<summary>
    /// Holds the info and methods for Swimming.
    ///<summary>


    public class Swimming : Activity
    {
        private int _laps;

        public Swimming(int laps, string activity, string date, int length) : base(activity, date, length, 0)
        {
            _laps = laps;
            _distance = (laps * 50) / 1609.34;
        }

        public override void GetSummary()
        {
            Console.WriteLine($"{_date} {_activity} ({_length} min) - Distance {Math.Round(_distance, 3)} miles, Speed {Math.Round(TrueSpeed(), 4)} mph, Pace {Math.Round(TruePace(), 3)} min per mile");
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