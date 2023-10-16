class ListingActivity : Activity
{
  private List<string> _promts = new List<string>
  {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?",
    "What were some times that you helped someone?",
    "What will you do next week to be better?"
  };
  private List<string> _promtsUser = new List<string>();

  public ListingActivity(string name, string description) : base(name, description)
  {

  }
  public void Run()
  {
    DisplayStartingMessage();
    SetDuration(int.Parse(Console.ReadLine()));
    Console.Clear();
    Console.WriteLine($"Get ready...");
    ShowSpinner(3);
    Console.WriteLine("List as many responses you can to the following prompt:");
    GetRandomPrompt();
    Console.Write("You may begin in: ");
    ShowCountDown(5);

    DateTime futureTime = DateTime.Now.AddSeconds(GetDuration());
    DateTime currentTime = DateTime.Now;

    while (currentTime <= futureTime)
    {
        Console.Write("> ");
        _promtsUser.Add(Console.ReadLine());
        currentTime = DateTime.Now;
    }
    Console.WriteLine($"You listed {_promtsUser.Count} items!\n");
    DisplayEndingMessage();
    ShowSpinner(3);

  }
  public void GetRandomPrompt()
  {
    Random random = new Random();
    int index = random.Next(_promts.Count);
    Console.WriteLine($"--- {_promts[index]} ---");
  }  

}