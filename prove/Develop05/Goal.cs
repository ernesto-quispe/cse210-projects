abstract class Goal 
{
    private string _shortName;
    private string _description;
    private int _points;
    private bool _isComplete = false;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public string GetShortName()
    {
      return _shortName;
    }
    public string GetDescription()
    {
      return _description;
    }
    public int GetPoints()
    {
      return _points;
    }
    public bool GetIsComplete()
    {
      return _isComplete;
    }    
    public void SetIsComplete(bool complete)
    {
      _isComplete = complete;
    }    
    public abstract int RecordEvent();
    public abstract void DisplayGoal();
   public abstract string GetStringRepresentation();
    public virtual bool IsComplete(int number)
    {
        return false;
    }   
    public virtual void DisplayNameGoal()
    {
       Console.WriteLine(_shortName);
    }

}