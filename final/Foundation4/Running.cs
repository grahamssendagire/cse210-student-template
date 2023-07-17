public class Running : Activity
{
    private double distance;
    private DateTime date;
    private int Length;

    public Running(DateTime date, int Length, double distance) : base(date, Length)
    {
        this.distance = distance;
        this.date = date;
        this.Length = Length;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / Length * 60;
    }

    public override double GetPace()
    {
        return Length / distance;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
}