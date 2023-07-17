public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int Length, double speed) : base(date, Length)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Speed: {speed} kph, Pace: {GetPace()} min/km";
    }
}