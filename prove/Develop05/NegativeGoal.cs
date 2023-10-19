class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void DisplayGoal()
    {
         Console.WriteLine($"[ ] {GetShortName()} ({GetDescription()})");
    } 
        
    public override int RecordEvent()
    {
        int pointsObtained = GetPoints();
        Console.WriteLine($"You lost {GetPoints()} points, keep trying!");
        return pointsObtained;
    }
    
    public override string GetStringRepresentation()
    {
        string goalString = $"NegativeGoal@{GetShortName()}|{GetDescription()}|{GetPoints()}";
        return goalString;
    }
}