using System;

class Program
{
    static void Main(string[] args)
    {
      Menu menu = new Menu();
      GoalManager goalManager = new GoalManager();
      int choice = -1;

        while (choice != 6)
        {   
            int totalScore = goalManager.GetScore();
            Console.WriteLine($"\nYou have {totalScore} points.\n");
            menu.DisplayMainMenu();
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    menu.DisplayGoalOptions();
                    goalManager.CreateGoals(int.Parse(Console.ReadLine()));
                    break;
                case 2:
                    Console.WriteLine("The goals are:");
                    goalManager.DisplayGoals();
                    break;
                case 3:
                    Console.Write("What is the filename for the goal file? ");
                    goalManager.SaveGoals(Console.ReadLine());
                    break;
                case 4:
                    Console.Write("What is the filename for the goal file? ");
                    goalManager.LoadGoals(Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("The goals are:");
                    goalManager.DisplayNameGoals();
                    Console.Write("Which goal did you accomplish? ");
                    goalManager.RecordGoal(int.Parse(Console.ReadLine()));
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine($"{choice} is not a valid option");
                    break;
            }
        }
    }
}