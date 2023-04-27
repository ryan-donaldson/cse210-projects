using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        DisplayWelcome();
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        string name = PromptUserName();
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        int num = PromptUserNumber();
        static int SquareNumber(int num)
        {
            int square = (num * num);
            return square;
        }
        int numSquared = SquareNumber(num);
        static void DisplayResult(string name, int num)
        {
            Console.Write($"{name}, the square of your number is {num}");
        }
        DisplayResult(name, numSquared);
    }
}