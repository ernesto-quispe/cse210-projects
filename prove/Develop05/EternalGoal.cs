class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void DisplayGoal()
    {
         Console.WriteLine($"[ ] {GetShortName()} ({GetDescription()})");
    } 
        
    public override int RecordEvent()
    {
        int pointsObtained = GetPoints();
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        return pointsObtained;
    }
    
    public override string GetStringRepresentation()
    {
        string goalString = $"EternalGoal@{GetShortName()}|{GetDescription()}|{GetPoints()}";
        return goalString;
    }
}