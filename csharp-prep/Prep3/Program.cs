using System;

class Program
{
    static void Main(string[] args)
    {
       Random randomGenerator = new Random();
       int number = randomGenerator.Next(1, 100);
       //Console.WriteLine($"The number: {number}");

       bool guess = true;
       int numberGuess;
       int attempts = 0;

       while (guess) 
       {
           Console.Write("What is your guess? ");
           numberGuess = int.Parse(Console.ReadLine());

           attempts ++;

            if (number > numberGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < numberGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {

                Console.WriteLine($"You guessed it in {attempts} attempts!");
                Console.WriteLine("Do want to play again ?");
                string answer = Console.ReadLine();

                if (answer == "yes")
                {
                   number = randomGenerator.Next(1, 100);  
                   //Console.WriteLine($"The number: {number}");
                   Console.WriteLine("Start again"); 
                   attempts = 0;
                }
                else
                {
                   guess = false;
                }

            }

       }



    }
}