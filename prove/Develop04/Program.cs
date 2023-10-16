using System;

class Program
{
    static void Main(string[] args)
    {
        int option = -1;
        Attempts attempts = new Attempts();

        while(option != 4)
        {
          Console.Clear();
          Console.WriteLine("Menu Options:");
          Console.WriteLine(" 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Quit");
          Console.Write("Select a choice from the menu: ");
          option = int.Parse(Console.ReadLine());

          switch(option)
          {
              case 1:
              {
                Console.Clear();
                string name = "Breathing Activity";
                string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n";
                BreathingActivity breathingActivity = new BreathingActivity(name, description);
                breathingActivity.Run();
                attempts.SetTotalAttempts(1);
                attempts.GetTotalAttempts(1);
                breathingActivity.ShowSpinner(3);
                break;
              }   
              case 2:
              {
                Console.Clear();
                string name = "Reflecting Activity";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n";
                ReflectingActivity reflectingActivity = new ReflectingActivity(name, description);
                reflectingActivity.Run(); 
                attempts.SetTotalAttempts(2);
                attempts.GetTotalAttempts(2);
                reflectingActivity.ShowSpinner(3);
                break;
              }
              case 3:
              {
                Console.Clear();
                string name = "Listing Activity";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                ListingActivity listingActivity = new ListingActivity(name, description); 
                listingActivity.Run();
                attempts.SetTotalAttempts(3);
                attempts.GetTotalAttempts(3);
                listingActivity.ShowSpinner(3);
                break;
              }
          }
          
        }
    }
}