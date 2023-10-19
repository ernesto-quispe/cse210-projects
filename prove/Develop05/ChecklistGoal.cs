class ChecklistGoal : Goal
{
    private int _timesToComplete;
    private int _bonusPoints;
    private int _checkComplete;

    public ChecklistGoal(string name, string description, int points, int times, int bonusPoints) : base(name, description, points)
    {
        _timesToComplete = times;
        _bonusPoints = bonusPoints;
    }

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int times, int checkComplete, bool isComplete) : base(name, description, points)
    {
        _timesToComplete = times;
        _bonusPoints = bonusPoints;
        _checkComplete = checkComplete;
        SetIsComplete(isComplete);
    }

    public override void DisplayGoal()
    {
        if(GetIsComplete())
        {
            Console.WriteLine($"[X] {GetShortName()} ({GetDescription()}) -- Currently Completed: {_checkComplete}/{_timesToComplete}");
        } 
        else 
        {
            Console.WriteLine($"[ ] {GetShortName()} ({GetDescription()}) -- Currently Completed: {_checkComplete}/{_timesToComplete}");
        }
    }

    public override int RecordEvent()
    {   
        int pointsObtained = 0;
        if(!GetIsComplete())
        {   
            _checkComplete++;
            pointsObtained = GetPoints();
            SetIsComplete(IsComplete(_checkComplete));
            if(_checkComplete == _timesToComplete) 
            {
                pointsObtained = GetPoints() + _bonusPoints;
                Console.WriteLine($"Congratulations! You have earned {pointsObtained} points!");
            } 
            else 
            {
                Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
            }
            
        } 
        else 
        {
            Console.WriteLine("You already complete this goal!");
        }
        return pointsObtained;
    }

    public override bool IsComplete(int number)
    {
        bool completed = false;
        if(number == _timesToComplete)
        {
            completed = true;
            return completed;
        } 
        else {
            return completed;
        }
    }

    public override string GetStringRepresentation()
    {
        string goalString = $"ChecklistGoal@{GetShortName()}|{GetDescription()}|{GetPoints()}|{_bonusPoints}|{_timesToComplete}|{_checkComplete}|{GetIsComplete()}";
        return goalString;
    }
}