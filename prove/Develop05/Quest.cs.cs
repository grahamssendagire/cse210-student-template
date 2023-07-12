using System;
using System.Collections.Generic;
public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
    }
    public abstract void RecordEvent();
    public abstract string GetStatus();
}