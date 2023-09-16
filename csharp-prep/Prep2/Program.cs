using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade ");

        string letterGrade = "";
        string symbol = "";
        string grade = Console.ReadLine();
        int percentGrade = int.Parse(grade);
         

        if (percentGrade >=90)
        {
            letterGrade = "A";
        }
        else if (percentGrade >= 80)
        {
            letterGrade = "B"; 
        }
        else if (percentGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (percentGrade >= 60)
        {
            letterGrade = "D";
        }
        else 
        {
            letterGrade = "F";
        }


        if ( (percentGrade % 10) >= 7 && letterGrade != "A" && letterGrade != "F" )
        {
            symbol = "+";
        }
        else if ((percentGrade % 10) < 3 && letterGrade != "F")
        {
            symbol = "-";
        }
        else{
            symbol = "";
        }


        Console.WriteLine($"Your Letter grade is: {letterGrade}{symbol}");


        if (percentGrade >= 70)
        {
            Console.WriteLine("Well done you passed!");
        }
        else
        {
            Console.WriteLine("Next time you will do better!");
        }

    }
}