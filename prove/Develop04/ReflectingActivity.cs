class ReflectingActivity : Activity
{
      private List<string> _prompts = new List<string>
      {
      "Think of a time when you stood up for someone else.",
      "Think of a time when you succeeded in a difficult task.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless",
      "Think of a time when you felt loved.",
      "Think of a time when you were responsible for something having a negative feeling.",
      "Think of a time when you failed at something.",
      "Think of a time when you made someone feel better."
      };
      private List<string> _questions = new List<string>
      {
      "How did you feel when it was over?",
      "What made this experience stand out to you?",
      "What is your favorite thing about this experience?",
      "What did you not like about the experience",
      "What could you learn from this experience that applies to other situations?",
      "What did you learn about yourself through this experience?",
      "If you were faced with the same situation again, what could you have done better"
      };

      public ReflectingActivity(string name, string description) : base(name, description)
      {
          
      }

      public void Run()
      {
        DisplayStartingMessage();
        SetDuration(int.Parse(Console.ReadLine()));
        Console.Clear();
        Console.WriteLine($"Get ready...");
        ShowSpinner(5);

        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {prompt} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine($"Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime futureTime = DateTime.Now.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.Now;

        while (currentTime <= futureTime)
        {
            string question = GetRandomQuestion();
            Console.Write($"> {question}  ");
            ShowSpinner(5);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
        DisplayEndingMessage();
        ShowSpinner(3);
      }
      public string GetRandomPrompt()
      {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
      }
      public string GetRandomQuestion()
      {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
      }
}