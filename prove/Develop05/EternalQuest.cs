public class EternalQuest
{
    private List<Goal> _goals = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
        Console.WriteLine($"Added goal: {goal.Name}");
    }

    public void RecordEvent(string name)
    {
        foreach (Goal goal in _goals)
        {
            if (goal.Name == name)
            {
                goal.RecordEvent();
                return;
            }
        }

        Console.WriteLine($"Goal not found: {name}");
    }

    public void DisplayStatus()
    {
        int totalPoints = 0;

        Console.WriteLine("Current Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStatus());
            totalPoints += goal.Points;
        }

        Console.WriteLine($"Total Points: {totalPoints}");
    }
}
