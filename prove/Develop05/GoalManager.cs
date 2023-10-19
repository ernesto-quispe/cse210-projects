class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public int GetScore()
    {
        return _score;
    }
    public void CreateGoals(int choice)
    {   
        if (choice <= 0 || choice > 4)
        {
            Console.WriteLine("Please choose a valid type of goal!");
        } 
        else
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal (If it's a negative goal, use a negative number)? ");
            int points = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                _goals.Add(new SimpleGoal(goalName, goalDescription, points));
            } 
            else if(choice == 2)
            {
                _goals.Add(new EternalGoal(goalName, goalDescription, points));
            } 
            else if(choice == 3)
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int timeToAccomplish = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(goalName, goalDescription, points, timeToAccomplish, bonusPoints));
            }
            else if(choice == 4)
            {
                _goals.Add(new NegativeGoal(goalName, goalDescription, points));
            }             
        }
    }
    public void DisplayGoals()
    {   
        if(_goals.Count > 0)
        {
            int count = 1;
            foreach (var goal in _goals)
            {   
                Console.Write($"{count}. ");
                goal.DisplayGoal();
                count++;
            }
        }
        else
        {
            Console.WriteLine("There are no goals entered");
        }
    }
    public void DisplayNameGoals()
    {
        if(_goals.Count > 0)
        {
            int count = 1;
            foreach (Goal goal in _goals)
            {   
                Console.Write($"{count}. ");
                goal.DisplayNameGoal();
                count++;
            }
        }
        else
        {
            Console.WriteLine("There are no goals entered");
        }
    }

    public void RecordGoal(int option)
    {   
        if (option > 0 && option <= _goals.Count)
        {
            int points = _goals[option -1].RecordEvent();
            _score  += points;
            Console.WriteLine($"You now have {_score} points!");
        }
        else
        {
            Console.WriteLine("Please type a valid option!");
        }
        
    }
    public void SaveGoals(string filename)
    {   
        if(_goals.Count > 0)
        {
            using(StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
        }
        else
        {
            Console.WriteLine("There are not goals to save at this time");
        }
    }

    public void LoadGoals(string filename)
    {   
        if (File.Exists(filename))
        {   
            string [] arrayLines = File.ReadAllLines(filename);
            if(arrayLines.Length > 0)
            {
                string value = File.ReadLines(filename).Take(1).First();
                int points = int.Parse(value);
                _score  += points;
                string [] lines = File.ReadAllLines(filename).Skip(1).ToArray(); 
                foreach (var line in lines)
                {
                    string[] parts = line.Split("@");
                    string goalType = parts[0];
                    string goalInfo = parts[1];
                    if(goalType == "SimpleGoal")
                    {
                        string[] goalParts = goalInfo.Split("|");
                        string goalName = goalParts[0];
                        string goalDescription = goalParts[1];
                        int goalPoints = int.Parse(goalParts[2]);
                        bool goalComplete = bool.Parse(goalParts[3]);
                        _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints, goalComplete));
                    } 
                    else if (goalType == "EternalGoal")
                    {
                        string[] goalParts = goalInfo.Split("|");
                        string goalName = goalParts[0];
                        string goalDescription = goalParts[1];
                        int goalPoints = int.Parse(goalParts[2]);
                        _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
                    } 
                    else if (goalType == "NegativeGoal")
                    {
                        string[] goalParts = goalInfo.Split("|");
                        string goalName = goalParts[0];
                        string goalDescription = goalParts[1];
                        int goalPoints = int.Parse(goalParts[2]);
                        _goals.Add(new NegativeGoal(goalName, goalDescription, goalPoints));
                    }                     
                    else if(goalType == "ChecklistGoal")
                    {
                        string[] goalParts = goalInfo.Split("|");
                        string goalName = goalParts[0];
                        string goalDescription = goalParts[1];
                        int goalPoints = int.Parse(goalParts[2]);
                        int goalBonusPoints = int.Parse(goalParts[3]);
                        int goalTimes = int.Parse(goalParts[4]);
                        int goalCheckComplete = int.Parse(goalParts[5]);
                        bool goalIsComplete = bool.Parse(goalParts[6]);
                        _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, goalBonusPoints, goalTimes, goalCheckComplete, goalIsComplete));
                    }
                }
            }
            else
            {
                Console.WriteLine($"The file {filename} doesn't have any information!");
            }
        }
        else
        {
            Console.WriteLine($"The file {filename} doesn't exist, please try another name!");
        }  
    }     
    

}