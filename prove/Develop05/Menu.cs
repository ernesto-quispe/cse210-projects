class Menu {

    public void DisplayMainMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create new Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public void DisplayGoalOptions()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine(" 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal\n 4. Negative Goal");
        Console.Write("Which type of goal would you like to create? ");
    }
}