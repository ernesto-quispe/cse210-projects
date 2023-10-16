class Attempts {

  private int _totalBreathingActivity = 0;
  private int _totalListingActivity = 0;
  private int _totalReflectingActivity = 0;

   public void GetTotalAttempts(int option)
 {
   if (option == 1)
   {
     Console.WriteLine($"Total times trying Breathing Activity: {_totalBreathingActivity}");
   }
   else if(option ==2)
   {
     Console.WriteLine($"Total times trying Reflecting Activity: {_totalReflectingActivity}");
   }
   else
   {
     Console.WriteLine($"Total times trying Listing ctivity: {_totalListingActivity}");
   }

 }
 public void SetTotalAttempts(int option)
 {
   if (option == 1)
   {
     _totalBreathingActivity += 1;
   }
   else if(option ==2)
   {
     _totalReflectingActivity += 1;
   }
   else
   {
     _totalListingActivity += 1;
   }
 }
}