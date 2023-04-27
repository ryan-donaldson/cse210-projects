using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
        int guess = 0;
        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess < number)
            {
                Console.WriteLine("Higher");
                continue;
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
                continue;
            }
            else
            {
                break;
            }
        }
        Console.Write("You guessed it!");
    }
}