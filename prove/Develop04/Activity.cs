class Activity 
{
  // attributes
  private string _name;
  private string _description;
  private int _duration;
  
  //Constructors
  public Activity(string name, string description)
  {
    _name = name;
    _description = description;
  }
  //getters y setters
  public int GetDuration()
  {
    return _duration;
  }
  public void SetDuration(int time)
  {
    _duration = time;
  }
  //shows initial message
  public void DisplayStartingMessage()
  {
    Console.WriteLine($"Welcome to the {_name}.\n");
    Console.WriteLine($"{_description}");
    Console.Write("\nHow long, in seconds, would you like for your session? ");
  }
  //shows final message
  public void DisplayEndingMessage()
  {
    Console.WriteLine($"Well done!!");
    ShowSpinner(5);
    Console.WriteLine($"You have completed another {GetDuration()} seconds of the {_name}.");
  }

  public void ShowSpinner(int time)
  {
    while (time != 0)
    {
       Console.Write("/");
       Thread.Sleep(200);
       Console.Write("\b \b");

       Console.Write("-");
       Thread.Sleep(200);
       Console.Write("\b \b");

       Console.Write("\\");
       Thread.Sleep(200);
       Console.Write("\b \b");

       Console.Write("|");
       Thread.Sleep(200);
       Console.Write("\b \b");   

       time -=1;
    }
    Console.Write("\n");
  }
  public void ShowCountDown(int time)
  {
     while (time != 0)
     {
      Console.Write($"{time}");
      Thread.Sleep(1000);
      Console.Write("\b \b");

      time -= 1;
     }
    Console.Write("\n\n"); 
  }

}