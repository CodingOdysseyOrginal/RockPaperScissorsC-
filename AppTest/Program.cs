using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter either rock, paper, or scissors: ");
        string userChoice = Console.ReadLine().ToLower();

        Random random = new Random();
        int randomNumber = random.Next(1, 4);

        string computerChoice;

        switch (randomNumber)
        {
            case 1:
                computerChoice = "rock";
                break;
            case 2:
                computerChoice = "paper";
                break;
            case 3:
                computerChoice = "scissors";
                break;
            default:
                computerChoice = "";
                break;
        }

        Console.WriteLine("Computer chose: " + computerChoice);

        string result = DetermineWinner(userChoice, computerChoice);
        Console.WriteLine(result);

        Console.ReadLine();
    }

    static string DetermineWinner(string userChoice, string computerChoice)
    {
        if (userChoice == computerChoice)
        {
            return "It's a draw!";
        }
        else if ((userChoice == "rock" && computerChoice == "scissors") ||
                 (userChoice == "paper" && computerChoice == "rock") ||
                 (userChoice == "scissors" && computerChoice == "paper"))
        {
            return "You win!";
        }
        else
        {
            return "You lose!";
        }
    }
}
