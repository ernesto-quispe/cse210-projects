using System;


public class PromptGenerator{

  public List<string> _prompts = new List<string>();

  public string GetPrompt()
  {
    _prompts.Add("Did you help someone today?");
    _prompts.Add("What was your spiritual experience?");
    _prompts.Add("What was the fun part during tha day?");
    _prompts.Add("What has caused you stress today?");
    _prompts.Add("What worries you the most right now?");
    
    var random = new Random();
    int indexQuestion = random.Next(_prompts.Count);

    return _prompts[indexQuestion];
  }


}