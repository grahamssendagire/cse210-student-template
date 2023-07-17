
public class Swimming : Activity
{
    private int laps;
    private DateTime date;
    private int Length;

    public Swimming(DateTime date, int Length, int laps) : base(date, Length)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / Length * 60;
    }

    public override double GetPace()
    {
        return Length / GetDistance();
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}
