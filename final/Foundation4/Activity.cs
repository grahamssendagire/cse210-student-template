public class Activity
{
    private DateTime date;
    private int Length;

    public Activity(DateTime date, int Length)
    {
        this.date = date;
        this.Length = Length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} {GetType().Name} ({Length} min)";
    }
}