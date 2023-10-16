class BreathingActivity : Activity
{
    
  public BreathingActivity(string name, string description) : base(name, description){}
  public void Run()
  {
    DisplayStartingMessage();
    SetDuration(int.Parse(Console.ReadLine()));
    Console.Clear();
    Console.WriteLine($"Get ready...");
    ShowSpinner(4);

   DateTime futureTime = DateTime.Now.AddSeconds(GetDuration());
   DateTime currentTime = DateTime.Now;

   while (currentTime <= futureTime)
   {
      Console.Write("Breathe in...");
      ShowCountDown(4);
      Console.Write("Now breathe out...");
      ShowCountDown(6);
      currentTime = DateTime.Now;
   }
    DisplayEndingMessage();
    ShowSpinner(5);
  }

}