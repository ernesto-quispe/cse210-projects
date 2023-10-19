class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public SimpleGoal(string name, string description, int points, bool complete) : base(name, description, points)
    {
        SetIsComplete(complete);
    }

    public override void DisplayGoal()
    {
        if (GetIsComplete())
        {
            Console.WriteLine($"[X] {GetShortName()} ({GetDescription()})");
        } 
        else 
        {
            Console.WriteLine($"[ ] {GetShortName()} ({GetDescription()})");
        }
    }

    public override int RecordEvent()
    {   int  pointsObtained = 0;
        if(!GetIsComplete())
        {
            pointsObtained = GetPoints();
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
            SetIsComplete(IsComplete(pointsObtained));
            
        } 
        else 
        {
            Console.WriteLine("You already achieved this goal!");
        }
        return pointsObtained;
        
    }

    public override string GetStringRepresentation()
    {
        string goalString = $"SimpleGoal@{GetShortName()}|{GetDescription()}|{GetPoints()}|{GetIsComplete()}";
        return goalString;
    }

    public override bool IsComplete(int number)
    {
        bool completed = false;
        if(number == GetPoints())
        {
            completed = true;
            return completed;
        } 
        else 
        {
            return completed;
        }
    }

}