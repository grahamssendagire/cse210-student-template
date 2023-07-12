public class program
{
public static void Main()
{
    EternalQuest quest = new EternalQuest();

    // Add some example goals
    quest.AddGoal(new SimpleGoal("Run a Marathon", 1000));
    quest.AddGoal(new EternalGoal("Read Scriptures", 100));
    quest.AddGoal(new ChecklistGoal("Attend Temple", 50, 10));

    // Record some progress on the goals
    quest.RecordEvent("Read Scriptures");
    quest.RecordEvent("Read Scriptures");
    quest.RecordEvent("Attend Temple");
    quest.RecordEvent("Attend Temple");
    quest.RecordEvent("Attend Temple");
    quest.RecordEvent("Attend Temple");
    quest.RecordEvent("Attend Temple");
    quest.RecordEvent("Attend Temple");
    // Display the current status of the goals
    quest.DisplayStatus();
 }
};